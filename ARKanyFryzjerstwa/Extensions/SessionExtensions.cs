using System.Text.Json;

namespace ARKanyFryzjerstwa.Extensions
{
    public static class SessionExtensions
    {
        /// <summary> Ustawia wartość dla podanego klucza w sesji. </summary>
        /// <param name="session"> Obiekt <see cref="ISession"/>. </param>
        /// <param name="key"> Klucz elementu w sesji. </param>
        /// <param name="value"> Wartość elementu w sesji. </param>
        public static void Set<T>(this ISession session, string key, T value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        /// <summary> Zwraca wartość dla podanego klucza w sesji. </summary>
        /// <param name="session"> Obiekt <see cref="ISession"/>. </param>
        /// <param name="key"> Klucz elementu w sesji. </param>
        /// <returns> Wartość dla danego klucza w sesji. </returns>
        public static T? Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default : JsonSerializer.Deserialize<T>(value);
        }
    }
}
