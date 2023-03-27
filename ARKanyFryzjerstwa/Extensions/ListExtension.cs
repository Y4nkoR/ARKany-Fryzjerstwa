namespace ARKanyFryzjerstwa.Extensions
{
    public static class ListExtension
    {
        /// <summary> Sprawdza, czy lista jest pusta lub równa null.</summary>
        /// <param name="list"> Lista do sprawdzenia. </param>
        /// <returns> True, jeśli lista jest pusta lub równa null.</returns>
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list == null || list.Count == 0;
        }

        /// <summary> Losowo sortuje elementy obiektu <see cref="IEnumerable{T}"/>.</summary>
        /// <param name="values"> Obiekt <see cref="IEnumerable{T}"/> do sprawdzenia. </param>
        /// <returns> Losowo posortowany obiekt <see cref="IEnumerable{T}"/>.</returns>
        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> values)
        {
            return values.OrderBy(x => Guid.NewGuid());
        }

        /// <summary> Sprawdza, czy lista jest równa innej liście.</summary>
        /// <param name="list1"> Pierwsza lista. </param>
        /// <param name="list2"> Druga lista. </param>
        /// <returns> True, jeśli listy są równe.</returns>
        public static bool IsEqualTo<T>(this IList<T> list1, IList<T> list2)
        {
            if (list1 == null || list2 == null)
            {
                return false;
            }

            var firstNotSecond = list1.Except(list2).Any();
            var secondNotFirst = list2.Except(list1).Any();

            return !firstNotSecond && !secondNotFirst;
        }
    }
}
