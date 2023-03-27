using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class AppointmentDao : BaseDao, IAppointmentDao
    {
        public AppointmentDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Appointments, currentSalonId) {  }

        /// <summary>Dodaje wizytę do bazy danych.</summary>
        /// <param name="appointment">Wizyta do dodania.</param>
        /// <exception cref="Microsoft.EntityFrameworkCore.DbUpdateException">jeśli wizyta przed doadaniem ma przypisane id, lub nieuzupełnione wymagane pole.</exception>
        /// <exception cref="NullReferenceException">jeśli appointment == null.</exception>
        public void AddAppointment(Appointment appointment)
        {
            _identityContext.Appointments.Add(appointment);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <param name="appointmentId">Unikalny nr Id wizyty</param>
        /// <returns>Jeśli wizyta o podanym id istnieje zwraca obiekt <see cref="Appointment"/>, w przeciwnym razie zwraca <c>null</c>.</returns>
        public Appointment? GetAppointmentById(int appointmentId)
        {
            return _identityContext.Appointments.Where(c => c.Id == appointmentId).FirstOrDefault();
        }

        /// <summary> Wyszukuje i zwraca listę wizyt dla danych pracowników i dnia.</summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista wizyt dla podanych pracowników i dnia. </returns>
        public IList<Appointment> GetAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date)
        {
            return _identityContext.Appointments.Where(a => employees.Contains(a.EmployeeId) && a.Start.Date == date.Date).ToList();
        }

        /// <summary> Wyszukuje i zwraca listę nieanulowanych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista wizyt, które nie zostały anulowane. </returns>
        public IList<Appointment> GetNotCanceledAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date)
        {
            return _identityContext.Appointments.Where(a => employees.Contains(a.EmployeeId) && 
            a.Start.Date == date.Date && a.Status != AppointmentStatus.Canceled).ToList();
        }

        /// <summary> Wyszukuje i zwraca listę zaplanowanych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista zaplanowanych wizyt. </returns>
        public IList<Appointment> GetScheduledAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date)
        {
            return _identityContext.Appointments.Where(a => employees.Contains(a.EmployeeId) &&
            a.Start.Date == date.Date && a.Status == AppointmentStatus.Scheduled).ToList();
        }

        /// <summary> Wyszukuje i zwraca listę zakończonych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employeeId"> Id pracownika. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista ukończonych wizyt.</returns>
        public IList<Appointment> GetCompletedAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date)
        {
            return _identityContext.Appointments.Where(a => employees.Contains(a.EmployeeId) &&
            a.Start.Date == date && a.Status == AppointmentStatus.Completed).ToList();
        }

        /// <summary> Wyszukuje i zwraca listę wizyt dla danego klienta. </summary>
        /// <param name="clientId"> Id klienta.</param>
        /// <returns> Lista wizyt danego klienta. </returns>
        public IList<Appointment> GetAppointmentsByClientId(int clientId)
        {
            return _identityContext.Appointments.Where(a => a.ClientId == clientId).ToList();
        }

        /// <summary>Aktualizuje wizytę w bazie danych.</summary>
        /// <param name="appointment">Wizyta do aktualizacji.</param>
        /// <exception cref="NullReferenceException">jeśli appointment == null.</exception>
        public void UpdateAppointment(Appointment appointment)
        {
            _identityContext.Appointments.Update(appointment);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }
        /// <summary> Aktualizuje podane wizyty w bazie danych. </summary>
        /// <param name="appointments"> Lista obiektów <see cref="Appointment"/> zawierających informacje o wizytach do aktualizacji.</param>
        public void UpdateAppointments(IList<Appointment> appointments)
        {
            _identityContext.UpdateRange(appointments);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }
    }
}
