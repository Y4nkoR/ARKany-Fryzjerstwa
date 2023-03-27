using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services.IServices;
using EnumsNET;
using Microsoft.Extensions.Caching.Memory;
using System.Text.RegularExpressions;

namespace ARKanyFryzjerstwa.Services
{
    public class ServicesService : IServicesService
    {
        private const string SALON_RESOURCES_CACHE_KEY = "AllSalonResources_";

        private readonly IMemoryCache _memoryCache;
        private readonly IServiceDao _serviceDao;
        private readonly IResourceDao _resourcesDao;
        private readonly IServiceResourceDao _serviceResourceDao;

        public ServicesService(IdentityContext identityContext, int? currentSalonId, IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
            _serviceDao = new ServiceDao(identityContext, currentSalonId);
            _resourcesDao = new ResourceDao(identityContext, currentSalonId);
            _serviceResourceDao = new ServiceResourceDao(identityContext, currentSalonId);
        }
        public ServicesService(IMemoryCache memoryCache, IServiceDao serviceDao, IResourceDao resourceDao, IServiceResourceDao serviceResourceDao)
        {
            _memoryCache = memoryCache;
            _serviceDao = serviceDao;
            _resourcesDao = resourceDao;
            _serviceResourceDao = serviceResourceDao;
        }

        /// <summary>
        /// Zwraca dane o usłudze na podstawie unikalnego numeru Id.
        /// </summary>
        /// <param name="serviceId"> Unikalny numer Id usługi.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi o usłudze.</returns>
        /// <exception cref="Exception"> Usługa o podanym Id nie istnieje.</exception>
        public ServiceModel GetServiceModelById(int serviceId)
        {
            var service = _serviceDao.GetServiceById(serviceId);
            if (service == null)
            {
                throw new Exception(nameof(service));
            }

            var serviceModel = ConvertService(service);
            return serviceModel;
        }

        /// <summary>
        /// Zwraca usługi dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ServicesModel"/> z danymi o usługach.</returns>
        public ServicesModel GetServicesModel(int salonId)
        {
            var salonServices = _serviceDao.GetServicesBySalonId(salonId).Select(s => ConvertService(s)).ToList();

            var model = new ServicesModel
            {
                Services = salonServices
            };

            return model;
        }

        /// <summary>
        /// Dodaje usługę.
        /// </summary>
        /// <param name="service"> Dane usługi do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi dodanej usługi.</returns>
        public ServiceModel AddNewService(ServiceModel service, int salonId)
        {
            var serviceToAdd = ConvertServiceModel(service, salonId);
            _serviceDao.AddService(serviceToAdd);
            var result = ConvertService(serviceToAdd);
            return result;
        }

        /// <summary>
        /// Aktualizuje usługę.
        /// </summary>
        /// <param name="service"> Dane usługi do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi zaktualizowanej usługi.</returns>
        public ServiceModel UpdateService(ServiceModel service, int salonId)
        {
            var serviceToUpdate = ConvertServiceModel(service, salonId);
            _serviceDao.UpdateService(serviceToUpdate);
            var result = ConvertService(serviceToUpdate);
            return result;
        }

        /// <summary>
        /// Aktualizuje usługi.
        /// </summary>
        /// <param name="services"> Lista usług do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="ServiceModel"/> z danymi zaktualizowanych usług.</returns>
        public List<ServiceModel> UpdateServices(List<ServiceModel> services, int salonId)
        {
            List<Service> servicesToUpdate = new List<Service>();
            foreach(var service in services)
            {
                var serviceToUpdate = ConvertServiceModel(service, salonId);
                servicesToUpdate.Add(serviceToUpdate);
                
            }
            _serviceDao.UpdateServices(servicesToUpdate);
            return services;
        }

