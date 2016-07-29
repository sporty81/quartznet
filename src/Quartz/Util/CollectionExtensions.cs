using System.Collections.Generic;
using System.Linq;

namespace Quartz.Util
{
    /// <summary>
    /// Extension methods for <see cref="IDictionary{TKey,TValue}" />.
    /// </summary>
    public static class DictionaryExtensions
    {
        /// <summary>
        /// Tries to read value and returns the value if successfully read. Otherwise return default value
        /// for value's type.
        /// </summary>
        /// <typeparam name="TKey"></typeparam>
        /// <typeparam name="TValue"></typeparam>
        /// <param name="dictionary"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static TValue TryGetAndReturn<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
        {
            TValue retValue;
            if (!dictionary.TryGetValue(key, out retValue))
            {
                retValue = default(TValue);
            }
            return retValue;
        }

        public static IEnumerable<List<T>> InSetsOf<T>(this IEnumerable<T> source, int max)
        {
            List<T> toReturn = new List<T>(max);
            foreach (var item in source)
            {
                toReturn.Add(item);
                if (toReturn.Count == max)
                {
                    yield return toReturn;
                    toReturn = new List<T>(max);
                }
            }
            if (toReturn.Any())
            {
                yield return toReturn;
            }
        }
    }
}