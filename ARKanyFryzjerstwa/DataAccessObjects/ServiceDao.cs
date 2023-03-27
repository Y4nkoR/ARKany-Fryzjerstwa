using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using Microsoft.EntityFrameworkCore;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class ServiceDao : BaseDao, IServiceDao
    {
        public ServiceDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Services, currentSalonId) {  }

        /// <summary> Dodaje podaną usługę do bazy danych.</summary>
        /// <param name="service"> Obiekt <see cref="Service"/> zawierający informacje o dodawanej usłudze. </param>
        public void AddService(Service service)
        {
            _identityContext.Services.Add(service);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Pobiera informacje o usłudze na podstawie numeru Id.</summary>
        /// <param name="serviceId"> Uniklany numer Id usługi. </param>
        /// <returns> Obiekt <see cref="Service"/> zawierający informacje o usłudze. Jeśli informacje o danej usłudze nie istnieją, zwracana jest wartość null.</returns>
        public Service? GetServiceById(int serviceId)
        {
            return _identityContext.Services.Where(s => s.Id == serviceId).Include(s => s.ServiceResources).ThenInclude(sr => sr.Resource).FirstOrDefault();
        }

        /// <summary> Pobiera informacje o aktywnych usługach dla danego salonu.</summary>
        /// <param name="salonId"> Uniklany numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Service"/> zawierających informacje o usługach.</returns>
        public IList<Service> GetActiveServicesForSalon(int salonId)
        {
            return _identityContext.Services.Where(s => s.IsActive && s.SalonId == salonId).ToList();
        }

        /// <summary> Pobiera informacje o usługach dla danego salonu.</summary>
        /// <param name="salonId"> Uniklany numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Service"/> zawierających informacje o usługach.</returns>
        public IList<Service> GetServicesBySalonId(int salonId)
        {
            return _identityContext.Services.Where(s => s.SalonId == salonId).Include(s => s.ServiceResources).ThenInclude(sr => sr.Resource).ToList();
        }

        /// <summary> Aktualizuje informacje o danej usłudze.</summary>
        /// <param name="service"> Obiekt <see cref="Service"/> zawierający informacje o usłudze. </param>
        public void UpdateService(Service service)
        {
            _identityContext.Services.Update(service);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Aktualizuje informacje o danych usługach.</summary>
        /// <param name="services"> Lista obiektów <see cref="Service"/> zawierających informacje o usługach. </param>
        public void UpdateServices(List<Service> services)
        {
            _identityContext.UpdateRange(services);
            _identityContext.SaveChanges();
        }
    }
}
