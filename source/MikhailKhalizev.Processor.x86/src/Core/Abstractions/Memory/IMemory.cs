using System;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.Core.Abstractions.Memory
{
    public interface IMemory
    {
        /// <summary>
        /// Ram size in bytes.
        /// </summary>
        int Length { get; }

        ArraySegment<byte> GetMinSize(Address address, int minSize);
    }
}