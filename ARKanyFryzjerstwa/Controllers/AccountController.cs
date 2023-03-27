using ARKanyFryzjerstwa.Data;
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
    public class AccountController : BaseController
    {
        private readonly SignInManager<User> _signInManager;
        private readonly IAccountService _accountService;

        public AccountController(IdentityContext identityContext, IHttpContextAccessor httpContextAccessor, 
            UserManager<User> userManager, SignInManager<User> signInManager, IAccountService? accountService = null) 
            : base(userManager, httpContextAccessor)
        {
            _signInManager = signInManager;
            _accountService = accountService ?? new AccountService(identityContext, userManager, UserSalonId);
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Account
        /// </summary>
        /// <returns> Przekierowuje do akcji Index kontrolera Home. </returns>
        [HttpGet]
        [Authorize]
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        /// <summary>
        /// Obsługuje żadanie GET: /Account/Login
        /// </summary>
        /// <returns> Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca <see cref="ViewResult"/> strony logowania. </returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            if(_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }

            ViewData[Program.NOTIFICATION_KEY] = HttpContext.Session.Get<NotificationModel>(Program.NOTIFICATION_KEY);
            HttpContext.Session.Remove(Program.NOTIFICATION_KEY);
            return View();
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Account/RegisterSalon
        /// </summary>
        /// <returns> Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca <see cref="ViewResult"/> strony rejestracji salonu. </returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult RegisterSalon()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Home");
            }
            return View(new RegisterSalonModel());
        }

        /// <summary>
        /// Obsługuje żądanie GET: /Account/PasswordReset
        /// </summary>
        /// <returns> Dla zalogowanego użytkownika przekierowuje do akcji Index kontrolera Home, dla niezalogowanego zwraca <see cref="ViewResult"/> strony zmiany hasła. </returns>
        [HttpGet]
        [AllowAnonymous]
        public IActionResult PasswordReset()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction("Index", "Account");
            }
            var model = new PasswordResetModel();
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Account/Login
        /// </summary>
        /// <param name="model"> Dane wypełnione w formularzu logowania. </param>
        /// <returns> W przypadku logowania zakończonego sukcesem przekierowuje do akcji Index kontrolera Home, inaczej zwraca <see cref="ViewResult"/> strony logowania z informacjami o błędach. </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var userName = _accountService.GetUsernameByLogin(model.Login);

                if (userName != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(userName, model.Password, model.RememberMe, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                ModelState.AddModelError(string.Empty, "Błędny login lub hasło.");
            }
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Account/RegisterSalon
        /// </summary>
        /// <param name="model"> Dane wypełnione w formularzu rejestracji salonu. </param>
        /// <returns> W przypadku rejestrcji zakończonej sukcesem przekierowuje do akcji Login, inaczej zwraca <see cref="ViewResult"/> strony rejestracji salonu z informacjami o błędach. </returns>
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> RegisterSalon(RegisterSalonModel model)
        {
            if (ModelState.IsValid && await _accountService.RegisterSalon(model))
            {
                HttpContext.Session.Set(Program.NOTIFICATION_KEY, new NotificationModel(ARKanyResources.SalonRegisterSuccessMsg, NotificationType.Success));
                return RedirectToAction("Login", "Account");
            }
            ViewData[Program.NOTIFICATION_KEY] = new NotificationModel(ARKanyResources.SalonRegisterErrorMsg, NotificationType.Error);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Account/PasswordReset
        /// </summary>
        /// <param name="model"> Dane wypełnione w formularzu resetu hasła. </param>
        /// <returns> W przypadku resetu hasła zakończonego sukcesem przekierowuje do akcji Login, inaczej zwraca <see cref="ViewResult"/> strony resetu hasła z informacjami o błędach.</returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public IActionResult PasswordReset(PasswordResetModel model)
        {
            model.ShowPasswordDetials = true;
            if(ModelState.IsValid && _accountService.PasswordReset(model))
            {
                HttpContext.Session.Set(Program.NOTIFICATION_KEY, new NotificationModel(ARKanyResources.ChangingPasswordSuccessMsg, NotificationType.Success));
                return RedirectToAction("Login", "Account");
            }
            ViewData[Program.NOTIFICATION_KEY] = new NotificationModel(ARKanyResources.ChangingPasswordErrorMsg, NotificationType.Error);
            return View(model);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Account/SendPasswordResetVerificationCode
        /// </summary>
        /// <param name="login"> Login użytkownika, któremu ma zostać wysłany kod weryfikacyjny. </param>
        /// <returns> Obiekt <see cref="NotificationModel"/> w formacie JSON z informacją o rezultacie wysłania kodu weryfikacyjnego. </returns>
        [HttpPost]
        [AllowAnonymous]
        public JsonResult SendPasswordResetVerificationCode(string? login)
        {
            var notification = _accountService.SendPasswordResetVerificationCode(login, Url);
            return Json(notification);
        }

        /// <summary>
        /// Obsługuje żądanie POST: /Account/Logout
        /// </summary>
        /// <returns> Przekierowuje do akcji Index kontrolera Home. </returns>
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
