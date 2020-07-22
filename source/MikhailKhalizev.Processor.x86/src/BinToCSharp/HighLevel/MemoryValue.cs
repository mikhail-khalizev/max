using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class MemoryValue : Value
    {
        public RegisterInfo Segment { get; }
        public Value Address { get; }

        public MemoryValue(RegisterInfo segment, Value address, int dataLengthInBits) : base(dataLengthInBits)
        {
            if (!segment.IsSegment)
                throw new ArgumentException($"Expected segment register, but found {segment}");

            Segment = segment;
            Address = address;
        }
    }
}