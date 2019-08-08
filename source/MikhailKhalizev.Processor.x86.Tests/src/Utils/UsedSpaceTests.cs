using System.Linq;
using FluentAssertions;
using MikhailKhalizev.Processor.x86.Utils;
using Xunit;
using Xunit.Abstractions;

namespace MikhailKhalizev.Processor.x86.Tests.Utils
{
    public class UsedSpaceTests
    {
        public ITestOutputHelper OutputHelper { get; }

        public UsedSpaceTests(ITestOutputHelper outputHelper)
        {
            OutputHelper = outputHelper;
        }

        [Fact]
        public void AddTest()
        {
            var us = new UsedSpace<int>();

            us.ToSpacesString().Should().Be("");

            us.Add(5, 6);
            us.ToSpacesString().Should().Be("{5, 6}");
            
            us.Add(7, 8);
            us.ToSpacesString().Should().Be("{5, 6}, {7, 8}");

            us.Add(6, 7);
            us.ToSpacesString().Should().Be("{5, 8}");

            us.Add(4, 9);
            us.ToSpacesString().Should().Be("{4, 9}");

            us.Add(12, 13);
            us.ToSpacesString().Should().Be("{4, 9}, {12, 13}");

            us.Add(10, 11);
            us.ToSpacesString().Should().Be("{4, 9}, {10, 11}, {12, 13}");

            us.Add(14, 15);
            us.ToSpacesString().Should().Be("{4, 9}, {10, 11}, {12, 13}, {14, 15}");

            us.Add(6, 13);
            us.ToSpacesString().Should().Be("{4, 13}, {14, 15}");

            us.Add(3, 16);
            us.ToSpacesString().Should().Be("{3, 16}");

            us.Add(20, 25);
            us.ToSpacesString().Should().Be("{3, 16}, {20, 25}");

            us.Add(2, int.MinValue);
            us.ToSpacesString().Should().Be("{2, ∞}");
        }

