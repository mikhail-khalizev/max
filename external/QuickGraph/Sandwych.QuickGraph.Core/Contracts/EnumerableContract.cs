using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace QuickGraph.Contracts
{
    public static class EnumerableContract
    {
        [Pure]
        public static bool ElementsNotNull<T>(IEnumerable<T> elements)
        {
            Contract.Requires(elements != null);
#if DEBUG

            return Enumerable.All(elements, e => e != null);
#else
            return true;
#endif
        }

        [Pure]
        public static bool All(int lowerBound, int exclusiveUpperBound, Func<int, bool> predicate)
        {
          for (int i = lowerBound; i < exclusiveUpperBound; i++)
          {
            if (!predicate(i)) return false;
          }
          return true;
        }
    }
}
