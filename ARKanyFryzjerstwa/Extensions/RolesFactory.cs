using EnumsNET;
using System.ComponentModel;

namespace ARKanyFryzjerstwa.Extensions
{
    public enum Role
    {
        [Description("SalonOwnerRole")]
        SalonOwner = 0,
    }

    public static class RolesFactory
    {
        /// <summary> Zwraca nazwę podanej roli. </summary>
        /// <param name="role"> Rola, której nazwa ma zostać zwrócona. </param>
        /// <returns> Nazwa roli w postaci ciągu znaków.</returns>
        public static string GetName(Role role)
        {
            return role.AsString(EnumFormat.Description);
        }
    }
}
