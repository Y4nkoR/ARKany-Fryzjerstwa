using ARKanyFryzjerstwa.Models;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IAccountService
    {
        /// <summary>
        /// Tworzy i dodaje do bazy danych salon oraz właściciela.
        /// </summary>
        /// <param name="model"> Obiekt <see cref="RegisterSalonModel"/> z danymi salonu oraz właściciela.</param>
        /// <returns>True, jeśli pomyślnie utworzono salon. W przeciwnym wypadku - false.</returns>
        Task<bool> RegisterSalon(RegisterSalonModel model);
        /// <summary>
        /// Resetuje hasło użytkownika.
        /// </summary>
        /// <param name="model"> Obiekt <see cref="PasswordResetModel"/> z danymi do zresetowania hasła.</param>
        /// <returns> True, jeśli pomyślnie zmieniono hasło. 
        /// W przypadku niepowodzenia, do modelu dodany zostaje <see cref="IdentityError"/> z informacją o błędzie oraz zwrócona zostaje wartość false.</returns>
        bool PasswordReset(PasswordResetModel model);
        /// <summary>
        /// Wysyła maila z kodem weryfikacyjnym oraz instrukcją zmiany hasła.
        /// </summary>
        /// <param name="login"> Login użytkownika resetującego hasło.</param>
        /// <param name="url"> Obiekt <see cref="IUrlHelper"/> służący do wygenerowania adresu URL.</param>
        /// <returns> Obiekt <see cref="NotificationModel"/> z danymi powiadomienia.</returns>
        NotificationModel SendPasswordResetVerificationCode(string? login, IUrlHelper url);
        /// <summary>
        /// Zwraca nazwę użytkownika na podstawie podanego loginu (nazwy użytkownika lub emailu).
        /// </summary>
        /// <param name="login"> Nazwa użytkownika lub email.</param>
        /// <returns> Ciąg znaków będący nazwą użytkownika. </returns>
        string? GetUsernameByLogin(string input);
        /// <summary>
        /// Zwraca notatkę dla podanego pracownika.
        /// </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <returns> Tekst notatki. </returns>
        string GetUserNote(string employeeId);
        /// <summary>
        /// Zapisuje notatkę dla podanego pracownika.
        /// </summary>
        /// <param name="note"> Tekst notatki. </param>
        /// <param name="employeeId"> Uniklany Id pracownika.</param>
        /// <exception cref="ArgumentOutOfRangeException"> Notatka przekracza dozwoloną ilość znaków.</exception>
        void SaveUserNote(string note, string employeeId);
    }
}
