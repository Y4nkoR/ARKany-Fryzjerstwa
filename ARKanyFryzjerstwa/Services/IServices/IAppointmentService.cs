using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IAppointmentService
    {
        /// <summary>
        /// Zwraca dane potrzebne do utworzenia wizyty.
        /// </summary>
        /// <param name="salonId"> Uniklany numer Id salonu. </param>
        /// <returns>Obiekt <see cref="AppointmentCreationDataModel"/> z danymi potrzebnymi do utworzenia wizyty.</returns>
        AppointmentCreationDataModel GetAppointmentCreationData(int salonId);
        /// <summary>
        /// Zwraca numer telefonu i/lub email podanego klienta.
        /// </summary>
        /// <param name="clientId">Unikalny numer Id klienta.</param>
        /// <returns> Obiekt <see cref="ContactData"/> z numerem telefonu i/lub emailem klienta.</returns>
        ContactData GetPhoneAndEmail(int clientId);
        /// <summary>
        /// Tworzy nową wizytę.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane nowej wizyty.</param>
        /// <param name="authorId"> Unikalny Id pracownika dodającego nową wizytę. </param>
        /// <param name="salonId"> Unikalny numer Id salonu, w którym dodawana jest wizyta.</param>
        /// <returns>Obiekt <see cref="Appointment"/> z danymi o utworzonej wizycie.</returns>
        Appointment CreateAppointment(AppointmentAddModel appointmentAddModel, string? authorId, int salonId);
        /// <summary>
        /// Anuluje wizytę.
        /// </summary>
        /// <param name="appointmentId"> Unikalny numer Id wizyt do anulowania.</param>
        /// <exception cref="ArgumentNullException"> Wizyta z takim Id nie istnieje.</exception>
        void CancelAppointment(int appointmentId);
        /// <summary>
        /// Sprawdza, czy dodawana wizyta konfliktuje z już istniejącą dla danego pracownika.
        /// </summary>
        /// <param name="appointmentAddModel"> Dane dodawanej wizyty. </param>
        /// <returns>True, jeśli wizyta konfliktuje z już istniejącą. W przeciwnym wypadku - false.</returns>
        bool DoAppointmentsOverlap(AppointmentAddModel appointmentAddModel);
        /// <summary>
        /// Zakańcza wizytę.
        /// </summary>
        /// <param name="appointmentCompletionData"> Dane kończonej wizyty.</param>
        /// <exception cref="ArgumentNullException"> Podana wizyta nie istnieje.</exception>
        void CompleteAppointment(AppointmentCompletionDataModel appointmentCompletionData);
        /// <summary>
        /// Zwraca informacje o usłudze przypisanej do danej wizyty.
        /// </summary>
        /// <param name="appointmentId"> Unikalny numer Id wizyty.</param>
        /// <returns>Obiekt <see cref="ServiceModel"/> z danymi o usłudze.</returns>
        /// <exception cref="ArgumentNullException"> Wizyta o podanym Id nie istnieje.</exception>
        ServiceModel GetAppointmentServiceModel(int appointmentId);
    }
}
