using System;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory
{
    public static class ArraySegmentExtensions
    {
        public static short GetInt16(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToInt16(bytes.Slice(byteOffset).AsSpan());
        }

        public static ushort GetUInt16(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToUInt16(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetUInt16(this ArraySegment<byte> bytes, int value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), (ushort) value);
        }

        public static void SetUInt16(this ArraySegment<byte> bytes, Value value, int byteOffset = 0)
        {
            SetUInt16(bytes, value.UInt16, byteOffset);
        }


        public static int GetInt32(this ArraySegment<byte> bytes, int byteOffset = 0)
        {
            return BitConverter.ToInt32(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetInt32(this ArraySegment<byte> bytes, int value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), value);
        }

        
        public static uint GetUInt32(this ArraySegment<byte> bytes)
        {
            return BitConverter.ToUInt32(bytes.AsSpan());
        }
        
        public static uint GetUInt32(this ArraySegment<byte> bytes, int byteOffset)
        {
            return BitConverter.ToUInt32(bytes.Slice(byteOffset).AsSpan());
        }

        public static void SetUInt32(this ArraySegment<byte> bytes, uint value, int byteOffset = 0)
        {
            BitConverter.TryWriteBytes(bytes.AsSpan(byteOffset), value);
        }
        
        public static void SetUInt32(this ArraySegment<byte> bytes, Value value, int byteOffset = 0)
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
        
        
        public static bool SequenceEqual(this ArraySegment<byte> b1, ArraySegment<byte> b2)
        {
            if (b1.Count != b2.Count)
                return false;

            for (var i = 0; i < b1.Count; i++)
            {
                if (b1[i] != b2[i])
                    return false;
            }

            return true;
        }
    }
}