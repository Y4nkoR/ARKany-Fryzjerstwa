using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Extensions;
using Microsoft.AspNetCore.Identity;
using Moq;
using NUnit.Framework;
using System.Security.Claims;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class UserExtensionsTests
    {
        #region ClientDisplayName
        [Test]
        [TestCaseSource(nameof(GetTestCaseDataForClientDisplayNameTest))]
        public void ClientDisplayNameTest(Client client, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = client.DisplayName();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> GetTestCaseDataForClientDisplayNameTest()
        {
            yield return new TestCaseData(new Client(), " ");
            yield return new TestCaseData(new Client() { FirstName = "Felix" }, "Felix ");
            yield return new TestCaseData(new Client() { LastName = "Adams" }, " Adams");
            yield return new TestCaseData(new Client() { FirstName = "Felix", LastName = "Adams"}, "Felix Adams");
        }

        [Test]
        public void ClientDisplayNameIfClientIsNullShouldThrowsNullReferenceExceptionTest()
        {
            //Arrange
            Client client = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => client.DisplayName());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }
        #endregion
        #region UserDisplayName
        [Test]
        [TestCaseSource(nameof(GetTestCaseDataForUserDisplayNameTest))]
        public void UserDisplayNameTest(User user, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = user.DisplayName();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> GetTestCaseDataForUserDisplayNameTest()
        {
            yield return new TestCaseData(new User(), " ");
            yield return new TestCaseData(new User() { FirstName = "Felix" }, "Felix ");
            yield return new TestCaseData(new User() { LastName = "Adams" }, " Adams");
            yield return new TestCaseData(new User() { FirstName = "Felix", LastName = "Adams" }, "Felix Adams");
        }

        [Test]
        public void UserDisplayNameIfClientIsNullShouldThrowsNullReferenceExceptionTest()
        {
            //Arrange
            User user = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => user.DisplayName());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }
        #endregion
        #region GetUser
        [Test]
        public void GetUserTest()
        {
            //Arrange
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            User user = new User() { Id = "test id" };
            MyMock<IUserStore<User>> userStore = new MyMock<IUserStore<User>>();
            MyMock<UserManager<User>> userManagerMock = new MyMock<UserManager<User>>(userStore.Object, null, null, null, null, null, null, null, null);
            userManagerMock.Setup(x => x.GetUserAsync(claimsPrincipal), Times.Once()).ReturnsAsync(user);

            //Act
            var result = userManagerMock.Object.GetUser(claimsPrincipal);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(user.Id));
            Assert.That(result, Is.EqualTo(user));
            userManagerMock.VerifySetup();
        }

        [Test]
        public void GetUserIfClaimsPrincipalIsNullShouldReturnNullTest()
        {
            //Arrange
            ClaimsPrincipal claimsPrincipal = null;
            UserManager<User> userManager = null;

            //Act
            var result = userManager.GetUser(claimsPrincipal);

            //Assert
            Assert.That(result, Is.Null);
        }
        #endregion
        #region Is(Not)InRole
        [Test]
        public void IsOrIsNotInRoleIfIsInRoleTest()
        {
            //Arrange
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            claimsPrincipal.AddIdentity(new ClaimsIdentity(new[] { new Claim(ClaimTypes.Role, RolesFactory.GetName(Role.SalonOwner)) }));
            Role role = Role.SalonOwner;

            //Act
            var resultForIs = claimsPrincipal.IsInRole(role);
            var resultForIsNot = claimsPrincipal.IsNotInRole(role);

            //Assert
            Assert.That(resultForIs, Is.True);
            Assert.That(resultForIsNot, Is.False);
        }

        [Test]
        public void IsOrIsNotInRoleIfIsNotInRoleTest()
        {
            //Arrange
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal();
            Role role = Role.SalonOwner;

            //Act
            var resultForIs = claimsPrincipal.IsInRole(role);
            var resultForIsNot = claimsPrincipal.IsNotInRole(role);

            //Assert
            Assert.That(resultForIs, Is.False);
            Assert.That(resultForIsNot, Is.True);
        }
        #endregion
    }
}
