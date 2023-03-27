using System.Globalization;
using System.Text.RegularExpressions;

namespace ARKanyFryzjerstwa.Extensions
{
    public static class StringExtensions
    {
        /// <summary> Zwraca cenę w postaci liczby dziesiętnej. </summary>
        /// <param name="priceString"> Cena w postaci tekstu. </param>
        /// <returns> Cena w postaci liczby dziesiętnej. </returns>
        public static decimal GetPrice(this string priceString)
        {
            var numberString = priceString.Replace(" zł", "").Replace(",", ".");
            var nrFormatInfo = new CultureInfo("pl", false).NumberFormat;
            nrFormatInfo.NumberDecimalSeparator = ".";
            var price = decimal.Parse(numberString, nrFormatInfo);
            const int priceMultipler = 100;
            var result = Math.Ceiling(price * priceMultipler) / priceMultipler;
            return result;
        }

        /// <summary> Zwraca czas trwania w minutach z czasu w postaci "hh:mm". </summary>
        /// <param name="durationString"> Czas trwania w postaci tekstu. </param>
        /// <returns> Czas trwania w minutach. </returns>
        public static int GetMinutesFromDurationString(this string durationString)
        {
            var splitted = durationString.Split(':');
            var sign = 1;
            if (splitted[0].StartsWith('-'))
            {
                splitted[0] = splitted[0].Substring(1);
                sign = -1;
            }
            var hours =  int.Parse(splitted[0]);
            var minutes = int.Parse(splitted[1]);
            var result = (hours * 60 + minutes) * sign;
            return result;
        }

        /// <summary> Sprawdza, czy ciąg znaków nie zawiera tylko znaków białych lub nie jest pusty. </summary>
        /// <param name="str"> Ciąg znaków do sprawdzenia. </param>
        /// <returns> True, jeśli ciąg znaków nie jest pusty lub nie zawiera tylko znaków białych. </returns>
        public static bool IsNotOnlyWhitespaces(this string str)
        {
            return !string.IsNullOrWhiteSpace(str);
        }

        /// <summary> Zamienia liczbę z postaci heksadecymalnej na dzisiętną. </summary>
        /// <param name="hex"> Liczba do konwersji. </param>
        /// <returns> Liczba w postaci dziesiętnej. </returns>
        public static int HexToInt(this string hex)
        {
            return Convert.ToInt32(hex, 16);
        }

        /// <summary> Normalizuje nazwę użytkownika. </summary>
        /// <param name="userName"> Nazwa użytkownika do znormalizowania. </param>
        /// <returns> Znormalizowana nazwa użytkownika. </returns>
        public static string NormalizeUserName(this string userName)
        {
            string mismatchedRegex = $"[^{Program.ALLOWED_LOGIN_CHARS}]";
            var result = Regex.Replace(userName.ToLower(), mismatchedRegex, new MatchEvaluator(ReplaceToNormalizedChars));
            return result;
        }

        /// <summary> Zastępuje znaki w ciągu znaków ich znormalizowaną wersją. </summary>
        /// <param name="match"> Obiekt <see cref="Match"/> do znormalizowania. </param>
        /// <returns> Znormalizowany ciąg znaków. </returns>
        private static string ReplaceToNormalizedChars(Match match)
        {
            return match.Value switch
            {
                "ą" => "a",
                "ć" => "c",
                "ę" => "e",
                "ł" => "l",
                "ń" => "n",
                "ó" => "o",
                "ś" => "s",
                "ż" => "z",
                "ź" => "z",
                _ => string.Empty,
            };
        }
    }
}
