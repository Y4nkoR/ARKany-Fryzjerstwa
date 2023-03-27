using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class ResourcesController : BaseController
    {
        private readonly IResourcesService _resourcesService;

        public ResourcesController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, IResourcesService? resourcesService = null)
             : base(userManager, httpContextAccessor)
        {
            _resourcesService = resourcesService ?? new ResourcesService(identityContext, UserSalonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Resources
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony z listą zasobów salonu. </returns>
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            var model = _resourcesService.GetResourcesModel(CurrentSalonId);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Resources/AddNewResource
        /// </summary>
        /// <param name="resource"> Zasób do dodania.</param>
        /// <returns> Obiekt <see cref="ResourceModel"/> w formacie JSON dodanego zasobu. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult AddNewResource(ResourceModel resource)
        {
            var result = _resourcesService.AddNewResource(resource, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Resources/UpdateResource
        /// </summary>
        /// <param name="resource"> Zasób do zaktualizowania.</param>
        /// <returns> Obiekt <see cref="ResourceModel"/> w formacie JSON zaktualizowanego zasobu. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult UpdateResource(ResourceModel resource)
        {
            var result = _resourcesService.UpdateResource(resource, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Resources/RemoveResource
        /// </summary>
        /// <param name="resourceId"> Unikalny identyfikator zasobu.</param>
        [Authorize]
        [HttpPost]
        public void RemoveResource(int resourceId)
        {
            _resourcesService.RemoveResource(resourceId, CurrentSalonId);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Resources/RemoveResources
        /// </summary>
        /// <param name="resourcesIds"> Lista unikalnych identyfikatorów zasobów.</param>
        [Authorize]
        [HttpPost]
        public void RemoveResources(List<int> resourcesIds)
        {
            _resourcesService.RemoveResources(resourcesIds, CurrentSalonId);
        }

    }
}