        /// <summary>
        /// Zwraca zasoby dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="DisplayedResource"/> z danymi zasobów.</returns>
        public IList<DisplayedResource> GetSalonResources(int salonId)
        {
            var cacheKey = SALON_RESOURCES_CACHE_KEY + salonId;
            if (!_memoryCache.TryGetValue(cacheKey, out CacheItem<IList<DisplayedResource>> cacheItem) || !_resourcesDao.IsUpToDate(cacheItem.ModificationTime))
            {
                var resources = _resourcesDao.GetResourcesBySalonId(salonId).Select(x => new DisplayedResource(x.Id, x.Name, x.Unit.AsString(EnumFormat.Description))).OrderBy(x => x.Name).ToList();
                cacheItem = new CacheItem<IList<DisplayedResource>>(resources);
                var cacheExpiryOptions = new MemoryCacheEntryOptions
                {
                    AbsoluteExpiration = DateTime.Now.AddMinutes(60),
                };
                _memoryCache.Set(cacheKey, cacheItem, cacheExpiryOptions);
            }
            
            return cacheItem?.Item;
        }

        /// <summary>
        /// Zwraca zasoby używane w trakcie danej usługi.
        /// </summary>
        /// <param name="serviceId"> Unikalny numer Id usługi.</param>
        /// <returns>Lista obiektów <see cref="DisplayingServiceResourceModel"/> z danymi o zasobach używanych w trakcie danej usługi.</returns>
        public IList<DisplayingServiceResourceModel> GetServiceResources(int serviceId)
        {
            var result = _serviceResourceDao.GetServiceResources(serviceId);
            return result;
        }

        /// <summary>
        /// Aktualizuje zasoby używane w trakcie danej usługi.
        /// </summary>
        /// <param name="resources"> Aktualizowane zasoby.</param>
        /// <param name="serviceId"> Aktualizowana usługa.</param>
        public void SaveServiceResources(IList<DisplayingServiceResourceModel> resources, int serviceId)
        {
            _serviceResourceDao.UpdateServiceResources(resources, serviceId);
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="Service"/> na obiekt <see cref="ServiceModel"/>.
        /// </summary>
        /// <param name="service">Obiekt do przekonwertowania.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> z danymi o usłudze.</returns>
        private static ServiceModel ConvertService(Service service)
        {
            var result = new ServiceModel
            {
                Id = service.Id,
                Name = service.Name,
                Duration = service.Duration.MinutesToDurationString(),
                Price = service.Price.ToPriceString(),
                Resources = service.ServiceResources == null ? new List<ServiceResourceModel>() 
                                                            : ResourcesService.ConvertServiceResources(service.ServiceResources),
                IsActive = service.IsActive
            };
            return result;
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="ServiceModel"/> na obiekt <see cref="Service"/>.
        /// </summary>
        /// <param name="service">Obiekt do przekonwertowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="Service"/> z danymi o usłudze.</returns>
        /// <exception cref="ArgumentException"> Dane usługi są niepoprawne.</exception>
        private Service ConvertServiceModel(ServiceModel service, int salonId)
        {
            if (!ValidateServiceModel(service))
            {
                throw new ArgumentException("Service model is not valid.");
            }
            var result = new Service
            {
                Id = service.Id,
                Name = service.Name,
                Duration = service.Duration.GetMinutesFromDurationString(),
                Price = service.Price.GetPrice(),
                SalonId = salonId,
                IsActive = service.IsActive
            };
            return result;
        }

        /// <summary>
        /// Sprawdza, czy dane o usłudze są poprawne.
        /// </summary>
        /// <param name="service"> Dane do sprawdzenia.</param>
        /// <returns> True, jeśli dane są poprawne. W przeciwnym wypadku - false.</returns>
        private bool ValidateServiceModel(ServiceModel service)
        {
            const string durationPattern = @"^[0-9]{1,2}:[0-9]{2}$";
            const string pricePattern = @"^[0-9]{1,4}[\.,]?([0-9]{1,2})?( ?zł)?$";

            return (service != null) && 
                (service.Duration != null) && 
                (service.Price != null) && 
                service.Name.IsNotOnlyWhitespaces() && 
                service.Name.Length <= 200 && 
                Regex.IsMatch(service.Duration, durationPattern) && 
                Regex.IsMatch(service.Price, pricePattern);
        }
    }
}
