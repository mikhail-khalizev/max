using System;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public interface IMemorySpaceReadAccess
    {
        ArraySegment<byte> GetMinSize(Address address, int minSize);
        ArraySegment<byte> GetMinSize(SegmentRegister seg, Address address, int minSize);

        ArraySegment<byte> GetFixSize(Address address, int size);
        ArraySegment<byte> GetFixSize(SegmentRegister seg, Address address, int size);
    }
}