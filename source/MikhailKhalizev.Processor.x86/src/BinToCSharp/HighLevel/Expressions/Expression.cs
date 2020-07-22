using System.Threading;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public abstract class ExpressionVisitor
    {

    }



    // Immutable with all derived classes.
    public abstract class Expression
    {
        public static Expression From(int value, int lengthInBits) => Operations.From(value, lengthInBits);
        public static Expression From(uint value, int lengthInBits) => Operations.From(value, lengthInBits);

        public static Expression True { get; } = From(1, 1);
        public static Expression False { get; } = From(0, 1);

        public static Expression operator +(Expression a, Expression b) => Operations.Add(a, b);
        public static Expression operator +(Expression a, int b) => Operations.Add(a, b);
        public static Expression operator +(int a, Expression b) => Operations.Add(a, b);

        public static Expression operator -(Expression a, Expression b) => Operations.Sub(a, b);
        public static Expression operator -(Expression a, int b) => Operations.Sub(a, b);
        public static Expression operator -(int a, Expression b) => Operations.Sub(a, b);
        
        public static Expression operator *(Expression a, int b) => Operations.Mul(a, b);
        public static Expression operator *(int a, Expression b) => Operations.Mul(a, b);
        
        public static Expression operator ^(Expression a, Expression b) => Operations.Xor(a, b);


        private static int _lastSequenceIndex;

        protected Expression(int lengthInBits)
        {
            LengthInBits = lengthInBits;
            SequenceIndex = Interlocked.Increment(ref _lastSequenceIndex);
        }

        public static explicit operator Expression(bool binary)
        {
            return binary ? True : False;
        }


        public virtual int LengthInBits { get; }

        public int SequenceIndex { get; }

        public virtual bool UsedAsInt { get; set; }
        public virtual bool UsedAsUint { get; set; }
        public virtual bool UsedAsPointer { get; set; }
    }
}