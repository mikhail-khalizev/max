using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public abstract class Value
    {
        protected Value(int bits)
        {
            Bits = bits;
        }

        public virtual int Bits { get; }

        public virtual bool UsedAsInt { get; set; }
        public virtual bool UsedAsUint { get; set; }
        public virtual bool UsedAsPointer { get; set; }

        public static Value From(int value, int bits) => Operations.From(value, bits);
        public static Value From(uint value, int bits) => Operations.From(value, bits);

        public static Value operator +(Value a, Value b) => Operations.Add(a, b);
        public static Value operator +(Value a, int b) => Operations.Add(a, b);
        public static Value operator +(int a, Value b) => Operations.Add(a, b);

        public static Value operator -(Value a, Value b) => Operations.Sub(a, b);
        public static Value operator -(Value a, int b) => Operations.Sub(a, b);
        public static Value operator -(int a, Value b) => Operations.Sub(a, b);
    }


    public class ProxyValue : Value
    {
        public Value Source { get; set; }

        /// <inheritdoc />
        public ProxyValue() : base(0)
        { }

        /// <inheritdoc />
        public override int Bits => Source.Bits;

        /// <inheritdoc />
        public override bool UsedAsInt
        {
            get => Source.UsedAsInt;
            set => Source.UsedAsInt = value;
        }

        /// <inheritdoc />
        public override bool UsedAsUint
        {
            get => Source.UsedAsUint;
            set => Source.UsedAsUint = value;
        }

        /// <inheritdoc />
        public override bool UsedAsPointer
        {
            get => Source.UsedAsPointer;
            set => Source.UsedAsPointer = value;
        }
    }

    public class InputValue : Value
    {
        public Value Target { get; } // RegisterValue or MemoryValue (stack).

        public IReadOnlyList<Value> Sources => _sources;
        private readonly List<Value> _sources = new List<Value>();

        /// <inheritdoc />
        public InputValue(Value target) : base(target.Bits)
        {
            Target = target;
        }

        public void AddSource(Value source)
        {
            _sources.Add(source);
        }

        /// <inheritdoc />
        public override bool UsedAsInt
        {
            get => _usedAsInt || _sources.Any(x => x.UsedAsInt);
            set
            {
                _usedAsInt |= value;
                _sources.ForEach(x => x.UsedAsInt |= _usedAsInt);
            }
        }
        private bool _usedAsInt;

        /// <inheritdoc />
        public override bool UsedAsUint
        {
            get => _usedAsUint || _sources.Any(x => x.UsedAsUint);
            set
            {
                _usedAsUint |= value;
                _sources.ForEach(x => x.UsedAsUint |= _usedAsUint);
            }
        }
        private bool _usedAsUint;

        /// <inheritdoc />
        public override bool UsedAsPointer
        {
            get => _usedAsPointer || _sources.Any(x => x.UsedAsPointer);
            set
            {
                _usedAsPointer |= value;
                _sources.ForEach(x => x.UsedAsPointer |= _usedAsPointer);
            }
        }
        private bool _usedAsPointer;

        public void UpdateUsed()
        {
            UsedAsInt = UsedAsInt;
            UsedAsUint = UsedAsUint;
            UsedAsPointer = UsedAsPointer;
        }
    }


    public class ConstantValue : Value
    {
        public int Value { get; }

        /// <inheritdoc />
        public ConstantValue(int value, int bits) : base(bits)
        {
            Value = value;
        }

        public static ConstantValue operator -(ConstantValue a) => new ConstantValue(-a.Value, a.Bits);

        public static ConstantValue operator +(ConstantValue a, ConstantValue b)
        {
            if (a == null)
                return b;
            if (b == null)
                return a;

            if (a.Bits != b.Bits)
                throw new NotSupportedException("a.Bits != b.Bits");
            return new ConstantValue(a.Value + b.Value, a.Bits);
        }

        public static ConstantValue operator -(ConstantValue a, ConstantValue b)
        {
            if (a == null)
                return -b;
            if (b == null)
                return a;

            if (a.Bits != b.Bits)
                throw new NotSupportedException("a.Bits != b.Bits");
            return new ConstantValue(a.Value - b.Value, a.Bits);
        }

        public static ConstantValue operator *(ConstantValue a, int b) => new ConstantValue(a.Value * b, a.Bits);

        public static ConstantValue operator *(int a, ConstantValue b) => b * a;
    }

    public class RegisterValue : Value
    {
        public RegisterInfo RegisterInfo { get; }

        public RegisterValue(RegisterInfo registerInfo) : base(registerInfo.Bits)
        {
            RegisterInfo = registerInfo;
        }
    }

    public class MemoryValue : Value
    {
        public Value Address { get; }
        public Value Value { get; }

        public MemoryValue(Value address, int bits) : base(bits)
        {
            Address = address;
        }

        public MemoryValue(Value address, Value value) : base(value.Bits)
        {
            Address = address;
            Value = value;
        }
    }

    //public class CombineValue : Value

    public class SumValue : Value
    {
        public IReadOnlyDictionary<Value, int /* count */> Items => _items;
        private readonly Dictionary<Value, int> _items;

        public SumValue(Dictionary<Value, int> items)
            : base(items.Select(x => x.Key.Bits).Distinct().Single())
        {
            _items = items;
        }

        public SumValue(Dictionary<Value, int> items, int bits)
            : base(bits)
        {
            _items = items;
        }
    }

    //public class ConditionValue : Value // 1 Bit
}