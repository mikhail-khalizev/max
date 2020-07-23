using System;
using System.Threading;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    // Immutable with all derived classes.
    public abstract class Expression
    {
        public static Expression True { get; } = Number(1, 1);
        public static Expression False { get; } = Number(0, 1);

        
        public static Expression Boolean(bool value) => value ? True : False;
        public static Expression Zero(int lengthInBits) => new ConstantExpression(0, lengthInBits);
        public static Expression Number(int value, int lengthInBits) => new ConstantExpression(value, lengthInBits);
        public static Expression Number(uint value, int lengthInBits) => new ConstantExpression((int) value, lengthInBits);

        public static Expression IsZero(Expression exp) => Expression.Equal(exp, Zero(exp.LengthInBits));
        public static Expression IsNegative(Expression exp) => Expression.LessThan(exp, Zero(exp.LengthInBits));
        

        // TODO Refactor operator's.
        public static Expression operator +(Expression a, Expression b) => Operations.Add(a, b);
        public static Expression operator +(Expression a, int b) => Operations.Add(a, b);
        public static Expression operator +(int a, Expression b) => Operations.Add(a, b);

        public static Expression operator -(Expression a, Expression b) => Operations.Sub(a, b);
        public static Expression operator -(Expression a, int b) => Operations.Sub(a, b);
        public static Expression operator -(int a, Expression b) => Operations.Sub(a, b);

        public static Expression operator *(Expression a, int b) => Operations.Mul(a, b);
        public static Expression operator *(int a, Expression b) => Operations.Mul(a, b);

        public static Expression operator ^(Expression left, Expression right) => Expression.ExclusiveOr(left, right);


        public static BinaryExpression MakeBinary(ExpressionType binaryType, Expression left, Expression right)
        {
            switch (binaryType)
            {
                // case ExpressionType.Add:
                //     return Add(left, right, method);
                // case ExpressionType.AddChecked:
                //     return AddChecked(left, right, method);
                // case ExpressionType.Subtract:
                //     return Subtract(left, right, method);
                // case ExpressionType.SubtractChecked:
                //     return SubtractChecked(left, right, method);
                // case ExpressionType.Multiply:
                //     return Multiply(left, right, method);
                // case ExpressionType.MultiplyChecked:
                //     return MultiplyChecked(left, right, method);
                // case ExpressionType.Divide:
                //     return Divide(left, right, method);
                // case ExpressionType.Modulo:
                //     return Modulo(left, right, method);
                // case ExpressionType.Power:
                //     return Power(left, right, method);
                // case ExpressionType.And:
                //     return And(left, right, method);
                // case ExpressionType.AndAlso:
                //     return AndAlso(left, right, method);
                // case ExpressionType.Or:
                //     return Or(left, right, method);
                // case ExpressionType.OrElse:
                //     return OrElse(left, right, method);
                case ExpressionType.LessThan:
                    return LessThan(left, right);
                case ExpressionType.LessThanOrEqual:
                    return LessThanOrEqual(left, right);
                case ExpressionType.GreaterThan:
                    return GreaterThan(left, right);
                case ExpressionType.GreaterThanOrEqual:
                    return GreaterThanOrEqual(left, right);
                // case ExpressionType.Equal:
                //     return Equal(left, right, liftToNull, method);
                // case ExpressionType.NotEqual:
                //     return NotEqual(left, right, liftToNull, method);
                case ExpressionType.ExclusiveOr:
                    return ExclusiveOr(left, right);
                // case ExpressionType.Coalesce:
                //     return Coalesce(left, right, conversion);
                // case ExpressionType.ArrayIndex:
                //     return ArrayIndex(left, right);
                // case ExpressionType.RightShift:
                //     return RightShift(left, right, method);
                // case ExpressionType.LeftShift:
                //     return LeftShift(left, right, method);
                // case ExpressionType.Assign:
                //     return Assign(left, right);
                default:
                    throw new InvalidOperationException($"Error.UnhandledBinary({binaryType}, {nameof(binaryType)})");
            }
        }

        #region Comparison Expressions

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "greater than" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.GreaterThan"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression GreaterThan(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.GreaterThan, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "less than" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.LessThan"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>

        public static BinaryExpression LessThan(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.LessThan, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "greater than or equal" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.GreaterThanOrEqual"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression GreaterThanOrEqual(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.GreaterThanOrEqual, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "less than or equal" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.LessThanOrEqual"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression LessThanOrEqual(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.LessThanOrEqual, 1, left, right);
        }

        #endregion

        #region Equality Operators

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an equality comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Equal"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Equal(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.Equal, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an inequality comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.NotEqual"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression NotEqual(Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.NotEqual, 1, left, right);
        }

        #endregion

        #region Arithmetic Expressions

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a bitwise or logical XOR operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.ExclusiveOr"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression ExclusiveOr(Expression left, Expression right)
        {
            if (left.LengthInBits != right.LengthInBits)
                throw new ArgumentException($"LengthInBits of operand differ.");
            return new BinaryExpression(ExpressionType.ExclusiveOr, left.LengthInBits, left, right);
        }

        #endregion



        // private static int _lastSequenceIndex;

        public virtual ExpressionType NodeType { get; }

        // /// <summary>
        // /// The <see cref="Type"/> of the value represented by this <see cref="Expression"/>.
        // /// </summary>
        // public virtual Type Type

        // Length in bits of result data or 0, if no result available by this type of Expression.
        public virtual int LengthInBits { get; }

        // public virtual int SequenceIndex { get; }

        protected Expression(ExpressionType nodeType, int lengthInBits)
        {
            NodeType = nodeType;
            LengthInBits = lengthInBits;
            // SequenceIndex = Interlocked.Increment(ref _lastSequenceIndex);
        }

        protected internal virtual Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitDefault(this);
        }

        // TODO
        // /// <summary>
        // /// Creates a <see cref="String"/> representation of the Expression.
        // /// </summary>
        // /// <returns>A <see cref="String"/> representation of the Expression.</returns>
        // public override string ToString()
        // {
        //     return ExpressionStringBuilder.ExpressionToString(this);
        // }
    }
}