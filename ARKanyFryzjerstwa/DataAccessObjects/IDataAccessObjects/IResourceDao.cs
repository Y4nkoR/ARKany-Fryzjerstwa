using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IResourceDao : IBaseDaoGetters
    {
        /// <summary> Pobiera informacje o zasobie na podstawie numeru Id.</summary>
        /// <param name="resourceId"> Unikalny numer Id zasobu. </param>
        /// <returns> Obiekt <see cref="Resource"/> zawierający informacje o zasobie. Jeśli informacje o danym zasobie nie istnieją, zwracana jest wartość null.</returns>
        Resource? GetResourceById(int resourceId);
        /// <summary> Pobiera informacje o wszystkich zasobach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Resource"/> zawierających informacje o zasobach.</returns>
        IList<Resource> GetResourcesBySalonId(int salonId);
        /// <summary> Pobiera informacje o kończących się zasobach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="Resource"/> zawierających informacje o kończących się zasobach.</returns>
        IList<Resource> GetResourcesGettingLow(int salondId);
        /// <summary> Dodaje zasób do bazy danych.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o dodawanym zasobie. </param>
        void AddResource(Resource resource);
        /// <summary> Aktualizuje informacje o danym zasobie.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o zasobie. </param>
        void UpdateResource(Resource resource);
        /// <summary> Usuwa podany zasób z bazy danych.</summary>
        /// <param name="resource"> Obiekt <see cref="Resource"/> zawierający informacje o zasobie do usunięcia. </param>
        void RemoveResource(Resource resource);
        /// <summary> Usuwa podane zasoby z bazy danych.</summary>
        /// <param name="resourcesToRemove"> Lista obiektów <see cref="Resource"/> zawierających informacje o zasobach do usunięcia. </param>
        void RemoveResources(List<Resource> resourcesToRemove);
    }
}
