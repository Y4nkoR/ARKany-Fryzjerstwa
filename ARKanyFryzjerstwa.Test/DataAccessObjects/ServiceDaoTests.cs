using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class ServiceDaoTests : BaseDaoTests<ServiceDao>
    {
        #region AddService
        [Test]
        public void AddServiceTest()
        {
            //Arrange
            var serviceToAdd = new Service()
            {
                IsActive = true,
                Duration = 45,
                Name = "Test service",
                Price = 45.5m,
                SalonId = CURRENT_SALON_ID,
            };

            //Act
            _dao.AddService(serviceToAdd);

            //Assert
            var result = Context.Services.FirstOrDefault(x => x.Id == serviceToAdd.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(serviceToAdd, result);
        }
        #endregion
        #region GetServiceById
        [Test]
        public void GetServiceByIdTest()
        {
            //Arrange
            var serviceToAdd = new Service()
            {
                IsActive = true,
                Duration = 45,
                Name = "Test service",
                Price = 45.5m,
                SalonId = CURRENT_SALON_ID,
            };
            Context.Services.Add(serviceToAdd);
            Context.SaveChanges();

            //Act
            var result = _dao.GetServiceById(serviceToAdd.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(serviceToAdd, result);
        }
        #endregion
        #region GetActiveServicesForSalon
        [Test]
        public void GetActiveServicesForSalonTest()
        {
            //Arrange
            var services = new List<Service>()
            {
                new()
                {
                    IsActive = true,
                    Duration = 45,
                    Name = "Test service",
                    Price = 45.5m,
                    SalonId = CURRENT_SALON_ID,
                },
                new()
                {
                    IsActive = true,
                    Duration = 25,
                    Name = "Test service2",
                    Price = 45.4m,
                    SalonId = CURRENT_SALON_ID,
                },
                new()
                {
                    IsActive = false,
                    Duration = 35,
                    Name = "Test service3",
                    Price = 42.5m,
                    SalonId = CURRENT_SALON_ID,
                },
            };
            Context.Services.AddRange(services);
            Context.SaveChanges();
            var activeServices = services.GetRange(0, 2);

            //Act
            var result = _dao.GetActiveServicesForSalon(CURRENT_SALON_ID);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(2));
            foreach (var service in result)
            {
                Assert.That(service.IsActive, Is.True);
            }

            foreach (var activeService in activeServices)
            {
                var resultService = result.FirstOrDefault(x => x.Id == activeService.Id);
                Assert.That(resultService, Is.Not.Null);
                AssertAreEqual(activeService, resultService);
            }
        }
        #endregion
        #region GetServicesBySalonId
        [Test]
        public void GetServicesBySalonIdTest()
        {
            //Arrange
            var otherSalon = Context.Salons.FirstOrDefault(x => x.Id != CURRENT_SALON_ID);
            Assert.That(otherSalon, Is.Not.Null);

            var services = new List<Service>()
            {
                new()
                {
                    IsActive = true,
                    Duration = 45,
                    Name = "Test service",
                    Price = 45.5m,
                    SalonId = CURRENT_SALON_ID,
                },
                new()
                {
                    IsActive = true,
                    Duration = 25,
                    Name = "Test service2",
                    Price = 45.4m,
                    SalonId = CURRENT_SALON_ID,
                },
                new()
                {
                    IsActive = false,
                    Duration = 35,
                    Name = "Test service3",
                    Price = 42.5m,
                    SalonId = otherSalon.Id,
                },
            };
            Context.Services.AddRange(services);
            Context.SaveChanges();
            var salonServices = services.GetRange(0, 2);

            //Act
            var result = _dao.GetServicesBySalonId(CURRENT_SALON_ID);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(2));
            foreach (var service in result)
            {
                Assert.That(service.SalonId, Is.EqualTo(CURRENT_SALON_ID));
            }

            foreach (var salonService in salonServices)
            {
                var resultService = result.FirstOrDefault(x => x.Id == salonService.Id);
                Assert.That(resultService, Is.Not.Null);
                AssertAreEqual(salonService, resultService);
            }

        }
        #endregion
        #region UpdateService
        [Test]
        public void UpdateServiceTest()
        {
            //Arrange
            var serviceToUpdate = Context.Services.FirstOrDefault();
            Assert.That(serviceToUpdate, Is.Not.Null);
            serviceToUpdate.IsActive = false;
            serviceToUpdate.Duration = 35;
            serviceToUpdate.Name = "updated name";
            serviceToUpdate.Price = 75.3m;
            
            //Act
            _dao.UpdateService(serviceToUpdate);

            //Assert
            var result = Context.Services.FirstOrDefault(x => x.Id == serviceToUpdate.Id);
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(serviceToUpdate, result);
        }
        #endregion
        #region UpdateServices
        [Test]
        public void UpdateServicesTest()
        {
            //Arrange
            var servicesToUpdate = Context.Services.Take(3).ToList();
            foreach (var service in servicesToUpdate)
            {
                service.Name = "New name";
                service.IsActive = false;
            }

            var servicesIds = servicesToUpdate.Select(s => s.Id).ToList();

            //Act
            _dao.UpdateServices(servicesToUpdate);

            //Assert
            var result = Context.Services.Where(x => servicesIds.Contains(x.Id)).ToList();
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.EqualTo(3));
            foreach (var serviceToUpdate in servicesToUpdate)
            {
                var resultService = result.FirstOrDefault(x => x.Id == serviceToUpdate.Id);
                Assert.That(resultService, Is.Not.Null);
                AssertAreEqual(serviceToUpdate, resultService);
            }
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new ServiceDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(Service expected, Service actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.SalonId, Is.EqualTo(expected.SalonId));
                Assert.That(actual.Name, Is.EqualTo(expected.Name));
                Assert.That(actual.Duration, Is.EqualTo(expected.Duration));
                Assert.That(actual.Price, Is.EqualTo(expected.Price));
                Assert.That(actual.IsActive, Is.EqualTo(expected.IsActive));
            });
        }
    }
}
