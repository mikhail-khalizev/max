using FluentAssertions;
using MikhailKhalizev.Processor.x86.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Utils
{
    public class MySortedSetTests
    {
        [Fact]
        public void FirstGreater()
        {
            var set = new MySortedSet<Interval<int>>(
                new[] { Interval.From(10, 11), Interval.From(20, 21), Interval.From(30, 31) },
                Interval<int>.BeginComparer);
            
            set.FirstGreaterOrDefault(Interval.From(5, 0)).Should().Be(Interval.From(10, 11));
            set.FirstGreaterOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(20, 21));
            set.FirstGreaterOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(20, 21));
            set.FirstGreaterOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(30, 31));
            set.FirstGreaterOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(30, 31));
            set.FirstGreaterOrDefault(Interval.From(30, 0)).Should().Be(Interval<int>.Empty);
            set.FirstGreaterOrDefault(Interval.From(35, 0)).Should().Be(Interval<int>.Empty);
        }

        [Fact]
        public void FirstNotLess()
        {
            var set = new MySortedSet<Interval<int>>(
                new[] { Interval.From(10, 11), Interval.From(20, 21), Interval.From(30, 31) },
                Interval<int>.BeginComparer);

            set.FirstNotLessOrDefault(Interval.From(5, 0)).Should().Be(Interval.From(10, 11));
            set.FirstNotLessOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(10, 11));
            set.FirstNotLessOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(20, 21));
            set.FirstNotLessOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(20, 21));
            set.FirstNotLessOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(30, 31));
            set.FirstNotLessOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(30, 31));
            set.FirstNotLessOrDefault(Interval.From(35, 0)).Should().Be(Interval<int>.Empty);
        }

        [Fact]
        public void FirstNotGreater()
        {
            var set = new MySortedSet<Interval<int>>(
                new[] { Interval.From(10, 11), Interval.From(20, 21), Interval.From(30, 31) },
                Interval<int>.BeginComparer);

            set.FirstNotGreaterOrDefault(Interval.From(5, 0)).Should().Be(Interval<int>.Empty);
            set.FirstNotGreaterOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(10, 11));
            set.FirstNotGreaterOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(10, 11));
            set.FirstNotGreaterOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(20, 21));
            set.FirstNotGreaterOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(20, 21));
            set.FirstNotGreaterOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(30, 31));
            set.FirstNotGreaterOrDefault(Interval.From(35, 0)).Should().Be(Interval.From(30, 31));
        }

        [Fact]
        public void FirstLess()
        {
            var set = new MySortedSet<Interval<int>>(
                new[] { Interval.From(10, 11), Interval.From(20, 21), Interval.From(30, 31) },
                Interval<int>.BeginComparer);

            set.FirstLessOrDefault(Interval.From(5, 0)).Should().Be(Interval<int>.Empty);
            set.FirstLessOrDefault(Interval.From(10, 0)).Should().Be(Interval<int>.Empty);
            set.FirstLessOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(10, 11));
            set.FirstLessOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(10, 11));
            set.FirstLessOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(20, 21));
            set.FirstLessOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(20, 21));
            set.FirstLessOrDefault(Interval.From(35, 0)).Should().Be(Interval.From(30, 31));
        }
    }
}