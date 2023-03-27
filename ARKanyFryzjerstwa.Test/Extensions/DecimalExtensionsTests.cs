using NUnit.Framework;
using ARKanyFryzjerstwa.Extensions;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class DecimalExtensionsTests
    {
        #region ToPriceString
        [Test]
        [TestCaseSource(nameof(TestCasesForToPriceStringTest))]
        public void ToPriceStringTest(decimal price, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = price.ToPriceString();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForToPriceStringTest()
        {
            yield return new TestCaseData((decimal)3.0, "3,00 zł");
            yield return new TestCaseData((decimal)55.898, "55,90 zł");
            yield return new TestCaseData((decimal)-50.345, "-50,34 zł");
            yield return new TestCaseData((decimal)0.001, "0,01 zł");
        }
        #endregion
    }
}
