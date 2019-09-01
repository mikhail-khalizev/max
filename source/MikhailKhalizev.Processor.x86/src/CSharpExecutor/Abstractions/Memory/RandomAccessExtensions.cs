using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public static class RandomAccessExtensions
    {
        public static ArraySegment<byte> GetMinSize(this IRandomAccess memory, SegmentRegister seg, Address address, int minSize)
        {
            if (seg.Descriptor.Present == false /* @todo || seg.is_null() */)
                throw new NotImplementedException();

            if (seg.fail_limit_check(address, minSize))
                throw new NotImplementedException();

            var ret = memory.GetMinSize(seg[address], minSize);


            // correct size with segment limit

            var end = address + ret.Count;

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


        public static ArraySegment<byte> GetFixSize(this IRandomAccess memory, Address address, int size)
        {
            return memory.GetMinSize(address, size).Slice(0, size);
        }
     
        public static ArraySegment<byte> GetFixSize(this IRandomAccess memory, SegmentRegister seg, Address address, int size)
        {
            return memory.GetMinSize(seg, address, size).Slice(0, size);
        }


        public static ref T Get<T>(this IRandomAccess memory, Address address)
        {
            var bytes = memory.GetMinSize(address, Marshal.SizeOf<T>());
            return ref Unsafe.As<byte, T>(ref bytes.AsSpan()[0]);
        }


        public static bool Equals(this IRandomAccess memory, Address address, ArraySegment<byte> left)
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


        public static byte[] ReadAll(this IRandomAccess memory, Address address, int size)
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
        
        public static string ReadCString(this IRandomAccess memory, Address address, int maxLength = int.MaxValue)
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