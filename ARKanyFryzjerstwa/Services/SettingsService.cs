using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Errors;
using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Models.Colors;
using ARKanyFryzjerstwa.Resources;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserDao _userDao;
        private readonly ISalonDao _salonDao;

        public SettingsService(IdentityContext identityContext, UserManager<User> userManager, int? currentSalonId)
        {
            _userManager = userManager;
            _userDao = new UserDao(identityContext, currentSalonId);
            _salonDao = new SalonDao(identityContext, currentSalonId);
        }
        public SettingsService(UserManager<User> userManager, IUserDao userDao, ISalonDao salonDao)
        {
            _userManager = userManager;
            _userDao = userDao;
            _salonDao = salonDao;
        }

        /// <summary>
        /// Zwraca listę pracowników dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="EmployeeModel"/> z danymi o pracownikach.</returns>
        public List<EmployeeModel> GetEmployees(int salonId)
        {
            var salonEmployees = _userDao.GetEmployeesBySalonId(salonId);
            var emoloyees = salonEmployees.Select(x => ConvertToEmployeeModel(x)).OrderBy(x => x.LastName + x.FirstName).ToList();
            return emoloyees;
        }

        /// <summary>
        /// Dodaje nowego pracownika.
        /// </summary>
        /// <param name="model"> Dane pracownika do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <param name="url">Obiekt <see cref="IUrlHelper"/> służący do wygenerowania adresu URL.</param>
        /// <returns> Obiekt <see cref="EmployeeModel"/> z danymi o utworzonym pracowniku.</returns>
        /// <exception cref="ARKanyIdentityException">Nieznany błąd.</exception>
        public async Task<EmployeeModel> AddNewEmployee(EmployeeToAddModel model, int salonId, IUrlHelper url)
        {
            var employee = new User()
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                SalonId = salonId,
                Color = GenerateEmployeeColor(salonId),
                UserName = GenerateEmployeeUserName(model)
            };
            var password = Generator.GeneratePassword();

            var createResult = await _userManager.CreateAsync(employee, password);
            if(!createResult.Succeeded)
            {
                string errorMsg = createResult.Errors.Any() ? createResult.Errors.First().Description : ARKanyResources.UnknowErrorMsg;
                throw new ARKanyIdentityException(errorMsg);
            }

            _userDao.SetModificationDateTimeToNow();
            var appUrl = url.ActionLink("Index", "Home");
            var resetPswdUrl = url.ActionLink("PasswordReset", "Account");
            MailService.SendCreationEmployeeAccountMailBody(employee, appUrl, resetPswdUrl);

            var result = ConvertToEmployeeModel(employee);
            return result;
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="User"/> na obiekt <see cref="EmployeeModel"/>.
        /// </summary>
        /// <param name="employee"> Obiekt do przekonwertowania.</param>
        /// <returns> Obiekt <see cref="EmployeeModel"/> z danymi o użytkowniku.</returns>
        private static EmployeeModel ConvertToEmployeeModel(User employee)
        {
            return new EmployeeModel()
            {
                Id = employee.Id,
                UserName = employee.UserName,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Color = employee.Color
            };
        }

        /// <summary>
        /// Generuje nazwę użytkownika dla podanego pracownika.
        /// </summary>
        /// <param name="model"> Dane pracownika.</param>
        /// <returns> Ciąg znaków będący wygenerowaną nazwą użytkownika.</returns>
        private string GenerateEmployeeUserName(EmployeeToAddModel model)
        {
            var name = model.FirstName.Length < 3 ? model.FirstName : model.FirstName[..3];
            var initUserName = $"{model.LastName}.{name}".NormalizeUserName();
            var userName = initUserName;
            var existingUserNames = _userDao.GetUserNamesStartsWith(userName);
            if (existingUserNames == null || !existingUserNames.Any())
            {
                return userName;
            }

            int index = 0;
            string newUserName;
            do
            {
                newUserName = $"{userName}{index}";
                index++;
            } while (existingUserNames.Contains(newUserName));
            return newUserName;
        }

        /// <summary>
        /// Generuje kolor pracownika.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Ciąg znaków będący wygenerowanym kolorem pracownika.</returns>
        private string GenerateEmployeeColor(int salonId)
        {
            var employeesColors = _salonDao.GetEmployeesColorsForSalon(salonId);
            var listOfHue = employeesColors.Select(c => new RgbColor(c).ToHsvColor().Hue).Distinct().ToList();
            listOfHue.Sort();
            var listOfDiff = new List<double>();
            for (int i = 0; i < listOfHue.Count - 1; i ++)
            {
                var diff = listOfHue[i + 1] - listOfHue[i];
                listOfDiff.Add(diff);
            }
            var lastDiff = 360 + listOfHue[0] - listOfHue[listOfHue.Count - 1];
            listOfDiff.Add(lastDiff);
            var maxDiff = listOfDiff.Max();
            var maxDiffIndex = listOfDiff.IndexOf(maxDiff);
            var hue = (maxDiff / 2) + listOfHue[maxDiffIndex];

            return new HsvColor(hue, 0.4, 0.75).ToHexColor(); 
        }

        /// <summary>
        /// Aktualizuje kolor pracownika.
        /// </summary>
        /// <param name="color"> Kolor do zapisania.</param>
        /// <param name="employeeId">Unikalny Id pracownika.</param>
        public void SaveEmployeeColor(string color, string employeeId)
        {
            _userDao.UpdateEmployeeColor(employeeId, color);
        }
    }
}
