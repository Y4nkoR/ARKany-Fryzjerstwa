using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IServicesService
    {
        /// <summary>
        /// Zwraca dane o usłudze na podstawie unikalnego numeru Id.
        /// </summary>
        /// <param name="serviceId"> Unikalny numer Id usługi.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi o usłudze.</returns>
        /// <exception cref="Exception"> Usługa o podanym Id nie istnieje.</exception>
        ServiceModel GetServiceModelById(int serviceId);
        /// <summary>
        /// Zwraca usługi dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ServicesModel"/> z danymi o usługach.</returns>
        ServicesModel GetServicesModel(int salonId);
        /// <summary>
        /// Dodaje usługę.
        /// </summary>
        /// <param name="service"> Dane usługi do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi dodanej usługi.</returns>
        ServiceModel AddNewService(ServiceModel service, int salonId);
        /// <summary>
        /// Aktualizuje usługę.
        /// </summary>
        /// <param name="service"> Dane usługi do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi zaktualizowanej usługi.</returns>
        ServiceModel UpdateService(ServiceModel service, int salonId);
        /// <summary>
        /// Aktualizuje usługi.
        /// </summary>
        /// <param name="services"> Lista usług do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="ServiceModel"/> z danymi zaktualizowanych usług.</returns>
        List<ServiceModel> UpdateServices(List<ServiceModel> services, int salonId);
        /// <summary>
        /// Zwraca zasoby dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="DisplayedResource"/> z danymi zasobów.</returns>
        IList<DisplayedResource> GetSalonResources(int salonId);
        /// <summary>
        /// Zwraca zasoby używane w trakcie danej usługi.
        /// </summary>
        /// <param name="serviceId"> Unikalny numer Id usługi.</param>
        /// <returns>Lista obiektów <see cref="DisplayingServiceResourceModel"/> z danymi o zasobach używanych w trakcie danej usługi.</returns>
        IList<DisplayingServiceResourceModel> GetServiceResources(int serviceId);
        /// <summary>
        /// Aktualizuje zasoby używane w trakcie danej usługi.
        /// </summary>
        /// <param name="resources"> Aktualizowane zasoby.</param>
        /// <param name="serviceId"> Aktualizowana usługa.</param>
        void SaveServiceResources(IList<DisplayingServiceResourceModel> resources, int serviceId);
    }
}
