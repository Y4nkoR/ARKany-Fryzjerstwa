using ARKanyFryzjerstwa.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace ARKanyFryzjerstwa.Extensions
{
    public static class UserExtensions
    {
        /// <summary> Zwraca nazwę klienta w postaci do wyświetlenia. </summary>
        /// <param name="client"> Klient, którego nazwa ma zostać zwrócona. </param>
        /// <returns> Nazwa klienta w postaci do wyświetlenia. </returns>
        public static string DisplayName(this Client client)
        {
            return client.FirstName + " " + client.LastName;
        }

        /// <summary> Zwraca nazwę użytkownika w postaci do wyświetlenia. </summary>
        /// <param name="user"> Użytkownik, którego nazwa ma zostać zwrócona. </param>
        /// <returns> Nazwa użytkownika w postaci do wyświetlenia. </returns>
        public static string DisplayName(this User user)
        {
            return user.FirstName + " " + user.LastName;
        }

        /// <summary> Zwraca użytkownika odpowiadajacego przekazanemu obiektowi <see cref="ClaimsPrincipal"/>. </summary>
        /// <param name="userManager"> Obiekt <see cref="UserManager{TUser}"/>. </param>
        /// <param name="user"> Obiekt <see cref="ClaimsPrincipal"/>, dla którego ma zostać zwrócony użytkownik. </param>
        /// <returns> Użytkownik odpowiadający przekazanemu obiektowi <see cref="ClaimsPrincipal"/> lub null, jeśli taki użytkownik nie istnieje. </returns>
        public static User GetUser(this UserManager<User> userManager, ClaimsPrincipal user)
        {
            if (user == null)
            {
                return null;
            }
            return userManager.GetUserAsync(user).Result;
        }

        /// <summary> Sprawdza, czy przekazany obiekt <see cref="ClaimsPrincipal"/> posiada określoną rolę. </summary>
        /// <param name="user"> Obiekt <see cref="ClaimsPrincipal"/>, który ma zostać sprawdzony. </param>
        /// <param name="role"> Obiekt <see cref="Role"/>. </param>
        /// <returns> True, jeśli podany <see cref="ClaimsPrincipal"/> posiada określoną rolę. </returns>
        public static bool IsInRole(this ClaimsPrincipal user, Role role)
        {
            return user.IsInRole(RolesFactory.GetName(role));
        }

        /// <summary> Sprawdza, czy przekazany obiekt <see cref="ClaimsPrincipal"/> nie posiada określonej roli. </summary>
        /// <param name="user"> Obiekt <see cref="ClaimsPrincipal"/>, który ma zostać sprawdzony. </param>
        /// <param name="role"> Obiekt <see cref="Role"/>. </param>
        /// <returns> True, jeśli podany <see cref="ClaimsPrincipal"/> nie posiada określonej roli. </returns>
        public static bool IsNotInRole(this ClaimsPrincipal user, Role role)
        {
            return !user.IsInRole(role);
        }
    }
}
