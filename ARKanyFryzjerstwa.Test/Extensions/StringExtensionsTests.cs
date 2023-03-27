using ARKanyFryzjerstwa.Extensions;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using Org.BouncyCastle.Utilities.Encoders;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class StringExtensionsTests
    {
        #region GetPrice
        [Test]
        [TestCase("23,8", 23.8)]
        [TestCase("0,55 zł", 0.55)]
        [TestCase("2.83", 2.83)]
        [TestCase("12.00 zł", 12)]
        public void GetPriceTest(string priceString, decimal expected)
        {
            //Arrange -> TestCases
            //Act
            var result = priceString.GetPrice();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("a")]
        [TestCase("10.a")]
        public void GetPriceIfStringFormatIsWrongShouldThrowsFormatExceptionTest(string priceString)
        {
            //Arrange -> TestCases
            //Act
            var exception = Assert.Throws<FormatException>(() => priceString.GetPrice());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void GetPriceIfStringIsNullShouldThrowsNullReferenceExceptionTest()
        {
            //Arrange -> TestCaseSource
            string priceString = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => priceString.GetPrice());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }
        #endregion
        #region GetMinutesFromDurationString
        [Test]
        [TestCase("0:05", 5)]
        [TestCase("0:8", 8)]
        [TestCase("5:35", 335)]
        [TestCase("-1:20", -80)]
        [TestCase("-0:32", -32)]
        public void GetMinutesFromDurationStringTest(string durationString, int expected)
        {
            //Arrange -> TestCases
            //Act
            var result = durationString.GetMinutesFromDurationString();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase("54")]
        [TestCase("8")]
        public void GetMinutesFromDurationStringIfStringIsInNumberFormatShouldThrowsIndexOutOfRangeExceptionTest(string durationString)
        {
            //Arrange -> TestCases
            //Act
            var exception = Assert.Throws<IndexOutOfRangeException>(() => durationString.GetMinutesFromDurationString());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        [TestCase("")]
        [TestCase("a")]
        [TestCase(":")]
        [TestCase("abc:23")]
        [TestCase("3.5:5")]
        [TestCase("3,5:5")]
        [TestCase("00:2a")]
        [TestCase("5:5.5")]
        [TestCase("5:5,5")]
        public void GetMinutesFromDurationStringIfTimeFormatIsWrongShouldThrowsFormatExceptionTest(string durationString)
        {
            //Arrange -> TestCases
            //Act
            var exception = Assert.Throws<FormatException>(() => durationString.GetMinutesFromDurationString());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void GetMinutesFromDurationStringIfStringIsNullShouldThrowsNullReferenceExceptionTest()
        {
            //Arrange
            string durationString = null;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => durationString.GetMinutesFromDurationString());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }
        #endregion  
        #region IsNotOnlyWhitespaces
        [Test]
        [TestCaseSource(nameof(TestCaseDataForIsNotOnlyWhitespacesTest))]
        public void IsNotOnlyWhitespacesTest(string str, bool expected)
        {
            //Arrange  -> TestCaseSource
            //Act
            var result = str.IsNotOnlyWhitespaces();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCaseDataForIsNotOnlyWhitespacesTest()
        {
            yield return new TestCaseData(null, false);
            yield return new TestCaseData(string.Empty, false);
            yield return new TestCaseData("  ", false);
            yield return new TestCaseData(" ", false);
            yield return new TestCaseData("a", true);
            yield return new TestCaseData("test msg", true);
        }
        #endregion
        #region HexToInt
        [Test]
        [TestCase("0", 0)]
        [TestCase("a", 10)]
        [TestCase("A", 10)]
        [TestCase("f", 15)]
        [TestCase("F", 15)]
        [TestCase("145", 325)]
        [TestCase("cba", 3258)]
        [TestCase("CBA", 3258)]
        public void HexToIntTest(string hex, int expected)
        {
            //Arrange => TestCases
            //Act
            var result = hex.HexToInt();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(" ")]
        [TestCase("g")]
        [TestCase("123kl")]
        [TestCase("test")]
        public void HexToIntIfFormatIsWrongShouldThrowsFormatExceptionTest(string text)
        {
            //Arrange => TestCases
            //Act
            var exception = Assert.Throws<FormatException>(() => text.HexToInt());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void HexToIntIfStringIsEmptyShouldThrowsArgumentOutOfRangeExceptionTest()
        {
            //Arrange
            var text = string.Empty;

            //Act
            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => text.HexToInt());

            //Assert
            Assert.That(exception, Is.Not.Null);
        }
        #endregion
        #region NormalizeUserName
        [Test]
        [TestCase("", "")]
        [TestCase("Testowy tekst", "testowytekst")]
        [TestCase("Pęko-@#!wski  . Łuka    s\nz", "pekowski.lukasz")]
        public void NormalizeUserNameTest(string userName, string expected)
        {
            //Arrange -> TestCases
            //Act
            var result = userName.NormalizeUserName();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion
    }
}
