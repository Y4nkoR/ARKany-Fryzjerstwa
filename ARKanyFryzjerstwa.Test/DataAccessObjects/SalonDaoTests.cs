using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.DataAccessObjects;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.DataAccessObjects
{
    [TestFixture]
    [Explicit("Hit db")]
    public class SalonDaoTests : BaseDaoTests<SalonDao>
    {
        #region InsertSalon
        [Test]
        public void InsertSalonTest()
        {
            //Arrange
            var salonToAdd = new Salon()
            {
                Name = "New salon",
                PhoneNumber = "123321123"
            };

            //Act
            var result = _dao.InsertSalon(salonToAdd);

            //Assert
            Assert.That(result, Is.EqualTo(salonToAdd.Id));
            var insertedSalon = Context.Salons.FirstOrDefault(x => x.Id == salonToAdd.Id);
            Assert.That(insertedSalon, Is.Not.Null);
            AssertAreEqual(salonToAdd, insertedSalon);
        }
        #endregion
        #region GetEmployeesColorsForSalon
        [Test]
        public void GetEmployeesColorsForSalonTest()
        {
            //Arrange
            var employees = new List<User>()
            {
                new()
                {
                    SalonId = CURRENT_SALON_ID,
                    Color = "#123412",
                    FirstName = "TestName",
                    LastName = "Test Last Name"
                },
                new()
                {
                    SalonId = CURRENT_SALON_ID,
                    Color = "#000111",
                    FirstName = "TestName",
                    LastName = "Test Last Name"
                },
                new()
                {
                    SalonId = CURRENT_SALON_ID,
                    Color = "#88f345",
                    FirstName = "TestName",
                    LastName = "Test Last Name"
                },
            };
            Context.Users.AddRange(employees);
            Context.SaveChanges();

            //Act
            var colors = _dao.GetEmployeesColorsForSalon(CURRENT_SALON_ID);

            //Assert
            Assert.That(colors, Is.Not.Null);
            Assert.That(colors, Has.Count.AtLeast(1));
            foreach (var employee in employees)
            {
                var result = colors.Contains(employee.Color);
                Assert.That(result, Is.True);
            }
        }
        #endregion

        protected override void SetDao()
        {
            _dao = new SalonDao(Context, CURRENT_SALON_ID);
        }

        private static void AssertAreEqual(Salon expected, Salon actual)
        {
            Assert.Multiple(() =>
            {
                Assert.That(actual.Id, Is.EqualTo(expected.Id));
                Assert.That(actual.Name, Is.EqualTo(expected.Name));
                Assert.That(actual.PhoneNumber, Is.EqualTo(expected.PhoneNumber));
            });
        }
    }
}
