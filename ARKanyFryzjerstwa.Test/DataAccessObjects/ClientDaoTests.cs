using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class ClientDaoTests : BaseDaoTests<ClientDao>
    {
        #region GetClientById
        [Test]
        public void GetClientByIdTest()
        {
            //Arrange
            var clients = new List<Client>()
            {
                new()
                {
                    FirstName = "Bob",
                    LastName = "Nowak",
                    PhoneNumber = "123123123"
                },
                new()
                {
                    FirstName = "Alice",
                    LastName = "Wonderland",
                    Email = "alice@test.com"
                },
                new()
                {
                    FirstName = "John",
                    LastName = "Newman",
                    PhoneNumber = "234432234",
                    Email = "johny@test.com"
                }
            };
            Context.Clients.AddRange(clients);
            Context.SaveChanges();

            //Act
            var result = _dao.GetClientById(clients[1].Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(clients[1], result);
        }
        #endregion

        #region GetClientsForSalon
        [Test]
        public void GetClientsForSalonTest()
        {
            //Arrange
            var clients = new List<Client>()
            {
                new()
                {
                    FirstName = "Bob",
                    LastName = "Nowak",
                    PhoneNumber = "123123123"
                },
                new()
                {
                    FirstName = "Alice",
                    LastName = "Wonderland",
                    Email = "alice@test.com"
                },
                new()
                {
                    FirstName = "John",
                    LastName = "Newman",
                    PhoneNumber = "234432234",
                    Email = "johny@test.com"
                },
                new()
                {
                    FirstName = "Alan",
                    LastName = "Lander",
                    PhoneNumber = "984651324",
                    Email = "alan@tests.com"
                }
            };
            Context.Clients.AddRange(clients);
            Context.SaveChanges();

            var salonsIds = Context.Salons.Take(2).Select(s => s.Id).ToList();
            Assert.That(salonsIds, Is.Not.Null);
            Assert.That(salonsIds, Has.Count.EqualTo(2));
            var clientsSalons = new List<ClientSalon>()
            {
                new() { ClientId = clients[0].Id, SalonId = salonsIds[0] },
                new() { ClientId = clients[1].Id, SalonId = salonsIds[1] },
                new() { ClientId = clients[2].Id, SalonId = salonsIds[1] },
                new() { ClientId = clients[3].Id, SalonId = salonsIds[0] },
            };
            Context.ClientSalon.AddRange(clientsSalons);
            Context.SaveChanges();
            var expected = clients.GetRange(1, 2);

            //Act
            var result = _dao.GetClientsForSalon(salonsIds[1]);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(2));
            foreach (var expectedClient in expected)
            {
                var resultClient = result.FirstOrDefault(x => x.Id == expectedClient.Id);
                Assert.That(resultClient, Is.Not.Null);
                AssertAreEqual(expectedClient, resultClient);
            }
        }
        #endregion

        #region AddClient
        [Test]
        public void AddClientTest()
        {
            //Arrange
            var clientToAdd = new Client()
            {
                FirstName = "TestName",
                LastName = "TestLastName",
                PhoneNumber = "098098098",
                Email = "test@test.com"
            };

            //Act
            _dao.AddClient(clientToAdd);

            //Assert
            var result = Context.Clients.FirstOrDefault(x => x.Id == clientToAdd.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(clientToAdd, result);
        }
        #endregion

        #region UpdateClient
        [Test]
        public void UpdateClientTest()
        {
            //Arrange
            var clientToUpdate = Context.Clients.FirstOrDefault();
            Assert.That(clientToUpdate, Is.Not.Null);

            clientToUpdate.FirstName = "NewName";
            clientToUpdate.LastName = "New Last Name";
            clientToUpdate.Email = "new@mail.org";
            clientToUpdate.PhoneNumber = "000000000";

            //Act
            _dao.UpdateClient(clientToUpdate);

            //Assert
            var result = Context.Clients.FirstOrDefault(x => x.Id == clientToUpdate.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(clientToUpdate, result);
        }
        #endregion

        #region RemoveClients
        [Test]
        public void RemoveClientsTest()
        {
            //Arrange
            var clientsToRemove = Context.Clients.Take(3).ToList();
            Assert.That(clientsToRemove, Is.Not.Null);
            Assert.That(clientsToRemove, Has.Count.EqualTo(3));
            var clientsIds = clientsToRemove.Select(x => x.Id).ToList();

            //Act
            _dao.RemoveClients(clientsToRemove);

            //Assert
            var result = Context.Clients.Any(x => clientsIds.Contains(x.Id));
            Assert.That(result, Is.False);
        }
        #endregion

        #region IsClientDuplicate
        [Test]
        public void IsClientDuplicateIfTrueTest()
        {
            //Arrange
            var client = new Client()
            {
                FirstName = "Amanda",
                LastName = "Black",
                PhoneNumber = "012012012",
                Email = "amanda@black.com"
            };
            Context.Clients.Add(client);
            Context.SaveChanges();
            var clientSalon = new ClientSalon() { ClientId = client.Id, SalonId = CURRENT_SALON_ID };
            Context.ClientSalon.Add(clientSalon);
            Context.SaveChanges();

            var clientToCheck = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
                Email = client.Email
            };

            //Act
            var result = _dao.IsClientDuplicate(clientToCheck);
            
            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void IsClientDuplicateIfTrueOnlyEmailTest()
        {
            //Arrange
            var client = new Client()
            {
                FirstName = "Amanda",
                LastName = "Black",
                PhoneNumber = "012012012",
                Email = "amanda@black.com"
            };
            Context.Clients.Add(client);
            Context.SaveChanges();
            var clientSalon = new ClientSalon() { ClientId = client.Id, SalonId = CURRENT_SALON_ID };
            Context.ClientSalon.Add(clientSalon);
            Context.SaveChanges();

            var clientToCheck = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = "333333333",
                Email = client.Email
            };

            //Act
            var result = _dao.IsClientDuplicate(clientToCheck);

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void IsClientDuplicateIfTrueOnlyPhoneTest()
        {
            //Arrange
            var client = new Client()
            {
                FirstName = "Amanda",
                LastName = "Black",
                PhoneNumber = "012012012",
                Email = "amanda@black.com"
            };
            Context.Clients.Add(client);
            Context.SaveChanges();
            var clientSalon = new ClientSalon() { ClientId = client.Id, SalonId = CURRENT_SALON_ID };
            Context.ClientSalon.Add(clientSalon);
            Context.SaveChanges();

            var clientToCheck = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                PhoneNumber = client.PhoneNumber,
                Email = "other@mail.pl"
            };

            //Act
            var result = _dao.IsClientDuplicate(clientToCheck);

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void IsClientDuplicateIfFalseTest()
        {
            //Arrange
            var client = new Client()
            {
                FirstName = "Amanda",
                LastName = "Black",
                PhoneNumber = "012012012",
                Email = "amanda@black.com"
            };
            var toRemove = Context.Clients.Where(c => c.FirstName == client.FirstName && c.LastName == client.LastName);
            Context.Clients.RemoveRange(toRemove);
            Context.SaveChanges();

            var otherSalon = Context.Salons.FirstOrDefault(s => s.Id != CURRENT_SALON_ID);
            Assert.That(otherSalon, Is.Not.Null);

            Context.Clients.Add(client);
            Context.SaveChanges();

            var clientSalon = new ClientSalon() { ClientId = client.Id, SalonId = otherSalon.Id };
            Context.ClientSalon.Add(clientSalon);
            Context.SaveChanges();

            var clientToCheck = new Client()
            {
                FirstName = client.FirstName,
                LastName = client.LastName,
                Email = client.Email,
                PhoneNumber = client.PhoneNumber
            };

            //Act
            var result = _dao.IsClientDuplicate(clientToCheck);

            //Assert
            Assert.That(result, Is.False);
        }
        #endregion

        #region RemoveClient
        [Test]
        public void RemoveClientTest()
        {
            //Arrange
            var clientToRemove = Context.Clients.FirstOrDefault();
            Assert.That(clientToRemove, Is.Not.Null);
            var clientId = clientToRemove.Id;

            //Act
            _dao.RemoveClient(clientToRemove);

            //Assert
            var result = Context.Clients.Any(x => x.Id == clientId);
            Assert.That(result, Is.False);
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new ClientDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(Client expected, Client actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
                Assert.That(actual.LastName, Is.EqualTo(expected.LastName));
                Assert.That(actual.PhoneNumber, Is.EqualTo(expected.PhoneNumber));
                Assert.That(actual.Email, Is.EqualTo(expected.Email));
            });
        }
    }
}
