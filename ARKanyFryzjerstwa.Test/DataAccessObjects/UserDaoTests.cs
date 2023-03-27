using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class UserDaoTests : BaseDaoTests<UserDao>
    {
        #region GetEmployeesBySalonId
        [Test]
        public void GetEmployeesBySalonIdTest()
        {
            //Arrange
            var salon = Context.Salons.FirstOrDefault();
            Assert.That(salon, Is.Not.Null);

            var newEmployees = new List<User>()
            {
                new()
                {
                    FirstName = "name",
                    LastName = "lastName",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name1",
                    LastName = "lastName1",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name2",
                    LastName = "lastName2",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name3",
                    LastName = "lastName3",
                    UserName = "userName",
                    Color = "#123123",
                    SalonId = salon.Id
                },
            };
            Context.Users.AddRange(newEmployees);
            Context.SaveChanges();

            //Act
            var result = _dao.GetEmployeesBySalonId(salon.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(newEmployees.Count));
            foreach (var newEmployee in newEmployees)
            {
                var resultEmployee = result.FirstOrDefault(x => x.Id == newEmployee.Id);
                Assert.That(resultEmployee, Is.Not.Null);
                AssertAreEqual(newEmployee, resultEmployee);
            }
        }
        #endregion
        #region GetEmployeesByEmployeeIds
        [Test]
        public void GetEmployeesByEmployeeIdsTest()
        {
            //Arrange
            var salon = Context.Salons.FirstOrDefault();
            Assert.That(salon, Is.Not.Null);

            var newEmployees = new List<User>()
            {
                new()
                {
                    FirstName = "name",
                    LastName = "lastName",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name1",
                    LastName = "lastName1",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name2",
                    LastName = "lastName2",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name3",
                    LastName = "lastName3",
                    UserName = "userName",
                    Color = "#123123",
                    SalonId = salon.Id
                },
            };
            Context.Users.AddRange(newEmployees);
            Context.SaveChanges();

            var employeesIds = newEmployees.Select(x => x.Id).ToList();

            //Act
            var result = _dao.GetEmployeesByEmployeeIds(employeesIds);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.EqualTo(employeesIds.Count));
            foreach (var newEmployee in newEmployees)
            {
                var resultEmployee = result.FirstOrDefault(x => x.Id == newEmployee.Id);
                Assert.That(resultEmployee, Is.Not.Null);
                AssertAreEqual(newEmployee, resultEmployee);
            }
        }
        #endregion
        #region GetUserNamesStartsWith
        [Test]
        public void GetUserNamesStartsWithTest()
        {
            //Arrange
            const string startNamePart = "mal";
            var salon = Context.Salons.FirstOrDefault();
            Assert.That(salon, Is.Not.Null);

            var newEmployees = new List<User>()
            {
                new()
                {
                    FirstName = "name",
                    LastName = "lastName",
                    UserName = startNamePart + "axs",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name1",
                    LastName = "lastName1",
                    UserName = startNamePart + "afd",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name2",
                    LastName = "lastName2",
                    UserName = startNamePart + "stbs",
                    Color = "#123123",
                    SalonId = salon.Id
                },
                new()
                {
                    FirstName = "name3",
                    LastName = "lastName3",
                    UserName = "userName",
                    Color = "#123123",
                    SalonId = salon.Id
                },
            };

            Context.Users.AddRange(newEmployees);
            Context.SaveChanges();

            //Act
            var result = _dao.GetUserNamesStartsWith(startNamePart);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Has.Count.AtLeast(3));
            foreach (var resultName in result)
            {
                Assert.That(resultName, Does.StartWith(startNamePart));
            }

            foreach (var checkResult in newEmployees.GetRange(0, 3).Select(newEmployee => result.Contains(newEmployee.UserName)))
            {
                Assert.That(checkResult, Is.True);
            }
        }
        #endregion
        #region UpdateEmployeeColor
        [Test]
        public void UpdateEmployeeColorTest()
        {
            //Arrange
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);

            const string color = "#123123";
            
            //Act
            _dao.UpdateEmployeeColor(employee.Id, color);
            
            //Assert
            var result = Context.Users.FirstOrDefault(x => x.Id == employee.Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Color, Is.EqualTo(color));
        }
        #endregion
        #region GetUserNote
        [Test]
        public void GetUserNoteTest()
        {
            //Arrange
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);

            var notesToRemove = Context.Notes.Where(x => x.EmployeeId == employee.Id);
            Context.Notes.RemoveRange(notesToRemove);
            Context.SaveChanges();

            var note = new Note()
            {
                EmployeeId = employee.Id,
                Text = "new note123"
            };
            Context.Notes.Add(note);
            Context.SaveChanges();

            //Act
            var result = _dao.GetUserNote(employee.Id);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(note.Text));
        }
        #endregion
        #region SaveUserNote
        [Test]
        public void SaveUserNoteTest()
        {
            //Arrange
            var employee = Context.Users.FirstOrDefault();
            Assert.That(employee, Is.Not.Null);

            const string note = "New note";

            //Act
            _dao.SaveUserNote(note, employee.Id);

            //Assert
            var result = Context.Notes.FirstOrDefault(x => x.EmployeeId == employee.Id);
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Text, Is.EqualTo(note));
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new UserDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(User expected, User actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.IsActive, Is.EqualTo(expected.IsActive));
                Assert.That(actual.FirstName, Is.EqualTo(expected.FirstName));
                Assert.That(actual.LastName, Is.EqualTo(expected.LastName));
                Assert.That(actual.Color, Is.EqualTo(expected.Color));
                Assert.That(actual.UserName, Is.EqualTo(expected.UserName));
            });
        }

    }
}
