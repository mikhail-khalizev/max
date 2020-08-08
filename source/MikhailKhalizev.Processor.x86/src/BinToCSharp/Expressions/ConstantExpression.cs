using System;
using System.Linq.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ConstantExpression : Expression
    {
        public static ConstantExpression operator -(ConstantExpression a) => new ConstantExpression(-a.Value, a.LengthInBits);

        public static ConstantExpression operator +(ConstantExpression left, ConstantExpression right)
        {
            if (left.LengthInBits != right.LengthInBits)
                throw new NotSupportedException("left.LengthInBits != right.LengthInBits");
            return new ConstantExpression(left.Value + right.Value, left.LengthInBits);
        }

        public static ConstantExpression operator -(ConstantExpression left, ConstantExpression right)
        {
            if (left.LengthInBits != right.LengthInBits)
                throw new NotSupportedException("left.LengthInBits != right.LengthInBits");
            return new ConstantExpression(left.Value - right.Value, left.LengthInBits);
        }

        public static ConstantExpression operator *(ConstantExpression left, int right) =>
            new ConstantExpression(left.Value * right, left.LengthInBits);

        public static ConstantExpression operator *(int left, ConstantExpression right) =>
            new ConstantExpression(left * right.Value, right.LengthInBits);

        public static ConstantExpression operator ^(ConstantExpression left, ConstantExpression right)
        {
            if (left.LengthInBits != right.LengthInBits)
                throw new NotSupportedException("left.LengthInBits != right.LengthInBits");
            return new ConstantExpression(left.Value ^ right.Value, left.LengthInBits);
        }


        public int Value { get; }
        public ConstantType ConstantType { get; }

        /// <inheritdoc />
        protected internal ConstantExpression(int value, int lengthInBits)
            : this(ConstantType.Default, value, lengthInBits)
        { }

        /// <inheritdoc />
        protected internal ConstantExpression(ConstantType constantType, int value, int lengthInBits)
            : base(ExpressionType.Constant, lengthInBits)
        {
            ConstantType = constantType;

            if (lengthInBits != 32)
            {
                var isNegative = (value & (1 << (lengthInBits - 1))) != 0;
                if (isNegative)
                    value |= ~((1 << lengthInBits) - 1);
            }

            Value = value;
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitConstant(this);
        }
    }
}