using System;
using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public class MySortedDictionary<TKey, TValue>
    {
        private readonly MyComparer _comparer;
        private readonly SortedDictionary<TKey, TValue> _dict;


        public MySortedDictionary()
        {
            _comparer = new MyComparer();
            _dict = new SortedDictionary<TKey, TValue>(_comparer);
        }

        public MySortedDictionary(IComparer<TKey> comparer)
        {
            _comparer = new MyComparer(comparer);
            _dict = new SortedDictionary<TKey, TValue>(_comparer);
        }

        public TValue this[TKey key]
        {
            get
            {
                if (_comparer.SearchNearest)
                    throw new NotImplementedException("SearchNearest is true");
                return _dict[key];
            }
            set
            {
                if (_comparer.SearchNearest)
                    throw new NotImplementedException("SearchNearest is true");
                _dict[key] = value;
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");
            return _dict.TryGetValue(key, out value);
        }

        public void Add(TKey key, TValue value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");
            _dict.Add(key, value);
        }

        public int Count => _dict.Count;

        public TKey FirstGreaterOrDefault(TKey value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");

            _comparer.SearchNearest = true;
            _comparer.SearchNearestGreater = true;
            try
            {
                _dict.TryGetValue(value, out var dummy);
                return _comparer.NearestFollowing;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        // GreaterOrEqual
        public TKey FirstNotLessOrDefault(TKey value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");

            _comparer.SearchNearest = true;
            try
            {
                if (_dict.TryGetValue(value, out var dummy))
                    return _comparer.NearestEqual;
                return _comparer.NearestFollowing;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        // LessOrEqual
        public TKey FirstNotGreaterOrDefault(TKey value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");

            _comparer.SearchNearest = true;
            try
            {
                if (_dict.TryGetValue(value, out var dummy))
                    return _comparer.NearestEqual;
                return _comparer.NearestPreceeding;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        public TKey FirstLessOrDefault(TKey value)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");

            _comparer.SearchNearest = true;
            _comparer.SearchNearestLess = true;
            try
            {
                _dict.TryGetValue(value, out var dummy);
                return _comparer.NearestPreceeding;
            }
            finally
            {
                _comparer.Reset();
            }
        }

        public IEnumerable<TKey> GreaterThat(TKey key)
        {
            if (_comparer.SearchNearest)
                throw new NotImplementedException("SearchNearest is true");
            
            var i = key;
            while (true)
            {
                _comparer.SearchNearest = true;
                _comparer.SearchNearestGreater = true;
                try
                {
                    _dict.TryGetValue(i, out var dummy);
                    if (!_comparer.NearestFollowingSet)
                        yield break;

                    i = _comparer.NearestFollowing;
                    yield return i;
                }
                finally
                {
                    _comparer.Reset();
                }
            }
        }

        private class MyComparer : IComparer<TKey>
        {
            public readonly IComparer<TKey> Original;

            public bool SearchNearest;
            public bool SearchNearestGreater;
            public bool SearchNearestLess;

            public TKey NearestPreceeding;
            public TKey NearestEqual;
            public TKey NearestFollowing;

            public bool NearestPreceedingSet;
            public bool NearestFollowingSet;


            public MyComparer()
                : this(Comparer<TKey>.Default)
            { }

            public MyComparer(IComparer<TKey> original)
            {
                Original = original;
            }

            public int Compare(TKey x, TKey y)
            {
                var comp = Original.Compare(x, y);

                if (!SearchNearest)
                    return comp;

                if (comp == 0)
                {
                    NearestEqual = y;

                    if (SearchNearestGreater)
                        return 1;
                    if (SearchNearestLess)
                        return -1;
                }

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
                NearestEqual = default;
                NearestPreceeding = default;
                
                NearestPreceedingSet = false;
                NearestFollowingSet = false;
            }
        }
    }
}