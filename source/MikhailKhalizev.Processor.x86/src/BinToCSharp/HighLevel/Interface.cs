using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public interface IUpdateUsed
    {
        void UpdateUsed();
    }

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
        public static Value operator -(Value a, Value b) => Operations.Sub(a, b);
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

    public class InputValue : Value, IUpdateUsed
    {
        public Value Target { get; } // RegisterValue or MemoryValue (stack).

        public IReadOnlyList<Value> Sources => _sources;
        private readonly List<Value> _sources = new List<Value>();

        /// <inheritdoc />
        public InputValue(Value target, int bits) : base(bits)
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


    //public class ConstantValue : Value
    //public class RegisterValue : Value
    //public class MemoryValue : Value

    //public class CombineValue : Value
    //public class AddSubValue : Value

    //public class ConditionValue : Value // 1 Bit


    public static class Operations
    {
        public static Value From(int value, int bits) => throw new NotImplementedException();
        public static Value From(uint value, int bits) => throw new NotImplementedException();

        public static Value Add(Value a, Value b) => throw new NotImplementedException();
        public static Value Sub(Value a, Value b) => throw new NotImplementedException();
    }

    public class Block
    {
        public List<InputValue> Input { get; } = new List<InputValue>();

        public Value GetRegister(RegisterInfo register) => throw new NotImplementedException();
        public void SetRegister(RegisterInfo register, Value value) => throw new NotImplementedException();

        public Value GetMemory(Value address) => throw new NotImplementedException();
        public void SetMemory(Value address, Value value) => throw new NotImplementedException();

        public Value NextBlockIndex { get; set; }
        public List<Block> NextBlocks { get; set; }
    }
}