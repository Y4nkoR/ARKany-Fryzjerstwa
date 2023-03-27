using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class SalonDao : BaseDao, ISalonDao 
    {
        public SalonDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Salons, currentSalonId) {  }
        
        /// <summary>
        /// Dodaje przekazany salon do bazy danych.
        /// </summary>
        /// <param name="salon">Salon do dodania do bazy danych.</param>
        /// <returns>Id dodanego salonu.</returns>
        public int InsertSalon(Salon salon)
        {
            _identityContext.Salons.Add(salon);
            _identityContext.SaveChanges();
            return salon.Id;
        }

        /// <summary>
        /// Pobiera kolory pracowników salonu o podanym identyfikatorze.
        /// </summary>
        /// <param name="salonId">Identyfikator salonu.</param>
        /// <returns>Kolory pracowników salonu.</returns>
        public IList<string> GetEmployeesColorsForSalon(int salonId)
        {
            return _identityContext.Users.Where(u => u.SalonId == salonId).Select(u => u.Color).ToList();
        }
    }
}
