using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.Utils
{
    // @todo https://github.com/mbuchetics/RangeTree - A generic implementation of a centered interval tree in C#

    public class UsedSpace<T>
    {
        private static readonly IComparer<T> Comparer = Comparer<T>.Default;
        private static readonly IEqualityComparer<T> EqualityComparer = EqualityComparer<T>.Default;
        
        // [T start, T end)
        private readonly List<Interval<T>> _spaces = new List<Interval<T>>();
        
        /// <summary>
        /// Добавляет область [begin, end).
        /// </summary>
        public void Add(T begin, T end)
        {
            _spaces.Add(new Interval<T>(begin, end));
        }

        public bool Contains(T val, bool withRightBound = false)
        {
            return _spaces.Any(x => x.Contains(val, withRightBound));
        }
    }
}
