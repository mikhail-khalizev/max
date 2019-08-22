using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public static class MemoryExtensions
    {
        public static ArraySegment<byte> GetMinSize(this IMemory memory, SegmentRegister seg, Address address, int minSize)
        {
            if (seg.Descriptor.Present == false /* @todo || seg.is_null() */)
                throw new NotImplementedException();

            if (seg.fail_limit_check(address, minSize))
                throw new NotImplementedException();

            var ret = memory.GetMinSize(seg[address], minSize);


            // correct size with segment limit

            Address end = address + ret.Count;

            if (seg.Descriptor.Limit + 1 != 0)
            {
                if (end == 0)
                    end = seg.Descriptor.Limit + 1; // todo can't understand
                else
                    end = Math.Min(end, seg.Descriptor.Limit + 1);
            }

            if (end <= address)
                throw new NotImplementedException();

            ret = ret.Slice(0, end - address);

            return ret;
        }

        public static ArraySegment<byte> GetFixSize(this IMemory memory, Address address, int size)
        {
            return memory.GetMinSize(address, size).Slice(0, size);
        }
     
        public static ArraySegment<byte> GetFixSize(this IMemory memory, SegmentRegister seg, Address address, int size)
        {
            return memory.GetMinSize(seg, address, size).Slice(0, size);
        }

        // Dangerous. Because bytes.Array must be pinned before call.
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

        public static bool Equals(this IMemory memory, Address address, ArraySegment<byte> left)
        {
            var i = 0;

            while (left.Count != 0)
            {
                var code = memory.GetMinSize(address + i, 1);

                if (left.Count <= code.Count)
                    return code.Slice(0, left.Count).SequenceEqual(left);

                if (!left.Slice(0, code.Count).SequenceEqual(code))
                    return false;

                i += code.Count;
                left = left.Slice(code.Count);
            }

            return true;
        }

        public static byte[] ReadAll(this IMemory memory, Address address, int size)
        {
            var result = new byte[size];

            for (var i = 0; i < size;)
            {
                var availableSpace = memory.GetMinSize(address + i, 1);
                if (size - i < availableSpace.Count)
                    availableSpace = availableSpace.Slice(0, size - i);

                availableSpace.CopyTo(result, i);
                i += availableSpace.Count;
            }

            return result;
        }
        
        public static string ReadCString(this IMemory memory, Address address, int maxLength = int.MaxValue)
        {
            var availSpace = ArraySegment<byte>.Empty;

            var sb = new StringBuilder();
            for (var ptr = address; 0 < maxLength; ptr++, maxLength--)
            {
                if (availSpace.Count == 0)
                    availSpace = memory.GetMinSize(ptr, 1);

                var c = (char) availSpace[0];
                availSpace = availSpace.Slice(1);

                if (c == '\0')
                    break;
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}