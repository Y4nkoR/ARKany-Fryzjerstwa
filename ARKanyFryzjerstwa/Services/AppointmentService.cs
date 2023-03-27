using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;

namespace ARKanyFryzjerstwa.Services
{
    public class AppointmentService : IAppointmentService
    {
        private const string APPOINTMENT_CACHE_KEY = "AppointmentCreationData";

        private readonly IClientDao _clientDao;
        private readonly IAppointmentDao _appointmentDao;
        private readonly IServiceDao _serviceDao;
        private readonly IUserDao _userDao;
        private readonly IClientsService _clientsService;
        private readonly IServicesService _servicesService;
        private readonly IMemoryCache _memoryCache;

        public AppointmentService(IdentityContext identityContext, int? currentSalonId, IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _clientDao = new ClientDao(identityContext, currentSalonId);
            _appointmentDao = new AppointmentDao(identityContext, currentSalonId);
            _serviceDao = new ServiceDao(identityContext, currentSalonId);
            _userDao = new UserDao(identityContext, currentSalonId);
            _clientsService = new ClientsService(identityContext, currentSalonId);
            _servicesService = new ServicesService(identityContext, currentSalonId, memoryCache);
        }

        public AppointmentService(IMemoryCache memoryCache, IClientDao clientDao, IAppointmentDao appointmentDao,
            IServiceDao serviceDao, IUserDao userDao, IClientsService clientsService, IServicesService servicesService)
        {
            _memoryCache = memoryCache;
            _clientDao = clientDao;
            _appointmentDao = appointmentDao;
            _serviceDao = serviceDao;
            _userDao = userDao;
            _clientsService = clientsService;
            _servicesService = servicesService;
        }

        /// <summary>
        /// Zwraca dane potrzebne do utworzenia wizyty.
        /// </summary>
        /// <param name="salonId"> Uniklany numer Id salonu. </param>
        /// <returns>Obiekt <see cref="AppointmentCreationDataModel"/> z danymi potrzebnymi do utworzenia wizyty.</returns>
        public AppointmentCreationDataModel GetAppointmentCreationData(int salonId)
        {
            var salonAppointmentCacheKey = salonId.ToString() + "_" + APPOINTMENT_CACHE_KEY;

            if (!_memoryCache.TryGetValue(salonAppointmentCacheKey, out CacheItem<AppointmentCreationDataModel> appointmentCreationData))
            {
                var item = new AppointmentCreationDataModel();
                item.Clients = GetAppointmentCreationClients(salonId);
                item.Services = GetAppointmentCreationServices(salonId);
                item.Employees = GetAppointmentCreationEmployees(salonId);

                appointmentCreationData = new CacheItem<AppointmentCreationDataModel>(item);

                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddHours(5),
                };
                _memoryCache.Set(salonAppointmentCacheKey, appointmentCreationData, cacheExpiryOptions);
            }
            else
            {
                var time = DateTime.Now;
                var isModified = false;
                if (!_clientDao.IsUpToDate(appointmentCreationData.ModificationTime))
                {
                    appointmentCreationData.Item.Clients = GetAppointmentCreationClients(salonId);
                    isModified = true;
                }

                if (!_serviceDao.IsUpToDate(appointmentCreationData.ModificationTime))
                {
                    appointmentCreationData.Item.Services = GetAppointmentCreationServices(salonId);
                    isModified = true;
                }

                if (!_userDao.IsUpToDate(appointmentCreationData.ModificationTime))
                {
                    appointmentCreationData.Item.Employees = GetAppointmentCreationEmployees(salonId);
                    isModified = true;
                }

                if (isModified)
                {
                    appointmentCreationData.UpDateModificationTime(time);
                }
            }

            return appointmentCreationData?.Item;
        }

        /// <summary>
        /// Zwraca numer telefonu i/lub email podanego klienta.
        /// </summary>
        /// <param name="clientId">Unikalny numer Id klienta.</param>
        /// <returns> Obiekt <see cref="ContactData"/> z numerem telefonu i/lub emailem klienta.</returns>
        public ContactData GetPhoneAndEmail(int clientId)
        {
            Client? client = _clientDao.GetClientById(clientId);
            if (client == null)
            {
                return new ContactData();
            }
            string phoneNumber = client.PhoneNumber ?? "";
            string email = client.Email ?? "";
            return new ContactData{ PhoneNumber = phoneNumber, Email = email };
        }

