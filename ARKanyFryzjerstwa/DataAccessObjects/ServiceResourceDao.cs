using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class ServiceResourceDao : BaseDao, IServiceResourceDao
    {
        public ServiceResourceDao(IdentityContext identityContext, int? currentSalonId) 
            : base(identityContext, DatabaseTable.ServiceResource, currentSalonId)
        {}

        /// <summary> Pobiera informacje o zasobach używanych podczas podanej usługi.</summary>
        /// <param name="serviceId"> Unikalny numer Id usługi. </param>
        /// <returns> Lista obiektów <see cref="DisplayingServiceResourceModel"/> zawierających informacje o zużyciu zasobów.</returns>
        public IList<DisplayingServiceResourceModel> GetServiceResources(int serviceId)
        {
            var result = _identityContext.ServiceResource
                .Where(x => x.ServiceId == serviceId)
                .Select(x => new DisplayingServiceResourceModel() { Id = x.ResourceId, Usage = x.Usage }).ToList();
            return result;
        }

        /// <summary> Aktualizuje informacje o zasobach używanych w trakcie podanej usługi.</summary>
        /// <param name="resources"> Lista obiektów <see cref="DisplayingServiceResourceModel"/> zawierających informacje o używanych zasobach. </param>
        /// <param name="serviceId"> Unikalny numer Id usługi. </param>
        public void UpdateServiceResources(IList<DisplayingServiceResourceModel> resources, int serviceId)
        {
            var salonResources = _identityContext.ServiceResource.Where(x => x.ServiceId == serviceId);
            var resourcesToAdd = resources.Select(x => new ServiceResource()
            {
                ResourceId = x.Id,
                Usage = x.Usage,
                ServiceId = serviceId
            });

            using (var transaction = _identityContext.Database.BeginTransaction())
            {
                _identityContext.RemoveRange(salonResources);
                _identityContext.AddRange(resourcesToAdd);
                _identityContext.SaveChanges();

                SetModificationDateTimeToNow();
                transaction.Commit();
            }
        }

    }
}
