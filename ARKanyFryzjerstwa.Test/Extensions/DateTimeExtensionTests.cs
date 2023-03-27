using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;
using System.Globalization;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class DateTimeExtensionTests
    {
        #region ToMonthTitle
        [Test]
        [TestCaseSource(nameof(TestCasesForToMonthTitleWithDefaultCultureTest))]
        public void ToMonthTitleWithDefaultCultureTest(DateTime date, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = date.ToMonthTitle();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForToMonthTitleWithDefaultCultureTest()
        {
            yield return new TestCaseData(new DateTime(2022, 1, 12), "styczeń 2022");
            yield return new TestCaseData(new DateTime(2022, 2, 12), "luty 2022");
            yield return new TestCaseData(new DateTime(2022, 3, 12), "marzec 2022");
            yield return new TestCaseData(new DateTime(2022, 4, 12), "kwiecień 2022");
            yield return new TestCaseData(new DateTime(2022, 5, 12), "maj 2022");
            yield return new TestCaseData(new DateTime(2022, 6, 12), "czerwiec 2022");
            yield return new TestCaseData(new DateTime(2022, 7, 12), "lipiec 2022");
            yield return new TestCaseData(new DateTime(2022, 8, 12), "sierpień 2022");
            yield return new TestCaseData(new DateTime(2022, 9, 12), "wrzesień 2022");
            yield return new TestCaseData(new DateTime(2022, 10, 12), "październik 2022");
            yield return new TestCaseData(new DateTime(2022, 11, 12), "listopad 2022");
            yield return new TestCaseData(new DateTime(2022, 12, 12), "grudzień 2022");
            yield return new TestCaseData(new DateTime(1998, 12, 12), "grudzień 1998");
            yield return new TestCaseData(new DateTime(2022, 1, 1), "styczeń 2022");
            yield return new TestCaseData(new DateTime(2022, 12, 31), "grudzień 2022");
            yield return new TestCaseData(new DateTime(2022, 12, 31, 23, 59, 59), "grudzień 2022");
        }

        [Test]
        [TestCaseSource(nameof(TestCasesForToMonthTitleIfCultureIsCorrectTest))]
        public void ToMonthTitleIfCultureIsCorrectTest(DateTime date, string culture, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = date.ToMonthTitle(culture);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForToMonthTitleIfCultureIsCorrectTest()
        {
            yield return new TestCaseData(new DateTime(2022, 1, 12), "pl", "styczeń 2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "pl-PL", "styczeń 2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "en-US", "January 2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "de-DE", "Januar 2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "", "January 2022");
        }

        [Test]
        public void ToMonthTitleIfCultureIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            string culture = null;
            var date = DateTime.Today;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => date.ToMonthTitle(culture));

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void ToMonthTitleIfCultureIsIncorrectShouldThrowCultureNotFoundExceptionTest()
        {
            //Arrange 
            const string culture = "Test";
            var date = DateTime.Today;

            //Act
            var exception = Assert.Throws<CultureNotFoundException>(() => date.ToMonthTitle(culture));

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        #endregion

        #region ToDayTitle
        [Test]
        [TestCaseSource(nameof(TestCaseDataForToDayTitleWithDefaultCultureTest))]
        public void ToDayTitleWithDefaultCultureTest(DateTime date, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = date.ToDayTitle();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCaseDataForToDayTitleWithDefaultCultureTest()
        {
            yield return new TestCaseData(new DateTime(2022, 1, 12), "środa, 12.01.2022");
            yield return new TestCaseData(new DateTime(2022, 2, 12), "sobota, 12.02.2022");
            yield return new TestCaseData(new DateTime(2022, 3, 12), "sobota, 12.03.2022");
            yield return new TestCaseData(new DateTime(2022, 4, 12), "wtorek, 12.04.2022");
            yield return new TestCaseData(new DateTime(2022, 5, 12), "czwartek, 12.05.2022");
            yield return new TestCaseData(new DateTime(2022, 6, 12), "niedziela, 12.06.2022");
            yield return new TestCaseData(new DateTime(2022, 7, 12), "wtorek, 12.07.2022");
            yield return new TestCaseData(new DateTime(2022, 8, 12), "piątek, 12.08.2022");
            yield return new TestCaseData(new DateTime(2022, 9, 12), "poniedziałek, 12.09.2022");
            yield return new TestCaseData(new DateTime(2022, 10, 12), "środa, 12.10.2022");
            yield return new TestCaseData(new DateTime(2022, 11, 12), "sobota, 12.11.2022");
            yield return new TestCaseData(new DateTime(2022, 12, 12), "poniedziałek, 12.12.2022");
            yield return new TestCaseData(new DateTime(1998, 12, 12), "sobota, 12.12.1998");
            yield return new TestCaseData(new DateTime(2022, 1, 1), "sobota, 01.01.2022");
            yield return new TestCaseData(new DateTime(2022, 12, 31), "sobota, 31.12.2022");
            yield return new TestCaseData(new DateTime(2022, 12, 31, 23, 59, 59), "sobota, 31.12.2022");
        }

        [Test]
        [TestCaseSource(nameof(TestCasesForToDayTitleIfCultureIsCorrectTest))]
        public void ToDayTitleIfCultureIsCorrectTest(DateTime date, string culture, string expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = date.ToDayTitle(culture);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForToDayTitleIfCultureIsCorrectTest()
        {
            yield return new TestCaseData(new DateTime(2022, 1, 12), "pl", "środa, 12.01.2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "pl-PL", "środa, 12.01.2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "en-US", "Wednesday, 12.01.2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "de-DE", "Mittwoch, 12.01.2022");
            yield return new TestCaseData(new DateTime(2022, 1, 12), "", "Wednesday, 12.01.2022");
        }

        [Test]
        public void ToDayTitleIfCultureIsNullShouldThrowNullReferenceExceptionTest()
        {
            //Arrange
            string culture = null;
            var date = DateTime.Today;

            //Act
            var exception = Assert.Throws<NullReferenceException>(() => date.ToDayTitle(culture));

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        [Test]
        public void ToDayTitleIfCultureIsIncorrectShouldThrowCultureNotFoundExceptionTest()
        {
            //Arrange 
            var culture = "Test";
            var date = DateTime.Today;

            //Act
            var exception = Assert.Throws<CultureNotFoundException>(() => date.ToDayTitle(culture));

            //Assert
            Assert.That(exception, Is.Not.Null);
        }

        #endregion

        #region GetFirstDayOfWeek
        [Test]
        [TestCaseSource(nameof(TestCasesForGetFirstDayOfWeekTest))]
        public void GetFirstDayOfWeekTest(DateTime date, DateTime expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = date.GetFirstDayOfWeek();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForGetFirstDayOfWeekTest()
        {
            yield return new TestCaseData(new DateTime(2022, 4, 4), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 5), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 6), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 7), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 8), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 9), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 4, 10), new DateTime(2022, 4, 4));
            yield return new TestCaseData(new DateTime(2022, 7, 3), new DateTime(2022, 06, 27));
            yield return new TestCaseData(new DateTime(2022, 8, 11, 8, 53, 26), new DateTime(2022, 8, 8, 8, 53, 26));
        }
        #endregion
    }
}
