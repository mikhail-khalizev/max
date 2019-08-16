using System;
using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public struct Interval
    {
        public static Interval<Address, Address.Comparer> From(Address begin, Address end) => new Interval<Address, Address.Comparer>(begin, end);

        public static Interval<T> From<T>(T begin, T end) => new Interval<T>(begin, end);

        public static Interval<T> Empty<T>(T dummy = default) => Interval<T>.Empty;
    }
    
    /// <summary>
    /// Интервал начиная с <see cref="Begin"/> и заканчивая <see cref="End"/> не включая последний.
    /// Другими словами [Begin, End).
    /// </summary>
    public struct Interval<T, TComparer> : IEquatable<Interval<T, TComparer>>
        where TComparer : IComparer<T>
    {
        private static readonly TComparer Comparer;

        static Interval()
        {
            if (typeof(TComparer) == typeof(IComparer<T>))
                Comparer = (TComparer) (object) Comparer<T>.Default;
        }


        public T Begin { get; }
        public T End { get; }

        public static Interval<T, TComparer> Empty => default;
        public bool IsEmpty => Comparer.Compare(Begin, End) == 0;


        public Interval(T begin, T end)
        {
            Begin = begin;
            End = end;
        }

        /// <summary>
        /// Проверяет, принадлежит ли значение интервалу [Begin, End).
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="withRightBound">true, если необходимо проверить на принадлежность интервалу [Begin, End]; иначе - false.</param>
        /// <returns>true - если принадлежит, false - если не принадлежит.</returns>
        public bool Contains(T value, bool withRightBound = false)
        {
            var r = Comparer.Compare(value, End);
            return Comparer.Compare(Begin, value) <= 0 && (r < 0 || (withRightBound && r == 0));
        }

        /// <summary>
        /// Проверяет, содержится ли интервал <paramref name="value"/> в текущем интервале.
        /// </summary>
        /// <param name="value">Интервал.</param>
        /// <returns>true - если содержится, false - если не содержится.</returns>
        public bool Contains(Interval<T, TComparer> value)
        {
            return Comparer.Compare(Begin, value.Begin) <= 0 && Comparer.Compare(value.End, End) <= 0;
        }

        /// <summary>
        /// Находит пересечение интервала <paramref name="value"/> с текущим интервалом.
        /// </summary>
        /// <param name="value">Интервал.</param>
        /// <returns>Если интервалы имеют общие точки, то интервал, иначе - <see cref="Empty"/>.</returns>
        public Interval<T, TComparer> Intersect(Interval<T, TComparer> value)
        {
            var end = Comparer.Compare(End, value.End) < 0 ? End : value.End;
            var begin = Comparer.Compare(Begin, value.Begin) < 0 ? value.Begin : Begin;
            return Comparer.Compare(begin, end) < 0 ? new Interval<T, TComparer>(begin, end) : Empty;
        }

        public Interval<T, TComparer> Combine(Interval<T, TComparer> value)
        {
            var endI = Comparer.Compare(End, value.End) < 0 ? End : value.End;
            var beginI = Comparer.Compare(Begin, value.Begin) < 0 ? value.Begin : Begin;
            if (Comparer.Compare(endI, beginI) < 0)
                return Empty;

            var end = Comparer.Compare(End, value.End) < 0 ? value.End : End;
            var begin = Comparer.Compare(Begin, value.Begin) < 0 ? Begin : value.Begin;
            return new Interval<T, TComparer>(begin, end);
        }

        public bool IsIntersects(Interval<T, TComparer> b, bool considerTouch = true)
        {
            return considerTouch
                ? (Comparer.Compare(Begin, b.End) <= 0) & (Comparer.Compare(End, b.Begin) >= 0)
                : (Comparer.Compare(Begin, b.End) < 0) & (Comparer.Compare(End, b.Begin) > 0);
        }

        public IEnumerable<Interval<T, TComparer>> Subtract(Interval<T, TComparer> sub)
        {
            if (Comparer.Compare(sub.End, Begin) <= 0 || Comparer.Compare(End, sub.Begin) <= 0)
            {
                yield return this;
                yield break;
            }

            if (Comparer.Compare(Begin, sub.Begin) <= 0)
            {
                var result = new Interval<T, TComparer>(Begin, sub.Begin);
                if (!result.IsEmpty)
                    yield return result;
            }

            if (Comparer.Compare(sub.End, End) <= 0)
            {
                var result = new Interval<T, TComparer>(sub.End, End);
                if (!result.IsEmpty)
                    yield return result;
            }
        }

        public IEnumerable<Interval<T, TComparer>> Subtract(IEnumerable<Interval<T, TComparer>> subs)
        {
            var result = new List<Interval<T, TComparer>> { this };
            foreach (var interval in subs)
            {
                result = result.SelectMany(x => x.Subtract(interval)).ToList();
                if (result.Count == 0)
                    break;
            }

            return result;
        }

        public IEnumerable<Interval<T, TComparer>> Split(T point)
        {
            if (Comparer.Compare(Begin, point) < 0 && Comparer.Compare(point, End) < 0)
            {
                yield return new Interval<T, TComparer>(Begin, point);
                yield return new Interval<T, TComparer>(point, End);
            }
            else
                yield return this;
        }

        public IEnumerable<Interval<T, TComparer>> Split(Interval<T, TComparer> interval)
        {
            return Split(interval.Begin).SelectMany(x => x.Split(interval.End));
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"[{Begin}, {End})";
        }

        #region IEquatable

        /// <summary>Показывает, равен ли этот экземпляр заданному объекту.</summary>
        /// <returns>Значение true, если <paramref name="obj" /> и данный экземпляр относятся к одному типу и представляют одинаковые значения; в противном случае — значение false. </returns>
        /// <param name="obj">Объект для сравнения с текущим экземпляром. </param>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            return obj is Interval<T, TComparer> interval && Equals(interval);
        }

        public bool Equals(Interval<T, TComparer> other)
        {
            return Begin.Equals(other.Begin) && End.Equals(other.End);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (Begin.GetHashCode() * 397) ^ End.GetHashCode();
            }
        }

        /// <summary>Returns a value that indicates whether the values of two <see cref="T:Exo.Processor.x86.BinToCSharp.Interval" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(Interval<T, TComparer> left, Interval<T, TComparer> right)
        {
            return left.Equals(right);
        }

        /// <summary>Returns a value that indicates whether two <see cref="T:Exo.Processor.x86.BinToCSharp.Interval" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(Interval<T, TComparer> left, Interval<T, TComparer> right)
        {
            return !left.Equals(right);
        }

        #endregion


        public static IComparer<Interval<T, TComparer>> BeginComparer =>
            new CustomComparer<Interval<T, TComparer>>(
                (x, y) => Comparer.Compare(x.Begin, y.Begin));
    }

    /// <summary>
    /// Интервал начиная с <see cref="Begin"/> и заканчивая <see cref="End"/> не включая последний.
    /// Другими словами [Begin, End).
    /// </summary>
    public struct Interval<T> : IEquatable<Interval<T>>
    {
        private Interval<T, IComparer<T>> _impl;

        public T Begin => _impl.Begin;
        public T End => _impl.End;

        public static Interval<T> Empty => default;
        public bool IsEmpty => _impl.IsEmpty;

        
        public Interval(T begin, T end)
        {
            _impl = new Interval<T, IComparer<T>>(begin, end);
        }

        public Interval(Interval<T, IComparer<T>> interval)
        {
            _impl = interval;
        }


        /// <summary>
        /// Проверяет, принадлежит ли значение интервалу [Begin, End).
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="withRightBound">true, если необходимо проверить на принадлежность интервалу [Begin, End]; иначе - false.</param>
        /// <returns>true - если принадлежит, false - если не принадлежит.</returns>
        public bool Contains(T value, bool withRightBound = false) => _impl.Contains(value, withRightBound);

        /// <summary>
        /// Проверяет, содержится ли интервал <paramref name="value"/> в текущем интервале.
        /// </summary>
        /// <param name="value">Интервал.</param>
        /// <returns>true - если содержится, false - если не содержится.</returns>
        public bool Contains(Interval<T> value) => _impl.Contains(value);

        /// <summary>
        /// Находит пересечение интервала <paramref name="value"/> с текущим интервалом.
        /// </summary>
        /// <param name="value">Интервал.</param>
        /// <returns>Если интервалы имеют общие точки, то интервал, иначе - <see cref="Empty"/>.</returns>
        public Interval<T> Intersect(Interval<T> value) => _impl.Intersect(value);

        public Interval<T> Combine(Interval<T> value) => _impl.Combine(value);

        public bool IsIntersects(Interval<T> b, bool considerTouch = true) => _impl.IsIntersects(b, considerTouch);

        public IEnumerable<Interval<T>> Subtract(Interval<T> sub) => _impl.Subtract(sub).Select(x => new Interval<T>(x));

        public IEnumerable<Interval<T>> Subtract(IEnumerable<Interval<T>> subs) => _impl.Subtract(subs.Select(x => x._impl)).Select(x => new Interval<T>(x));

        public IEnumerable<Interval<T>> Split(T point) => _impl.Split(point).Select(x => new Interval<T>(x));

        public IEnumerable<Interval<T>> Split(Interval<T> interval) => _impl.Split(interval).Select(x => new Interval<T>(x));

        /// <inheritdoc />
        public override string ToString() => _impl.ToString();


        #region IEquatable

        /// <summary>Показывает, равен ли этот экземпляр заданному объекту.</summary>
        /// <returns>Значение true, если <paramref name="obj" /> и данный экземпляр относятся к одному типу и представляют одинаковые значения; в противном случае — значение false. </returns>
        /// <param name="obj">Объект для сравнения с текущим экземпляром. </param>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            return obj is Interval<T> interval && Equals(interval);
        }

        public bool Equals(Interval<T> other) => _impl.Equals(other);

        public override int GetHashCode() => _impl.GetHashCode();

        /// <summary>Returns a value that indicates whether the values of two <see cref="T:Exo.Processor.x86.BinToCSharp.Interval" /> objects are equal.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        public static bool operator ==(Interval<T> left, Interval<T> right) => left._impl == right._impl;

        /// <summary>Returns a value that indicates whether two <see cref="T:Exo.Processor.x86.BinToCSharp.Interval" /> objects have different values.</summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        public static bool operator !=(Interval<T> left, Interval<T> right) => left._impl != right._impl;

        #endregion

        
        public static implicit operator Interval<T>(Interval<T, IComparer<T>> interval) => new Interval<T>(interval);
        public static implicit operator Interval<T, IComparer<T>>(Interval<T> interval) => interval._impl;

        public static IComparer<Interval<T>> BeginComparer =>
            new CustomComparer<Interval<T>>(
                (x, y) => Interval<T, IComparer<T>>.BeginComparer.Compare(x, y));
    }
}