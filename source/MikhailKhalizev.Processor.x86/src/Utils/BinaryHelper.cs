using System;
using System.Collections.Generic;
using System.Numerics;

namespace MikhailKhalizev.Processor.x86.Utils
{
    public static class BinaryHelper
    {
        public static int MaskInt32(int lengthInBits)
        {
            if (lengthInBits < 0 || 32 < lengthInBits)
                throw new ArgumentOutOfRangeException(nameof(lengthInBits));
            
            if (lengthInBits == 32)
                return unchecked((int)0xffff_ffff);
            return (int)(~(uint.MaxValue << lengthInBits));
        }

        public static uint MaskUInt32(int lengthInBits)
        {
            if (lengthInBits < 0 || 32 < lengthInBits)
                throw new ArgumentOutOfRangeException(nameof(lengthInBits));
            
            if (lengthInBits == 32)
                return 0xffff_ffff;
            return ~(uint.MaxValue << lengthInBits);
        }

        public static ulong MaskUInt64(int lengthInBits)
        {
            if (lengthInBits < 0 || 64 < lengthInBits)
                throw new ArgumentOutOfRangeException(nameof(lengthInBits));

            if (lengthInBits == 64)
                return 0xffff_ffff_ffff_ffff;
            return ~(ulong.MaxValue << lengthInBits);
        }

        public static ulong MaskUInt64(int lengthInBits, int offset) => MaskUInt64(lengthInBits) << offset;

        // TODO rename to SignBitAndHigher
        public static ulong HighBitsMask(int bit) => ~(MaskUInt64(bit) >> 1);


        public static bool IsSet(int value, int bit)
        {
            if (bit < 0)
                return false;

            return ((value >> bit) & 1) != 0;
        }

        public static bool IsSet(uint value, int bit)
        {
            if (bit < 0)
                return false;

            return ((value >> bit) & 1) != 0;
        }

        public static bool IsSetByMask(uint value, uint mask)
        {
            return (value & mask) != 0;
        }

        public static bool IsSet(ulong value, int bit)
        {
            if (bit < 0)
                return false;

            return ((value >> bit) & 1) != 0;
        }


        public static int GetInt(byte target, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (int) MaskUInt64(bits, targetOffset);
            return (target & targetMask) >> targetOffset;
        }

        public static uint GetUInt(byte target, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (uint) MaskUInt64(bits, targetOffset);
            return (target & targetMask) >> targetOffset;
        }

        public static void Set(ref byte target, bool source, int targetOffset)
        {
            var mask = MaskUInt64(1, targetOffset);
            target = (byte) ((target & ~mask) | (source ? mask : 0));
        }

        public static void Set(ref uint target, bool source, int targetOffset)
        {
            var mask = MaskUInt64(1, targetOffset);
            target = (uint) ((target & ~mask) | (source ? mask : 0));
        }

        public static void SetByMask(ref uint target, bool source, uint mask)
        {
            target = (uint) ((target & ~mask) | (source ? mask : 0));
        }

        public static void Set(byte target, ref uint source, int sourceOffset = 0, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (uint) MaskUInt64(bits, targetOffset);
            var sourceMask = (uint) MaskUInt64(bits, sourceOffset);
            source = (source & ~sourceMask) | ((((target & targetMask) >> targetOffset) << sourceOffset) & sourceMask);
        }

        public static void Set(ref byte target, ulong source, int sourceOffset = 0, int bits = 8, int targetOffset = 0)
        {
            var targetMask = MaskUInt64(bits, targetOffset);
            target = (byte) ((target & ~targetMask) | (((source >> sourceOffset) << targetOffset) & targetMask));
        }

        public static ushort FromBytes(int high, int low) => (ushort) ((high << 8) + low);

        public static uint FromBytes(int high, int middle, int low) => (uint) ((high << 16) + (middle << 8) + low);

        public static uint FromBytes(int p3, int p2, int p1, int p0) =>
            (uint) ((p3 << 24) + (p2 << 16) + (p1 << 8) + p0);

        public static void ToBytes(uint value, ref byte p3, ref byte p2, ref byte p1, ref byte p0)
        {
            p3 = (byte)(value >> 24);
            p2 = (byte)(value >> 16);
            p1 = (byte)(value >> 8);
            p0 = (byte)(value);
        }

        public static IEnumerable<bool> EnumerateBits(BigInteger value)
        {
            foreach (int b in value.ToByteArray())
            {
                var data = b;
                for (var i = 0; i < 8; i++)
                {
                    yield return data % 2 != 0;
                    data = data / 2;
                }
            }
        }

        public static int Int32FromBits(IEnumerable<bool> littleEndianBits) => (int) Int64FromBits(littleEndianBits);

        public static long Int64FromBits(IEnumerable<bool> littleEndianBits)
        {
            long result = 0;

            var offset = 0;
            foreach (var bit in littleEndianBits)
            {
                if (bit)
                    result |= 1L << offset;
                offset++;
            }

            return result;
        }
    }
}