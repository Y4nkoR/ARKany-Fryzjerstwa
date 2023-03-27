using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Moq;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class ClientsServiceTests
    {
        private MyMock<IClientDao> _clientDao;
        private MyMock<IAppointmentDao> _appointmentDao;
        private IClientsService _service;

        [SetUp]
        public void Setup()
        {
            _clientDao = new MyMock<IClientDao>();
            _appointmentDao = new MyMock<IAppointmentDao>();

            _service = new ClientsService(_clientDao.Object, _appointmentDao.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _clientDao.VerifyAll();
            _appointmentDao.VerifyAll();
        }

        #region GetClientsModel
        [Test]
        public void GetClientsModelTest()
        {
            //Arrange
            const int salonId = 5;
            var salonClients = new List<Client>()
            {
                new (){ Id=6, FirstName="Adam", LastName="Michalak", PhoneNumber=null, Email="mail@test.pl"},
                new (){ Id=42, FirstName="Ewa", LastName="Nowak", PhoneNumber="123123123", Email=null }
            };
            _clientDao.Setup(x => x.GetClientsForSalon(salonId), Times.Once()).Returns(salonClients);

            //Act
            var result = _service.GetClientsModel(salonId);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Clients, Is.Not.Null);
            Assert.That(result.Clients, Is.Not.Empty);
            Assert.That(result.Clients.Count, Is.EqualTo(salonClients.Count));
            foreach(var resultClient in result.Clients)
            {
                var client = salonClients.FirstOrDefault(x => x.Id == resultClient.Id);
                Assert.That(client, Is.Not.Null);
                Assert.That(resultClient.Id, Is.EqualTo(client.Id));
                Assert.That(resultClient.FirstName, Is.EqualTo(client.FirstName));
                Assert.That(resultClient.LastName, Is.EqualTo(client.LastName));
                Assert.That(resultClient.PhoneNumber, Is.EqualTo(client.PhoneNumber));
                Assert.That(resultClient.Email, Is.EqualTo(client.Email));
            }
        }
        #endregion
        #region CreateClient

        [Test]
        public void CreateClientTest()
        {
            //Arrange
            var client = new Client()
            {
                Email = "test@test.pl",
                PhoneNumber = "890890890",
                FirstName = "Test",
                LastName = "Testowicz"
            };
            const int id = 109;
            _clientDao.Setup(x => x.AddClient(client), Times.Once()).Returns(id);

            //Act
            var result = _service.CreateClient(client);

            //Assert
            Assert.That(result, Is.EqualTo(id));
        }
        #endregion
        #region RemoveClient

        [Test]
        public void RemoveClientTest()
        {
            //Arrange
            const int id = 34;
            var appointments = new List<Appointment>()
            {
                new() { ServiceId = 1, ClientId = 1 },
                new() { ServiceId = 2, ClientId = 2 },
                new() { ServiceId = 3, ClientId = 3 },
            };
            _appointmentDao.Setup(x => x.GetAppointmentsByClientId(id), Times.Once())
                .Returns(appointments);
            _appointmentDao.Setup(x => x.UpdateAppointments( It.Is<List<Appointment>>(a => 
                a.TrueForAll(b => b.ClientId == null))), Times.Once());
            _clientDao.Setup(x => x.RemoveClient(It.Is<Client>(c => c.Id == id)), Times.Once());

            //Act
            _service.RemoveClient(id);

            //Assert - TearDown()
        }
        #endregion
        #region RemoveClients

        [Test]
        public void RemoveClientsTest()
        {
            //Arrange
            var clientsIds = new List<int>() { 1, 3};
            var appointments = new List<Appointment>();
            _appointmentDao.Setup(x => x.GetAppointmentsByClientId(clientsIds[0]), Times.Once()).Returns(appointments);
            _appointmentDao.Setup(x => x.GetAppointmentsByClientId(clientsIds[1]), Times.Once()).Returns(appointments);
            _appointmentDao.Setup(x => x.UpdateAppointments(It.Is<List<Appointment>>(list =>
                list.TrueForAll(a => a.ClientId == null))), Times.Exactly(2));
            _clientDao.Setup(x => x.RemoveClients(It.Is<List<Client>>(list =>
                list.Count == 2 && list[0].Id == clientsIds[0] && list[1].Id == clientsIds[1])), Times.Once());

            //Act
            _service.RemoveClients(clientsIds);

            //Assert -> TearDown()
        }
        #endregion
        #region ConvertClient

        [Test]
        public void ConvertClientTest()
        {
            //Arrange
            var client = new Client()
            {
                Id = 5,
                FirstName = "Test",
                LastName = "Testowicz",
                Email = "test@mail.com",
                PhoneNumber = "098098098"
            };

            //Act
            var result = _service.ConvertClient(client);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(client.Id));
            Assert.That(result.FirstName, Is.EqualTo(client.FirstName));
            Assert.That(result.LastName, Is.EqualTo(client.LastName));
            Assert.That(result.Email, Is.EqualTo(client.Email));
            Assert.That(result.PhoneNumber, Is.EqualTo(client.PhoneNumber));
        }
        #endregion
        #region UpdateClient
        [Test]
        public void UpdateClientTest()
        {
            //Arrange
            var clientModel = new ClientModel()
            {
                Email = "test@mail.org",
                FirstName = "Alan",
                LastName = "Nowak",
                Id = 5,
                PhoneNumber = "123123123"
            };
            _clientDao.Setup(x => x.UpdateClient(It.Is<Client>(c => 
                c.Id == clientModel.Id && 
                c.FirstName == clientModel.FirstName &&
                c.LastName == clientModel.LastName &&
                c.PhoneNumber == clientModel.PhoneNumber &&
                c.Email == clientModel.Email)), Times.Once());

            //Act
            var result = _service.UpdateClient(clientModel);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(clientModel.Id));
            Assert.That(result.FirstName, Is.EqualTo(clientModel.FirstName));
            Assert.That(result.LastName, Is.EqualTo(clientModel.LastName));
            Assert.That(result.Email, Is.EqualTo(clientModel.Email));
            Assert.That(result.PhoneNumber, Is.EqualTo(clientModel.PhoneNumber));
        }
        #endregion
        #region IsClientDuplicate

        [Test]
        public void IsClientDuplicateIfTrueTest()
        {
            //Arrange
            var client = new ClientModel()
            {
                FirstName = "Bob",
                LastName = "Marley",
                Email = "test@test.pl",
                PhoneNumber = "123123123"
            };
            _clientDao.Setup(x => x.IsClientDuplicate(It.Is<Client>(c =>
                c.FirstName == client.FirstName &&
                c.LastName == client.LastName &&
                c.Email == client.Email &&
                c.PhoneNumber == client.PhoneNumber &&
                c.Id == client.Id)), Times.Once()).Returns(true);

            //Act
            var result = _service.IsClientDuplicate(client);

            //Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void IsClientDuplicateIfFalseTest()
        {
            //Arrange
            var client = new ClientModel()
            {
                FirstName = "Bob",
                LastName = "Marley",
                Email = "test@test.pl",
                PhoneNumber = "123123123"
            };
            _clientDao.Setup(x => x.IsClientDuplicate(It.Is<Client>(c =>
                c.FirstName == client.FirstName &&
                c.LastName == client.LastName &&
                c.Email == client.Email &&
                c.PhoneNumber == client.PhoneNumber &&
                c.Id == client.Id)), Times.Once()).Returns(false);

            //Act
            var result = _service.IsClientDuplicate(client);

            //Assert
            Assert.That(result, Is.False);
        }
        #endregion
    }
}
