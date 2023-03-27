using System.Collections.Generic;
using System.Text;

namespace ARKanyFryzjerstwa.Extensions
{
    public static class Generator
    {
        private static Random _random = new Random();
        public static string AllowedLower => "abcdefghijkmnopqrstuvwxyz";
        public static string AllowedUpper => "ABCDEFGHJKLMNPQRSTUVWXYZ";
        public static string AllowedDigits => "123456789";
        public static string AllowedSpecial => "!@#$%^&*+=<>?./";
        public static string AllAllowed => $"{AllowedLower}{AllowedUpper}{AllowedDigits}{AllowedSpecial}";
        public static string AllowedUpperAndDigits => $"{AllowedUpper}{AllowedDigits}";


        /// <summary> Generuje losowe hasło spełniające określone warunki:
        /// <list type="bullet">
        ///     <item> Przynajmniej jedna mała litera. </item>
        ///     <item> Przynajmniej jedna duża litera. </item>
        ///     <item> Przynajmniej jedna cyfra. </item>
        ///     <item> Przynajmniej jeden znak specjalny. </item>
        ///     <item> Długość równa 6 znaków. </item>
        /// </list>
        /// </summary>
        /// <returns> Wygenerowane hasło.</returns>
        public static string GeneratePassword()
        {
            var builder = new StringBuilder();
            builder.Append(RandomChar(AllowedLower));
            builder.Append(RandomChar(AllowedUpper));
            builder.Append(RandomChar(AllowedDigits));
            builder.Append(RandomChar(AllowedSpecial));
            for (int i = 0; i < 2; i++)
            {
                builder.Append(RandomChar(AllAllowed));
            }

            var shuffled =  builder.ToString().Shuffle();
            return string.Concat(shuffled);
        }

        /// <summary> Generuje kod weryfikacyjny używany przy resetowaniu hasła.</summary>
        /// <param name="length"> Długość kodu. </param>
        /// <returns> Wygenerowany kod.</returns>
        public static string GenerateVerificationCode(int length = 8)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                builder.Append(RandomChar(AllowedUpperAndDigits));
            }

            return string.Concat(builder.ToString());
        }

        /// <summary> Wybiera losowy znak z ciągu znaków.</summary>
        /// <param name="chars"> Ciąg znaków, z których ma zostać wybrany jeden losowy. </param>
        /// <returns> Losowo wybrany znak.</returns>
        private static char RandomChar(string chars)
        {
            int setLength = chars.Length;
            int index = _random.Next(setLength);
            return chars[index];
        }
    }
}
