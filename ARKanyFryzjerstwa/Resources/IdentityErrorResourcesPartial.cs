namespace ARKanyFryzjerstwa.Resources
{
    /// <summary>
    /// Klasa zwracająca sformatowane ciągi z <see cref="IdentityErrorResources"/>
    /// </summary>
    public partial class IdentityErrorResources
    {
        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="InvalidUserName"/>.
        /// </summary>
        /// <param name="userName">Błędna nazwa użytkownika.</param>
        /// <returns>Sformatowany ciąg <see cref="InvalidUserName"/>.</returns>
        public static string FormatInvalidUserName(string userName) => string.Format(InvalidUserName, userName);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="InvalidEmail"/>.
        /// </summary>
        /// <param name="email">Błędny email.</param>
        /// <returns>Sformatowany ciąg <see cref="InvalidEmail"/>.</returns>
        public static string FormatInvalidEmail(string email) => string.Format(InvalidEmail, email);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="DuplicateUserName"/>.
        /// </summary>
        /// <param name="userName">Zduplikowana nazwa użytkownika.</param>
        /// <returns>Sformatowany ciąg <see cref="DuplicateUserName"/>.</returns>
        public static string FormatDuplicateUserName(string userName) => string.Format(DuplicateUserName, userName);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="DuplicateEmail"/>.
        /// </summary>
        /// <param name="email">Zdplikowany email.</param>
        /// <returns>Sformatowany ciąg <see cref="DuplicateEmail"/>.</returns>
        public static string FormatDuplicateEmail(string email) => string.Format(DuplicateEmail, email);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="InvalidRoleName"/>.
        /// </summary>
        /// <param name="roleName">Błędna nazwa roli.</param>
        /// <returns>Sformatowany ciąg <see cref="InvalidRoleName"/>.</returns>
        public static string FormatInvalidRoleName(string roleName) => string.Format(InvalidRoleName, roleName);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="DuplicateRoleName"/>.
        /// </summary>
        /// <param name="roleName">Nazwa zduplikowanej roli.</param>
        /// <returns>Sformatowany ciąg <see cref="DuplicateRoleName"/>.</returns>
        public static string FormatDuplicateRoleName(string roleName) => string.Format(DuplicateRoleName, roleName);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="UserAlreadyInRole"/>.
        /// </summary>
        /// <param name="roleName">Nazwa istniejącej roli.</param>
        /// <returns>Sformatowany ciąg <see cref="UserAlreadyInRole"/>.</returns>
        public static string FormatUserAlreadyInRole(string roleName) => string.Format(UserAlreadyInRole, roleName);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="UserNotInRole"/>.
        /// </summary>
        /// <param name="roleName">Nazwa roli.</param>
        /// <returns>Sformatowany ciąg <see cref="UserNotInRole"/>.</returns>
        public static string FormatUserNotInRole(string roleName) => string.Format(UserNotInRole, roleName);
        
        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="PasswordTooShort"/>.
        /// </summary>
        /// <param name="length">Minimalna długość hasła.</param>
        /// <returns>Sformatowany ciąg <see cref="PasswordTooShort"/>.</returns>
        public static string FormatPasswordTooShort(int length) => string.Format(PasswordTooShort, length);

        /// <summary>
        /// Zwraca sformatowany ciąg <see cref="PasswordRequiresUniqueChars"/>.
        /// </summary>
        /// <param name="uniqueChars">Wymagana liczba róznych znaków.</param>
        /// <returns>Sformatowany ciąg <see cref="PasswordRequiresUniqueChars"/>.</returns>
        public static string FormatPasswordRequiresUniqueChars(int uniqueChars) => string.Format(PasswordRequiresUniqueChars, uniqueChars);
    }
}
