namespace MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions
{
    public sealed class NumericValue8 : Value
    {
        private uint _value;

        public NumericValue8(int value)
        {
            _value = (uint)value & 0xff;
        }

        /// <inheritdoc />
        public override int Bits => 8;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => _value;
            set => _value = (uint)value & 0xff;
        }

        /// <inheritdoc />
        public override short Int16
        {
            get => (sbyte)_value;
            set => _value = (byte)value;
        }

        /// <inheritdoc />
        public override ushort UInt16
        {
            get => (ushort)_value;
            set => _value = value;
        }

        /// <inheritdoc />
        public override int Int32
        {
            get => (sbyte)_value;
            set => _value = (uint)value & 0xff;
        }

        /// <inheritdoc />
        public override uint UInt32
        {
            get => _value;
            set => _value = value & 0xff;
        }

        /// <inheritdoc />
        public override long Int64
        {
            get => (sbyte)_value;
            set => _value = (uint)value & 0xff;
        }

        /// <inheritdoc />
        public override ulong UInt64
        {
            get => _value;
            set => _value = (uint)value & 0xff;
        }

        /// <inheritdoc />
        public override bool IsNegative => (sbyte)_value < 0;

        /// <inheritdoc />
        public override bool IsPositive => 0 <= (sbyte)_value;
    }

    public sealed class NumericValue16 : Value
    {
        private uint _value;

        public NumericValue16(int value)
        {
            _value = (uint)value & 0xffff;
        }

        /// <inheritdoc />
        public override int Bits => 16;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => _value;
            set => _value = (uint)value & 0xffff;
        }

        /// <inheritdoc />
        public override short Int16
        {
            get => (short)_value;
            set => _value = (ushort)value;
        }

        /// <inheritdoc />
        public override ushort UInt16
        {
            get => (ushort)_value;
            set => _value = value;
        }

        /// <inheritdoc />
        public override int Int32
        {
            get => (short)_value;
            set => _value = (uint)value & 0xffff;
        }

        /// <inheritdoc />
        public override uint UInt32
        {
            get => _value;
            set => _value = value & 0xffff;
        }

        /// <inheritdoc />
        public override long Int64
        {
            get => (short)_value;
            set => _value = (uint)value & 0xffff;
        }

        /// <inheritdoc />
        public override ulong UInt64
        {
            get => _value;
            set => _value = (uint)value & 0xffff;
        }

        /// <inheritdoc />
        public override bool IsNegative => (short)_value < 0;

        /// <inheritdoc />
        public override bool IsPositive => 0 <= (short)_value;
    }

    public sealed class NumericValue32 : Value
    {
        private uint _value;

        public NumericValue32(int value)
        {
            _value = (uint)value;
        }

        public NumericValue32(uint value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override int Bits => 32;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => _value;
            set => _value = (uint)value;
        }

        /// <inheritdoc />
        public override int Int32
        {
            get => (int)_value;
            set => _value = (uint)value;
        }

        /// <inheritdoc />
        public override uint UInt32
        {
            get => _value;
            set => _value = value;
        }

        /// <inheritdoc />
        public override long Int64
        {
            get => (int)_value;
            set => _value = (uint)value;
        }

        /// <inheritdoc />
        public override ulong UInt64
        {
            get => _value;
            set => _value = (uint)value;
        }

        /// <inheritdoc />
        public override bool IsNegative => (int)_value < 0;

        /// <inheritdoc />
        public override bool IsPositive => 0 <= (int)_value;
    }

    public sealed class NumericValue64 : Value
    {
        private ulong _value;

        public NumericValue64(long value)
        {
            _value = (ulong)value;
        }

        public NumericValue64(ulong value)
        {
            _value = value;
        }

        /// <inheritdoc />
        public override int Bits => 64;

        /// <inheritdoc />
        protected override ulong UInt64Internal
        {
            get => _value;
            set => _value = value;
        }

        /// <inheritdoc />
        public override long Int64
        {
            get => (long)_value;
            set => _value = (ulong)value;
        }

        /// <inheritdoc />
        public override ulong UInt64
        {
            get => _value;
            set => _value = value;
        }

        /// <inheritdoc />
        public override bool IsNegative => (long)_value < 0;

        /// <inheritdoc />
        public override bool IsPositive => 0 <= (long)_value;
    }

    public sealed class NumericValue : Value
    {
        public static Value From(uint value, int bits) => From((int)value, bits);

        public static Value From(int value, int bits)
        {
            switch (bits)
            {
                case 8:
                    return new NumericValue8(value);
                case 16:
                    return new NumericValue16(value);
                case 32:
                    return new NumericValue32(value);
                case 64:
                    return new NumericValue64(value);
                default:
                    return new NumericValue((uint)value, bits);
            }
        }

        public static Value From(ulong value, int bits) => From((long)value, bits);

        public static Value From(long value, int bits)
        {
            switch (bits)
            {
                case 8:
                    return new NumericValue8((int)value);
                case 16:
                    return new NumericValue16((int)value);
                case 32:
                    return new NumericValue32((int)value);
                case 64:
                    return new NumericValue64(value);
                default:
                    return new NumericValue((ulong)value, bits);
            }
        }


        public override int Bits { get; }

        /// <inheritdoc />
        protected override ulong UInt64Internal { get; set; }


        private NumericValue(ulong value, int bits)
        {
            UInt64Internal = value;
            Bits = bits;
        }
    }
}