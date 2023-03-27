using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Errors;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Resources;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Controllers
{
    [Authorize]
    public class SettingsController : BaseController
    {
        private readonly ISettingsService _settingsService;
        public bool IsUserNotSalonOwner => User.IsNotInRole(Role.SalonOwner);

        public SettingsController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, ISettingsService? settingsService = null) 
            : base(userManager, httpContextAccessor)
        {
            _settingsService = settingsService ?? new SettingsService(identityContext, userManager, UserSalonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Settings
        /// </summary>
        /// <returns> Zwraca obiekt <see cref="ViewResult"/> strony z panelem ustawień salonu lub przekierowuje do akcji Index kontrolera Schedule. </returns>
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            if (IsUserNotSalonOwner)
            {
                return RedirectToAction("Index", "Schedule");
            }

            return View();
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Settings/GetEmployees
        /// </summary>
        /// <returns> Lista obiektów <see cref="EmployeeModel"/> w formacie JSON z danymi pracowników aktualnego salonu. </returns>
        /// <exception cref="System.Exception"> Użytkowik nie ma uprawnień. </exception>
        [HttpPost]
        [Authorize]
        public JsonResult GetEmployees()
        {
            if (IsUserNotSalonOwner)
            {
                throw new Exception(ARKanyResources.NoPerrmisionErrorMessage);
            }

            var employees = _settingsService.GetEmployees(CurrentSalonId);

            return Json(employees);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Settings/AddNewEmployee
        /// </summary>
        /// <param name="model"> Dane pracownika do utworzenia.</param>
        /// <returns> Obiekt <see cref="EmployeeModel"/> w formacie JSON z danymi utworzonego pracownika lub obiekt w formacie JSON z informacją o błędzie.</returns>
        [HttpPost]
        [Authorize]
        public JsonResult AddNewEmployee(EmployeeToAddModel model)
        {
            if (IsUserNotSalonOwner)
            {
                return Json(new { error = ARKanyResources.NoPerrmisionErrorMessage });
            }

            try
            {
                var employee = _settingsService.AddNewEmployee(model, CurrentSalonId, Url).Result;
                return Json(employee);
            }
            catch(Exception ex)
            {
                if (ex.InnerException != null && ex.InnerException.GetType() == typeof(ARKanyIdentityException))
                {
                    return Json(new { error = ex.InnerException.Message });
                }
                throw new Exception();
            }
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Settings/SaveEmployeeColor
        /// </summary>
        /// <param name="color"> Kolor.</param>
        /// <param name="employeeId"> Unikalny identyfikator pracownika.</param>
        /// <returns> "Success" lub obiekt w formacie JSON z informacją o błędzie. </returns>
        [HttpPost]
        [Authorize]
        public JsonResult SaveEmployeeColor(string color, string employeeId)
        {
            if (IsUserNotSalonOwner)
            {
                return Json(new { error = ARKanyResources.NoPerrmisionErrorMessage });
            }

            _settingsService.SaveEmployeeColor(color, employeeId);

            return Json("Success");
        }

    }
}
