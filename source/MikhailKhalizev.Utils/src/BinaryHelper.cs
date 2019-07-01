using System;
using System.Collections.Generic;
using System.Numerics;

namespace MikhailKhalizev.Utils
{
    public static class BinaryHelper
    {
        public static ulong Mask(int bits)
        {
            if (bits < 0 || 64 < bits)
                throw new ArgumentOutOfRangeException(nameof(bits));

            if (bits == 0)
                return 0;
            if (bits == 64)
                return 0xffff_ffff_ffff_ffff;
            return (1ul << bits) - 1;
        }

        public static ulong Mask(int bits, int offset) => Mask(bits) << offset;

        public static ulong HighBitsMask(int bit) => ~(Mask(bit) >> 1);


        public static bool IsSet(ulong value, int bit)
        {
            if (bit < 0)
                return false;

            return ((value >> bit) & 1) != 0;
        }

        public static int GetInt(byte target, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (int) Mask(bits, targetOffset);
            return (target & targetMask) >> targetOffset;
        }

        public static uint GetUInt(byte target, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (uint) Mask(bits, targetOffset);
            return (target & targetMask) >> targetOffset;
        }

        public static void Set(ref byte target, bool source, int targetOffset)
        {
            var mask = Mask(1, targetOffset);
            target = (byte) ((target & ~mask) | (source ? mask : 0));
        }

        public static void Set(byte target, ref uint source, int sourceOffset = 0, int bits = 8, int targetOffset = 0)
        {
            var targetMask = (uint) Mask(bits, targetOffset);
            var sourceMask = (uint) Mask(bits, sourceOffset);
            source = (source & ~sourceMask) | ((((target & targetMask) >> targetOffset) << sourceOffset) & sourceMask);
        }

        public static void Set(ref byte target, ulong source, int sourceOffset = 0, int bits = 8, int targetOffset = 0)
        {
            var targetMask = Mask(bits, targetOffset);
            target = (byte) ((target & ~targetMask) | (((source >> sourceOffset) << targetOffset) & targetMask));
        }

        public static ushort FromBytes(int high, int low) => (ushort) ((high << 8) + low);

        public static uint FromBytes(int high, int middle, int low) => (uint) ((high << 16) + (middle << 8) + low);

        public static uint FromBytes(int p4, int high, int middle, int low) =>
            (uint) ((p4 << 24) + (high << 16) + (middle << 8) + low);

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