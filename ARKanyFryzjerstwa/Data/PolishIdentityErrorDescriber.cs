using ARKanyFryzjerstwa.Resources;
using Microsoft.AspNetCore.Identity;

namespace ARKanyFryzjerstwa.Data
{
    /// <summary>
    /// Klasa umożliwiająca zwracania polskich opisów błędów dla <see cref="IdentityError"/>.
    /// </summary>
    public class PolishIdentityErrorDescriber : IdentityErrorDescriber
    {
        #region OtherErrors
        /// <summary>
        /// Zwraca domyślny <see cref="IdentityError"/>.
        /// </summary>
        /// <returns>Domyślny <see cref="IdentityError"/>.</returns>
        public override IdentityError DefaultError()
        {
            return new IdentityError
            {
                Code = nameof(DefaultError),
                Description = IdentityErrorResources.DefaultError
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący na błąd współbieżności.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący na błąd współbieżności.</returns>
        public override IdentityError ConcurrencyFailure()
        {
            return new IdentityError
            {
                Code = nameof(ConcurrencyFailure),
                Description = IdentityErrorResources.ConcurrencyFailure
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący na błędny token.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący na błędny token.</returns>
        public override IdentityError InvalidToken()
        {
            return new IdentityError
            {
                Code = nameof(InvalidToken),
                Description = IdentityErrorResources.InvalidToken
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że kod odzyskiwania nie został zrealizowany.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że kod odzyskiwania nie został zrealizowany.</returns>
        public override IdentityError RecoveryCodeRedemptionFailed()
        {
            return new IdentityError
            {
                Code = nameof(RecoveryCodeRedemptionFailed),
                Description = IdentityErrorResources.RecoveryCodeRedemptionFailed
            };
        }
        #endregion

        #region User
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że określony <paramref name="userName"/> jest niepoprawny.
        /// </summary>
        /// <param name="userName">Nazwa użytkownika, która jest niepoprawna.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że określony <paramref name="userName"/> jest niepoprawny.</returns>
        public override IdentityError InvalidUserName(string userName)
        {
            return new IdentityError
            {
                Code = nameof(InvalidUserName),
                Description = IdentityErrorResources.FormatInvalidUserName(userName)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że określony <paramref name="email"/> jest niepoprawny.
        /// </summary>
        /// <param name="email">Email , który jest niepoprawny.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że określony <paramref name="email"/> jest niepoprawny.</returns>
        public override IdentityError InvalidEmail(string email)
        {
            return new IdentityError()
            {
                Code = nameof(InvalidEmail),
                Description = IdentityErrorResources.FormatInvalidEmail(email)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, żę określony <paramref name="userName"/> już istnieje.
        /// </summary>
        /// <param name="userName">Nazwa użytkownika, która już istnieje.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, żę określony <paramref name="userName"/> już istnieje.</returns>
        public override IdentityError DuplicateUserName(string userName)
        {
            return new IdentityError()
            {
                Code = nameof(DuplicateUserName),
                Description = IdentityErrorResources.FormatDuplicateUserName(userName)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że określony <paramref name="email"/> jest już powiązany z kontem.
        /// </summary>
        /// <param name="email">Email, który jet już powiązany z kontem.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że określony <paramref name="email"/> jest już powiązany z kontem.</returns>
        public override IdentityError DuplicateEmail(string email)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateEmail),
                Description = IdentityErrorResources.FormatDuplicateEmail(email)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że blokada użytkownika jest niedostępna.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że blokada użytkownika jest niedostępna.</returns>
        public override IdentityError UserLockoutNotEnabled()
        {
            return new IdentityError
            {
                Code = nameof(UserLockoutNotEnabled),
                Description = IdentityErrorResources.UserLockoutNotEnabled
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że użytkownik ma już ustawione hasło.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że użytkownik ma już ustawione hasło.</returns>
        public override IdentityError UserAlreadyHasPassword()
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyHasPassword),
                Description = IdentityErrorResources.UserAlreadyHasPassword
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie pasuje.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie pasuje.</returns>
        public override IdentityError PasswordMismatch()
        {
            return new IdentityError
            {
                Code = nameof(PasswordMismatch),
                Description = IdentityErrorResources.PasswordMismatch
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że zewnętrzny login jest już powiązany z kontem.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że zewnętrzny login jest już powiązany z kontem.</returns>
        public override IdentityError LoginAlreadyAssociated()
        {
            return new IdentityError
            {
                Code = nameof(LoginAlreadyAssociated),
                Description = IdentityErrorResources.LoginAlreadyAssociated
            };
        }
        #endregion

        #region Role
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że określona nazwa <paramref name="role"/> jest nieprawidłowa.
        /// </summary>
        /// <param name="role">Nieprawidłowa rola..</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że określona nazwa <paramref name="role"/> jest nieprawidłowa.</returns>
        public override IdentityError InvalidRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(InvalidRoleName),
                Description = IdentityErrorResources.FormatInvalidRoleName(role)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że określona nazwa <paramref name="role"/> juz istnieje.
        /// </summary>
        /// <param name="role">Zduplikowana rola.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że określona nazwa <paramref name="role"/> juz istnieje.</returns>
        public override IdentityError DuplicateRoleName(string role)
        {
            return new IdentityError
            {
                Code = nameof(DuplicateRoleName),
                Description = IdentityErrorResources.FormatDuplicateRoleName(role)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że użytkownik ma już przypisaną określoną <paramref name="role"/>.
        /// </summary>
        /// <param name="role">Zduplikowana rola.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że użytkownik ma już przypisaną określoną <paramref name="role"/>.</returns>
        public override IdentityError UserAlreadyInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserAlreadyInRole),
                Description = IdentityErrorResources.FormatUserAlreadyInRole(role)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że użytkownik nie ma przypisanej określonej <paramref name="role"/>.
        /// </summary>
        /// <param name="role">Nieprzypisana do użytkownika rola.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że użytkownik nie ma przypisanej określonej <paramref name="role"/>.</returns>
        public override IdentityError UserNotInRole(string role)
        {
            return new IdentityError
            {
                Code = nameof(UserNotInRole),
                Description = IdentityErrorResources.FormatUserNotInRole(role)
            };
        }
        #endregion

        #region Password Requirements
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogów minimalnej długości <paramref name="length"/> znaków.
        /// </summary>
        /// <param name="length">Minimalna długość hasła.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogów minimalnej długości <paramref name="length"/> znaków.</returns>
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = nameof(PasswordTooShort),
                Description = IdentityErrorResources.FormatPasswordTooShort(length)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymagania minimalnej liczby <paramref name="uniqueChars"/> różnych znaków.
        /// </summary>
        /// <param name="uniqueChars">Wymagana liczba róznych znaków.</param>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymagania minimalnej liczby <paramref name="uniqueChars"/> różnych znaków.</returns>
        public override IdentityError PasswordRequiresUniqueChars(int uniqueChars)
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresUniqueChars),
                Description = IdentityErrorResources.FormatPasswordRequiresUniqueChars(uniqueChars)
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania znaków specjalnych.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania znaków specjalnych.</returns>
        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresNonAlphanumeric),
                Description = IdentityErrorResources.PasswordRequiresNonAlphanumeric
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania cyfr.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania cyfr.</returns>
        public override IdentityError PasswordRequiresDigit()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresDigit),
                Description = IdentityErrorResources.PasswordRequiresDigit
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania małych liter.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania małych liter.</returns>
        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError
            {
                Code = nameof(PasswordRequiresLower),
                Description = IdentityErrorResources.PasswordRequiresLower
            };
        }
        /// <summary>
        /// Zwraca <see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania wielkich liter.
        /// </summary>
        /// <returns><see cref="IdentityError"/> wskazujący, że hasło nie spełnia wymogu posiadania wielkich liter.</returns>
        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = nameof(PasswordRequiresUpper),
                Description = IdentityErrorResources.PasswordRequiresUpper
            };
        }
        #endregion

    }
}
