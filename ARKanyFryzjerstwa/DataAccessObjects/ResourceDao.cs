using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using Microsoft.EntityFrameworkCore;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class ResourceDao : BaseDao, IResourceDao
    {
        public ResourceDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Resources, currentSalonId) {  }

        /// <summary> Dodaje zasób do bazy danych.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o dodawanym zasobie. </param>
        public void AddResource(Resource resource)
        {
            _identityContext.Resources.Add(resource);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Pobiera informacje o zasobie na podstawie numeru Id.</summary>
        /// <param name="resourceId"> Unikalny numer Id zasobu. </param>
        /// <returns> Obiekt <see cref="Resource"/> zawierający informacje o zasobie. Jeśli informacje o danym zasobie nie istnieją, zwracana jest wartość null.</returns>
        public Resource? GetResourceById(int resourceId)
        {
            return _identityContext.Resources.Where(r => r.Id == resourceId).Include(s => s.ServiceResources).ThenInclude(sr => sr.Service).FirstOrDefault();
        }

        /// <summary> Pobiera informacje o wszystkich zasobach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Resource"/> zawierających informacje o zasobach.</returns>
        public IList<Resource> GetResourcesBySalonId(int salonId)
        {
            return _identityContext.Resources.Where(r => r.SalonId == salonId).Include(s => s.ServiceResources).ThenInclude(sr => sr.Service).ToList();
        }

        /// <summary> Pobiera informacje o kończących się zasobach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Resource"/> zawierających informacje o kończących się zasobach.</returns>
        public IList<Resource> GetResourcesGettingLow(int salondId)
        {
            return _identityContext.Resources.Where(r => r.SalonId == salondId && r.Quantity <= r.AlertQuantity).ToList(); 
        }

        /// <summary> Aktualizuje informacje o danym zasobie.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o zasobie. </param>
        public void UpdateResource(Resource resource)
        {
            _identityContext.Resources.Update(resource);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Usuwa podany zasób z bazy danych.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o zasobie do usunięcia. </param>
        public void RemoveResource(Resource resource)
        {
            _identityContext.Resources.Remove(resource);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Usuwa podane zasoby z bazy danych.</summary>
        /// <param name="resourcesToRemove"> Lista obiektów <see cref="Resource"/> zawierających informacje o zasobach do usunięcia. </param>
        public void RemoveResources(List<Resource> resourcesToRemove)
        {
            _identityContext.RemoveRange(resourcesToRemove);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }
    }
}
