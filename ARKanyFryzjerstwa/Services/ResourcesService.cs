using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services.IServices;

namespace ARKanyFryzjerstwa.Services
{
    public class ResourcesService : IResourcesService
    {
        private readonly IResourceDao _resourceDao;

        public ResourcesService(IdentityContext identityContext, int? currentSalonId)
        {
            _resourceDao = new ResourceDao(identityContext, currentSalonId);
        }
        public ResourcesService(IResourceDao resourceDao)
        {
            _resourceDao = resourceDao;
        }

        /// <summary>
        /// Zwraca informacje o zasobach dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourcesModel"/> z danymi o zasobach.</returns>
        public ResourcesModel GetResourcesModel(int salonId)
        {
            var salonResources = _resourceDao.GetResourcesBySalonId(salonId).Select(r => ConvertResource(r)).ToList(); ;

            var model = new ResourcesModel
            {
                Resources = salonResources
            };

            return model;
        }

        /// <summary>
        /// Zwraca informacje o kończących się zasobach dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns>Obiekt <see cref="ResourcesModel"/> z danymi o kończących się zasobach.</returns>
        public ResourcesModel GetResourcesGettingLow(int salonId)
        {
            var resources = _resourceDao.GetResourcesGettingLow(salonId).Select(r => ConvertResource(r)).ToList();

            var model = new ResourcesModel
            {
                Resources = resources
            };

            return model;
        }

        /// <summary>
        /// Dodaje nowy zasób.
        /// </summary>
        /// <param name="resource"> Dane o zasobie do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourceModel"/> z danymi dodanego zasobu.</returns>
        public ResourceModel AddNewResource(ResourceModel resource, int salonId)
        {
            var resourceToAdd = ConvertResourceModel(resource, salonId);
            _resourceDao.AddResource(resourceToAdd);
            var result = ConvertResource(resourceToAdd);
            return result;
        }

        /// <summary>
        /// Aktualizuje zasób.
        /// </summary>
        /// <param name="resource"> Dane zasobu do zaktualizowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns>Obiekt <see cref="ResourceModel"/> z danymi o zaktualizowanym zasobie.</returns>
        public ResourceModel UpdateResource(ResourceModel resource, int salonId)
        {
            var resourceToUpdate = ConvertResourceModel(resource, salonId);
            _resourceDao.UpdateResource(resourceToUpdate);
            var result = ConvertResource(resourceToUpdate);
            return result;
        }

        /// <summary>
        /// Aktualizuje zasoby przypisane do usługi.
        /// </summary>
        /// <param name="serviceResourceModels"> Zasoby do zaktualizowania.</param>
        /// <exception cref="Exception"> Podany zasób nie istnieje.</exception>
        public void UpdateServiceResources(List<ResourceUsageModel> serviceResourceModels)
        {
            foreach (var serviceResourceModel in serviceResourceModels)
            {
                var resource = _resourceDao.GetResourceById(serviceResourceModel.Id);
                if (resource == null)
                {
                    throw new Exception("Resource not found (null)");
                }
                resource.Quantity = (float)Math.Round(resource.Quantity - serviceResourceModel.Usage, 2);

                _resourceDao.UpdateResource(resource);
            }
        }

        /// <summary>
        /// Usuwa zasób.
        /// </summary>
        /// <param name="resourceId"> Unikalny numer Id zasobu do usunięcia.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        public void RemoveResource(int resourceId, int salonId)
        {
            var resourceToDelete = new Resource
            {
                Id = resourceId,
                SalonId = salonId
            };

            _resourceDao.RemoveResource(resourceToDelete);
        }

        /// <summary>
        /// Usuwa zasoby.
        /// </summary>
        /// <param name="resourceIds"> Lista unikalnych numerów Id zasobów do usunięcia.</param>
        /// <param name="salonId">Unikalny numer Id salonu.</param>
        public void RemoveResources(List<int> resourceIds, int salonId)
        {
            List<Resource> resourcesToRemove = new List<Resource>();

            foreach (var resourceId in resourceIds)
            {
                var resourceToDelete = new Resource
                {
                    Id = resourceId,
                    SalonId = salonId
                };
                resourcesToRemove.Add(resourceToDelete);
            }

            _resourceDao.RemoveResources(resourcesToRemove);
        }

        /// <summary>
        /// Konwertuje obiekty <see cref="ServiceResource"/> na obiekty <see cref="ServiceResourceModel"/>.
        /// </summary>
        /// <param name="serviceResources"> Kolekcja obiektów do przekonwertowania.</param>
        /// <returns> Lista przekonwertowanych obiektów <see cref="ServiceResourceModel"/> z danymi o zasobach przypisanych do usługi.</returns>
        public static List<ServiceResourceModel> ConvertServiceResources (ICollection<ServiceResource> serviceResources)
        {
            return serviceResources.Select(sr => ConvertServiceResource(sr)).ToList();
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="ServiceResource"/> na obiekt <see cref="ServiceResourceModel"/>.
        /// </summary>
        /// <param name="serviceResource">Obiekt do przekonwertowania.</param>
        /// <returns> Przekonwertowany obiekt <see cref="ServiceResourceModel"/> z danymi o zasobie przypisanym do usługi.</returns>
        private static ServiceResourceModel ConvertServiceResource (ServiceResource serviceResource)
        {
            var result = new ServiceResourceModel
            {
                Id = serviceResource.ResourceId,
                Name = serviceResource.Resource.Name,
                Usage = serviceResource.Usage,
                Quantity = serviceResource.Resource.Quantity,
                Unit = serviceResource.Resource.Unit.ToString().ToLower()
            };

            return result;
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="Resource"/> na obiekt <see cref="ResourceModel"/>.
        /// </summary>
        /// <param name="resource">Obiekt do przekonwertowania.</param>
        /// <returns> Przekonwertowany obiekt <see cref="ResourceModel"/> z danymi o zasobie.</returns>
        private ResourceModel ConvertResource(Resource resource)
        {
            var result = new ResourceModel
            {
                Id = resource.Id,
                Name = resource.Name,
                Quantity = resource.Quantity.ToString(),
                Unit = resource.Unit,
                AlertQuantity = resource.AlertQuantity.ToString()
            };

            return result;
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="ResourceModel"/> na obiekt <see cref="Resource"/>.
        /// </summary>
        /// <param name="resource"> Obiekt do przekonwertowania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Przekonwertowany obiekt <see cref="Resource"/> z danymi o zasobie.</returns>
        /// <exception cref="ArgumentException">Podane dane o zasobie są niepoprawne.</exception>
        private Resource ConvertResourceModel(ResourceModel resource, int salonId)
        {
            if (!ValidateResourceModel(resource))
            {
                throw new ArgumentException("Resource model is not valid.");
            }
            var result = new Resource
            {
                Id = resource.Id,
                SalonId = salonId,
                Name = resource.Name,
                Quantity = float.Parse(resource.Quantity),
                Unit = resource.Unit,
                AlertQuantity = float.Parse(resource.AlertQuantity)
            };
            return result;
        }

        /// <summary>
        /// Sprawdza, czy dane o zasobie są poprawne.
        /// </summary>
        /// <param name="resource">Dane do sprawdzenia.</param>
        /// <returns> True, jeśli dane są poprawne. W przeciwnym wypadku - false.</returns>
        private bool ValidateResourceModel(ResourceModel resource)
        {
            float result;
            var isQuantityParsable = float.TryParse(resource.Quantity, out result);

            return isQuantityParsable &&
                (resource != null) &&
                (resource.Name.IsNotOnlyWhitespaces()) &&
                (resource.Name.Length <= 200);
        }
    }
}