        /// <summary>
        /// Tworzy nową wizytę.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane nowej wizyty.</param>
        /// <param name="authorId"> Unikalny Id pracownika dodającego nową wizytę. </param>
        /// <param name="salonId"> Unikalny numer Id salonu, w którym dodawana jest wizyta.</param>
        /// <returns>Obiekt <see cref="Appointment"/> z danymi o utworzonej wizycie.</returns>
        public Appointment CreateAppointment(AppointmentAddModel appointmentAddModel,string? authorId, int salonId)
        {
            var appointmentToAdd = ConvertAppointmentAddModel(appointmentAddModel, authorId, salonId);
            _appointmentDao.AddAppointment(appointmentToAdd);
            return appointmentToAdd;
        }

        /// <summary>
        /// Anuluje wizytę.
        /// </summary>
        /// <param name="appointmentId"> Unikalny numer Id wizyt do anulowania.</param>
        /// <exception cref="ArgumentNullException"> Wizyta z takim Id nie istnieje.</exception>
        public void CancelAppointment(int appointmentId)
        {
            var appointment = _appointmentDao.GetAppointmentById(appointmentId);
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }
            appointment.Status = AppointmentStatus.Canceled;
            _appointmentDao.UpdateAppointment(appointment);       
        }

        /// <summary>
        /// Sprawdza, czy dodawana wizyta konfliktuje z już istniejącą dla danego pracownika.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane dodawanej wizyty. </param>
        /// <returns>True, jeśli wizyta konfliktuje z już istniejącą. W przeciwnym wypadku - false.</returns>
        public bool DoAppointmentsOverlap(AppointmentAddModel appointmentAddModel)
        {
            IList<string> employees = new List<string>();
            employees.Add(appointmentAddModel.EmployeeId);
            var appointments = _appointmentDao.GetScheduledAppointmentsByEmployeeIdsAndDate(employees, appointmentAddModel.Date);
            
            var dates = GetAppointmentStartAndEndDate(appointmentAddModel);
            var startDate = dates.StartDate;
            var endDate = dates.EndDate;
            
            var result = appointments.Any(a => startDate < a.End && endDate > a.Start);
            return result;
        }

        /// <summary>
        /// Zakańcza wizytę.
        /// </summary>
        /// <param name="appointmentCompletionData"> Dane kończonej wizyty.</param>
        /// <exception cref="ArgumentNullException"> Podana wizyta nie istnieje.</exception>
        public void CompleteAppointment(AppointmentCompletionDataModel appointmentCompletionData)
        {
            var appointmentId = appointmentCompletionData.AppointmentId;
            var appointment = _appointmentDao.GetAppointmentById(appointmentId);
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }
            appointment.Status = AppointmentStatus.Completed;
            appointment.StandardPrice = appointmentCompletionData.StandardPrice.GetPrice();
            appointment.FinalPrice = appointmentCompletionData.FinalPrice.GetPrice();
            _appointmentDao.UpdateAppointment(appointment);
        }

        /// <summary>
        /// Zwraca informacje o usłudze przypisanej do danej wizyty.
        /// </summary>
        /// <param name="appointmentId"> Unikalny numer Id wizyty.</param>
        /// <returns>Obiekt <see cref="ServiceModel"/> z danymi o usłudze.</returns>
        /// <exception cref="ArgumentNullException"> Wizyta o podanym Id nie istnieje.</exception>
        public ServiceModel GetAppointmentServiceModel(int appointmentId)
        {
            var appointment = _appointmentDao.GetAppointmentById(appointmentId);
            if (appointment == null)
            {
                throw new ArgumentNullException(nameof(appointment));
            }

            var serviceModel = _servicesService.GetServiceModelById(appointment.ServiceId);
            return serviceModel;
        }

        #region privateMethods
        
        /// <summary>
        /// Zwraca klienta przypisanego do dodawanej wizyty.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane dodawanej wizyty. </param>
        /// <returns>Obiekt <see cref="Client"/> z informacjami o kliencie.</returns>
        private Client GetClient(AppointmentAddModel appointmentAddModel)
        {
            Client client = new Client();

            var clientFirstAndLastName = appointmentAddModel.Client.Split(' ');
            client.FirstName = clientFirstAndLastName[0];

            if (clientFirstAndLastName.Length > 1)
            {
                client.LastName = string.Join(' ', clientFirstAndLastName.Skip(1));
            }
            else
            {
                client.LastName = "";
            }

            client.PhoneNumber = appointmentAddModel.PhoneNumber;
            client.Email = appointmentAddModel.Email;

            return client;
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="AppointmentAddModel"/> na obiekt <see cref="Appointment"/>.
        /// </summary>
        /// <param name="appointmentAddModel"> Obiekt z danymi o dodawanej wizycie do przekonwertowania. </param>
        /// <param name="authorId"> Unikalny Id autora wizyty. </param>
        /// <param name="salonId"> Unikalny Id salonu. </param>
        /// <returns>Obiekt <see cref="Appointment"/> z danymi o wizycie. </returns>
        private Appointment ConvertAppointmentAddModel(AppointmentAddModel appointmentAddModel, string? authorId, int salonId)
        {
            var appointment = new Appointment();
            appointment.AuthorId = authorId;
            var dates = GetAppointmentStartAndEndDate(appointmentAddModel);
            appointment.Start = dates.StartDate;
            appointment.End = dates.EndDate;
            appointment.ServiceId = appointmentAddModel.ServiceId;
            appointment.EmployeeId = appointmentAddModel.EmployeeId;

            if(!appointmentAddModel.IsAnonymous)
            {
                if (int.TryParse(appointmentAddModel.Client, out int clientId))
                {
                    Client? client = _clientDao.GetClientById(clientId);
                    if (client != null)
                    {
                        if (client.PhoneNumber != appointmentAddModel.PhoneNumber || client.Email != appointmentAddModel.Email)
                        {
                            client.PhoneNumber = appointmentAddModel.PhoneNumber;
                            client.Email = appointmentAddModel.Email;
                            _clientDao.UpdateClient(client);
                        }
                        appointment.ClientId = client.Id;
                    }
                }
                else
                {
                    Client client = GetClient(appointmentAddModel);
                    clientId = _clientsService.CreateClient(client);
                    appointment.ClientId = clientId;
                }
            }

            appointment.Status = AppointmentStatus.Scheduled;
            return appointment;
        }

        /// <summary>
        /// Zwraca datę i czas początku oraz końca wizyty.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane dodawanej wizyty.</param>
        /// <returns>Para obiektów <see cref="DateTime"/> zawierająca datę oraz czas początku i końca wizyty.</returns>
        /// <exception cref="Exception"> Czas zakończenia nie może być równy wartości null.</exception>
        private (DateTime StartDate, DateTime EndDate) GetAppointmentStartAndEndDate(AppointmentAddModel appointmentAddModel)
        {
            if (appointmentAddModel.EndTime == null)
            {
                throw new Exception("EndTime can't be null"); //TODO: Exception? Ustawiać EndTime na minimalny czas trwania?
            }

            var splittedTime = appointmentAddModel.StartTime.Split(":");
            TimeSpan startTime = new TimeSpan(int.Parse(splittedTime[0]), int.Parse(splittedTime[1]), 0);
            var startDate = appointmentAddModel.Date + startTime;

            splittedTime = appointmentAddModel.EndTime.Split(":");
            TimeSpan endTime = new TimeSpan(int.Parse(splittedTime[0]), int.Parse(splittedTime[1]), 0);
            var endDate = appointmentAddModel.Date + endTime;

            return (startDate, endDate);
        }

        /// <summary>
        /// Zwraca słownik klientów dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Słownik, którego kluczami są numery Id klientów, a wartościami - ich wyświetlane nazwy.</returns>
        private IDictionary<int, string> GetAppointmentCreationClients(int salonId)
        {
            return _clientDao.GetClientsForSalon(salonId).ToDictionary(k => k.Id, v => v.DisplayName());
        }

        /// <summary>
        /// Zwraca listę usług dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="AppointmentServiceModel"/> z informacjami o usługach.</returns>
        private IList<AppointmentServiceModel> GetAppointmentCreationServices(int salonId)
        {
            return _serviceDao.GetActiveServicesForSalon(salonId).Select(s => new AppointmentServiceModel { Id = s.Id, Name = s.Name, Duration = s.Duration }).ToList();
        }


        /// <summary>
        /// Zwraca słownik pracowników dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Słownik, którego kluczami są Id pracowników, a wartościami - ich wyświetlane nazwy.</returns>
        private IDictionary<string, string> GetAppointmentCreationEmployees(int salonId)
        {
            return _userDao.GetEmployeesBySalonId(salonId).ToDictionary(k => k.Id, v => v.DisplayName());
        }

        #endregion
    }
}
