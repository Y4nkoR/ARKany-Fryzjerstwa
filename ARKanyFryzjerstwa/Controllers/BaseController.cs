using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Controllers
{
    public abstract class BaseController : Controller
    {
        /// <summary>
        /// Obiekt <see cref="UserManager{TUser}"/>. Niedostępny spoza kontrolera.
        /// </summary>
        protected readonly UserManager<User> _userManager;

        /// <summary>
        /// Obiekt <see cref="User"/> zalogowanego użytkownika.
        /// </summary>
        public User CurrentUser => _userManager.GetUser(User);

        /// <summary>
        /// Unikalny identyfikator salonu zalogowanego użytkownika lub null w przypadku niezalogowanego. 
        /// </summary>
        public int? UserSalonId => CurrentUser?.SalonId;
        /// <summary>
        /// Unikalny identyfikator salonu zalogowanego użytkownika.
        /// </summary>
        public int CurrentSalonId => CurrentUser.SalonId;

        public BaseController(UserManager<User> userManager, IHttpContextAccessor httpContextAccessor)
        {
            ControllerContext.HttpContext = httpContextAccessor.HttpContext!;
            _userManager = userManager;
        }
    }
}
