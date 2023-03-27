using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IServiceResourceDao
    {
        /// <summary> Pobiera informacje o zasobach używanych podczas podanej usługi.</summary>
        /// <param name="serviceId"> Unikalny numer Id usługi. </param>
        /// <returns> Lista obiektów <see cref="DisplayingServiceResourceModel"/> zawierających informacje o zużyciu zasobów.</returns>
        IList<DisplayingServiceResourceModel> GetServiceResources(int serviceId);
        /// <summary> Aktualizuje informacje o zasobach używanych w trakcie podanej usługi.</summary>
        /// <param name="resources"> Lista obiektów <see cref="DisplayingServiceResourceModel"/> zawierających informacje o używanych zasobach. </param>
        /// <param name="serviceId"> Unikalny numer Id usługi. </param>
        void UpdateServiceResources(IList<DisplayingServiceResourceModel> resources, int serviceId);
    }
}
