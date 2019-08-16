using System.Collections;
using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public class MySortedSet<T> : IReadOnlyCollection<T>
    {
        private readonly MyComparer _comparer;
        private readonly SortedSet<T> _set;


        public MySortedSet()
        {
            _comparer = new MyComparer();
            _set = new SortedSet<T>(_comparer);
        }

        public MySortedSet(IComparer<T> comparer)
        {
            _comparer = new MyComparer(comparer);
            _set = new SortedSet<T>(_comparer);
        }

        public MySortedSet(IEnumerable<T> collection)
        {
            _comparer = new MyComparer();
            _set = new SortedSet<T>(collection, _comparer);
        }

        public MySortedSet(IEnumerable<T> collection, IComparer<T> comparer)
        {
            _comparer = new MyComparer(comparer);
            _set = new SortedSet<T>(collection, _comparer);
        }


        public void Clear() => _set.Clear();
        
        public bool Add(T item) => _set.Add(item);

        public bool TryGetValue(T equalValue, out T actualValue) => _set.TryGetValue(equalValue, out actualValue);

        public bool Remove(T item) => _set.Remove(item);

        public int Count => _set.Count;

        public bool Contains(T item) => _set.Contains(item);

        public T FirstGreaterOrDefault(T value)
        {
            _comparer.SearchNearest = true;
            _comparer.SearchNearestGreater = true;
            try
            {
                _set.TryGetValue(value, out var dummy);
                return _comparer.NearestFollowing;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        // GreaterOrEqual
        public T FirstNotLessOrDefault(T value)
        {
            _comparer.SearchNearest = true;
            try
            {
                if (_set.TryGetValue(value, out var actual))
                    return actual;
                return _comparer.NearestFollowing;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        // LessOrEqual
        public T FirstNotGreaterOrDefault(T value)
        {
            _comparer.SearchNearest = true;
            try
            {
                if (_set.TryGetValue(value, out var actual))
                    return actual;
                return _comparer.NearestPreceeding;
            }
            finally
            {
                _comparer.Reset();
            }
        }
        
        public T FirstLessOrDefault(T value)
        {
            _comparer.SearchNearest = true;
            _comparer.SearchNearestLess = true;
            try
            {
                _set.TryGetValue(value, out var dummy);
                return _comparer.NearestPreceeding;
            }
            finally
            {
                _comparer.Reset();
            }
        }


        public T[] ToArray()
        {
            var arr = new T[_set.Count];
            var i = 0;
            foreach (var x in _set)
                arr[i++] = x;
            return arr;
        }
        
        public List<T> ToList()
        {
            var list = new List<T>(_set.Count);
            foreach (var x in _set)
                list.Add(x);
            return list;
        }

        /// <inheritdoc />
        public IEnumerator<T> GetEnumerator() => _set.GetEnumerator();

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)_set).GetEnumerator();

        private class MyComparer : IComparer<T>
        {
            public readonly IComparer<T> Original;
            
            public bool SearchNearest;
            public bool SearchNearestGreater;
            public bool SearchNearestLess;
            
            public T NearestPreceeding;
            public T NearestFollowing;
            
            private bool NearestPreceedingSet;
            private bool NearestFollowingSet;


            public MyComparer()
                : this(Comparer<T>.Default)
            { }

            public MyComparer(IComparer<T> original)
            {
                Original = original;
            }

            public int Compare(T x, T y)
            {
                var comp = Original.Compare(x, y);

                if (!SearchNearest)
                    return comp;

                if (comp == 0 && SearchNearestGreater)
                    return 1;
                if (comp == 0 && SearchNearestLess)
                    return -1;
                    
                if (0 < comp /* y < x */ &&
                    (!NearestPreceedingSet || Original.Compare(NearestPreceeding, y) < 0))
                {
                    NearestPreceeding = y;
                    NearestPreceedingSet = true;
                }

                if (comp < 0 /* x < y */ &&
                    (!NearestFollowingSet || Original.Compare(y, NearestFollowing) < 0))
                {
                    NearestFollowing = y;
                    NearestFollowingSet = true;
                }

                return comp;
            }

            public void Reset()
            {
                SearchNearest = false;
                SearchNearestGreater = false;
                SearchNearestLess = false;
                NearestFollowing = default;
                NearestPreceedingSet = false;
                NearestPreceeding = default;
                NearestFollowingSet = false;
            }
        }
    }
}
