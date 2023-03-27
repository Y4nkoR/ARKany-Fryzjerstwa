using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IAppointmentDao : IBaseDaoGetters
    {
        /// <summary>Dodaje wizytę do bazy danych.</summary>
        /// <param name="appointment">Wizyta do dodania.</param>
        void AddAppointment(Appointment appointment);
        /// <param name="appointmentId">Unikalny nr Id wizyty</param>
        /// <returns>Jeśli wizyta o podanym id istnieje zwraca obiekt <see cref="Appointment"/>, w przeciwnym razie zwraca <c>null</c>.</returns>
        Appointment? GetAppointmentById(int appointmentId);
        /// <summary> Wyszukuje i zwraca listę wizyt dla danych pracowników i dnia.</summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista wizyt dla podanych pracowników i dnia. </returns>
        IList<Appointment> GetAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date);
        /// <summary> Wyszukuje i zwraca listę nieanulowanych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista wizyt, które nie zostały anulowane. </returns>
        IList<Appointment> GetNotCanceledAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date);
        /// <summary> Wyszukuje i zwraca listę zaplanowanych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employees"> Lista pracowników, dla których należy szukać danych. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista zaplanowanych wizyt. </returns>
        IList<Appointment> GetScheduledAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date);
        /// <summary> Wyszukuje i zwraca listę zakończonych wizyt dla danych pracowników i dnia. </summary>
        /// <param name="employeeId"> Id pracownika. </param>
        /// <param name="date"> Dzień, w którym należy szukać wizyt. </param>
        /// <returns> Lista ukończonych wizyt.</returns>
        IList<Appointment> GetCompletedAppointmentsByEmployeeIdsAndDate(IList<string> employees, DateTime date);
        /// <summary> Wyszukuje i zwraca listę wizyt dla danego klienta. </summary>
        /// <param name="clientId"> Id klienta.</param>
        /// <returns> Lista wizyt danego klienta. </returns>
        IList<Appointment> GetAppointmentsByClientId(int clientId);
        /// <summary>Aktualizuje wizytę w bazie danych.</summary>
        /// <param name="appointment">Wizyta do aktualizacji.</param>
        void UpdateAppointment(Appointment appointment);
        /// <summary> Aktualizuje podane wizyty w bazie danych. </summary>
        /// <param name="appointments"> Lista obiektów <see cref="Appointment"/> zawierających informacje o wizytach do aktualizacji.</param>
        void UpdateAppointments(IList<Appointment> appointments);
    }
}
