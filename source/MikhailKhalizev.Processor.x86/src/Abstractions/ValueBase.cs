using System;
using MikhailKhalizev.Processor.x86.Abstractions.Value;
using MikhailKhalizev.Utils;

namespace MikhailKhalizev.Processor.x86.Abstractions
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
        public abstract int Bits { get; }

        protected abstract ulong UInt64Internal { get; set; }


        public ushort UInt16
        {
            get
            {
                if (16 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                return (ushort)(UInt64Internal & mask);
            }
            set
            {
                if (16 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                UInt64Internal = value & mask;
            }
        }

        public uint UInt32
        {
            get
            {
                if (32 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                return (uint) (UInt64Internal & mask);
            }
            set
            {
                if (32 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                UInt64Internal = value & mask;
            }
        }

        public int Int32
        {
            get
            {
                var maskSrc = BinaryHelper.Mask(Bits);

                var val = UInt32;
                if (IsNegative)
                    val |= ~(uint)maskSrc;

                return (int)val;
            }
            set => UInt32 = (uint)value;
        }

        public ulong UInt64
        {
            get
            {
                if (64 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                return UInt64Internal & mask;
            }
            set
            {
                if (64 < Bits)
                    throw new InvalidOperationException();

                var mask = BinaryHelper.Mask(Bits);
                UInt64Internal = value & mask;
            }
        }

        public long Int64
        {
            get
            {
                var maskSrc = BinaryHelper.Mask(Bits);

                var val = UInt64;
                if (IsNegative)
                    val |= ~maskSrc;

                return (long)val;
            }
            set => UInt64 = (ulong)value;
        }

        public bool IsNegative => IsBitSet(Bits - 1);

        public virtual bool IsBitSet(int bit)
        {
            return BinaryHelper.IsSet(UInt64, bit);
        }


        #region Cast from Numeric Operators

        public static implicit operator ValueBase(int value) => (Value.Value)value;
        public static implicit operator ValueBase(uint value) => (Value.Value)value;
        public static implicit operator ValueBase(long value) => (Value.Value)value;
        public static implicit operator ValueBase(ulong value) => (Value.Value)value;

        #endregion

        #region Math Operators

        // Рискованно переопределять * / < <= > >= т.к. не известно, знаковые ли у нас переменные или нет.

        public static Value.Value operator ~(ValueBase v1) => ~v1.UInt64;

        public static Value.Value operator +(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 + v2.UInt64, Math.Max(v1.Bits, v2.Bits));

        public static Value.Value operator -(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 - v2.UInt64, Math.Max(v1.Bits, v2.Bits));

        public static Value.Value operator *(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 * v2.UInt64, Math.Min(v1.Bits + v2.Bits, 64));
        
        public static Value.Value operator &(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 & v2.UInt64, Math.Max(v1.Bits, v2.Bits));

        public static Value.Value operator |(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 | v2.UInt64, Math.Max(v1.Bits, v2.Bits));

        public static Value.Value operator ^(ValueBase v1, ValueBase v2) => new NumericValue(v1.UInt64 ^ v2.UInt64, Math.Max(v1.Bits, v2.Bits));

        public static Value.Value operator >>(ValueBase v1, int v2) => new NumericValue(v1.UInt64 >> v2, v1.Bits);

        public static Value.Value operator <<(ValueBase v1, int v2) => new NumericValue(v1.UInt64 << v2, v1.Bits);

        #endregion

        #region IEquatable<ValueBase>

        /// <inheritdoc />
        public bool Equals(ValueBase other)
        {
            return UInt64 == other?.UInt64;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            var other = obj as ValueBase;
            return other != null && Equals(other);
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            return UInt64.GetHashCode();
        }

        public static bool operator ==(ValueBase left, ValueBase right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ValueBase left, ValueBase right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}
