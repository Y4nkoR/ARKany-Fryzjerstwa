using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IStatisticsService
    {
        /// <summary>
        /// Zwraca statystyki wyświetlane na głównej stronie.
        /// </summary>
        /// <param name="employeeId"> Unikalny Id pracownika, dla którego mają zostać wyświetlone statystyki.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="HomepageStatisticsModel"/> ze statystykiami.</returns>
        HomepageStatisticsModel GetHomepageStatistics(string employeeId, int salonId);
    }
}