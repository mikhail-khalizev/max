using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MikhailKhalizev.Processor.x86.Utils
{
    // NOTE https://github.com/mbuchetics/RangeTree - A generic implementation of a centered interval tree in C#

    public class IntervalCollection<T> : IReadOnlyCollection<Interval<T>>
    {
        public static T MinValue { get; }
        public static T MaxValue { get; }

        public static readonly IComparer<T> Comparer = Comparer<T>.Default;
        public static readonly IEqualityComparer<T> EqualityComparer = EqualityComparer<T>.Default;

        private readonly MySortedSet<Interval<T>> _ranges = new MySortedSet<Interval<T>>(Interval<T>.BeginComparer);

        static IntervalCollection()
        {
            var minSet = false;
            var maxSet = false;

            var fieldInfos = typeof(T).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy);

            foreach (var info in fieldInfos)
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


            throw new NotImplementedException($"{nameof(IntervalCollection<T>)} can't detect MinValue and MaxValue of type {typeof(T)}.");
        }

        public void Clear() => _ranges.Clear();

        /// <summary>
        /// Добавляет область [begin, end).
        /// </summary>
        public Interval<T> Add(T begin, T end)
        {
            if (EqualityComparer.Equals(end, begin))
            {
                // throw new InvalidOperationException("Попытка добавить пустой промежуток.");
                return Interval.From(begin, end);
            }

            if (Comparer.Compare(end, begin) < 0 && !EqualityComparer.Equals(end, MinValue))
            {
                // throw new InvalidOperationException("Попытка добавить промежуток отрицательной длины.");
                return Interval.From(begin, end);
            }


            var intervalBefore = _ranges.FirstNotGreaterOrDefault(Interval.From(begin, default));
            if (intervalBefore != default)
            {
                if (Comparer.Compare(begin, intervalBefore.End) <= 0 || EqualityComparer.Equals(intervalBefore.End, MinValue))
                    return SetEnd(intervalBefore, end);
            }


            var intervalToCombine = _ranges.FirstNotLessOrDefault(Interval.From(begin, default));
            if (intervalToCombine != default)
            {
                if (Comparer.Compare(intervalToCombine.Begin, end) <= 0 || EqualityComparer.Equals(end, MinValue))
                {
                    var newInterval = Interval.From(begin, intervalToCombine.End);
                    _ranges.Remove(intervalToCombine);
                    _ranges.Add(newInterval);
                    return SetEnd(newInterval, end);
                }
            }


            var interval = Interval.From(begin, end);
            if (!_ranges.Add(interval))
                throw new InvalidOperationException("Элемент уже существует, хотя не должен.");

            return interval;
        }

        private Interval<T> SetEnd(Interval<T> interval, T end)
        {
            if (EqualityComparer.Equals(end, interval.Begin))
                throw new ArgumentOutOfRangeException("Попытка установить нулевую длину промежутка.");

            if (Comparer.Compare(end, interval.Begin) < 0 && !EqualityComparer.Equals(end, MinValue))
                throw new ArgumentOutOfRangeException("Попытка установить отрицательную длину промежутка.");


            var last = interval;
            while (true)
            {
                var next = _ranges.FirstGreaterOrDefault(interval);
                if (next == default)
                    break;
                if (Comparer.Compare(end, next.Begin) < 0 && !EqualityComparer.Equals(end, MinValue))
                    break;
                _ranges.Remove(next);
                last = next;
            }

            _ranges.Remove(interval);


            if (EqualityComparer.Equals(interval.End, MinValue) || EqualityComparer.Equals(end, MinValue))
                interval = Interval.From(interval.Begin, end);
            else
                interval = Interval.From(interval.Begin, Comparer.Compare(last.End, end) < 0 ? end : last.End);

            _ranges.Add(interval);

            return interval;
        }

        public Interval<T> FindIntervalThatContainsValue(T val, bool withRightBound)
        {
            var interval = _ranges.FirstNotGreaterOrDefault(Interval.From(val, default));
            if (interval == default)
                return Interval<T>.Empty;

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
            return !FindIntervalThatContainsValue(val, withRightBound).IsEmpty;
        }

        public Interval<T> GetIntervalBefore(T begin)
        {
            return _ranges.FirstLessOrDefault(Interval.From(begin, default));
        }

        /// <summary>
        /// Возвращает интервал с наименьшим Begin содержащим область со значениями больше и равными value.
        /// </summary>
        public Interval<T> LowerBound(T value, bool withRightBound)
        {
            var interval = _ranges.FirstNotGreaterOrDefault(Interval.From(value, default));

            if (interval != default)
            {
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

            return _ranges.FirstNotLessOrDefault(Interval.From(value, default));
        }

        public string ToIntervalsString()
        {
            if (_ranges.Count == 0)
                return "";

            var sb = new StringBuilder();
            foreach (var interval in _ranges)
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
            return _ranges.GetEnumerator();
        }

        /// <inheritdoc />
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)_ranges).GetEnumerator();
        }

        /// <inheritdoc />
        public int Count => _ranges.Count;

        #endregion
    }
}
