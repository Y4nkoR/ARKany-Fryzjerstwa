using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services.IServices;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace ARKanyFryzjerstwa.Services
{
    public class ClientsService : IClientsService
    {
        private readonly IClientDao _clientDao;
        private readonly IAppointmentDao _appointmentDao;

        public ClientsService(IdentityContext identityContext, int? currentSalonId)
        {
            _clientDao = new ClientDao(identityContext, currentSalonId);
            _appointmentDao = new AppointmentDao(identityContext, currentSalonId);

        }
        public ClientsService(IClientDao clientDao, IAppointmentDao appointmentDao)
        {
            _clientDao = clientDao;
            _appointmentDao = appointmentDao;
        }

        /// <summary>
        /// Zwraca klientów dla danego salonu.
        /// </summary>
        /// <param name="salonId"> Unikalny numer Id salonu.</param>
        /// <returns> Obiekt <see cref="ClientsModel"/> z danymi klientów.</returns>
        public ClientsModel GetClientsModel(int salonId)
        {
            var salonClients = _clientDao.GetClientsForSalon(salonId).Select(s => ConvertClient(s)).ToList();

            var model = new ClientsModel
            {
                Clients = salonClients
            };

            return model;
        }

        /// <summary>
        /// Tworzy nowego klienta.
        /// </summary>
        /// <param name="client"> Dane klienta do utworzenia. </param>
        /// <returns> Unikalny numer Id nowo utworzonego klienta.</returns>
        /// <exception cref="ArgumentException"> Dane klienta są niepoprawne.</exception>
        public int CreateClient(Client client)
        {
            var clientModel = ConvertClient(client);
            if (!ValidateClientModel(clientModel))
            {
                throw new ArgumentException("Client data is not valid.");
            }
            var clientId = _clientDao.AddClient(client);
            return clientId;
        }

        /// <summary>
        /// Usuwa klienta.
        /// </summary>
        /// <param name="clientId"> Unikalny numer Id klienta do usunięcia.</param>
        public void RemoveClient(int clientId)
        {
            var clientAppointments = _appointmentDao.GetAppointmentsByClientId(clientId);
            foreach(var appointment in clientAppointments){
                appointment.ClientId = null;
            }
            _appointmentDao.UpdateAppointments(clientAppointments);
            var clientToDelete = new Client
            {
                Id = clientId
            };
            _clientDao.RemoveClient(clientToDelete);

        }

        /// <summary>
        /// Usuwa klientów.
        /// </summary>
        /// <param name="clientIds"> Lista unikalnym numerów Id klientów do usunięcia.</param>
        public void RemoveClients(List<int> clientIds)
        {
            var clientsToRemove = new List<Client>();

            foreach (var clientId in clientIds)
            {
                var clientAppointments = _appointmentDao.GetAppointmentsByClientId(clientId);
                foreach (var appointment in clientAppointments)
                {
                    appointment.ClientId = null;
                }
                _appointmentDao.UpdateAppointments(clientAppointments);

                var clientToRemove = new Client
                {
                    Id = clientId
                };
                clientsToRemove.Add(clientToRemove);
            }

            _clientDao.RemoveClients(clientsToRemove);
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="Client"/> na obiekt <see cref="ClientModel"/>.
        /// </summary>
        /// <param name="client"> Obiekt z danymi klienta do przekonwertowania.</param>
        /// <returns> Obiekt <see cref="ClientModel"/> z danymi o kliencie.</returns>
        public ClientModel ConvertClient(Client client)
        {
            var result = new ClientModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber
            };
            return result;
        }

        /// <summary>
        /// Aktualizuje informacje o kliencie.
        /// </summary>
        /// <param name="client"> Dane klienta do zaktualizowania. </param>
        /// <returns> Obiekt <see cref="ClientModel"/> z zaktualizowanymi danymi o kliencie.</returns>
        /// <exception cref="ArgumentException"> Dane klienta są niepoprawne.</exception>
        public ClientModel UpdateClient(ClientModel client)
        {
            if (!ValidateClientModel(client))
            {
                throw new ArgumentException("Client data is not valid.");
            }
            var clientToUpdate = ConvertClientModel(client);
            _clientDao.UpdateClient(clientToUpdate);
            var result = ConvertClient(clientToUpdate);
            return result;
        }

        /// <summary>
        /// Sprawdza, czy klient o podanych danych już istnieje.
        /// </summary>
        /// <param name="clientModel"> Dane klienta do sprawdzenia.</param>
        /// <returns> True, jeśli klient o podanych danych już istnieje. W przeciwnym wypadku - false.</returns>
        public bool IsClientDuplicate(ClientModel clientModel)
        {
            var client = ConvertClientModel(clientModel);
            var result = _clientDao.IsClientDuplicate(client);
            return result;
        }

        /// <summary>
        /// Sprawdza, czy podany email jest poprawny.
        /// </summary>
        /// <param name="email"> Email do sprawdzenia.</param>
        /// <returns>True, jeśli podany email jest poprawny. W przeciwnym wypadku - false.</returns>
        private bool EmailValidation(string email)
        {
            try
            {
                MailAddress emailAdress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        /// <summary>
        /// Konwertuje obiekt <see cref="ClientModel"/> na obiekt <see cref="Client"/>.
        /// </summary>
        /// <param name="client"> Obiekt z danymi o kliencie do przekonwertowania.</param>
        /// <returns> Obiekt <see cref="Client"/> z danymi klienta.</returns>
        private Client ConvertClientModel(ClientModel client)
        {
            var result = new Client
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber
            };
            return result;
        }

        /// <summary>
        /// Sprawdza, czy podane dane klienta są poprawne.
        /// </summary>
        /// <param name="client"> Dane klienta do sprawdzenia.</param>
        /// <returns> True, jeśli dane są poprawne. W przeciwnym wypadku - false.</returns>
        private bool ValidateClientModel(ClientModel client)
        {
            const string phoneNumberPattern = @"^[0-9]{9}$|^[0-9]{11}$";
            if (client.PhoneNumber != null || client.Email != null)
            {
                bool phoneValidation = true;
                bool emailValidation = true;

                if (client.PhoneNumber != null)
                {
                    phoneValidation = Regex.IsMatch(client.PhoneNumber, phoneNumberPattern);
                }
                
                if (client.Email != null)
                {
                    emailValidation = EmailValidation(client.Email);
                }
                
                return (client != null) &&
                    (client.FirstName != null) &&
                    (client.LastName != null) &&
                    phoneValidation &&
                    emailValidation;
            }
            else
            {
                return false;
            }
        }
    }
}
