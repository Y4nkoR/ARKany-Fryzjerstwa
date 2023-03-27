using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class IntExtensionsTests
    {
        #region MinutesToDurationString
        [Test]
        [TestCaseSource(nameof(TestCasesForMinutesToDurationStringTest))]
        public void MinutesToDurationStringTest(int minutes, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = minutes.MinutesToDurationString();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForMinutesToDurationStringTest()
        {
            yield return new TestCaseData(0, "00:00");
            yield return new TestCaseData(54, "00:54");
            yield return new TestCaseData(62, "01:02");
            yield return new TestCaseData(-3, "-00:03");
            yield return new TestCaseData(-73, "-01:13");
        }
        #endregion
        #region ToHex
        [Test]
        [TestCase(0, "0")]
        [TestCase(10, "a")]
        [TestCase(15, "f")]
        [TestCase(325, "145")]
        [TestCase(3258, "cba")]
        public void ToHexTest(int number, string expected)
        {
            //Arrange => TestCases
            //Act
            var result = number.ToHex();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion
        #region ToLeftPadHex
        [Test]
        [TestCase(0, "00")]
        [TestCase(10, "0a")]
        [TestCase(15, "0f")]
        [TestCase(325, "145")]
        [TestCase(3258, "cba")]
        public void ToLeftPadHexTest(int number, string expected)
        {
            //Arrange => TestCases
            //Act
            var result = number.ToLeftPadHex();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(0, 2, '0', "00")]
        [TestCase(0, 3, '0', "000")]
        [TestCase(0, 2, 'a', "a0")]
        [TestCase(325, 2, '!', "145")]
        [TestCase(3258, 5, '#', "##cba")]
        public void ToLeftPadHexWithParamsTest(int number, int width, char padChar, string expected)
        {
            //Arrange => TestCases
            //Act
            var result = number.ToLeftPadHex(width, padChar);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion
    }
}
