using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects.IDataAccessObjects;
using ARKanyFryzjerstwa.Models;
using ARKanyFryzjerstwa.Services;
using ARKanyFryzjerstwa.Services.IServices;
using Microsoft.Extensions.Caching.Memory;
using Moq;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Services
{
    [TestFixture]
    public class AppointmentServiceTests
    {
        private MyMock<IMemoryCache> _memoryCache;
        private MyMock<IClientDao> _clientDao;
        private MyMock<IAppointmentDao> _appointmentDao;
        private MyMock<IServiceDao> _serviceDao;
        private MyMock<IUserDao> _userDao;
        private MyMock<IClientsService> _clientsService;
        private MyMock<IServicesService> _servicesService;
        private IAppointmentService _service;

        [SetUp]
        public void Setup() 
        {
            _memoryCache = new MyMock<IMemoryCache>();
            _clientDao = new MyMock<IClientDao>();
            _appointmentDao = new MyMock<IAppointmentDao>();
            _serviceDao = new MyMock<IServiceDao>();
            _userDao = new MyMock<IUserDao>();
            _clientsService = new MyMock<IClientsService>();
            _servicesService = new MyMock<IServicesService>();

            _service = new AppointmentService(_memoryCache.Object, _clientDao.Object, _appointmentDao.Object, 
                _serviceDao.Object, _userDao.Object, _clientsService.Object, _servicesService.Object);
        }
        [TearDown]
        public void TearDown() 
        {
            _memoryCache.VerifyAll();
            _clientDao.VerifyAll();
            _appointmentDao.VerifyAll();
            _serviceDao.VerifyAll();
            _userDao.VerifyAll();
            _clientsService.VerifyAll();
            _servicesService.VerifyAll();
        }
        
        #region GetPhoneAndEmail
        [Test]
        [TestCaseSource(nameof(TestCasesForGetPhoneAndEmailTest))]
        public void GetPhoneAndEmailTest(Client? client, ContactData expected)
        {
            //Arrange
            const int clientId = 1;
            _clientDao.Setup(x => x.GetClientById(clientId), Times.Once()).Returns(client);

            //Act
            var result = _service.GetPhoneAndEmail(clientId);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Email, Is.EqualTo(expected.Email));
            Assert.That(result.PhoneNumber, Is.EqualTo(expected.PhoneNumber));
        }
        private static IEnumerable<TestCaseData> TestCasesForGetPhoneAndEmailTest()
        {
            const int clientId = 1;
            yield return new TestCaseData(null, new ContactData() { Email = null, PhoneNumber = null });
            yield return new TestCaseData(new Client() { Id = clientId, Email = null, PhoneNumber = null }, new ContactData() { Email = "", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "", PhoneNumber = null }, new ContactData() { Email = "", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = null, PhoneNumber = "" }, new ContactData() { Email = "", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "", PhoneNumber = "" }, new ContactData() { Email = "", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = null, PhoneNumber = "123123123" }, new ContactData() { Email = "", PhoneNumber = "123123123" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "", PhoneNumber = "123123123" }, new ContactData() { Email = "", PhoneNumber = "123123123" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "test@mail.pl", PhoneNumber = null }, new ContactData() { Email = "test@mail.pl", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "test@mail.pl", PhoneNumber = "" }, new ContactData() { Email = "test@mail.pl", PhoneNumber = "" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "test@mail.pl", PhoneNumber = "123123123" }, new ContactData() { Email = "test@mail.pl", PhoneNumber = "123123123" });
            yield return new TestCaseData(new Client() { Id = clientId, Email = "test2@inny-mail.pl", PhoneNumber = "908554217" }, new ContactData() { Email = "test2@inny-mail.pl", PhoneNumber = "908554217" });
        }
        #endregion

        #region CreateAppointment
        [Test]
        [TestCase("12:")]
        [TestCase("12:test")]
        [TestCase("12:23test")]
        [TestCase("12:test23")]
        public void CreateAppointmentIfEndTimeHasWrongMinutesFormatShouldThrowFormatExceptionTest(string endTime)
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = "12:30", EndTime = endTime };

            //Act
            var exception = Assert.Throws<FormatException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        public void CreateAppointmentIfEndTimeHasOnlyHoursShouldThrowIndexOutOfRangeExceptionTest()
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = "12:30", EndTime = "13" };

            //Act
            var exception = Assert.Throws<IndexOutOfRangeException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        [TestCase("")]
        [TestCase("test")]
        [TestCase("test:23")]
        [TestCase("12test:23")]
        public void CreateAppointmentIfEndTimeHasWrongHoursFormatShouldThrowFormatExceptionTest(string endTime)
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = "12:30", EndTime = endTime };

            //Act
            var exception = Assert.Throws<FormatException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        [TestCase("12:")]
        [TestCase("12:test")]
        [TestCase("12:23test")]
        [TestCase("12:test23")]
        public void CreateAppointmentIfStartTimeHasWrongMinutesFormatShouldThrowFormatExceptionTest(string startTime)
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = startTime, EndTime="16:00" };

            //Act
            var exception = Assert.Throws<FormatException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        public void CreateAppointmentIfStartTimeHasOnlyHoursShouldThrowIndexOutOfRangeExceptionTest()
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = "12", EndTime="16:00" };

            //Act
            var exception = Assert.Throws<IndexOutOfRangeException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        [TestCase("")]
        [TestCase("test")]
        [TestCase("test:23")]
        [TestCase("12test:23")]
        public void CreateAppointmentIfStartTimeHasWrongHoursFormatShouldThrowFormatExceptionTest(string startTime)
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = startTime, EndTime="16:00" };

            //Act
            var exception = Assert.Throws<FormatException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        public void CreateAppointmentIfStartTimeIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = new AppointmentAddModel() { StartTime = null, EndTime="16:00" };

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }

        [Test]
        public void CreateAppointmentIfAppointmentAddModelIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            AppointmentAddModel appointmentAddModel = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => _service.CreateAppointment(appointmentAddModel, "test", 1));

            //Assert
            Assert.That(exception, Is.Not.Null);
            _clientDao.Verify(x => x.GetClientById(It.IsAny<int>()), Times.Never());
            _clientDao.Verify(x => x.UpdateClient(It.IsAny<Client>()), Times.Never());
            _clientsService.Verify(x => x.CreateClient(It.IsAny<Client>()), Times.Never());
            _appointmentDao.Verify(x => x.AddAppointment(It.IsAny<Appointment>()), Times.Never());
        }
        #endregion

        #region CancelAppointment
        [Test]
        public void CancelAppointmentTest()
        {
            //Arrange
            const int appointmentId = 5;
            const AppointmentStatus expectedStatus = AppointmentStatus.Canceled;
            var appointment = new Appointment() { Id = appointmentId };
            _appointmentDao.Setup(x => x.GetAppointmentById(appointmentId), Times.Once()).Returns(appointment);
            _appointmentDao.Setup(x => x.UpdateAppointment(appointment), Times.Once());

            //Act
            _service.CancelAppointment(appointmentId);

            //Assert -> TearDown()
            Assert.That(appointment.Status, Is.EqualTo(expectedStatus));
        }

        [Test]
        public void CancelAppointmentIfAppointmentDoesNotExistShouldThrowArgumentNullExceptionTest()
        {
            //Arrange
            const int appointmentId = 5;
            Appointment appointment = null;
            _appointmentDao.Setup(x => x.GetAppointmentById(appointmentId), Times.Once()).Returns(appointment);
            
            //Act
            var exception = Assert.Throws<ArgumentNullException>(() => _service.CancelAppointment(appointmentId));

            //Assert -> TearDown()
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.ParamName, Is.EqualTo("appointment"));
            Assert.That(appointment, Is.Null);
            _appointmentDao.Verify(x => x.UpdateAppointment(It.IsAny<Appointment>()), Times.Never());
        }
        #endregion

        #region DoAppointmentsOverlap
        [Test]
        public void DoAppointmentsOverlapIfTrueTest()
        {
            //Arrange
            var modelToCheck = new AppointmentAddModel()
            {
                Date = new DateTime(2022, 12, 20),
                EmployeeId = new Guid().ToString(),
                StartTime = "15:20",
                EndTime = "16:00"
            };
            var appointments = new List<Appointment>()
            {
                new()
                {
                    EmployeeId = modelToCheck.EmployeeId,
                    Start = new DateTime(2022, 12, 22, 14, 40, 0),
                    End = new DateTime(2022, 12, 22, 15, 30, 0)
                },
                new()
                {
                    EmployeeId = modelToCheck.EmployeeId,
                    Start = new DateTime(2022, 12, 22, 13, 00, 0),
                    End = new DateTime(2022, 12, 22, 14, 30, 0)
                },
                new()
                {
                    EmployeeId = modelToCheck.EmployeeId,
                    Start = new DateTime(2022, 12, 20, 14, 40, 0),
                    End = new DateTime(2022, 12, 20, 15, 30, 0)
                },
                new()
                {
                    EmployeeId = new Guid().ToString(),
                    Start = new DateTime(2022, 12, 20, 14, 40, 0),
                    End = new DateTime(2022, 12, 20, 15, 30, 0)
                },
            };

            _appointmentDao.Setup(x =>
                    x.GetScheduledAppointmentsByEmployeeIdsAndDate(It.IsAny<List<string>>(), modelToCheck.Date),
                Times.Once()).Returns(appointments);

            //Act
            var result = _service.DoAppointmentsOverlap(modelToCheck);

            //Assert
            Assert.That(result, Is.True);
        }
        [Test]
        public void DoAppointmentsOverlapIfFalseTest()
        {
            //Arrange
            var modelToCheck = new AppointmentAddModel()
            {
                Date = new DateTime(2022, 12, 20),
                EmployeeId = new Guid().ToString(),
                StartTime = "15:20",
                EndTime = "16:00"
            };
            var appointments = new List<Appointment>()
            {
                new()
                {
                    EmployeeId = modelToCheck.EmployeeId,
                    Start = new DateTime(2022, 12, 22, 14, 40, 0),
                    End = new DateTime(2022, 12, 22, 15, 30, 0)
                },
                new()
                {
                    EmployeeId = modelToCheck.EmployeeId,
                    Start = new DateTime(2022, 12, 20, 13, 00, 0),
                    End = new DateTime(2022, 12, 20, 14, 30, 0)
                },
                new()
                {
                    EmployeeId = new Guid().ToString(),
                    Start = new DateTime(2022, 12, 20, 14, 40, 0),
                    End = new DateTime(2022, 12, 20, 15, 30, 0)
                },
            };

            _appointmentDao.Setup(x =>
                    x.GetScheduledAppointmentsByEmployeeIdsAndDate(It.IsAny<List<string>>(), modelToCheck.Date),
                Times.Once()).Returns(appointments);

            //Act
            var result = _service.DoAppointmentsOverlap(modelToCheck);

            //Assert
            Assert.That(result, Is.True);
        }
        #endregion

        #region CompleteAppointment

        [Test]
        public void CompleteAppointmentTest()
        {
            //Arrange
            var model = new AppointmentCompletionDataModel()
            {
                AppointmentId = 32,
                FinalPrice = "45.50",
                StandardPrice = "50.00"
            };
            var appointment = new Appointment();
            _appointmentDao.Setup(x => x.GetAppointmentById(model.AppointmentId), Times.Once())
                .Returns(appointment);
            _appointmentDao.Setup(x => x.UpdateAppointment(appointment), Times.Once());

            //Act
            _service.CompleteAppointment(model);

            //Assert -> TearDown()
        }
        #endregion

        #region GetAppointmentServiceModel

        [Test]
        public void GetAppointmentServiceModel()
        {
            //Arrange
            var appointment = new Appointment()
            {
                Id = 56,
                ServiceId = 42
            };
            var serviceModel = new ServiceModel()
            {
                Id = appointment.ServiceId
            };
            _appointmentDao.Setup(x => x.GetAppointmentById(appointment.Id), Times.Once())
                .Returns(appointment);
            _servicesService.Setup(x => x.GetServiceModelById(appointment.ServiceId), Times.Once())
                .Returns(serviceModel);

            //Act
            var result = _service.GetAppointmentServiceModel(appointment.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(serviceModel));
        }
        #endregion

    }
}
