using System;
using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public class CustomComparer<T> : IComparer<T>
    {
        private readonly Func<T, T, int> _compare;

        public CustomComparer(Func<T, T, int> compare)
        {
            _compare = compare;
        }

        /// <inheritdoc />
        public int Compare(T x, T y)
        {
            return _compare(x, y);
        }
    }
}