using ARKanyFryzjerstwa.Data;

namespace ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects
{
    public interface IClientDao : IBaseDaoGetters
    {
        /// <summary> Pobiera dane o kliencie na podstawie podanego Id.</summary>
        /// <param name="clientId"> Unikalny numer id klienta. </param>
        /// <returns> Obiekt <see cref="Client"/> zawierający informacje o kliencie. Jeśli klient o podanych Id nie istnieje, zwrócony zostaje null. </returns>
        Client? GetClientById(int clientId);
        /// <summary> Pobiera dane wszystkich klientach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer id salonu. </param>
        /// <returns> Lista obiektów <see cref="Client"/> zawierających informacje o klientach. </returns>
        IList<Client> GetClientsForSalon(int salonId);
        /// <summary> Dodaje klienta do bazy danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie. </param>
        /// <returns> Unikalny numer id klienta. </returns>
        int AddClient(Client client);
        /// <summary> Aktualizuje dane klienta w bazie danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o dodawanym kliencie. </param>
        void UpdateClient(Client client);
        /// <summary> Usuwa klienta z bazy danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie do usunięcia. </param>
        void RemoveClient(Client client);
        /// <summary> Usuwa klientów z bazy danych.</summary>
        /// <param name="clientsToRemove"> Lista obiektów <see cref="Client"/> zawierających informacje o klientach do usunięcia. </param>
        public void RemoveClients(List<Client> clientsToRemove);
        /// <summary> Sprawdza, czy klient o podanych danych istnieje już w bazie danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie. </param>
        /// <returns> True, jeśli klient o podanych danych istnieje już w bazie danych. W przeciwnym wypadku zwraca false. </returns>
        public bool IsClientDuplicate(Client client);        
    }
}
