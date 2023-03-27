using ARKanyFryzjerstwa.Extensions;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Extensions
{
    [TestFixture]
    public class GeneratorTests
    {
        #region GeneratePassword
        [Test]
        public void GeneratePasswordTest()
        {
            //Arrange
            const string passwordPattern = @"^(?=.*?[0-9])(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^\p{L}0-9]).{6}$";

            //Act
            var result = Generator.GeneratePassword();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Does.Match(passwordPattern));
        }
        #endregion
        #region GenerateVerificationCode
        [Test]
        public void GenerateVerificationCodeTest()
        {
            //Arrange
            const string codePattern = @"^[A-Z0-9]{8}$";

            //Act
            var result = Generator.GenerateVerificationCode();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Does.Match(codePattern));
        }
        [Test]
        [TestCase(6)]
        [TestCase(8)]
        [TestCase(10)]
        [TestCase(11)]
        public void GenerateVerificationCodeWithParameterTest(int length)
        {
            //Arrange
            const string codePattern = @"^[A-Z0-9]+$";

            //Act
            var result = Generator.GenerateVerificationCode(length);

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Length, Is.EqualTo(length));
            Assert.That(result, Does.Match(codePattern));
        }
        #endregion
    }
}
