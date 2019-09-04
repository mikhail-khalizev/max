using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public static class SpanExtensions
    {
        public static ref T Ref<T>(this Span<byte> bytes)
        {
            if (bytes.Length < Marshal.SizeOf<T>())
                throw new ArgumentException($"Trying get {typeof(T).Name} with bytes size less than {Marshal.SizeOf<T>()}");
            return ref Unsafe.As<byte, T>(ref bytes[0]);
        }

        public static ref T Ref<T>(this Span<byte> bytes, int byteOffset)
        {
            return ref Ref<T>(bytes.Slice(byteOffset));
        }
    }
}