        [Fact]
        public void FindTest()
        {
            var us = new UsedSpace<uint> { { 3, 5 }, { 10, 12 }, { 20, uint.MinValue } };
            us.ToSpacesString().Should().Be("{3, 5}, {10, 12}, {20, ∞}");

            us.FindIntervalThatContainsValue(0, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(0, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(1, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(1, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(3, false).Should().Be(Interval.From<uint>(3, 5));
            us.FindIntervalThatContainsValue(3, true).Should().Be(Interval.From<uint>(3, 5));

            us.FindIntervalThatContainsValue(4, false).Should().Be(Interval.From<uint>(3, 5));
            us.FindIntervalThatContainsValue(4, true).Should().Be(Interval.From<uint>(3, 5));

            us.FindIntervalThatContainsValue(5, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(5, true).Should().Be(Interval.From<uint>(3, 5));

            us.FindIntervalThatContainsValue(6, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(6, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(9, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(9, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(10, false).Should().Be(Interval.From<uint>(10, 12));
            us.FindIntervalThatContainsValue(10, true).Should().Be(Interval.From<uint>(10, 12));

            us.FindIntervalThatContainsValue(11, false).Should().Be(Interval.From<uint>(10, 12));
            us.FindIntervalThatContainsValue(11, true).Should().Be(Interval.From<uint>(10, 12));

            us.FindIntervalThatContainsValue(12, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(12, true).Should().Be(Interval.From<uint>(10, 12));

            us.FindIntervalThatContainsValue(13, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(13, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(19, false).Should().Be(Interval<uint>.Empty);
            us.FindIntervalThatContainsValue(19, true).Should().Be(Interval<uint>.Empty);

            us.FindIntervalThatContainsValue(20, false).Should().Be(Interval.From<uint>(20, 0));
            us.FindIntervalThatContainsValue(20, true).Should().Be(Interval.From<uint>(20, 0));

            us.FindIntervalThatContainsValue(21, false).Should().Be(Interval.From<uint>(20, 0));
            us.FindIntervalThatContainsValue(21, true).Should().Be(Interval.From<uint>(20, 0));

            us.FindIntervalThatContainsValue(uint.MaxValue, false).Should().Be(Interval.From<uint>(20, 0));
            us.FindIntervalThatContainsValue(uint.MaxValue, true).Should().Be(Interval.From<uint>(20, 0));
        }
        
        [Fact]
        public void ContainsTest()
        {
            var us = new UsedSpace<uint> { { 3, 5 }, { 10, 12 }, { 20, uint.MinValue } };
            us.ToSpacesString().Should().Be("{3, 5}, {10, 12}, {20, ∞}");

            us.Contains(0, false).Should().BeFalse();
            us.Contains(0, true).Should().BeFalse();

            us.Contains(1, false).Should().BeFalse();
            us.Contains(1, true).Should().BeFalse();

            us.Contains(3, false).Should().BeTrue();
            us.Contains(3, true).Should().BeTrue();

            us.Contains(4, false).Should().BeTrue();
            us.Contains(4, true).Should().BeTrue();

            us.Contains(5, false).Should().BeFalse();
            us.Contains(5, true).Should().BeTrue();

            us.Contains(6, false).Should().BeFalse();
            us.Contains(6, true).Should().BeFalse();

            us.Contains(9, false).Should().BeFalse();
            us.Contains(9, true).Should().BeFalse();

            us.Contains(10, false).Should().BeTrue();
            us.Contains(10, true).Should().BeTrue();

            us.Contains(11, false).Should().BeTrue();
            us.Contains(11, true).Should().BeTrue();

            us.Contains(12, false).Should().BeFalse();
            us.Contains(12, true).Should().BeTrue();

            us.Contains(13, false).Should().BeFalse();
            us.Contains(13, true).Should().BeFalse();

            us.Contains(19, false).Should().BeFalse();
            us.Contains(19, true).Should().BeFalse();

            us.Contains(20, false).Should().BeTrue();
            us.Contains(20, true).Should().BeTrue();

            us.Contains(21, false).Should().BeTrue();
            us.Contains(21, true).Should().BeTrue();

            us.Contains(uint.MaxValue, false).Should().BeTrue();
            us.Contains(uint.MaxValue, true).Should().BeTrue();
        }
        
        [Fact]
        public void LowerBoundTest()
        {
            var us = new UsedSpace<uint> { { 3, 5 }, { 10, 12 }, { 20, uint.MinValue } };
            us.ToSpacesString().Should().Be("{3, 5}, {10, 12}, {20, ∞}");

            us.LowerBound(0, false).Should().Be(Interval.From<uint>(3, 5));
            us.LowerBound(0, true).Should().Be(Interval.From<uint>(3, 5));

            us.LowerBound(1, false).Should().Be(Interval.From<uint>(3, 5));
            us.LowerBound(1, true).Should().Be(Interval.From<uint>(3, 5));

            us.LowerBound(3, false).Should().Be(Interval.From<uint>(3, 5));
            us.LowerBound(3, true).Should().Be(Interval.From<uint>(3, 5));

            us.LowerBound(4, false).Should().Be(Interval.From<uint>(3, 5));
            us.LowerBound(4, true).Should().Be(Interval.From<uint>(3, 5));

            us.LowerBound(5, false).Should().Be(Interval.From<uint>(10, 12));
            us.LowerBound(5, true).Should().Be(Interval.From<uint>(3, 5));

            us.LowerBound(6, false).Should().Be(Interval.From<uint>(10, 12));
            us.LowerBound(6, true).Should().Be(Interval.From<uint>(10, 12));

            us.LowerBound(9, false).Should().Be(Interval.From<uint>(10, 12));
            us.LowerBound(9, true).Should().Be(Interval.From<uint>(10, 12));

            us.LowerBound(10, false).Should().Be(Interval.From<uint>(10, 12));
            us.LowerBound(10, true).Should().Be(Interval.From<uint>(10, 12));

            us.LowerBound(11, false).Should().Be(Interval.From<uint>(10, 12));
            us.LowerBound(11, true).Should().Be(Interval.From<uint>(10, 12));

            us.LowerBound(12, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(12, true).Should().Be(Interval.From<uint>(10, 12));

            us.LowerBound(13, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(13, true).Should().Be(Interval.From<uint>(20, 0));

            us.LowerBound(19, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(19, true).Should().Be(Interval.From<uint>(20, 0));

            us.LowerBound(20, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(20, true).Should().Be(Interval.From<uint>(20, 0));

            us.LowerBound(21, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(21, true).Should().Be(Interval.From<uint>(20, 0));

            us.LowerBound(uint.MaxValue, false).Should().Be(Interval.From<uint>(20, 0));
            us.LowerBound(uint.MaxValue, true).Should().Be(Interval.From<uint>(20, 0));
        }
    }
}