using System;
using System.Linq;
using System.Text;

namespace MikhailKhalizev.Processor.x86.Abstractions.Memory
{
    public static class MemoryExtensions
    {
        public static short GetInt16(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToInt16(bytes.Slice(byteOffset).AsSpan());
        }

        public static ushort GetUInt16(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToUInt16(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetUInt16(this ArraySegment<byte> bytes, ushort value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), value);
        }

        public static void SetUInt16(this ArraySegment<byte> bytes, Value.Value value, int byteOffset = 0)
        {
            SetUInt32(bytes, value.UInt32, byteOffset);
        }


        public static int GetInt32(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToInt32(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetInt32(this ArraySegment<byte> bytes, int value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), value);
        }

        
        public static uint GetUInt32(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToUInt32(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetUInt32(this ArraySegment<byte> bytes, uint value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), value);
        }
        
        public static void SetUInt32(this ArraySegment<byte> bytes, Value.Value value, int byteOffset = 0)
        {
            SetUInt32(bytes, value.UInt32, byteOffset);
        }


        public static float GetFloat(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            // 4 bytes.
            return BitConverter.ToSingle(bytes.Slice(byteOffset).AsSpan());
        }

        public static double GetDouble(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            // 8 bytes.
            return BitConverter.ToDouble(bytes.Slice(byteOffset).AsSpan());
        }

        public static string GetCString(this ArraySegment<byte> bytes, int byteOffset = 0, int maxLength = int.MaxValue)
        {
            return Encoding.UTF8.GetString(
                bytes
                    .Slice(byteOffset)
                    .Take(maxLength)
                    .TakeWhile(x => x != 0)
                    .ToArray());
        }
    }
}