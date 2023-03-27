namespace ARKanyFryzjerstwa.Extensions
{
    public static class IntExtensions
    {
        private const string DURATION_PATTERN = @"hh\:mm";

        /// <summary> Zwraca przekazane minuty jako czas w postaci "hh:mm".</summary>
        /// <param name="minutes"> Czas trwania w minutach. </param>
        /// <returns> Czas trwania w postaci "hh:mm".</returns>
        public static string MinutesToDurationString(this int minutes)
        {
            var sign = minutes < 0 ? "-" : string.Empty;
            var timeSpan = new TimeSpan(0, minutes, 0);
            var result = sign + timeSpan.ToString(DURATION_PATTERN);
            return result;
        }

        /// <summary> Zwraca liczbę w postaci heksadecymalnej.</summary>
        /// <param name="number"> Liczba do przekonwertowania. </param>
        /// <returns> Liczba w postaci heksadecymalnej jako tekst.</returns>
        public static string ToHex(this int number)
        {
            return number.ToString("x");
        }

        /// <summary> Zwraca liczbę w postaci (domyślnie dwucyfrowej) liczby heksadecymalnej.</summary>
        /// <param name="number"> Liczba do przekonwertowania. </param>
        /// <param name="width"> Liczba cyfr w zwracanej liczbie. </param>
        /// <param name="padChar"> Znak uzupełniający. </param>
        /// <returns> Liczba w postaci heksadecymalnej o określonej liczbie cyfr, jako tekst.</returns>
        public static string ToLeftPadHex(this int number, int width = 2, char padChar = '0')
        {
            return number.ToHex().PadLeft(width, padChar);
        }
    }
}
