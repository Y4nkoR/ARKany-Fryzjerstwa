using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Models;

namespace ARKanyFryzjerstwa.Services.IServices
{
    public interface IClientsService
    {
        /// <summary>
        /// Zwraca klientów dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ClientsModel"/> z danymi klientów.</returns>
        ClientsModel GetClientsModel(int salonId);
        /// <summary>
        /// Tworzy nowego klienta.
        /// </summary>
        /// <param name="client"> Dane klienta do utworzenia. </param>
        /// <returns> Unikalny numer Id nowo utworzonego klienta.</returns>
        /// <exception cref="ArgumentException"> Dane klienta są niepoprawne.</exception>
        int CreateClient(Client client);
        /// <summary>
        /// Aktualizuje informacje o kliencie.
        /// </summary>
        /// <param name="client"> Dane klienta do zaktualizowania. </param>
        /// <returns> Obiekt <see cref="ClientModel"/> z zaktualizowanymi danymi o kliencie.</returns>
        /// <exception cref="ArgumentException"> Dane klienta są niepoprawne.</exception>
        ClientModel UpdateClient(ClientModel client);
        /// <summary>
        /// Konwertuje obiekt <see cref="Client"/> na obiekt <see cref="ClientModel"/>.
        /// </summary>
        /// <param name="client"> Obiekt z danymi klienta do przekonwertowania.</param>
        /// <returns> Obiekt <see cref="ClientModel"/> z danymi o kliencie.</returns>
        ClientModel ConvertClient(Client client);
        /// <summary>
        /// Usuwa klienta.
        /// </summary>
        /// <param name="clientId"> Unikalny numer Id klienta do usunięcia.</param>
        void RemoveClient(int clientId);
        /// <summary>
        /// Usuwa klientów.
        /// </summary>
        /// <param name="clientIds"> Lista unikalnych numerów Id klientów do usunięcia.</param>
        void RemoveClients(List<int> clientIds);
        /// <summary>
        /// Sprawdza, czy klient o podanych danych już istnieje.
        /// </summary>
        /// <param name="clientModel"> Dane klienta do sprawdzenia.</param>
        /// <returns> True, jeśli klient o podanych danych już istnieje. W przeciwnym wypadku - false.</returns>
        bool IsClientDuplicate(ClientModel clientModel);
    }
}
