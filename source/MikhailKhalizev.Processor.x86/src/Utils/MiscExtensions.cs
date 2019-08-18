using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public static class MiscExtensions
    {
        public static int IndexOf<T>(
            [CanBeNull] this IEnumerable<T> source,
            T value,
            int defaultIfNotFound = -1)
        {
            if (source == null)
                return defaultIfNotFound;

            return source
                .Select((x, i) => new { Value = x, Index = i })
                .Where(x => Equals(x.Value, value))
                .Select(x => x.Index)
                .DefaultIfEmpty(defaultIfNotFound)
                .First();
        }

        public static int IndexOf<T>(
            [CanBeNull] this IEnumerable<T> source,
            Func<T, bool> condition,
            int defaultIfNotFound = -1)
        {
            if (source == null)
                return defaultIfNotFound;

            return source
                .Select((x, i) => new { Value = x, Index = i })
                .Where(x => condition(x.Value))
                .Select(x => x.Index)
                .DefaultIfEmpty(defaultIfNotFound)
                .First();
        }
    }
}