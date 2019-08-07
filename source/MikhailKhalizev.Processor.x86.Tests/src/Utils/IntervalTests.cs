using FluentAssertions;
using MikhailKhalizev.Processor.x86.Utils;
using Xunit;

namespace MikhailKhalizev.Processor.x86.Tests
{
    public class IntervalTests
    {
        [Fact]
        public void Interval_Combine()
        {
            Interval.From(5, 10).Combine(Interval.From(10, 15)).Should().Be(Interval.From(5, 15));
            Interval.From(5, 10).Combine(Interval.From(7, 15)).Should().Be(Interval.From(5, 15));
            Interval.From(5, 10).Combine(Interval.From(0, 15)).Should().Be(Interval.From(0, 15));
            Interval.From(5, 10).Combine(Interval.From(11, 15)).Should().Be(Interval.Empty<int>());
        }

        [Fact]
        public void Interval_Intersect()
        {
            Interval.From(5, 10).Intersect(Interval.From(10, 15)).Should().Be(Interval.Empty<int>());
            Interval.From(5, 10).Intersect(Interval.From(11, 15)).Should().Be(Interval.Empty<int>());
            Interval.From(5, 10).Intersect(Interval.From(7, 15)).Should().Be(Interval.From(7, 10));
        }

        [Fact]
        public void Interval_Contains()
        {
            Interval.From(5, 10).Contains(5).Should().BeTrue();
            Interval.From(5, 10).Contains(7).Should().BeTrue();
            Interval.From(5, 10).Contains(10).Should().BeFalse();
        }

        [Fact]
        public void Interval_Intersects()
        {
            Interval.From(5, 10).IsIntersects(Interval.From(10, 15), considerTouch: false).Should().BeFalse();
            Interval.From(5, 10).IsIntersects(Interval.From(10, 15), considerTouch: true).Should().BeTrue();
            
            Interval.From(10, 15).IsIntersects(Interval.From(5, 10), considerTouch: false).Should().BeFalse();
            Interval.From(10, 15).IsIntersects(Interval.From(5, 10), considerTouch: true).Should().BeTrue();


            Interval.From(5, 10).IsIntersects(Interval.From(9, 15), considerTouch: false).Should().BeTrue();
            Interval.From(5, 10).IsIntersects(Interval.From(9, 15), considerTouch: true).Should().BeTrue();

            Interval.From(9, 15).IsIntersects(Interval.From(5, 10), considerTouch: false).Should().BeTrue();
            Interval.From(9, 15).IsIntersects(Interval.From(5, 10), considerTouch: true).Should().BeTrue();


            Interval.From(5, 10).IsIntersects(Interval.From(11, 15), considerTouch: false).Should().BeFalse();
            Interval.From(5, 10).IsIntersects(Interval.From(11, 15), considerTouch: true).Should().BeFalse();

            Interval.From(11, 15).IsIntersects(Interval.From(5, 10), considerTouch: false).Should().BeFalse();
            Interval.From(11, 15).IsIntersects(Interval.From(5, 10), considerTouch: true).Should().BeFalse();
        }
        
        [Fact]
        public void Interval_SubtractSingle()
        {
            Interval.From(5, 10).Subtract(Interval.From(1, 4)).Should().BeEquivalentTo(new[] { Interval.From(5, 10) });
            Interval.From(5, 10).Subtract(Interval.From(1, 5)).Should().BeEquivalentTo(new[] { Interval.From(5, 10) });
            Interval.From(5, 10).Subtract(Interval.From(10, 15)).Should().BeEquivalentTo(new[] { Interval.From(5, 10) });
            Interval.From(5, 10).Subtract(Interval.From(11, 15)).Should().BeEquivalentTo(new[] { Interval.From(5, 10) });
            
            Interval.From(5, 10).Subtract(Interval.From(4, 6)).Should().BeEquivalentTo(new[] { Interval.From(6, 10) });
            Interval.From(5, 10).Subtract(Interval.From(5, 6)).Should().BeEquivalentTo(new[] { Interval.From(6, 10) });
            Interval.From(5, 10).Subtract(Interval.From(9, 10)).Should().BeEquivalentTo(new[] { Interval.From(5, 9) });
            Interval.From(5, 10).Subtract(Interval.From(9, 11)).Should().BeEquivalentTo(new[] { Interval.From(5, 9) });
            
            Interval.From(5, 10).Subtract(Interval.From(6, 9)).Should()
                .BeEquivalentTo(new[] { Interval.From(5, 6), Interval.From(9, 10) });

            Interval.From(5, 10).Subtract(Interval.From(4, 11)).Should().BeEmpty();
        }
        
        [Fact]
        public void Interval_SubtractCollection()
        {
            Interval.From(5, 10).Subtract(new []
                {
                    Interval.From(1, 6),
                    Interval.From(7, 9),
                    Interval.From(10, 11)
                }).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(6, 7),
                    Interval.From(9, 10)
                });
        }

        [Fact]
        public void Interval_Split()
        {
            Interval.From(5, 10).Split(Interval.From(4, 9)).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(5, 9),
                    Interval.From(9, 10)
                });

            Interval.From(5, 10).Split(Interval.From(6, 9)).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(5, 6),
                    Interval.From(6, 9),
                    Interval.From(9, 10)
                });

            Interval.From(5, 10).Split(Interval.From(6, 20)).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(5, 6),
                    Interval.From(6, 10),
                });

            Interval.From(5, 10).Split(Interval.From(0, 20)).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(5, 10)
                });

            Interval.From(5, 10).Split(Interval.From(7, 7)).Should()
                .BeEquivalentTo(new[]
                {
                    Interval.From(5, 7),
                    Interval.From(7, 10)
                });
        }
    }
}