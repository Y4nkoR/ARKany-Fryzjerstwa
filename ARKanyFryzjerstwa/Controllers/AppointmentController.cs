using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;
using Microsoft.AspNetCore.Identity;
using ARKanyFryzjerstwa.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Authorization;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class AppointmentController : BaseController
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, IAppointmentService? appointmentService = null, IMemoryCache? memoryCache = null)
             : base(userManager, httpContextAccessor)
        {
            var cache = memoryCache ?? new MemoryCache(new MemoryCacheOptions());
            _appointmentService = appointmentService ?? new AppointmentService(identityContext, UserSalonId, cache);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Appointment/GetAppointmentCreationData
        /// </summary>
        /// <returns> Obiekt <see cref="AppointmentCreationDataModel"/> w formacie JSON z danymi dla aktualnego salonu. </returns>
        [HttpPost]
        public JsonResult GetAppointmentCreationData()
        {
            var result = _appointmentService.GetAppointmentCreationData(CurrentSalonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Appointment/GetClientPhoneNumberAndEmail
        /// </summary>
        /// <param name="clientId"> Unikalny identyfikator klienta.</param>
        /// <returns> Obiekt <see cref="ContactData"/> w formacie JSON z danymi dla aktualneo salonu. </returns>
        [HttpPost]
        public JsonResult GetClientPhoneNumberAndEmail(int clientId)
        {
            var phoneAndMail = _appointmentService.GetPhoneAndEmail(clientId);
            return Json(phoneAndMail);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Appointment/CreateAppointment
        /// </summary>
        /// <param name="appointmentAddModel"> Dane z formularza dodawania nowej wizyty.</param>
        /// <returns> Obiekt <see cref="Appointment"/> w formacie JSON z danymi utworzonej wizyty. </returns>
        public JsonResult CreateAppointment(AppointmentAddModel appointmentAddModel)
        {
            var salonId = CurrentSalonId;
            var result = _appointmentService.CreateAppointment(appointmentAddModel,CurrentUser.Id, salonId);
            return Json(result);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Appointment/DoAppointmentsOverlap
        /// </summary>
        /// <param name="appointmentAddModel"> Dane z formularza dodawanej wizyty.</param>
        /// <returns> Obiekt <see cref="bool"/> w formacie JSON informujący, czy występują nakładające się wizyty. </returns>
        public JsonResult DoAppointmentsOverlap(AppointmentAddModel appointmentAddModel)
        {
            var result = _appointmentService.DoAppointmentsOverlap(appointmentAddModel);
            return Json(result);
        }
    }
}
