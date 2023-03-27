using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class RolesFactoryTests
    {
        #region GetName
        [Test]
        [TestCaseSource(nameof(TestCaseDataForGetNameTest))]
        public void GetNameTest(Role role, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = RolesFactory.GetName(role);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCaseDataForGetNameTest()
        {
            yield return new TestCaseData(Role.SalonOwner, "SalonOwnerRole");
        }
        #endregion
    }
}
