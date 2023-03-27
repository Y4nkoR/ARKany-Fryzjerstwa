using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class DictionaryExtensionsTests
    {
        #region IsNullOrEmpty
        [Test]
        public void IsNullOrEmptyIfDictionaryIsNullShouldReturnTrueTest()
        {
            //Arrange
            Dictionary<int, string> dictionary = null;
            const bool expected = true;

            //Act
            var result = dictionary.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCaseSource(nameof(TestCasesForIsNullOrEmptyTest))]
        public void IsNullOrEmptyTest<T1, T2>(IDictionary<T1, T2> dictionary, bool expected)
        {
            //Arrange -> TestCaseSource
            //Act
            var result = dictionary.IsNullOrEmpty();

            //Assert
            Assert.That(result, Is.EqualTo(expected));
        }
        private static IEnumerable<TestCaseData> TestCasesForIsNullOrEmptyTest()
        {
            yield return new TestCaseData(new Dictionary<int, string>(), true);
            yield return new TestCaseData(new Dictionary<string, string>(), true);
            yield return new TestCaseData(new Dictionary<int, int>(), true);
            yield return new TestCaseData(new Dictionary<int, int>(), true);
            yield return new TestCaseData(new Dictionary<int, SimpleClassForTest>(), true);
            var dict1 = new Dictionary<int, bool>
            {
                { 1, true }
            };
            yield return new TestCaseData(dict1, false);
            var dict2 = new Dictionary<string, SimpleClassForTest>
            {
                { "", new SimpleClassForTest() }
            };
            yield return new TestCaseData(dict2, false);
        }
        #endregion

        private class SimpleClassForTest { }
    }

}
