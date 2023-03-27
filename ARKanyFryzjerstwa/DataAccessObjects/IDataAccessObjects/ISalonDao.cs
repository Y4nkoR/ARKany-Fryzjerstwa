using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface ISalonDao
    {
        /// <summary>
        /// Dodaje przekazany salon do bazy danych.
        /// </summary>
        /// <param name="salon">Salon do dodania do bazy danych.</param>
        /// <returns>Id dodanego salonu.</returns>
        int InsertSalon(Salon salon);
        /// <summary>
        /// Pobiera kolory pracowników salonu o podanym identyfikatorze.
        /// </summary>
        /// <param name="salonId">Identyfikator salonu.</param>
        /// <returns>Kolory pracowników salonu.</returns>
        IList<string> GetEmployeesColorsForSalon(int salonId);
    }
}
