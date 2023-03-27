using Microsoft.AspNetCore.Http;
using NUnit.Framework;
using ARKanyFryzjerstwa.Extensions;
using System.Text;
using Moq;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class SessionExtensionsTests
    {
        private MyMock<ISession> _session;

        [SetUp]
        public void SetUp()
        {
            _session = new MyMock<ISession>();
        }
        [TearDown]
        public void TearDown()
        {
            _session.VerifyAll();
        }

        #region Set

        [Test]
        public void SetTest()
        {
            //Arrange
            const int valueToSet = 5;
            const string key = "key";
            var setValue = Array.Empty<byte>();
            _session.Setup(_ => _.Set(key, It.IsAny<byte[]>()), Times.Once())
                .Callback<string, byte[]>((k, v) => setValue = v);

            //Act
            _session.Object.Set(key, valueToSet);

            //Assert
            var convertedSetValue = Encoding.Default.GetString(setValue);
            Assert.That(convertedSetValue, Is.EqualTo(valueToSet.ToString()));
        }
        #endregion

        #region Get

        [Test]
        public void GetTest()
        {
            //Arrange
            const int expected = 5;
            const string key = "key";
            var value = new byte[] { 53 };

            _session.Setup(_ => _.TryGetValue(key, out value), Times.Once())
                .Returns(true);

            //Act
            var result = _session.Object.Get<int>(key);

            //Assert - TearDown()
            Assert.That(result, Is.EqualTo(expected));
        }

        #endregion
        
    }
}
