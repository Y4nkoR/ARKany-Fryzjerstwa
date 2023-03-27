using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Resources;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;

namespace ARKanyFryzjerstwa.Services
{
    public class ScheduleService : IScheduleService
    {
        private const string TIME_FORMAT = "H:mm";
        private const string DATE_FORMAT = "dd.MM.yyyy";
        private const string SCHEDULE_CACHE_KEY = "ScheduleAppointments";
        private const int CACHE_EXPIRATION = 60;

        private readonly IMemoryCache _memoryCache;
        private readonly IUserDao _userDao;
        private readonly IAppointmentDao _appointmentDao;
        private readonly IServiceDao _serviceDao;
        private readonly IClientDao _clientDao;

        public ScheduleService(IdentityContext identityContext, int? currentSalonId, IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _userDao = new UserDao(identityContext, currentSalonId);
            _appointmentDao = new AppointmentDao(identityContext, currentSalonId);
            _serviceDao = new ServiceDao(identityContext, currentSalonId);
            _clientDao = new ClientDao(identityContext, currentSalonId);
        }
        public ScheduleService(IMemoryCache memoryCache, IUserDao userDao, IAppointmentDao appointmentDao, IServiceDao serviceDao, IClientDao clientDao)
        {
            _memoryCache = memoryCache;
            _userDao = userDao;
            _appointmentDao = appointmentDao;
            _serviceDao = serviceDao;
            _clientDao = clientDao;
        }

        /// <summary>
        /// Zwraca dane o harmonogramie dla podanego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleModel"/> z danymi o harmonogramie.</returns>
        public ScheduleModel GetScheduleModel(int salonId)
        {
            var model = new ScheduleModel
            {
                Employees = _userDao.GetEmployeesBySalonId(salonId)
                            .Select(e => new ScheduleEmployeeDataModel { Id = e.Id, Color = e.Color, DisplayName = e.DisplayName()})
                            .ToList(),
                MonthTitle = DateTime.Today.ToMonthTitle()
            };
            return model;
        }

        /// <summary>
        /// Zwraca dane o dniach tygodnia, w którym znajduje się podana data.
        /// </summary>
        /// <param name="date"> Data, dla której należy zwrócić informacje o tygodniu.</param>
        /// <param name="employeeIds"> Lista unikalnych Id pracowników, dla których należy zwrócić dane.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleData"/> z informacjami o dniach tygodnia.</returns>
        public ScheduleData GetScheduleDays(DateTime date, IList<string> employeeIds, int salonId)
        {
            if (date == new DateTime())
            {
                date = DateTime.Today;
            }
            var start = date.GetFirstDayOfWeek();
            var end = start.AddDays(6);
            var clients = _clientDao.GetClientsForSalon(salonId) ?? new List<Client>();
            var employees = _userDao.GetEmployeesByEmployeeIds(employeeIds);
            var services = _serviceDao.GetServicesBySalonId(salonId) ?? new List<Service>();
            var days = new List<ScheduleDay>();
            int startHour = 7;
            int endHour = 19;

            for (var day = start; day <= end; day = day.AddDays(1))
            {
                var appointmetnts = _appointmentDao.GetNotCanceledAppointmentsByEmployeeIdsAndDate(employeeIds, day);
                var scheduleDay = new ScheduleDay
                {
                    Title = day.ToDayTitle(),
                    Appointments = ConvertAppointments(appointmetnts, clients, employees, services, out int dayStartHour, out int dayEndHour)
                };
                days.Add(scheduleDay);

                if (dayStartHour < startHour)
                {
                    startHour = dayStartHour;
                }
                if (dayEndHour > endHour)
                {
                    endHour = dayEndHour;
                }
            }

            var result = new ScheduleData
            {
                Title = date.ToMonthTitle(),
                Days = days,
                StartHour = startHour,
                EndHour = endHour
            };
            return result;
        }

