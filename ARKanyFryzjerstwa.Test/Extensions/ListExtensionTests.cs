using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class ListExtensionTests
    {
        #region IsNullOrEmpty
        [Test]
        public void IsNullOrEmptyIfListIsNullShouldReturnTrueTest()
        {
            //Arrange
            List<SimpleClassForTest> list = null;
            const bool expected = true;

            //Act
            var result = list.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCaseSource(nameof(TestCasesForIsNullOrEmptyTest))]
        public void IsNullOrEmptyTest<T>(IList<T> list, bool expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = list.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForIsNullOrEmptyTest()
        {
            yield return new TestCaseData(new List<int>(), true);
            yield return new TestCaseData(new List<string>(), true);
            yield return new TestCaseData(new List<SimpleClassForTest>(), true);
            yield return new TestCaseData(new List<int>() { 5, 7, 13 }, false);
            yield return new TestCaseData(new List<string>() { "" }, false);
            yield return new TestCaseData(new List<SimpleClassForTest>() { new SimpleClassForTest() }, false);
        }
        #endregion

        #region Shuffle
        [Test]
        [TestCase("")]
        [TestCase("Test mieszania")]
        [TestCase("test z cyframi 1234567890")]
        [TestCase("I zanki specjalne 134 !@$@$^źć")]
        public void ShuffleStringTest(string text)
        {
            //Arrange => TestCases
            //Act
            var result = text.Shuffle();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(text.Length));
            foreach(var c in result)
            {
                Assert.That(text, Does.Contain(c));
            }
        }
        #endregion

        #region IsEqualTo
        [Test]
        [TestCaseSource(nameof(TestCasesForIsEqualToTest))]
        public void IsEqualToTest<T>(IList<T> list1, IList<T> list2, bool expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = list1.IsEqualTo(list2);

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        private static IEnumerable<TestCaseData> TestCasesForIsEqualToTest()
        {
            yield return new TestCaseData(new List<int>(), new List<int>() { 5, 7, 13 }, false);
            yield return new TestCaseData(new List<int>() { 5, 7, 13 }, new List<int>(), false);
            yield return new TestCaseData(new List<int>() { 5, 7, 13 }, new List<int>() { 5, 3, 13 }, false);
            yield return new TestCaseData(new List<int>() { 5 }, new List<int>() { 5, 3, 13 }, false);
            yield return new TestCaseData(new List<string>() { "test", "test2" }, new List<string>() { "test2", "test3" }, false);
            yield return new TestCaseData(new List<string>() { "test" }, new List<string>() { "test", "test3" }, false);

            yield return new TestCaseData(new List<int>(), new List<int>(), true);
            yield return new TestCaseData(new List<int>() { 5, 3, 13 }, new List<int>() { 5, 3, 13 }, true);
            yield return new TestCaseData(new List<string>() { "test", "test2" }, new List<string>() { "test", "test2" }, true);
        }
        #endregion
        private class SimpleClassForTest { }
    }
}
