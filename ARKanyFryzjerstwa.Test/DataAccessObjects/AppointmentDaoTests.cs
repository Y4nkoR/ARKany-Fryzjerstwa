using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class AppointmentDaoTests : BaseDaoTests<AppointmentDao>
    {
        #region AddAppointment
        [Test]
        public void AddAppointmentTest()
        {
            //Arrange
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);
            var service = Context.Services.FirstOrDefault();
            Assert.That(service, Is.Not.Null);
            var client = Context.Clients.FirstOrDefault();
            Assert.That(client, Is.Not.Null);
            var toAdd = new Appointment()
            {
                Start = new DateTime(2022, 10, 15, 12, 30, 00),
                End = new DateTime(2022, 10, 15, 13, 00, 00),
                EmployeeId = employee.Id,
                AuthorId = employee.Id,
                ServiceId = service.Id,
                ClientId = client.Id,
                Status = AppointmentStatus.Completed,
                StandardPrice = 23.4m,
                FinalPrice = 20m
            };

            //Act
            _dao.AddAppointment(toAdd);

            //Assert
            Assert.That(toAdd.Id, Is.GreaterThan(0));
            var selected = Context.Appointments.FirstOrDefault(x => x.Id == toAdd.Id);
            Assert.That(selected, Is.Not.Null);
            AssertAreEqual(toAdd, selected);
        }

        [Test]
        public void AddAppointmentIfAlreadyExistInDbShouldThrowDbUpdateExceptionTest()
        {
            //Arrange
            const string expMsg = "Cannot insert explicit value for identity column in table 'Appointments' when IDENTITY_INSERT is set to OFF.";
            var toAdd = Context.Appointments.FirstOrDefault();
            Assert.That(toAdd, Is.Not.Null);
            Assert.That(toAdd.Id, Is.GreaterThan(0));

            //Act
            var exception = Assert.Throws<DbUpdateException>(() => _dao.AddAppointment(toAdd));

            //Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.InnerException, Is.Not.Null);
            Assert.That(exception.InnerException.GetType(), Is.EqualTo(typeof(SqlException)));
            Assert.That(exception.InnerException.Message, Is.EqualTo(expMsg));
        }

        [Test]
        public void AddAppointmentIfHasAssignedIdWhichDoesNotExistsShouldThrowDbUpdateExceptionTest()
        {
            //Arrange
            const string expMsg = "Cannot insert explicit value for identity column in table 'Appointments' when IDENTITY_INSERT is set to OFF.";
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);
            var service = Context.Services.FirstOrDefault();
            Assert.That(service, Is.Not.Null);
            var client = Context.Clients.FirstOrDefault();
            Assert.That(client, Is.Not.Null);
            var toAdd = new Appointment()
            {
                Id = -3,
                Start = new DateTime(2022, 10, 15, 12, 30, 00),
                End = new DateTime(2022, 10, 15, 13, 00, 00),
                EmployeeId = employee.Id,
                AuthorId = employee.Id,
                ServiceId = service.Id,
                ClientId = client.Id
            };

            //Act
            var exception = Assert.Throws<DbUpdateException>(() => _dao.AddAppointment(toAdd));

            //Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.InnerException, Is.Not.Null);
            Assert.That(exception.InnerException.GetType(), Is.EqualTo(typeof(SqlException)));
            Assert.That(exception.InnerException.Message, Is.EqualTo(expMsg));
        }

        [Test]
        public void AddAppointmentIfRequiredFieldIsNullShouldThrowDbUpdateExceptionTest()
        {
            //Arrange
            var expMsg1 = $"Cannot insert the value NULL into column ";
            var expMsg2 = "column does not allow nulls. INSERT fails.";
            var toAdd = new Appointment();

            //Act
            var exception = Assert.Throws<DbUpdateException>(() => _dao.AddAppointment(toAdd));

            //Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.InnerException, Is.Not.Null);
            Assert.That(exception.InnerException.GetType(), Is.EqualTo(typeof(SqlException)));
            Assert.That(exception.InnerException.Message, Contains.Substring(expMsg1));
            Assert.That(exception.InnerException.Message, Contains.Substring(expMsg2));
        }

        [Test]
        public void AddAppointmentIfAppointmentIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            Appointment toAdd = null;
            var expectedMsg = "Object reference not set to an instance of an object.";

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => _dao.AddAppointment(toAdd));

            //Assert
            Assert.That(exception, Is.Not.Null);
            Assert.That(exception.Message, Is.Not.Null);
            Assert.That(exception.Message, Is.Not.Empty);
            Assert.That(exception.Message, Is.EqualTo(expectedMsg));
        }
        #endregion

        #region GetAppointmentById
        [Test]
        public void GetAppointmentByIdTest()
        {
            //Arrange
            var appointmentToGet = Context.Appointments.FirstOrDefault();
            Assert.That(appointmentToGet, Is.Not.Null);

            //Act
            var result = _dao.GetAppointmentById(appointmentToGet.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            AssertAreEqual(appointmentToGet, result);
        }

        [Test]
        public void GetAppointmentByIdIfIdDoesNotExistsShouldReturnNullTest()
        {
            //Arrange
            const int appointmentId = -5;

            //Act
            var result = _dao.GetAppointmentById(appointmentId);

            //Assert
            Assert.That(result, Is.Null);
        }
        #endregion

        #region GetAppointmentsByEmployeeIdsAndDate
        [Test]
        public void GetAppointmentsByEmployeeIdsAndDateTest()
        {
            //Arrange
            const string methodName = nameof(GetAppointmentsByEmployeeIdsAndDateTest);
            var date = new DateTime(2022, 10, 15);

            var employees = Context.Users.Take(3).ToList();
            Assert.That(employees, Is.Not.Null);
            Assert.That(employees, Has.Count.EqualTo(3));
            var paramEmployeeIds = employees.Take(2).Select(x => x.Id).ToList();

            var services = employees.Select(emp => new Service()
                { SalonId = emp.SalonId, Name = methodName, Duration = 30, IsActive = true, Price = 40 }).ToList();
            Context.Services.AddRange(services);
            Context.SaveChanges();

            var fakeAppointments = new List<Appointment>()
            {
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 9, 30, 00),
                    End = new DateTime(2022, 10, 15, 10, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 13, 30, 00),
                    End = new DateTime(2022, 10, 15, 14, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 11, 30, 00),
                    End = new DateTime(2022, 10, 15, 12, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 14, 11, 30, 00),
                    End = new DateTime(2022, 10, 14, 12, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 16, 12, 30, 00),
                    End = new DateTime(2022, 10, 16, 13, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 12, 30, 00),
                    End = new DateTime(2022, 10, 17, 13, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Canceled
                }
            };
            Context.Appointments.AddRange(fakeAppointments);
            Context.SaveChanges();

            //Act
            var result = _dao.GetAppointmentsByEmployeeIdsAndDate(paramEmployeeIds, date);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expected in fakeAppointments.Take(3))
            {
                var resultAppointment = result.FirstOrDefault(x => x.Id == expected.Id && services.Any(s => s.Id == x.ServiceId));
                if (resultAppointment == null)
                {
                    Assert.Fail($"Appointment with Id = {expected.Id} not found in result.");
                }
                else
                {
                    AssertAreEqual(expected, resultAppointment);
                }
            }
        }
        #endregion

        #region GetNotCanceledAppointmentsByEmployeeIdsAndDate
        [Test]
        public void GetNotCanceledAppointmentsByEmployeeIdsAndDateTest()
        {
            //Arrange
            const string methodName = nameof(GetNotCanceledAppointmentsByEmployeeIdsAndDateTest);
            var date = new DateTime(2022, 10, 15);

            var employees = Context.Users.Take(3).ToList();
            Assert.That(employees, Is.Not.Null);
            Assert.That(employees, Has.Count.EqualTo(3));
            var paramEmployeeIds = employees.Take(2).Select(x => x.Id).ToList();

            var services = employees.Select(emp => new Service()
            { SalonId = emp.SalonId, Name = methodName, Duration = 30, IsActive = true, Price = 40 }).ToList();
            Context.Services.AddRange(services);
            Context.SaveChanges();

            var fakeAppointments = new List<Appointment>()
            {
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 9, 30, 00),
                    End = new DateTime(2022, 10, 15, 10, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 13, 30, 00),
                    End = new DateTime(2022, 10, 15, 14, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 11, 30, 00),
                    End = new DateTime(2022, 10, 15, 12, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 14, 11, 30, 00),
                    End = new DateTime(2022, 10, 14, 12, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 16, 12, 30, 00),
                    End = new DateTime(2022, 10, 16, 13, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 12, 30, 00),
                    End = new DateTime(2022, 10, 17, 13, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Canceled
                }
            };
            Context.Appointments.AddRange(fakeAppointments);
            Context.SaveChanges();

            //Act
            var result = _dao.GetNotCanceledAppointmentsByEmployeeIdsAndDate(paramEmployeeIds, date);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expected in fakeAppointments.Take(3))
            {
                var resultAppointment = result.FirstOrDefault(x => x.Id == expected.Id && services.Any(s => s.Id == x.ServiceId));
                if (resultAppointment == null)
                {
                    Assert.Fail($"Appointment with Id = {expected.Id} not found in result.");
                }
                else
                {
                    AssertAreEqual(expected, resultAppointment);
                }
            }
        }
        #endregion

        #region GetScheduledAppointmentsByEmployeeIdsAndDate
        [Test]
        public void GetScheduledAppointmentsByEmployeeIdsAndDateTest()
        {
            //Arrange
            const string methodName = nameof(GetScheduledAppointmentsByEmployeeIdsAndDateTest);
            var date = new DateTime(2022, 10, 15);

            var employees = Context.Users.Take(3).ToList();
            Assert.That(employees, Is.Not.Null);
            Assert.That(employees, Has.Count.EqualTo(3));
            var paramEmployeeIds = employees.Take(2).Select(x => x.Id).ToList();

            var services = employees.Select(emp => new Service()
            { SalonId = emp.SalonId, Name = methodName, Duration = 30, IsActive = true, Price = 40 }).ToList();
            Context.Services.AddRange(services);
            Context.SaveChanges();

            var fakeAppointments = new List<Appointment>()
            {
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 9, 30, 00),
                    End = new DateTime(2022, 10, 15, 10, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 13, 30, 00),
                    End = new DateTime(2022, 10, 15, 14, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 11, 30, 00),
                    End = new DateTime(2022, 10, 15, 12, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 14, 11, 30, 00),
                    End = new DateTime(2022, 10, 14, 12, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 16, 12, 30, 00),
                    End = new DateTime(2022, 10, 16, 13, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 12, 30, 00),
                    End = new DateTime(2022, 10, 17, 13, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Canceled
                }
            };
            Context.Appointments.AddRange(fakeAppointments);
            Context.SaveChanges();

            //Act
            var result = _dao.GetScheduledAppointmentsByEmployeeIdsAndDate(paramEmployeeIds, date);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expected in fakeAppointments.Take(3))
            {
                var resultAppointment = result.FirstOrDefault(x => x.Id == expected.Id && services.Any(s => s.Id == x.ServiceId));
                if (resultAppointment == null)
                {
                    Assert.Fail($"Appointment with Id = {expected.Id} not found in result.");
                }
                else
                {
                    AssertAreEqual(expected, resultAppointment);
                }
            }
        }
        #endregion

        #region GetCompletedAppointmentsByEmployeeIdsAndDate
        [Test]
        public void GetCompletedAppointmentsByEmployeeIdsAndDateTest()
        {
            //Arrange
            const string methodName = nameof(GetCompletedAppointmentsByEmployeeIdsAndDateTest);
            var date = new DateTime(2022, 10, 15);

            var employees = Context.Users.Take(3).ToList();
            Assert.That(employees, Is.Not.Null);
            Assert.That(employees, Has.Count.EqualTo(3));
            var paramEmployeeIds = employees.Take(2).Select(x => x.Id).ToList();

            var services = employees.Select(emp => new Service()
            { SalonId = emp.SalonId, Name = methodName, Duration = 30, IsActive = true, Price = 40 }).ToList();
            Context.Services.AddRange(services);
            Context.SaveChanges();

            var fakeAppointments = new List<Appointment>()
            {
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Completed,
                    StandardPrice = 20m,
                    FinalPrice = 19m
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 9, 30, 00),
                    End = new DateTime(2022, 10, 15, 10, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed,
                    StandardPrice = 20m,
                    FinalPrice = 19m
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 13, 30, 00),
                    End = new DateTime(2022, 10, 15, 14, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 11, 30, 00),
                    End = new DateTime(2022, 10, 15, 12, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Completed
                },
                new(){
                    Start = new DateTime(2022, 10, 14, 11, 30, 00),
                    End = new DateTime(2022, 10, 14, 12, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled
                },
                new(){
                    Start = new DateTime(2022, 10, 16, 12, 30, 00),
                    End = new DateTime(2022, 10, 16, 13, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed,
                    StandardPrice = 20m,
                    FinalPrice = 19m
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 12, 30, 00),
                    End = new DateTime(2022, 10, 17, 13, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Canceled
                }
            };
            Context.Appointments.AddRange(fakeAppointments);
            Context.SaveChanges();

            //Act
            var result = _dao.GetCompletedAppointmentsByEmployeeIdsAndDate(paramEmployeeIds, date);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expected in fakeAppointments.Take(3))
            {
                var resultAppointment = result.FirstOrDefault(x => x.Id == expected.Id && services.Any(s => s.Id == x.ServiceId));
                if (resultAppointment == null)
                {
                    Assert.Fail($"Appointment with Id = {expected.Id} not found in result.");
                }
                else
                {
                    AssertAreEqual(expected, resultAppointment);
                }
            }
        }
        #endregion

        #region GetAppointmentsByClientId
        [Test]
        public void GetAppointmentsByClientIdTest()
        {
            //Arrange
            const string methodName = nameof(GetAppointmentsByClientIdTest);
            var date = new DateTime(2022, 10, 15);

            var employees = Context.Users.Take(3).ToList();
            Assert.That(employees, Is.Not.Null);
            Assert.That(employees, Has.Count.EqualTo(3));
            var paramEmployeeIds = employees.Take(2).Select(x => x.Id).ToList();

            var services = employees.Select(emp => new Service()
            { SalonId = emp.SalonId, Name = methodName, Duration = 30, IsActive = true, Price = 40 }).ToList();
            Context.Services.AddRange(services);
            Context.SaveChanges();

            var clients = employees.Select(emp => new Client()
                { FirstName = "first", LastName = "last", PhoneNumber = "000000000" }).ToList();
            clients.Add(new Client() { FirstName = "second", LastName = "last", PhoneNumber = "000000010" });
            Context.Clients.AddRange(clients);
            Context.SaveChanges();

            var clientSalons = clients.Select(c => new ClientSalon() { ClientId = c.Id }).ToList();
            clientSalons[0].SalonId = employees[0].SalonId;
            clientSalons[1].SalonId = employees[1].SalonId;
            clientSalons[2].SalonId = employees[2].SalonId;
            clientSalons[3].SalonId = employees[1].SalonId;

            var fakeAppointments = new List<Appointment>()
            {
                new(){
                    Start = new DateTime(2022, 10, 9, 9, 30, 00),
                    End = new DateTime(2022, 10, 9, 10, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled,
                    ClientId = clients[1].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 13, 30, 00),
                    End = new DateTime(2022, 10, 15, 14, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Completed,
                    ClientId = clients[1].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 7, 30, 00),
                    End = new DateTime(2022, 10, 17, 9, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Canceled,
                    ClientId = clients[1].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 12, 30, 00),
                    End = new DateTime(2022, 10, 15, 13, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id, 
                    Status = AppointmentStatus.Canceled,
                    ClientId = clients[0].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 15, 11, 30, 00),
                    End = new DateTime(2022, 10, 15, 12, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Scheduled,
                    ClientId = clients[2].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 14, 11, 30, 00),
                    End = new DateTime(2022, 10, 14, 12, 00, 00),
                    EmployeeId = employees[0].Id,
                    AuthorId = employees[0].Id,
                    ServiceId = services[0].Id,
                    Status = AppointmentStatus.Canceled,
                    ClientId = clients[0].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 16, 12, 30, 00),
                    End = new DateTime(2022, 10, 16, 13, 00, 00),
                    EmployeeId = employees[1].Id,
                    AuthorId = employees[1].Id,
                    ServiceId = services[1].Id,
                    Status = AppointmentStatus.Scheduled,
                    ClientId = clients[3].Id
                },
                new(){
                    Start = new DateTime(2022, 10, 17, 12, 30, 00),
                    End = new DateTime(2022, 10, 17, 13, 00, 00),
                    EmployeeId = employees[2].Id,
                    AuthorId = employees[2].Id,
                    ServiceId = services[2].Id,
                    Status = AppointmentStatus.Canceled,
                }
            };
            Context.Appointments.AddRange(fakeAppointments);
            Context.SaveChanges();

            //Act
            var result = _dao.GetAppointmentsByClientId(clients[1].Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var expected in fakeAppointments.Take(3))
            {
                var resultAppointment = result.FirstOrDefault(x => x.Id == expected.Id && services.Any(s => s.Id == x.ServiceId));
                if (resultAppointment == null)
                {
                    Assert.Fail($"Appointment with Id = {expected.Id} not found in result.");
                }
                else
                {
                    AssertAreEqual(expected, resultAppointment);
                }
            }
        }
        #endregion

        #region UpdateAppointment
        [Test]
        public void UpdateAppointmentTest()
        {
            //Arrange
            var appointment = Context.Appointments.FirstOrDefault();
            Assert.That(appointment, Is.Not.Null);
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);
            var service = Context.Services.FirstOrDefault();
            Assert.That(service, Is.Not.Null);
            var client = Context.Clients.FirstOrDefault();
            Assert.That(client, Is.Not.Null);
            appointment.Start = new DateTime(2022, 10, 15, 12, 30, 00);
            appointment.End = new DateTime(2022, 10, 15, 13, 00, 00);
            appointment.EmployeeId = employee.Id;
            appointment.AuthorId = employee.Id;
            appointment.ServiceId = service.Id;
            appointment.ClientId = client.Id;

            //Act
            _dao.UpdateAppointment(appointment);

            //Assert
            Assert.That(appointment.Id, Is.GreaterThan(0));
            var selected = Context.Appointments.FirstOrDefault(x => x.Id == appointment.Id);
            Assert.That(selected, Is.Not.Null);
            AssertAreEqual(appointment, selected);
        }

        [Test]
        public void UpdateAppointmentIfAppointmentIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            Appointment toAdd = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => _dao.UpdateAppointment(toAdd));

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        #endregion

        #region UpdateAppointments
        [Test]
        public void UpdateAppointmentsTest()
        {
            //Arrange
            var appointments = Context.Appointments.Take(3).ToList();
            Assert.That(appointments, Is.Not.Null);
            Assert.That(appointments, Has.Count.EqualTo(3));
            foreach (var appointment in appointments)
            {
                appointment.FinalPrice = 35m;
                appointment.StandardPrice = 40m;
                appointment.Status = AppointmentStatus.Scheduled;
                appointment.Start = DateTime.Now;
                appointment.End = DateTime.Now.AddHours(1);
            }

            //Act
            _dao.UpdateAppointments(appointments);

            //Assert
            foreach (var appointment in appointments)
            {
                var resultAppointment = Context.Appointments.First(x => x.Id == appointment.Id);
                AssertAreEqual(appointment, resultAppointment);
            }
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new AppointmentDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(Appointment expected, Appointment actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.Start, Is.EqualTo(expected.Start));
                Assert.That(actual.End, Is.EqualTo(expected.End));
                Assert.That(actual.EmployeeId, Is.EqualTo(expected.EmployeeId));
                Assert.That(actual.AuthorId, Is.EqualTo(expected.AuthorId));
                Assert.That(actual.ServiceId, Is.EqualTo(expected.ServiceId));
                Assert.That(actual.ClientId, Is.EqualTo(expected.ClientId));
                Assert.That(actual.Status, Is.EqualTo(expected.Status));
                Assert.That(actual.StandardPrice, Is.EqualTo(expected.StandardPrice));
                Assert.That(actual.FinalPrice, Is.EqualTo(expected.FinalPrice));
            });
        }
        
    }
}