        /// <summary>
        /// Zwraca informacje o wizytach w tygodniu, w którym znajduje się podana data.
        /// </summary>
        /// <param name="date"> Data w tygodniu, dla którego mają zostać zwrócone informacje.</param>
        /// <param name="employees"> Lista unikalnych Id pracowników, dla których należy zwrócić dane.</param>
        /// <param name="forceCacheRefresh"> Wartość true wymusza aktualizację danych w cache.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleData"/> z danymi o wizytach w danym tygodniu.</returns>
        public ScheduleData GetAppointmentsForWeek(DateTime date, IList<string> employees, bool forceCacheRefresh, int salonId)
        {
            var firstWeekDay = date.GetFirstDayOfWeek();
            var cacheKey = salonId.ToString() + "_" + SCHEDULE_CACHE_KEY + "_" + firstWeekDay;

            _memoryCache.TryGetValue(cacheKey, out CacheItem<ScheduleAppointments> cacheData);
            var cachedEmployeesAreCorrect = employees.IsEqualTo(cacheData?.Item?.Employees);

            if (forceCacheRefresh || !cachedEmployeesAreCorrect || !_appointmentDao.IsUpToDate(cacheData.ModificationTime))
            {
                var scheduleDays = GetScheduleDays(date, employees, salonId);
                cacheData = new CacheItem<ScheduleAppointments>(new ScheduleAppointments()
                {
                    Employees = employees,
                    ScheduleData = scheduleDays
                });
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(CACHE_EXPIRATION),
                };
                _memoryCache.Set(cacheKey, cacheData, cacheExpiryOptions);
            }

            return cacheData?.Item?.ScheduleData;
        }

        /// <summary>
        /// Konwertuje listę obiektów <see cref="Appointment"/> na listę obiektow <see cref="AppointmentInfo"/>.
        /// </summary>
        /// <param name="appointments"> Lista wizyt do przekonwertowania.</param>
        /// <param name="clients"> Lista klientów.</param>
        /// <param name="employees"> Lista pracowników.</param>
        /// <param name="services"> Lista usług.</param>
        /// <param name="startHour"> Godzina rozpoczęcia dnia pracy.</param>
        /// <param name="endHour"> Godzina zakończniea dnia pracy.</param>
        /// <returns> Listę obiektów <see cref="AppointmentInfo"/> z danymi o wizytach.</returns>
        /// <exception cref="Exception"> Podany klient / pracownik / usługa nie istnieje.</exception>
        private IList<AppointmentInfo> ConvertAppointments(IList<Appointment>? appointments, IList<Client> clients, IList<User>? employees, IList<Service> services, out int startHour, out int endHour)
        {
            startHour = 24;
            endHour = 0;
            var result = new List<AppointmentInfo>();
            if (appointments.IsNullOrEmpty() || employees.IsNullOrEmpty())
            {
                return result;
            }

            foreach (var appointment in appointments)
            {
                var clientName = appointment.ClientId.HasValue ? 
                    clients.Where(c => c.Id == appointment.ClientId.Value).FirstOrDefault()?.DisplayName() ?? throw new Exception("Unknown client.")
                    : ARKanyResources.AnonymousClientName;
                var employee = employees.FirstOrDefault(e => e.Id == appointment.EmployeeId) ?? throw new Exception("Unknown employee.");
                var employeeName = employee.DisplayName();
                var employeeColor = employee.Color;
                var serviceName = services.Where(s => s.Id == appointment.ServiceId).FirstOrDefault()?.Name ?? throw new Exception("Unknown service.");

                var appointmentResult = new AppointmentInfo
                {
                    AppointmentId = appointment.Id,
                    ClientId = appointment.ClientId ?? -1,
                    ClientName = clientName,
                    EmployeeId = appointment.EmployeeId,
                    EmployeeName = employeeName,
                    EmployeeColor = employeeColor,
                    ServiceName = serviceName,
                    Date = appointment.Start.ToString(DATE_FORMAT),
                    StartTime = appointment.Start.ToString(TIME_FORMAT),
                    EndTime = appointment.End.ToString(TIME_FORMAT),
                    IsCompleted = appointment.Status == AppointmentStatus.Completed,
                    StandardPrice = appointment.StandardPrice.ToString(),
                    FinalPrice = appointment.FinalPrice.ToString()
                };
                result.Add(appointmentResult);
            }

            startHour = appointments.Select(a => a.Start.Hour).Min();
            endHour = appointments.Select(a => a.End.Hour).Max();

            return result;
        }
    }
}
