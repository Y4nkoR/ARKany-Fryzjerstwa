using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class UserDao : BaseDao, IUserDao
    {
        public UserDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Users, currentSalonId) {  }

        /// <summary> Pobiera informacje o pracownikach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="User"/> zawierających informacje o pracownikach.</returns>
        public IList<User> GetEmployeesBySalonId(int salonId)
        {
            return _identityContext.Users.Where(u => u.SalonId == salonId).ToList();
        }

        /// <summary> Pobiera informacje o pracownikach na podstawie podanych Id.</summary>
        /// <param name="employeeIds"> Lista unikalnych Id pracowników. </param>
        /// <returns> Lista obiektów <see cref="User"/> zawierających informacje o pracownikach.</returns>
        public IList<User> GetEmployeesByEmployeeIds(IList<string> employeeIds)
        {
            return _identityContext.Users.Where(u => employeeIds.Contains(u.Id)).ToList();
        }

        /// <summary> Pobiera informacje o nazwach użytkowników zaczynających się od podanej wartości.</summary>
        /// <param name="value"> Ciąg znaków, od którch zaczynać mają się zwrócone nazwy użytkowników. </param>
        /// <returns> Lista nazw użytkowników zaczynających się od podanej wartości.</returns>
        public IList<string> GetUserNamesStartsWith(string value)
        {
            return _identityContext.Users.Select(u => u.UserName).Where(u => u.StartsWith(value)).ToList();
        }

        /// <summary> Aktualizuje kolor danego pracownika. </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <param name="color"> Kolor do przypisania. </param>
        public void UpdateEmployeeColor(string employeeId, string color)
        {
            var employee = _identityContext.Users.FirstOrDefault(x => x.Id == employeeId);
            employee.Color = color; // employee can be null - we want to get an exception
            _identityContext.Users.Update(employee);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Pobiera notatkę podanego użytkownika. </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <returns> Tekst notatki. </returns>
        public string GetUserNote(string employeeId)
        {
            return _identityContext.Notes.FirstOrDefault(x => x.EmployeeId == employeeId)?.Text ?? string.Empty;
        }

        /// <summary> Zapisuje notatkę podanego użytkownika. </summary>
        /// <param name="note"> Tekst notatki. </param>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        public void SaveUserNote(string note, string employeeId)
        {
            var userNote = _identityContext.Notes.FirstOrDefault(x => x.EmployeeId == employeeId);
            var text = note ?? string.Empty;
            if (userNote == null)
            {
                userNote = new Note() 
                { 
                    EmployeeId = employeeId, 
                    Text = text 
                };
                _identityContext.Notes.Add(userNote);
            }
            else
            {
                userNote.Text = text;
                _identityContext.Notes.Update(userNote);
            }
            _identityContext.SaveChanges();
        }
    }
}
