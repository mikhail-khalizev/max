using System;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions
{
    /*
     * We need allow operation like:
     *
     *   Register mem { get; set; }
     *   Value val;
     *   mem = val; // Copy value.
     *
     * But if we make Value as base class, we can't implement implicit conversion from Value to MemoryValue and back
     * due to compile-time error "Conversion from base class" or "Conversion from derived class".
     *
     * So we make ValueBase class as base class for all <*>Value classes.
     * And assume Value class as universal value.
     *
     * Result:
     * 1. ValueBase - base class for all <*>Value.
     * 2. Any <*>Value can be implicit converted to Value.
     * 3. Any <*>Value can be assign from Value.
     * 4. Members should prefer return Value instead of ValueBase.
     *
     * --- Inheritance. ---
     *
     * Value         -> ValueBase
     * Register      -> ValueBase
     * MemoryValue   -> ValueBase
     *
     *
     * --- Implicit conversion. ---
     *
     * numeric       -> ValueBase
     *
     * numeric       -> Value
     *
     * Value        <-> Register
     * numeric       -> Register
     * MemoryValue   -> Register
     *
     * Value        <-> MemoryValue
     * numeric       -> MemoryValue
     * Register      -> MemoryValue
     *
     */

    public abstract class ValueBase : IEquatable<ValueBase>
    {
        public abstract int LengthInBits { get; }

        protected abstract ulong UInt64Internal { get; set; }


        public virtual ushort UInt16
        {
            get
            {
                if (16 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                return (ushort)(UInt64Internal & mask);
            }
            set
            {
                if (16 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                UInt64Internal = value & mask;
            }
        }

        public virtual short Int16
        {
            get
            {
                var val = UInt16;
                if (IsNegative)
                {
                    var maskSrc = BinaryHelper.MaskUInt64(LengthInBits);
                    val = (ushort) (val | (~(ushort) maskSrc));
                }

                return (short)val;
            }
            set => UInt16 = (ushort)value;
        }

        public virtual uint UInt32
        {
            get
            {
                if (32 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                return (uint)(UInt64Internal & mask);
            }
            set
            {
                if (32 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                UInt64Internal = value & mask;
            }
        }

        public virtual int UInt32AsInt
        {
            get => (int) UInt32;
            set => UInt32 = (uint)value;
        }

        public virtual int Int32
        {
            get
            {
                var val = UInt32;
                if (IsNegative)
                {
                    var maskSrc = BinaryHelper.MaskUInt64(LengthInBits);
                    val |= ~(uint) maskSrc;
                }

                return (int)val;
            }
            set => UInt32 = (uint)value;
        }

        public virtual ulong UInt64
        {
            get
            {
                if (64 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                return UInt64Internal & mask;
            }
            set
            {
                if (64 < LengthInBits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.MaskUInt64(LengthInBits);
                UInt64Internal = value & mask;
            }
        }

        public virtual long Int64
        {
            get
            {
                var val = UInt64;
                if (IsNegative)
                {
                    var maskSrc = BinaryHelper.MaskUInt64(LengthInBits);
                    val |= ~maskSrc;
                }

                return (long)val;
            }
            set => UInt64 = (ulong)value;
        }

        public virtual double Double
        {
            get
            {
                switch (LengthInBits)
                {
                    case 32:
                        return BitConverter.Int32BitsToSingle(Int32);
                    case 64:
                        return BitConverter.Int64BitsToDouble(Int64);
                    default:
                        throw new NotSupportedException($"value.LengthInBits: {LengthInBits}");
                }
            }
            set
            {
                switch (LengthInBits)
                {
                    case 32:
                        Int32 = BitConverter.SingleToInt32Bits((float)value);
                        break;
                    case 64:
                        Int64 = BitConverter.DoubleToInt64Bits(value);
                        break;
                    default:
                        throw new NotSupportedException($"value.LengthInBits: {LengthInBits}");
                }
            }
        }


        public virtual bool IsNegative => BinaryHelper.IsSet(UInt64, LengthInBits - 1);
        public virtual bool IsPositive => !BinaryHelper.IsSet(UInt64, LengthInBits - 1);
        public virtual bool IsBitSet(int bit) => BinaryHelper.IsSet(UInt64, bit);


        /// <inheritdoc />
        public override string ToString()
        {
            if (LengthInBits <= 32)
                return HexHelper.ToShortGrouped4Hex(UInt32);
            else
                return HexHelper.ToShortGrouped4Hex(UInt64);
        }

        #region Cast from Numeric Operators
        
        public static implicit operator ValueBase(sbyte value) => (Value)value;
        public static implicit operator ValueBase(byte value) => (Value)value;
        public static implicit operator ValueBase(short value) => (Value)value;
        public static implicit operator ValueBase(ushort value) => (Value)value;
        public static implicit operator ValueBase(int value) => (Value)value;
        public static implicit operator ValueBase(uint value) => (Value)value;
        public static implicit operator ValueBase(long value) => (Value)value;
        public static implicit operator ValueBase(ulong value) => (Value)value;

        public static implicit operator ValueBase(double value) => (Value)value;

        #endregion

        #region Math Operators

        // Рискованно переопределять [*, /, <, <=, >, >=] т.к. не известно, знаковые ли у нас переменные или нет.

        public static Value operator ~(ValueBase v1) => ~v1.UInt64;

        public static Value operator +(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 + v2.UInt64, Math.Max(v1.LengthInBits, v2.LengthInBits));

        public static Value operator -(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 - v2.UInt64, Math.Max(v1.LengthInBits, v2.LengthInBits));

        // Необходим для 'mov(memd_a32[gs, edi + ebx * 4], eax)'
        public static Value operator *(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 * v2.UInt64, Math.Max(v1.LengthInBits, v1.LengthInBits));

        public static Value operator &(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 & v2.UInt64, Math.Max(v1.LengthInBits, v2.LengthInBits));

        public static Value operator |(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 | v2.UInt64, Math.Max(v1.LengthInBits, v2.LengthInBits));

        public static Value operator ^(ValueBase v1, ValueBase v2) => NumericValue.From(v1.UInt64 ^ v2.UInt64, Math.Max(v1.LengthInBits, v2.LengthInBits));

        public static Value operator >>(ValueBase v1, int v2) => NumericValue.From(v1.UInt64 >> v2, v1.LengthInBits);

        public static Value operator <<(ValueBase v1, int v2) => NumericValue.From(v1.UInt64 << v2, v1.LengthInBits);

        public static Value operator ++(ValueBase v) => ++v.UInt64;

        public static Value operator --(ValueBase v) => --v.UInt64;

        #endregion

        #region IEquatable<ValueBase>

        /// <inheritdoc />
        public bool Equals(ValueBase other) => UInt64 == other?.UInt64;

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as ValueBase;
            return other != null && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode() => UInt64.GetHashCode();

        public static bool operator ==(ValueBase left, ValueBase right) => Equals(left, right);

        public static bool operator !=(ValueBase left, ValueBase right) => !Equals(left, right);

        #endregion
    }
}
