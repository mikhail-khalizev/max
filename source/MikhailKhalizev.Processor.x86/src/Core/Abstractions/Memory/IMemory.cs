using System;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public interface IMemory
    {
        int Length { get; }

        ArraySegment<byte> GetMinSize(Address address, int minSize);
        ArraySegment<byte> GetMinSize(SegmentRegister seg, Address address, int minSize);
    }
}