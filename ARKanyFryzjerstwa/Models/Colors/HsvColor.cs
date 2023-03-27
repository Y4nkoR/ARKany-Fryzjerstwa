namespace ARKanyFryzjerstwa.Models.Colors
{
    public class HsvColor
    {
        private double _hue;

        /// <summary>
        /// Pobiera lub ustawia wartość odcienia koloru (kąt stożka - wartości w przedziale [0, 360)).
        /// </summary>
        /// <value>
        /// Odcień.
        /// </value>
        public double Hue 
        { 
            get => _hue; 
            set
            {
                var temp = value % 360;
                if (temp < 0)
                {
                    temp += 360;
                }
                _hue = temp;
            }
        }
        /// <summary>
        /// Pobiera lub ustawia poziom nasycenia koloru (promień podstawy stożka - wartości od 0 do 1).
        /// </summary>
        /// <value>
        /// Nasycenie.
        /// </value>
        public double Saturation { get; set; }
        /// <summary>
        /// Pobiera lub ustawia jasność koloru (wysokość stożka - wartości od 0 do 1).
        /// </summary>
        /// <value>
        /// Jasność.
        /// </value>
        public double Value { get; set; }

        public HsvColor() { }
        public HsvColor(double hue, double saturation, double value) 
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
        }

        /// <summary>
        /// Konwertuje kolor w formacie HSV do formatu RGB.
        /// </summary>
        /// <returns>Kolor RGB</returns>
        public RgbColor ToRgbColor()
        {
            var result = new RgbColor();

            if (Value == 0)
            {
                return result;
            }  

            double max = Saturation * Value;
            double min = (Value - max);
            double middle = max * (1 - Math.Abs(((Hue / 60.0) % 2) - 1));

            int dominantColor = (int)Math.Floor(Hue / 60.0);

            int iMid = (int)((middle + min) * 255.0);
            int iMax = (int)((max + min) * 255.0);
            int iMin = (int)(min * 255.0);

            switch (dominantColor)
            {
                case 0:
                    result.Set(iMax, iMid, iMin);
                    break;
                case 1:
                    result.Set(iMid, iMax, iMin);
                    break;
                case 2:
                    result.Set(iMin, iMax, iMid);
                    break;
                case 3:
                    result.Set(iMin, iMid, iMax);
                    break;
                case 4:
                    result.Set(iMid, iMin, iMax);
                    break;
                case 5:
                    result.Set(iMax, iMin, iMid);
                    break;
            }

            return result;
        }

        /// <summary>
        /// Konwertue kolor w formacie HSV do zapisu szesnastkowego.
        /// </summary>
        /// <returns>Tekst z zapisem szesnastkowym koloru.</returns>
        public string ToHexColor()
        {
            return ToRgbColor().ToString();
        }
    }
}
