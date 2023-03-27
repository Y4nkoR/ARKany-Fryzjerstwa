using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class ServicesController : BaseController
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, IServicesService? servicesService = null, IMemoryCache? memoryCache = null)
             : base(userManager, httpContextAccessor)
        {
            var cache = memoryCache ?? new MemoryCache(new MemoryCacheOptions());
            _servicesService = servicesService ?? new ServicesService(identityContext, UserSalonId, cache);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Services
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony z listą usług salonu. </returns>
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var model = _servicesService.GetServicesModel(CurrentSalonId);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/AddNewService
        /// </summary>
        /// <param name="service"> Usługa do dodania.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> w formacie JSON dodanej usługi. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult AddNewService(ServiceModel service)
        {
            var result = _servicesService.AddNewService(service, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/UpdateServiceData
        /// </summary>
        /// <param name="service"> Usługa do zaktualizowania.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> w formacie JSON zaktualizowanej usługi. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult UpdateServiceData(ServiceModel service)
        {
            var result = _servicesService.UpdateService(service, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/UpdateServices
        /// </summary>
        /// <param name="services"> Lista usług do zaktualizowania.</param>
        /// <returns> Lista obiektów <see cref="ServiceModel"/> w formacie JSON zaktualizowanych usług. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult UpdateServices(List<ServiceModel> services)
        {
            var salonId = CurrentSalonId;
            var result = _servicesService.UpdateServices(services, salonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/GetSalonResources
        /// </summary>
        /// <returns> Lista obiektów <see cref="DisplayedResource"/> w formacie JSON z danymi o zasobach salonu. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult GetSalonResources()
        {
            var result = _servicesService.GetSalonResources(CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/GetServiceResources
        /// </summary>
        /// <param name="serviceId"> Unikalny identyfikator usługi.</param>
        /// <returns> Lista obiektów <see cref="DisplayingServiceResourceModel"/> w formacie JSON z danymi o zasobach usługi. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult GetServiceResources(int serviceId)
        {
            var result = _servicesService.GetServiceResources(serviceId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Services/SaveServiceResources
        /// </summary>
        /// <param name="resources"> Lista zasobów.</param>
        /// <param name="serviceId"> Unikalny identyfikator usługi.</param>
        /// <returns> "Success". </returns>
        [Authorize]
        [HttpPost]
        public JsonResult SaveServiceResources(IList<DisplayingServiceResourceModel> resources, int serviceId)
        {
            _servicesService.SaveServiceResources(resources, serviceId);
            return Json("Success");
        }

    }
}
