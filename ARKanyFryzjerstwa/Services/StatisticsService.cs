using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;

namespace ARKanyFryzjerstwa.Services
{
    public class StatisticsService : IStatisticsService
    {
        private const string CACHE_KEY = "HomepageStatisticsData";

        private readonly IMemoryCache _memoryCache;
        private readonly IAppointmentDao _appointmentDao;
        private readonly IUserDao _userDao;

        public StatisticsService(IdentityContext identityContext, int? currentSalonId, IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _appointmentDao = new AppointmentDao(identityContext, currentSalonId);
            _userDao = new UserDao(identityContext, currentSalonId);
        }

        public StatisticsService(IMemoryCache memoryCache, IAppointmentDao appointmentDao, IUserDao userDao)
        {
            _memoryCache = memoryCache;
            _appointmentDao = appointmentDao;
            _userDao = userDao;
        }

        /// <summary>
        /// Zwraca statystyki wyświetlane na głównej stronie.
        /// </summary>
        /// <param name="employeeId"> Unikalny Id pracownika, dla którego mają zostać wyświetlone statystyki.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="HomepageStatisticsModel"/> ze statystykiami.</returns>
        public HomepageStatisticsModel GetHomepageStatistics(string employeeId, int salonId)
        {
            var cacheKey = salonId.ToString() + "_" + CACHE_KEY + "_" + employeeId;
            if (!_memoryCache.TryGetValue(cacheKey, out CacheItem<HomepageStatisticsModel> cacheItem) || !_appointmentDao.IsUpToDate(cacheItem.ModificationTime))
            {
                var employees = _userDao.GetEmployeesBySalonId(salonId).Select(u => u.Id).ToList();

                var stats = new HomepageStatisticsModel();

                var date = DateTime.Today;
                var startDate = date.GetFirstDayOfWeek();
                var endDate = startDate.AddDays(6);
                var dates = new List<DateTime>();

                for (var day = startDate; day <= endDate; day = day.AddDays(1))
                {
                    dates.Add(day);
                }

                var employeesAppointmentsCounts = GetEmployeesAppointmentsCount(employees, dates);

                var currentEmployeeAppointmentsCounts = employeesAppointmentsCounts.FirstOrDefault(eac => eac.EmployeeId == employeeId);

                stats.CurrentUserPlannedAppointmentsCount = currentEmployeeAppointmentsCounts?.NotCanceledAppointmentsCount ?? 0;
                stats.CurrentUserServedClientsCount = currentEmployeeAppointmentsCounts?.CompletedAppointmentsCount ?? 0;
                stats.CurrentUserNewClientsCount = currentEmployeeAppointmentsCounts?.NewClientsAppointmentsCount ?? 0;

                stats.OverallPlannedAppointmentsCount = employeesAppointmentsCounts.Sum(eac => eac.NotCanceledAppointmentsCount);
                stats.OverallServedClientsCount = employeesAppointmentsCounts.Sum(eac => eac.CompletedAppointmentsCount);
                stats.OverallNewClientsCount = employeesAppointmentsCounts.Sum(eac => eac.NewClientsAppointmentsCount);

                cacheItem = new CacheItem<HomepageStatisticsModel>(stats);
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(60),
                };
                _memoryCache.Set(cacheKey, cacheItem, cacheExpiryOptions);
            }

            return cacheItem?.Item;
        }

        /// <summary>
        /// Zwraca liczbę wizyt, zakończonych wizyt oraz wizyt z nowymi klientami dla podanych pracowników i dat.
        /// </summary>
        /// <param name="employees"> Lista unikalnych Id pracowników. </param>
        /// <param name="dates"> Lista dat.</param>
        /// <returns> Lista obiektów <see cref="EmployeeAppointmentsCounts"/> z danymi o wizytach pracowników z danego zakresu dat.</returns>
        private List<EmployeeAppointmentsCounts> GetEmployeesAppointmentsCount(List<string> employees, List<DateTime> dates)
        {
            var employeesAppointmentsCounts = new List<EmployeeAppointmentsCounts>();
            var appointments = new List<Appointment>();

            foreach (var day in dates)
            {
                appointments.AddRange(_appointmentDao.GetNotCanceledAppointmentsByEmployeeIdsAndDate(employees, day).ToList());
            }

            var employeesAppointments = appointments.GroupBy(a => a.EmployeeId);
            var possibleNewClients = appointments.GroupBy(a => a.ClientId).Where(a => a.Count() == 1).Select(a => a.Key).ToList();

           
            foreach (var employeeAppointments in employeesAppointments)
            {
                var employeeAppointmentsCounts = new EmployeeAppointmentsCounts()
                {
                    EmployeeId = employeeAppointments.Key,
                    NotCanceledAppointmentsCount = employeeAppointments.Count(),
                    CompletedAppointmentsCount = employeeAppointments.Where(ea => ea.Status == AppointmentStatus.Completed).Count(),
                    NewClientsAppointmentsCount = employeeAppointments.Where(ea => ea.ClientId.HasValue && possibleNewClients.Contains(ea.ClientId) 
                                                                                && GetNotCanceledClientAppointmentsCount(ea.ClientId.Value) == 1).Count()
                };

                employeesAppointmentsCounts.Add(employeeAppointmentsCounts);
            }

            return employeesAppointmentsCounts;
        }

        /// <summary>
        /// Zwraca liczbę nieanulowanych wizyt dla danego klienta.
        /// </summary>
        /// <param name="clientId"> Unikalny numer Id klienta.</param>
        /// <returns>Liczba nieanulowanych wizyt.</returns>
        private int GetNotCanceledClientAppointmentsCount(int clientId)
        {
            return _appointmentDao.GetAppointmentsByClientId(clientId).Where(a => a.Status != AppointmentStatus.Canceled).Count();
        }
    }
}
