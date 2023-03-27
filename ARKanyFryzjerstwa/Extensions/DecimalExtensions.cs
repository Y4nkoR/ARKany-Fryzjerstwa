namespace ARKanyFryzjerstwa.Extensions
{
    public static class DecimalExtensions
    {
        private const string PRICE_PATTERN = "0.00 zł";
        private const int PRICE_MULTIPLER = 100;

        /// <summary> Zwraca cenę w postaci "X.XX zł".</summary>
        /// <param name="price"> Cena, która ma zostać sformatowana. </param>
        /// <returns> Cena w postaci "X.XX zł".</returns>
        public static string ToPriceString(this decimal price)
        {
            var rounded = Math.Ceiling(price * PRICE_MULTIPLER) / PRICE_MULTIPLER;
            var result = rounded.ToString(PRICE_PATTERN);
            return result;
        }
    }
}
