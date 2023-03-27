using ARKanyFryzjerstwa.Models;
using Microsoft.AspNetCore.Mvc;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface ISettingsService
    {
        /// <summary>
        /// Zwraca listę pracowników dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Lista obiektów <see cref="EmployeeModel"/> z danymi o pracownikach.</returns>
        List<EmployeeModel> GetEmployees(int salonId);
        /// <summary>
        /// Aktualizuje kolor pracownika.
        /// </summary>
        /// <param name="color"> Kolor do zapisania.</param>
        /// <param name="employeeId">Unikalny Id pracownika.</param>
        void SaveEmployeeColor(string color, string employeeId);
        /// <summary>
        /// Dodaje nowego pracownika.
        /// </summary>
        /// <param name="model"> Dane pracownika do dodania.</param>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <param name="url">Obiekt <see cref="IUrlHelper"/> służący do wygenerowania adresu URL.</param>
        /// <returns> Obiekt <see cref="EmployeeModel"/> z danymi o utworzonym pracowniku.</returns>
        /// <exception cref="ARKanyIdentityException">Nieznany błąd.</exception>
        Task<EmployeeModel> AddNewEmployee(EmployeeToAddModel model, int salonId, IUrlHelper url);
    }
}
