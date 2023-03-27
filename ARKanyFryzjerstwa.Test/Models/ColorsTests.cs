using ARKanyFryzjerstwa.Models.Colors;
using NUnit.Framework;

namespace ARKanyFryzjerstwa.Test.Models
{
    [TestFixture]
    public  class ColorsTests
    {
        #region RgbToHexColor
        [Test]
        [TestCase(0, 0, 0, "#000000")]
        [TestCase(255, 13, 42, "#ff0d2a")]
        [TestCase(84, 201, 61, "#54c93d")]
        [TestCase(100, 8, 254, "#6408fe")]
        public void RgbToHexColorTest(int red, int green, int blue, string expected)
        {
            //Arrange
            var rgb = new RgbColor(red, green, blue);

            //Act
            var result = rgb.ToString();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Not.Empty);
            Assert.That(result, Is.EqualTo(expected));
        }
        #endregion
        #region RgbToHsvColor
        [Test]
        [TestCase(30, 26, 108, 242.0, 0.75, 0.42)]
        [TestCase(109, 54, 23, 22.0, 0.789, 0.427)]
        [TestCase(109, 23, 54, 338.0, 0.789, 0.427)]
        [TestCase(83, 3, 4, 359.0, 0.964, 0.325)]
        [TestCase(21, 18, 104, 242.0, 0.827, 0.408)]
        public void RgbToHsvColorTest(int red, int green, int blue, double hue, double saturation, double value)
        {
            //Arrange
            var rgb = new RgbColor(red, green, blue);

            //Act
            var result = rgb.ToHsvColor();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Hue, Is.EqualTo(hue).Within(1));
            Assert.That(result.Saturation, Is.EqualTo(saturation).Within(0.01));
            Assert.That(result.Value, Is.EqualTo(value).Within(0.01));
        }
        #endregion
        #region HsvToRgbColor
        [Test]
        [TestCase(45.0, 0.54, 0.12, 31, 26, 14)]
        [TestCase(0, 0, 0, 0, 0, 0)]
        [TestCase(100.0, 1.0, 1.0, 85, 255, 0)]
        [TestCase(321.0, 0.23, 0.54, 138, 106, 127)]
        public void HsvToRgbColorTest(double hue, double saturation, double value, int red, int green, int blue)
        {
            //Arrange
            var hsv = new HsvColor(hue, saturation, value);

            //Act
            var result = hsv.ToRgbColor();

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Red, Is.EqualTo(red).Within(1));
            Assert.That(result.Green, Is.EqualTo(green).Within(1));
            Assert.That(result.Blue, Is.EqualTo(blue).Within(1));
        }
        #endregion
    }
}
