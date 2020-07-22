using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public abstract class Value
    {
        public static Value From(int value, int lengthInBits) => Operations.From(value, lengthInBits);
        public static Value From(uint value, int lengthInBits) => Operations.From(value, lengthInBits);

        public static Value True { get; } = From(1, 1);
        public static Value False { get; } = From(0, 1);

        public static Value operator +(Value a, Value b) => Operations.Add(a, b);
        public static Value operator +(Value a, int b) => Operations.Add(a, b);
        public static Value operator +(int a, Value b) => Operations.Add(a, b);

        public static Value operator -(Value a, Value b) => Operations.Sub(a, b);
        public static Value operator -(Value a, int b) => Operations.Sub(a, b);
        public static Value operator -(int a, Value b) => Operations.Sub(a, b);
        
        public static Value operator *(Value a, int b) => Operations.Mul(a, b);
        public static Value operator *(int a, Value b) => Operations.Mul(a, b);
        
        public static Value operator ^(Value a, Value b) => Operations.Xor(a, b);


        private static int _lastSequenceIndex;

        protected Value(int lengthInBits)
        {
            LengthInBits = lengthInBits;
            SequenceIndex = Interlocked.Increment(ref _lastSequenceIndex);
        }

        public static explicit operator Value(bool binary)
        {
            return binary ? True : False;
        }


        public virtual int LengthInBits { get; }

        public int SequenceIndex { get; }

        public virtual bool UsedAsInt { get; set; }
        public virtual bool UsedAsUint { get; set; }
        public virtual bool UsedAsPointer { get; set; }
    }


    public class InputValue : Value
    {
        public Value Target { get; } // RegisterValue or MemoryValue (stack).

        public IReadOnlyList<Value> Sources => _sources;
        private readonly List<Value> _sources = new List<Value>();

        /// <inheritdoc />
        public InputValue(Value target) : base(target.LengthInBits)
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
}