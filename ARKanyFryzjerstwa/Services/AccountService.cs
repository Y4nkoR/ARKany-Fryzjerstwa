using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Resources;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Services
{
    public class AccountService : IAccountService
    {
        private const int VERIFICATION_CODE_VALIDITY_TIME = 1;

        private readonly IdentityContext _identityContext;
        private readonly UserManager<User> _userManager;
        private readonly ISalonDao _salonDao;
        private readonly IVerificationCodeDao _verificationCodeDao;
        private readonly IUserDao _userDao;

        public AccountService(IdentityContext identityContext, UserManager<User> userManager, int? currentSalonId)
        {
            _salonDao = new SalonDao(identityContext, currentSalonId);
            _verificationCodeDao = new VerificationCodeDao(identityContext, currentSalonId);
            _userDao = new UserDao(identityContext, currentSalonId);
            _identityContext = identityContext;
            _userManager = userManager;
        }
        public AccountService(IdentityContext identityContext, UserManager<User> userManager, ISalonDao salonDao, IVerificationCodeDao verificationCodeDao, IUserDao userDao) 
        {
            _identityContext = identityContext;
            _userManager = userManager;
            _salonDao = salonDao;
            _verificationCodeDao = verificationCodeDao;
            _userDao = userDao;
        }

        /// <summary>
        /// Tworzy i dodaje do bazy danych salon oraz właściciela.
        /// </summary>
        /// <param name="model"> Obiekt <see cref="RegisterSalonModel"/> z danymi salonu oraz właściciela.</param>
        /// <returns>True, jeśli pomyślnie utworzono salon. W przeciwnym wypadku - false.</returns>
        public async Task<bool> RegisterSalon(RegisterSalonModel model)
        {
            var salon = new Salon()
            {
                Name = model.SalonName,
                PhoneNumber = model.SalonPhoneNumber
            };
            var user = new User()
            {
                UserName = model.UserName.ToLower(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Color = "#72bfb1"
            };

            using (var transaction = _identityContext.Database.BeginTransaction())
            {
                try
                {
                    _salonDao.InsertSalon(salon);
                    user.SalonId = salon.Id;
                    var result = await _userManager.CreateAsync(user, model.Password);

                    if (!result.Succeeded)
                    {
                        model.IdentityErrors.AddRange(result.Errors);
                        throw new Exception();
                    }

                    var roleResult = await _userManager.AddToRoleAsync(user, RolesFactory.GetName(Role.SalonOwner));

                    if (!roleResult.Succeeded)
                    {
                        model.IdentityErrors.AddRange(roleResult.Errors);
                        throw new Exception();
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }

        }

        /// <summary>
        /// Resetuje hasło użytkownika.
        /// </summary>
        /// <param name="model"> Obiekt <see cref="PasswordResetModel"/> z danymi do zresetowania hasła.</param>
        /// <returns> True, jeśli pomyślnie zmieniono hasło. 
        /// W przypadku niepowodzenia, do modelu dodany zostaje <see cref="IdentityError"/> z informacją o błędzie oraz zwrócona zostaje wartość false.</returns>
        public bool PasswordReset(PasswordResetModel model)
        {
            model.RequestDateTime = DateTime.Now;
            var user = GetUserByLogin(model.Login);
            if (user == null)
            {
                model.IdentityErrors.Add(new IdentityError() { Description = ARKanyResources.UserNotFoundErrorMsg });
                return false;
            }

            if(!ValidatePasswordResetVerificationCode(user.Id, model.VerificationCode, model.RequestDateTime))
            {
                model.IdentityErrors.Add(new IdentityError() { Description = ARKanyResources.InvalidVerificationCodeErrorDescription });
                return false;
            }

            var token = _userManager.GeneratePasswordResetTokenAsync(user).Result;
            var result = _userManager.ResetPasswordAsync(user, token, model.NewPassword).Result;
            if(!result.Succeeded)
            {
                model.IdentityErrors.AddRange(result.Errors);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Wysyła maila z kodem weryfikacyjnym oraz instrukcją zmiany hasła.
        /// </summary>
        /// <param name="login"> Login użytkownika resetującego hasło.</param>
        /// <param name="url"> Obiekt <see cref="IUrlHelper"/> służący do wygenerowania adresu URL.</param>
        /// <returns> Obiekt <see cref="NotificationModel"/> z danymi powiadomienia.</returns>
        public NotificationModel SendPasswordResetVerificationCode(string? login, IUrlHelper url)
        {
            var user = GetUserByLogin(login);
            if (user == null)
            {
                return new NotificationModel(ARKanyResources.UserNotFoundErrorMsg, NotificationType.Error);
            }
            var code = Generator.GenerateVerificationCode();
            var verificationCode = _verificationCodeDao.AddVerificationCode(code, user.Id);
            var link = url.ActionLink("PasswordReset", "Account");
            MailService.SendResetPasswordVerificationCodeMail(user, code, verificationCode.InsertDateTime.AddHours(VERIFICATION_CODE_VALIDITY_TIME), link);
            return new NotificationModel(ARKanyResources.VerificationCodeSendedMsg, NotificationType.Success);
        }

        /// <summary>
        /// Zwraca nazwę użytkownika na podstawie podanego loginu (nazwy użytkownika lub emailu).
        /// </summary>
        /// <param name="login"> Nazwa użytkownika lub email.</param>
        /// <returns> Ciąg znaków będący nazwą użytkownika. </returns>
        public string? GetUsernameByLogin(string login)
        {
            var tempLogin = login.Trim();
            var userName = tempLogin.Contains('@') ? ((User?) _userManager.FindByEmailAsync(tempLogin).Result)?.UserName : tempLogin;
            return userName;
        }

        /// <summary>
        /// Zwraca notatkę dla podanego pracownika.
        /// </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <returns> Tekst notatki. </returns>
        public string GetUserNote(string employeeId)
        {
            return _userDao.GetUserNote(employeeId);
        }

        /// <summary>
        /// Zapisuje notatkę dla podanego pracownika.
        /// </summary>
        /// <param name="note"> Tekst notatki. </param>
        /// <param name="employeeId"> Uniklany Id pracownika.</param>
        /// <exception cref="ArgumentOutOfRangeException"> Notatka przekracza dozwoloną ilość znaków.</exception>
        public void SaveUserNote(string note, string employeeId)
        {
            const int maxNoteLength = 4000;
            if(note != null && note.Length > maxNoteLength)
            {
                throw new ArgumentOutOfRangeException(nameof(note), $"Max note length is {maxNoteLength}.");
            }
            _userDao.SaveUserNote(note, employeeId);
        }

        /// <summary>
        /// Zwraca użytkownika na podstawie loginu (nazwy użytkownika lub emailu).
        /// </summary>
        /// <param name="login"> Nazwa użytkownika lub email. </param>
        /// <returns> Obiekt <see cref="User"/> z danymi o użytkowniku lub wartość null, jeśli użytkownik o podanym loginie nie istnieje.</returns>
        private User? GetUserByLogin(string? login)
        {
            if (login == null)
            {
                return null;
            }

            var tempLogin = login.Trim();
            var user = tempLogin.Contains('@') ? (User?)_userManager.FindByEmailAsync(tempLogin).Result : (User?)_userManager.FindByNameAsync(tempLogin).Result;
            return user;
        }

        /// <summary>
        /// Sprawdza, czy podany kod weryfikacyjny jest poprawny.
        /// </summary>
        /// <param name="userId"> Unikalny Id użytkownika.</param>
        /// <param name="code"> Kod weryfikacyjny.</param>
        /// <param name="requestDateTime"> Data i czas żądania zmiany hasła. </param>
        /// <returns> True, jeśli kod jest poprawny. W przeciwnym wypadku - false.</returns>
        private bool ValidatePasswordResetVerificationCode(string userId, string code, DateTime requestDateTime)
        {
            var lastCode = _verificationCodeDao.GetLastUserVerificationCode(userId);
            if (lastCode == null || lastCode.IsUsed || requestDateTime > lastCode.InsertDateTime.AddHours(VERIFICATION_CODE_VALIDITY_TIME) || code != lastCode.Code)
            {
                return false;
            }
            lastCode.IsUsed = true;
            _verificationCodeDao.Update(lastCode);
            return true;
        }
    }
}
