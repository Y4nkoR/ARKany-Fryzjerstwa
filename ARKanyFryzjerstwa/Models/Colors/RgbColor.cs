using ARKanyFryzjerstwa.Extensions;
using ARKanyFryzjerstwa.Resources;
using System.Text.RegularExpressions;

namespace ARKanyFryzjerstwa.Models.Colors
{
    public class RgbColor
    {
        private int _red;
        private int _green;
        private int _blue;

        /// <summary>
        /// Pobiera lub ustawia poziom natężenia koloru czerwonego (wartości od 0 do 255).
        /// </summary>
        /// <value>
        /// Natężenie koloru czerwonego.
        /// </value>
        public int Red 
        {
            get => _red; 
            set => _red = ToByteRange(value);
        }

        /// <summary>
        /// Pobiera lub ustawia poziom natężenia koloru zielonego (wartości od 0 do 255).
        /// </summary>
        /// <value>
        /// Natężenie koloru zielonego.
        /// </value>
        public int Green
        {
            get => _green;
            set => _green = ToByteRange(value);
        }

        /// <summary>
        /// Pobiera lub ustawia poziom natężenia koloru niebieskiego (wartości od 0 do 255).
        /// </summary>
        /// <value>
        /// Natężenie koloru niebieskiego.
        /// </value>
        public int Blue
        {
            get => _blue;
            set => _blue = ToByteRange(value);
        }

        public RgbColor() { }
        public RgbColor(int red, int green, int blue) 
        {
            Set(red, green, blue);
        }
        public RgbColor(string hexColor) 
        {
            const string hexPattern = "^#[0-9a-f]{6}$";

            if (!Regex.IsMatch(hexColor.ToLower(), hexPattern))
            {
                throw new ArgumentException(ARKanyResources.WrongHexColorFormatExceptionMessage, nameof(hexColor));
            }

            Red = hexColor.Substring(1, 2).HexToInt();
            Green = hexColor.Substring(3, 2).HexToInt();
            Blue = hexColor.Substring(5, 2).HexToInt();
        }

        /// <summary>
        /// Ustawia przekazane wartości składowych koloru.
        /// </summary>
        /// <param name="red">Natężenie składowej czerwonej</param>
        /// <param name="green">Natężenie składowej zielonej</param>
        /// <param name="blue">Natężenie składowej niebieskiej</param>
        public void Set(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }


        /// <summary>
        /// Konwertuje kolor w formacie RGB do formatu HSV.
        /// </summary>
        /// <returns>Kolor HSV</returns>
        public HsvColor ToHsvColor()
        {
            var list = new List<int>() { Red, Green, Blue };
            int max = list.Max();
            int min = list.Min();
            double value = max / 255.0;
            double saturation = max > 0 ? (1 - ((double)min / max)) : 0;

            double diff = max - min; 
            double hue = min == max ? 0 :
                (max == Red ? ((Green - Blue) / diff) % 6 :
                max == Green ? ((Blue - Red) / diff) + 2 :
                ((Red - Green) / diff) + 4) * 60;

            return new HsvColor(hue, saturation, value);
        }

        public override string ToString()
        {
            return $"#{Red.ToLeftPadHex()}{Green.ToLeftPadHex()}{Blue.ToLeftPadHex()}";
        }

        private static int ToByteRange(int number)
        {
            const int max = 256;
            var result = number % max;
            if (result < 0)
            {
                result += max;
            }
            return result;
        }

    }
}
