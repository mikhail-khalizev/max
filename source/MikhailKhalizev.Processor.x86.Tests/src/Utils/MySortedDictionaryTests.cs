using FluentAssertions;
using MikhailKhalizev.Processor.x86.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests.Utils
{
    public class MySortedDictionaryTests
    {
        [Fact]
        public void FirstGreater()
        {
            var dict = new MySortedDictionary<Interval<int>, object>(Interval<int>.BeginComparer);
            dict[Interval.From(10, 11)] = null;
            dict[Interval.From(20, 21)] = null;
            dict[Interval.From(30, 31)] = null;
            
            dict.FirstGreaterOrDefault(Interval.From(5, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstGreaterOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstGreaterOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstGreaterOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(30, 31));
            dict.FirstGreaterOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(30, 31));
            dict.FirstGreaterOrDefault(Interval.From(30, 0)).Should().Be(Interval<int>.Empty);
            dict.FirstGreaterOrDefault(Interval.From(35, 0)).Should().Be(Interval<int>.Empty);
        }

        [Fact]
        public void FirstNotLess()
        {
            var dict = new MySortedDictionary<Interval<int>, object>(Interval<int>.BeginComparer);
            dict[Interval.From(10, 11)] = null;
            dict[Interval.From(20, 21)] = null;
            dict[Interval.From(30, 31)] = null;

            dict.FirstNotLessOrDefault(Interval.From(5, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstNotLessOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstNotLessOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstNotLessOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstNotLessOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(30, 31));
            dict.FirstNotLessOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(30, 31));
            dict.FirstNotLessOrDefault(Interval.From(35, 0)).Should().Be(Interval<int>.Empty);
        }

        [Fact]
        public void FirstNotGreater()
        {
            var dict = new MySortedDictionary<Interval<int>, object>(Interval<int>.BeginComparer);
            dict[Interval.From(10, 11)] = null;
            dict[Interval.From(20, 21)] = null;
            dict[Interval.From(30, 31)] = null;

            dict.FirstNotGreaterOrDefault(Interval.From(5, 0)).Should().Be(Interval<int>.Empty);
            dict.FirstNotGreaterOrDefault(Interval.From(10, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstNotGreaterOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstNotGreaterOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstNotGreaterOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstNotGreaterOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(30, 31));
            dict.FirstNotGreaterOrDefault(Interval.From(35, 0)).Should().Be(Interval.From(30, 31));
        }

        [Fact]
        public void FirstLess()
        {
            var dict = new MySortedDictionary<Interval<int>, object>(Interval<int>.BeginComparer);
            dict[Interval.From(10, 11)] = null;
            dict[Interval.From(20, 21)] = null;
            dict[Interval.From(30, 31)] = null;

            dict.FirstLessOrDefault(Interval.From(5, 0)).Should().Be(Interval<int>.Empty);
            dict.FirstLessOrDefault(Interval.From(10, 0)).Should().Be(Interval<int>.Empty);
            dict.FirstLessOrDefault(Interval.From(15, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstLessOrDefault(Interval.From(20, 0)).Should().Be(Interval.From(10, 11));
            dict.FirstLessOrDefault(Interval.From(25, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstLessOrDefault(Interval.From(30, 0)).Should().Be(Interval.From(20, 21));
            dict.FirstLessOrDefault(Interval.From(35, 0)).Should().Be(Interval.From(30, 31));
        }
    }
}