using System.Globalization;

namespace ARKanyFryzjerstwa.Extensions
{
    public static class DateTimeExtension
    {
        /// <summary> Zwraca miesiąc i rok z podanej daty w postaci "MMMM yyyy".</summary>
        /// <param name="date"> Data, z której ma zostać zwrócona określona część. </param>
        /// <param name="culture"> Kultura, w której formacie ma zostać zapisany zwracany tekst. </param>
        /// <returns> Data w postaci "MMMM yyyy".</returns>
        public static string ToMonthTitle(this DateTime date, string culture = "pl")
        {
            return date.ToString("MMMM yyyy", CultureInfo.CreateSpecificCulture(culture));
        }

        /// <summary> Zwraca datę w postaci "dddd, dd.MM.yyyy".</summary>
        /// <param name="date"> Data, która ma zostać sformatowana. </param>
        /// <param name="culture"> Kultura, w której formacie ma zostać zapisany zwracany tekst. </param>
        /// <returns> Data w postaci "dddd, dd.MM.yyyy".</returns>
        public static string ToDayTitle(this DateTime date, string culture = "pl")
        {
            return date.ToString("dddd, dd.MM.yyyy", CultureInfo.CreateSpecificCulture(culture));
        }

        /// <summary> Zwraca datę pierwszego dnia tygodnia.</summary>
        /// <param name="dateTime"> Data, dla której ma zostać zwrócony pierwszy dzień tygodnia. </param>
        /// <returns> Obiekt <see cref="DateTime"/> reprezentujący pierwszy dzień tygodnia.</returns>
        public static DateTime GetFirstDayOfWeek(this DateTime dateTime)
        {
            var dayOfWeekNumber = (int) dateTime.DayOfWeek;
            var offset = dayOfWeekNumber == 0 ? 6 : dayOfWeekNumber - 1;
            return dateTime.AddDays(-offset);
        }
    }
}
