using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System.Diagnostics;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class HomeController : BaseController
    {
        private readonly IStatisticsService _statisticsService;
        private readonly IResourcesService _resourcesService;
        private readonly IAccountService _accountService;

        public HomeController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor,
            UserManager<User> userManager, IStatisticsService? statisticsService = null,
            IResourcesService? resourcesService = null, IAccountService? accountService = null, IMemoryCache? memoryCache = null) : base(userManager, httpContextAccessor)
        {
            var salonId = UserSalonId;
            var cache = memoryCache ?? new MemoryCache(new MemoryCacheOptions());
            _statisticsService = statisticsService ?? new StatisticsService(identityContext, salonId, cache);
            _resourcesService = resourcesService ?? new ResourcesService(identityContext, salonId);
            _accountService = accountService ?? new AccountService(identityContext, userManager, salonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony głównej. </returns>
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["UserFirstName"] = CurrentUser?.FirstName;
            return View();
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Home/Error
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony z informacją o błędzie. </returns>
        [AllowAnonymous]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Home/GetStats
        /// </summary>
        /// <returns> Obiekt <see cref="HomepageStatisticsModel"/> w formacie JSON ze statystykami dla aktualnego salonu. </returns>
        [HttpPost]
        public JsonResult GetStats()
        {
            var result = _statisticsService.GetHomepageStatistics(CurrentUser.Id, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Home/GetLowResources
        /// </summary>
        /// <returns> Obiekt <see cref="ResourcesModel"/> w formacie JSON z danymi o kończących się zasobach. </returns>
        [HttpPost]
        public JsonResult GetLowResources()
        {
            var result = _resourcesService.GetResourcesGettingLow(CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Home/GetUserNote
        /// </summary>
        /// <returns> Notatka użytkownika. </returns>
        [HttpPost]
        public JsonResult GetUserNote()
        {
            var note = _accountService.GetUserNote(CurrentUser.Id);
            return Json(note);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Home/SaveUserNote
        /// </summary>
        /// <param name="note">The note.</param>
        /// <returns> "Success". </returns>
        [HttpPost]
        public JsonResult SaveUserNote(string note)
        {
            _accountService.SaveUserNote(note, CurrentUser.Id);
            return Json("Success");
        }
    }
}