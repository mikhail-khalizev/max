using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class MemoryExpression : Expression
    {
        public RegisterInfo Segment { get; }
        public Expression Address { get; }

        public MemoryExpression(RegisterInfo segment, Expression address, int dataLengthInBits) : base(dataLengthInBits)
        {
            if (!segment.IsSegment)
                throw new ArgumentException($"Expected segment register, but found {segment}");

            Segment = segment;
            Address = address;
        }
    }
}