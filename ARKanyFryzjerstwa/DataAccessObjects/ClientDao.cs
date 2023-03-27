using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;

namespace ARKanyFryzjerstwa.DataAccessObjects
{
    public class ClientDao : BaseDao, IClientDao
    {
        public ClientDao(IdentityContext identityContext, int? currentSalonId) : base(identityContext, DatabaseTable.Clients, currentSalonId) { }

        /// <summary> Pobiera dane o kliencie na podstawie podanego Id.</summary>
        /// <param name="clientId"> Unikalny numer id klienta. </param>
        /// <returns> Obiekt <see cref="Client"/> zawierający informacje o kliencie. Jeśli klient o podanych Id nie istnieje, zwrócony zostaje null. </returns>
        public Client? GetClientById(int clientId)
        {
            return _identityContext.Clients.FirstOrDefault(c => c.Id == clientId);
        }

        /// <summary> Pobiera dane wszystkich klientach dla danego salonu.</summary>
        /// <param name="salonId"> Unikalny numer id salonu. </param>
        /// <returns> Lista obiektów <see cref="Client"/> zawierających informacje o klientach. </returns>
        public IList<Client> GetClientsForSalon(int salonId)
        {
            return _identityContext.ClientSalon
                .Where(cs => cs.SalonId == salonId)
                .Join(_identityContext.Clients,
                    cs => cs.ClientId, c => c.Id,
                    (cs, c) => c)
                .ToList();
        }

        /// <summary> Dodaje klienta do bazy danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie. </param>
        /// <returns> Unikalny numer id klienta. </returns>
        public int AddClient(Client client)
        {
            _identityContext.Clients.Add(client);
            _identityContext.SaveChanges();
            AssignClientToSalon(client.Id);
            SetModificationDateTimeToNow();
            return client.Id;
        }

        /// <summary> Aktualizuje dane klienta w bazie danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o dodawanym kliencie. </param>
        public void UpdateClient(Client client)
        {
            _identityContext.Clients.Update(client);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Usuwa klientów z bazy danych.</summary>
        /// <param name="clientsToRemove"> Lista obiektów <see cref="Client"/> zawierających informacje o klientach do usunięcia. </param>
        public void RemoveClients(List<Client> clientsToRemove)
        {
            _identityContext.RemoveRange(clientsToRemove);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Sprawdza, czy klient o podanych danych istnieje już w bazie danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie. </param>
        /// <returns> True, jeśli klient o podanych danych istnieje już w bazie danych. W przeciwnym wypadku zwraca false. </returns>
        public bool IsClientDuplicate(Client client)
        {

            return _identityContext.ClientSalon
                .Where(cs => cs.SalonId == _currentSalonId.Value)
                .Join(_identityContext.Clients,
                    cs => cs.ClientId, c => c.Id,
                    (cs, c) => c)
               .Any(c => c.FirstName == client.FirstName
            && c.LastName == client.LastName && c.Id != client.Id &&
            ((!(string.IsNullOrEmpty(client.PhoneNumber)) && c.PhoneNumber == client.PhoneNumber) || (!(string.IsNullOrEmpty(client.Email)) &&  c.Email == client.Email)));
        }

        /// <summary> Usuwa klienta z bazy danych.</summary>
        /// <param name="client"> Obiekt <see cref="Client"/> zawierający informacje o kliencie do usunięcia. </param>
        public void RemoveClient(Client client)
        {
            _identityContext.Clients.Remove(client);
            _identityContext.SaveChanges();
            SetModificationDateTimeToNow();
        }

        /// <summary> Przypisuje danego klienta do aktualnego salonu.</summary>
        /// <param name="clientId"> Unikalny numer Id klienta do przypisania. </param>
        private void AssignClientToSalon(int clientId)
        {
            var clientSalon = new ClientSalon()
            {
                ClientId = clientId,
                SalonId = _currentSalonId.Value
            };
            _identityContext.ClientSalon.Add(clientSalon);
            _identityContext.SaveChanges();
        }
    }
}
