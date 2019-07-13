using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using MikhailKhalizev.Processor.x86.Abstractions;

namespace MikhailKhalizev.Processor.x86.Utils
{
    // NOTE https://github.com/mbuchetics/RangeTree - A generic implementation of a centered interval tree in C#

    // TODO Rename to Intervals?

    public class UsedSpace<T> : IReadOnlyCollection<Interval<T>>
    {
        public static T MinValue { get; }
        public static T MaxValue { get; }

        public static readonly IComparer<T> Comparer = Comparer<T>.Default;
        public static readonly IEqualityComparer<T> EqualityComparer = EqualityComparer<T>.Default;

        private readonly SortedSet<Interval<T>> _spaces = new SortedSet<Interval<T>>(Interval<T>.BeginComparer);

        static UsedSpace()
        {
            var minSet = false;
            var maxSet = false;
            
            var fieldInfos = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (var info in fieldInfos)
            {
                if (info.Name == "MinValue")
                {
                    MinValue = (T) info.GetValue(null);
                    minSet = true;
                }
                else if(info.Name == "MaxValue")
                {
                    MaxValue = (T)info.GetValue(null);
                    maxSet = true;
                }

                if (minSet && maxSet)
                    break;
            }

            if (minSet && maxSet)
                return;


            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (var info in propertyInfos)
            {
                if (info.Name == "MinValue")
                {
                    MinValue = (T)info.GetValue(null);
                    minSet = true;
                }
                else if (info.Name == "MaxValue")
                {
                    MaxValue = (T)info.GetValue(null);
                    maxSet = true;
                }

                if (minSet && maxSet)
                    break;
            }

            if (minSet && maxSet)
                return;

            throw new NotImplementedException($"UsedSpace<T> for type {typeof(T)} not implemented.");
        }

        /// <summary>
        /// Добавляет область [begin, end).
        /// </summary>
        public Interval<T> Add(T begin, T end)
        {
            if (EqualityComparer.Equals(end, begin))
                throw new InvalidOperationException("Попытка добавить пустой промежуток.");

            if (Comparer.Compare(end, begin) < 0 && !EqualityComparer.Equals(end, MinValue))
                throw new InvalidOperationException("Попытка добавить промежуток отрицательной длины.");


            var view = _spaces.GetViewBetween(Interval.From(MinValue, default), Interval.From(begin, default));
            if (view.Count != 0)
            {
                var intervalBefore = view.Reverse().First();

                if (Comparer.Compare(begin, intervalBefore.End) <= 0 || EqualityComparer.Equals(intervalBefore.End, MinValue))
                    return SetEnd(intervalBefore, end);
            }


            view = _spaces.GetViewBetween(Interval.From(begin, default), Interval.From(MaxValue, default));
            if (view.Count != 0)
            {
                var intervalToCombine = view.First();

                if (Comparer.Compare(intervalToCombine.Begin, end) <= 0 || EqualityComparer.Equals(end, MinValue))
                {
                    var newInterval = Interval.From(begin, intervalToCombine.End);
                    _spaces.Remove(intervalToCombine);
                    _spaces.Add(newInterval);
                    return SetEnd(newInterval, end);
                }
            }


            var interval = Interval.From(begin, end);
            var ret = _spaces.Add(interval);
            if (ret == false)
                throw new InvalidOperationException("Элемент уже существует, хотя не должен.");

            return interval;
        }

        private Interval<T> SetEnd(Interval<T> interval, T end)
        {
            if (EqualityComparer.Equals(end, interval.Begin))
                throw new ArgumentOutOfRangeException("Попытка установить нулевую длину промежутка.");

            if (Comparer.Compare(end, interval.Begin) < 0 && !EqualityComparer.Equals(end, MinValue))
                throw new ArgumentOutOfRangeException("Попытка установить отрицательную длину промежутка.");


            var view = _spaces.GetViewBetween(interval, Interval.From(MaxValue, default));
            var last = interval;

            foreach (var next in view.Skip(1))
            {
                if (Comparer.Compare(end, next.Begin) < 0 && !EqualityComparer.Equals(end, MinValue))
                    break;

                last = next;
            }

            _spaces.GetViewBetween(interval, last).Clear();


            if (EqualityComparer.Equals(interval.End, MinValue) || EqualityComparer.Equals(end, MinValue))
                interval = Interval.From(interval.Begin, end);
            else
                interval = Interval.From(interval.Begin, Comparer.Compare(last.End, end) < 0 ? end : last.End);

            _spaces.Add(interval);

            return interval;
        }

        public Interval<T> Find(T val, bool withRightBound)
        {
            var view = _spaces.GetViewBetween(Interval.From(MinValue, default), Interval.From(val, default));
            if (view.Count == 0)
                return Interval<T>.Empty;

            var interval = view.Reverse().First();

            if (EqualityComparer.Equals(interval.End, MinValue))
                return interval;

            if (withRightBound)
            {
                if (Comparer.Compare(val, interval.End) <= 0)
                    return interval;
            }
            else
            {
                if (Comparer.Compare(val, interval.End) < 0)
                    return interval;
            }

            return Interval<T>.Empty;
        }

        public bool Contains(T val, bool withRightBound)
        {
            return !Find(val, withRightBound).IsEmpty;
        }

        public Interval<T> GetIntervalBefore(T begin)
        {
            var view = _spaces.GetViewBetween(Interval.From(MinValue, default), Interval.From(begin, default));

            return view.Reverse()
                .Where(x => Comparer.Compare(x.Begin, begin) < 0)
                .DefaultIfEmpty(Interval<T>.Empty)
                .First();
        }

        /// <summary>
        /// Возвращает интервал с наименьшим Begin содержащим область значений больше и равную value.
        /// </summary>
        public Interval<T> LowerBound(T value, bool withRightBound)
        {
            var view = _spaces.GetViewBetween(Interval.From(MinValue, default), Interval.From(value, default));
            
            if (view.Count != 0)
            {
                var interval = view.Reverse().First();

                if (EqualityComparer.Equals(interval.End, MinValue))
                    return interval;

                if (withRightBound)
                {
                    if (Comparer.Compare(value, interval.End) <= 0)
                        return interval;
                }
                else
                {
                    if (Comparer.Compare(value, interval.End) < 0)
                        return interval;
                }
            }

            return _spaces.GetViewBetween(Interval.From(value, default), Interval.From(MaxValue, default)).FirstOrDefault();
        }

        public string ToSpacesString()
        {
            if (_spaces.Count == 0)
                return "";

            var sb = new StringBuilder();
            foreach (var interval in _spaces)
            {
                var end = EqualityComparer.Equals(interval.End, MinValue) ? "∞" : interval.End.ToString();
                sb.Append($"{{{interval.Begin}, {end}}}, ");
            }

            sb.Length -= 2;
            return sb.ToString();
        }

        #region IReadOnlyCollection

        /// <inheritdoc />
        public IEnumerator<Interval<T>> GetEnumerator()
        {
            return _spaces.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_spaces).GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => _spaces.Count;

        #endregion
    }
}
