using System;
using System.Collections.Generic;
using System.Text;

namespace hw_16.Helpers
{
    public static class Algorithms
    {
        
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> MyOrderBy<T, TKey>(this IEnumerable<T> source, Func<T, TKey> keySelector)
            where TKey : IComparable<TKey>
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (keySelector == null) throw new ArgumentNullException(nameof(keySelector));

            List<T> list = new List<T>(source);
            int n = list.Count;

            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - 1 - i; j++)
                {
                    TKey keyJ = keySelector(list[j]);
                    TKey keyNext = keySelector(list[j + 1]);

                    if (keyJ.CompareTo(keyNext) > 0)
                    {
                        (list[j], list[j + 1]) = (list[j + 1], list[j]);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return list;
        }

        public static T MyFirst<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            foreach (var item in source)
            {
                return item;
            }
            throw new InvalidOperationException("Sequence contains no elements.");
        }

        public static T? MyFirstOrDefault<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            foreach (var item in source)
            {
                return item;
            }

            return default;
        }

        public static T MySingle<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            T? result = default;
            bool found = false;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    if (found)
                        throw new InvalidOperationException("Sequence contains more than one matching element");

                    result = item;
                    found = true;
                }
            }
            if (!found)
                throw new InvalidOperationException("Sequence contains no matching element");

            return result!;
        }

        public static T? MySingleOrDefault<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            T? result = default;
            bool found = false;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    if (found)
                        throw new InvalidOperationException("Sequence contains more than one matching element");

                    result = item;
                    found = true;
                }
            }

            return found ? result : default;
        }

        public static bool MyAny<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if (predicate(item))
                    return true;
            }

            return false;
        }

        public static bool MyAll<T>(this IEnumerable<T> source, Predicate<T> predicate)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if (!predicate(item))
                    return false;
            }

            return true;
        }

        public static int MyCount<T>(this IEnumerable<T> source, Predicate<T>? predicate = null)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            int count = 0;
            foreach (var item in source)
            {
                if (predicate == null || predicate(item))
                    count++;
            }

            return count;
        }

        public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> source)
        {
            if (source == null) throw new ArgumentNullException(nameof(source));

            HashSet<T> seen = new HashSet<T>();

            foreach (var item in source)
            {
                if (seen.Add(item))
                    yield return item;
            }
        }
    }
}