using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IScheduleService
    {
        /// <summary>
        /// Zwraca dane o harmonogramie dla podanego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleModel"/> z danymi o harmonogramie.</returns>
        ScheduleModel GetScheduleModel(int salonId);
        /// <summary>
        /// Zwraca dane o dniach tygodnia, w którym znajduje się podana data.
        /// </summary>
        /// <param name="date"> Data, dla której należy zwrócić informacje o tygodniu.</param>
        /// <param name="employeeIds"> Lista unikalnych Id pracowników, dla których należy zwrócić dane.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleData"/> z informacjami o dniach tygodnia.</returns>
        ScheduleData GetScheduleDays(DateTime date, IList<string> employeeIds, int salonId);
        /// <summary>
        /// Zwraca informacje o wizytach w tygodniu, w którym znajduje się podana data.
        /// </summary>
        /// <param name="date"> Data w tygodniu, dla którego mają zostać zwrócone informacje.</param>
        /// <param name="employees"> Lista unikalnych Id pracowników, dla których należy zwrócić dane.</param>
        /// <param name="forceCacheRefresh"> Wartość true wymusza aktualizację danych w cache.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ScheduleData"/> z danymi o wizytach w danym tygodniu.</returns>
        ScheduleData GetAppointmentsForWeek(DateTime date, IList<string> employees, bool forceCacheRefresh, int salonId);
    }
}
