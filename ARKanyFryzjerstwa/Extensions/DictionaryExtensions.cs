namespace ARKanyFryzjerstwa.Extensions
{
    public static class DictionaryExtensions
    {
        /// <summary> Sprawdza, czy słownik jest pusty lub równy null.</summary>
        /// <param name="dictionary"> Słownik, który ma zostać sprawdzony. </param>
        /// <returns> True, jeśli słownik jest pusty lub równy wartości null. W przeciwnym wypadku - false.</returns>
        public static bool IsNullOrEmpty<T1, T2>(this IDictionary<T1, T2> dictionary)
        {
            return dictionary == null || dictionary.Count == 0;
        }
    }
}