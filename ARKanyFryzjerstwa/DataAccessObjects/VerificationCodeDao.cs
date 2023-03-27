using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class VerificationCodeDao : BaseDao, IVerificationCodeDao
    {
        public VerificationCodeDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.VerificationCodes, currentSalonId) { }

        /// <summary>
        /// Dodaje do bazy danych nowy kod dla użytkownika.
        /// </summary>
        /// <param name="code">Wygenerowany kod</param>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <returns>Obiekt z informacjami na temat dodanego kodu</returns>
        public VerificationCode AddVerificationCode(string code, string userId)
        {
            var verificationCode = new VerificationCode()
            {
                Code = code,
                InsertDateTime = DateTime.Now,
                UserId = userId
            };

            _identityContext.VerificationCodes.Add(verificationCode);
            _identityContext.SaveChanges();

            return verificationCode;
        }

        /// <summary>
        /// Pobiera ostatni istniejący kod weryfikacyjny użytkownika
        /// </summary>
        /// <param name="userId">Identyfikator użytkownika</param>
        /// <returns>Obiekt z informacjami na temat ostatniego istniejącego kodu użytkownika</returns>
        public VerificationCode? GetLastUserVerificationCode(string userId)
        {
            return _identityContext.VerificationCodes.Where(x => x.UserId == userId).OrderByDescending(x => x.InsertDateTime).FirstOrDefault();
        }

        /// <summary>
        /// Aktualizuje informacje o kodzie w bazie danych
        /// </summary>
        /// <param name="verificationCode">Zaaktualizowany kod weryfikacyjny</param>
        public void Update(VerificationCode verificationCode)
        {
            _identityContext.VerificationCodes.Update(verificationCode);
            _identityContext.SaveChanges();
        }
    }
}
