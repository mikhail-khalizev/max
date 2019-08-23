using System;
using System.Collections.Generic;
using System.Globalization;
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

        public virtual Value BaseValue => this;


        public static Value From(int value, int bits) => throw new NotImplementedException();
        public static Value From(uint value, int bits) => throw new NotImplementedException();

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

        /// <inheritdoc />
        public override Value BaseValue => Source.BaseValue;
    }


    //public class ConstantValue : Value
    //public class RegisterValue : Value
    //public class MemoryValue : Value

    //public class CombineValue : Value
    //public class AddSubValue : Value


    public static class Operations
    {
        public static Value Add(Value a, Value b) => throw new NotImplementedException();
        public static Value Sub(Value a, Value b) => throw new NotImplementedException();
    }


    public class ValueStorage
    {
        public List<ProxyValue> Input { get; } = new List<ProxyValue>();

        public Value GetRegister(RegisterInfo register) => throw new NotImplementedException();
        public void SetRegister(RegisterInfo register, Value value) => throw new NotImplementedException();

        public Value GetMemory(Value address) => throw new NotImplementedException();
        public void SetMemory(Value address, Value value) => throw new NotImplementedException();
    }
}