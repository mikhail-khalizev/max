using System;
using System.Resources;
using System.Runtime.InteropServices;
using MikhailKhalizev.Processor.x86.Abstractions.Registers;
using System.Runtime.CompilerServices;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public static class MemoryReadAccessExtension
    {
        public static ArraySegment<byte> GetFixSize(this IMemory memory, Address address, int size)
        {
            return memory.GetMinSize(address, size).Slice(0, size);
        }
     
        public static ArraySegment<byte> GetFixSize(this IMemory memory, SegmentRegister seg, Address address, int size)
        {
            return memory.GetMinSize(seg, address, size).Slice(0, size);
        }

        public static unsafe ref T GetStruct<T>(this IMemory memory, Address address)
            where T : struct
        {
            var bytes = memory.GetMinSize(address, Marshal.SizeOf<T>());

            // bytes.Array must be pinned. See MikhailKhalizev.Processor.x86.FullSimulate.Memory constructor.

            var intPtr = Marshal.UnsafeAddrOfPinnedArrayElement(bytes.Array, bytes.Offset);
            var ptr = intPtr.ToPointer();
            
            ref var element = ref Unsafe.AsRef<T>(ptr);
            return ref element;
        }
    }
}