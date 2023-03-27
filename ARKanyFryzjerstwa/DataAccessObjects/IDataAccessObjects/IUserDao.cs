using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IUserDao : IBaseDaoSetters, IBaseDaoGetters
    {
        /// <summary> Pobiera informacje o pracownikach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer Id salonu. </param>
        /// <returns> Lista obiektów <see cref="User"/> zawierających informacje o pracownikach.</returns>
        IList<User> GetEmployeesBySalonId(int salonId);
        /// <summary> Pobiera informacje o pracownikach na podstawie podanych Id.</summary>
        /// <param name="employeeIds"> Lista unikalnych Id pracowników. </param>
        /// <returns> Lista obiektów <see cref="User"/> zawierających informacje o pracownikach.</returns>
        IList<User> GetEmployeesByEmployeeIds(IList<string> employeeIds);
        /// <summary> Pobiera informacje o nazwach użytkowników zaczynających się od podanej wartości.</summary>
        /// <param name="value"> Ciąg znaków, od którch zaczynać mają się zwrócone nazwy użytkowników. </param>
        /// <returns> Lista nazw użytkowników zaczynających się od podanej wartości.</returns>
        IList<string> GetUserNamesStartsWith(string value);
        /// <summary> Aktualizuje kolor danego pracownika. </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <param name="color"> Kolor do przypisania. </param>
        void UpdateEmployeeColor(string employeeId, string color);
        /// <summary> Pobiera notatkę podanego użytkownika. </summary>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        /// <returns> Tekst notatki. </returns>
        string GetUserNote(string employeeId);
        /// <summary> Zapisuje notatkę podanego użytkownika. </summary>
        /// <param name="note"> Tekst notatki. </param>
        /// <param name="employeeId"> Unikalny Id pracownika. </param>
        void SaveUserNote(string note, string employeeId);
    }
}
