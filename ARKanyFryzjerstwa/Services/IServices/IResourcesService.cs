using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IResourcesService
    {
        /// <summary>
        /// Zwraca informacje o zasobach dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourcesModel"/> z danymi o zasobach.</returns>
        ResourcesModel GetResourcesModel(int salonId);
        /// <summary>
        /// Zwraca informacje o kończących się zasobach dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns>Obiekt <see cref="ResourcesModel"/> z danymi o kończących się zasobach.</returns>
        ResourcesModel GetResourcesGettingLow(int salonId);
        /// <summary>
        /// Dodaje nowy zasób.
        /// </summary>
        /// <param name="resource"> Dane o zasobie do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourceModel"/> z danymi dodanego zasobu.</returns>
        ResourceModel AddNewResource(ResourceModel resource, int salonId);
        /// <summary>
        /// Aktualizuje zasób.
        /// </summary>
        /// <param name="resource"> Dane zasobu do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourceModel"/> z danymi o zaktualizowanym zasobie.</returns>
        ResourceModel UpdateResource(ResourceModel resource, int salonId);
        /// <summary>
        /// Aktualizuje zasoby przypisane do usługi.
        /// </summary>
        /// <param name="serviceResourceModels"> Zasoby do zaktualizowania.</param>
        /// <exception cref="Exception"> Podany zasób nie istnieje.</exception>
        void UpdateServiceResources(List<ResourceUsageModel> serviceResourceModels);
        /// <summary>
        /// Usuwa zasób.
        /// </summary>
        /// <param name="resourceId"> Unikalny numer Id zasobu do usunięcia.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        void RemoveResource(int resourceId, int salonId);
        /// <summary>
        /// Usuwa zasoby.
        /// </summary>
        /// <param name="resourceIds"> Lista unikalnych numerów Id zasobów do usunięcia.</param>
        /// <param name="salonId">Unikalny numer Id salonu.</param>
        void RemoveResources(List<int> resourceIds, int salonId);
    }
}
