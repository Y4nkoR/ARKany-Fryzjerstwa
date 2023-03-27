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
    public class ScheduleController : BaseController
    {
        private readonly IScheduleService _scheduleService;
        private readonly IAppointmentService _appointmentService;
        private readonly IResourcesService _resourcesService;

        public ScheduleController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, IScheduleService? scheduleService = null, IAppointmentService? appointmentService = null, 
            IResourcesService? resourcesService = null, IMemoryCache? memoryCache = null)
             : base(userManager, httpContextAccessor)
        {
            var salonId = UserSalonId;
            var cache = memoryCache ?? new MemoryCache(new MemoryCacheOptions());
            _scheduleService = scheduleService ?? new ScheduleService(identityContext, salonId, cache);
            _appointmentService = appointmentService ?? new AppointmentService(identityContext, salonId, cache);
            _resourcesService = resourcesService ?? new ResourcesService(identityContext, salonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Schedule
        /// </summary>
        /// <returns> Obiekt <see cref="ViewResult"/> strony z widokiem harmonogramu. </returns>
        [Authorize]
        [HttpGet]
        public IActionResult Index()
        {
            var model = _scheduleService.GetScheduleModel(CurrentSalonId);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Schedule/GetAppointmentsForWeek
        /// </summary>
        /// <param name="date"> Data.</param>
        /// <param name="employees"> Lista pracowników.</param>
        /// <param name="forceCacheRefresh"> Wartość <c>true</c> wymusza aktualizację danych w cache.</param>
        /// <returns> Obiekt <see cref="ScheduleData"/> w formacie JSON z danymi o wizytach w aktualnym salonie w wybranym tygodniu. </returns>
        [HttpPost]
        public JsonResult GetAppointmentsForWeek(DateTime date, IList<string> employees, bool forceCacheRefresh)
        {
            var result = _scheduleService.GetAppointmentsForWeek(date, employees, forceCacheRefresh, CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Schedule/CancelAppointment
        /// </summary>
        /// <param name="appointmentId"> Unikalny identyfikator wizyty do odwołania.</param>
        /// <returns> Unikalny identyfikator odwołanej wizyty. </returns>
        [HttpPost]
        public JsonResult CancelAppointment(int appointmentId)
        {
            _appointmentService.CancelAppointment(appointmentId);
            return Json(appointmentId);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Schedule/CompleteAppointment
        /// </summary>
        /// <param name="appointmentCompletionData"> Dane wizyty do zakończenia.</param>
        /// <returns> Unikalny identyfikator zakończonej wizyty.</returns>
        [HttpPost]
        public JsonResult CompleteAppointment(AppointmentCompletionDataModel appointmentCompletionData)
        {
            _appointmentService.CompleteAppointment(appointmentCompletionData);
            if (appointmentCompletionData.Resources != null)
            {
                _resourcesService.UpdateServiceResources(appointmentCompletionData.Resources);

            }
            return Json(appointmentCompletionData.AppointmentId);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Schedule/GetAppointmentServiceModel
        /// </summary>
        /// <param name="appointmentId"> Unikalny identyfikator wizyty.</param>
        /// <returns> Obiekt <see cref="ServiceModel"/> w formacie JSON z danymi o usłudze dla wizyty. </returns>
        [HttpPost]
        public JsonResult GetAppointmentServiceModel(int appointmentId)
        {
            var result = _appointmentService.GetAppointmentServiceModel(appointmentId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Schedule/GetAllResources
        /// </summary>
        /// <returns> Obiekt <see cref="ResourcesModel"/> w formacie JSON z danymi o zasobach salonu. </returns>
        [Authorize]
        [HttpPost]
        public JsonResult GetAllResources()
        {
            var result = _resourcesService.GetResourcesModel(CurrentSalonId);
            return Json(result);
        }
    }
}