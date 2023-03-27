using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class MenuHelperTests
    {
        #region GetTabClassActive
        [Test]
        [TestCaseSource(nameof(TestCasesDataForGetTabClassActiveTest))]
        public void GetTabClassActiveTest(string currentPath, string tabPath, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = MenuHelper.GetTabClassActive(currentPath, tabPath);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesDataForGetTabClassActiveTest()
        {
            const string activeClass = "active";
            yield return new TestCaseData("/Test/TestMethod", "/Test", activeClass);
            yield return new TestCaseData("/Test/TestMethod", "/Test/", activeClass);
            yield return new TestCaseData("/Test2/TestMetho", "/Test", string.Empty);
            yield return new TestCaseData(string.Empty, string.Empty, activeClass);
            yield return new TestCaseData(" ", " / ", activeClass);
            yield return new TestCaseData("/Test/TestMethod", string.Empty, string.Empty);
            yield return new TestCaseData(null, null, string.Empty);
            yield return new TestCaseData(string.Empty, null, string.Empty);
            yield return new TestCaseData(null, string.Empty, string.Empty);
            yield return new TestCaseData("/Test", null, string.Empty);
            yield return new TestCaseData(null, "/Test", string.Empty);
        }
        #endregion
    }
}
