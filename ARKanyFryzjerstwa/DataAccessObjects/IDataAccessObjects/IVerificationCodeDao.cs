using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IVerificationCodeDao
    {
        /// <summary>
        /// Dodaje do bazy danych nowy kod dla użytkownika.
        /// </summary>
        /// <param name="code">Wygenerowany kod</param>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <returns>Obiekt z informacjami na temat dodanego kodu</returns>
        VerificationCode AddVerificationCode(string code, string userId);
        /// <summary>
        /// Pobiera ostatni istniejący kod weryfikacyjny użytkownika
        /// </summary>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <returns>Obiekt z informacjami na temat ostatniego istniejącego kodu użytkownika</returns>
        VerificationCode? GetLastUserVerificationCode(string userId);
        /// <summary>
        /// Aktualizuje informacje o kodzie w bazie danych
        /// </summary>
        /// <param name="verificationCode">Zaaktualizowany kod weryfikacyjny</param>
        void Update(VerificationCode verificationCode);
    }
}
