using System.Threading;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    // Immutable with all derived classes.
    public abstract class Expression
    {
        public static Expression True { get; } = Number(1, 1);
        public static Expression False { get; } = Number(0, 1);


        public static ConstantExpression Zero(int lengthInBits) => new ConstantExpression(0, lengthInBits);
        public static Expression Number(int value, int lengthInBits) => new ConstantExpression(value, lengthInBits);
        public static Expression Number(uint value, int lengthInBits) => new ConstantExpression((int) value, lengthInBits);

        public static Expression IsNegative(Expression exp) => new ConditionExpression(
            exp,
            ConditionType.Less,
            Zero(exp.LengthInBits));

        public static Expression IsZero(Expression exp) => new ConditionExpression(
            exp,
            ConditionType.Equal,
            Zero(exp.LengthInBits));


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


        protected internal virtual Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitDefault(this);
        }
    }
}