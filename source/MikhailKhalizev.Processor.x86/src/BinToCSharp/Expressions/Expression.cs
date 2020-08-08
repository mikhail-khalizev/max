using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    // Immutable with all derived classes.
    public abstract class Expression
    {
        public static Expression True { get; } = Constant(1, 1);
        public static Expression False { get; } = Constant(0, 1);

        public static Expression Boolean(bool value) => value ? True : False;
        public static Expression Zero(int lengthInBits) => Constant(0, lengthInBits);
        public static Expression Constant(int value, int lengthInBits) => new ConstantExpression(value, lengthInBits);
        public static Expression Constant(uint value, int lengthInBits) => new ConstantExpression((int) value, lengthInBits);

        public static Expression Constant(ConstantType constantType, int value, int lengthInBits) =>
            new ConstantExpression(constantType, value, lengthInBits);

        public static Expression IsZero(Expression exp) => Equal(exp, Zero(exp.LengthInBits));

        public static Expression operator +(Expression left, Expression right) => Add(left, right);
        public static Expression operator +(Expression left, int right) => Add(left, Constant(right, left.LengthInBits));
        public static Expression operator +(int left, Expression right) => Add(Constant(left, right.LengthInBits), right);

        public static Expression operator -(Expression left, Expression right) => Subtract(left, right);
        public static Expression operator -(Expression left, int right) => Subtract(left, Constant(right, left.LengthInBits));
        public static Expression operator -(int left, Expression right) => Subtract(Constant(left, right.LengthInBits), right);

        public static Expression operator &(Expression left, Expression right) => And(left, right);
        public static Expression operator &(Expression left, int right) => And(left, Constant(right, left.LengthInBits));
        public static Expression operator &(int left, Expression right) => And(Constant(left, right.LengthInBits), right);

        public static Expression operator |(Expression left, Expression right) => Or(left, right);
        public static Expression operator |(Expression left, int right) => Or(left, Constant(right, left.LengthInBits));
        public static Expression operator |(int left, Expression right) => Or(Constant(left, right.LengthInBits), right);

        public static Expression operator ^(Expression left, Expression right) => ExclusiveOr(left, right);
        public static Expression operator ^(Expression left, int right) => ExclusiveOr(left, Constant(right, left.LengthInBits));
        public static Expression operator ^(int left, Expression right) => ExclusiveOr(Constant(left, right.LengthInBits), right);


        public static BinaryExpression MakeBinary(
            ExpressionType binaryType,
            NumberType numberType,
            int lengthInBits,
            Expression left,
            Expression right)
        {
            switch (binaryType)
            {
                case ExpressionType.Add:
                    return Add(lengthInBits, left, right);
                case ExpressionType.Subtract:
                    return Subtract(lengthInBits, left, right);
                case ExpressionType.Multiply:
                    return Multiply(numberType, lengthInBits, left, right);
                case ExpressionType.Divide:
                    return Divide(numberType, left, right);
                case ExpressionType.Modulo:
                    return Modulo(numberType, left, right);
                case ExpressionType.Power:
                    return Power(numberType, lengthInBits, left, right);
                case ExpressionType.And:
                    return And(left, right);
                case ExpressionType.AndAlso:
                    return AndAlso(left, right);
                case ExpressionType.Or:
                    return Or(left, right);
                case ExpressionType.OrElse:
                    return OrElse(left, right);
                case ExpressionType.LessThan:
                    return LessThan(numberType, left, right);
                case ExpressionType.LessThanOrEqual:
                    return LessThanOrEqual(numberType, left, right);
                case ExpressionType.GreaterThan:
                    return GreaterThan(numberType, left, right);
                case ExpressionType.GreaterThanOrEqual:
                    return GreaterThanOrEqual(numberType, left, right);
                case ExpressionType.Equal:
                    return Equal(left, right);
                case ExpressionType.NotEqual:
                    return NotEqual(left, right);
                case ExpressionType.ExclusiveOr:
                    return ExclusiveOr(left, right);
                case ExpressionType.RightShift:
                    return RightShift(numberType, left, right);
                case ExpressionType.LeftShift:
                    return LeftShift(numberType, lengthInBits, left, right);
                case ExpressionType.Assign:
                    return Assign(left, right);
                default:
                    throw new InvalidOperationException($"Error.UnhandledBinary({binaryType}, {nameof(binaryType)})");
            }
        }

        public static MemoryAccessExpression MemoryAccess(RegisterInfo segment, Expression address, int dataLengthInBits)
        {
            return new MemoryAccessExpression(segment, address, dataLengthInBits);
        }

        public static Expression MemoryWrite(RegisterInfo segment, Expression address, Expression value)
        {
            return Expression.Assign(MemoryAccess(segment, address, value.LengthInBits), value);
        }

        public static RegisterExpression RegisterAccess(RegisterInfo registerInfo)
        {
            return new RegisterExpression(registerInfo);
        }

        #region Assign

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an assignment operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Assign"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.
        /// </returns>
        public static BinaryExpression Assign(Expression left, Expression right)
        {
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.Equal, left.LengthInBits, left, right);
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
            RequiresSameLengthInBits(left, right);
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
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.NotEqual, 1, left, right);
        }

        #endregion

        #region Comparison Expressions

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "greater than" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.GreaterThan"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression GreaterThan(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.GreaterThan, numberType, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "less than" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.LessThan"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression LessThan(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.LessThan, numberType, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "greater than or equal" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.GreaterThanOrEqual"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression GreaterThanOrEqual(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.GreaterThanOrEqual, numberType, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a "less than or equal" numeric comparison.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.LessThanOrEqual"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression LessThanOrEqual(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.LessThanOrEqual, numberType, 1, left, right);
        }

        #endregion

        #region Boolean Expressions

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a conditional AND operation that evaluates the second operand only if it has to.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.AndAlso"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression AndAlso(Expression left, Expression right)
        {
            RequiresLengthInBits(left, 1);
            RequiresLengthInBits(right, 1);
            return new BinaryExpression(ExpressionType.AndAlso, 1, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a conditional OR operation that evaluates the second operand only if it has to.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.OrElse"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression OrElse(Expression left, Expression right)
        {
            RequiresLengthInBits(left, 1);
            RequiresLengthInBits(right, 1);
            return new BinaryExpression(ExpressionType.OrElse, 1, left, right);
        }

        #endregion

        #region Arithmetic Expressions

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an arithmetic addition operation that does not have overflow checking.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Add"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Add(Expression left, Expression right)
        {
            return Add(Math.Max(left.LengthInBits, right.LengthInBits), left, right);
        }

        public static BinaryExpression Add(int lengthInBits, Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.Add, lengthInBits, left, right);
        }

        public static Expression Add(int lengthInBits, params Expression[] items)
        {
            return Add(lengthInBits, items.AsEnumerable());
        }

        public static Expression Add(int lengthInBits, IEnumerable<Expression> items)
        {
            Expression e = null;
            foreach (var item in items)
            {
                if (e == null)
                    e = item;
                else
                    e = Add(lengthInBits, e, item);
            }

            if (e == null)
                throw new ArgumentException("No operands");
            return e;
        }

        public static Expression Add(params Expression[] items)
        {
            return Add(items.AsEnumerable());
        }

        public static Expression Add(IEnumerable<Expression> items)
        {
            Expression e = null;
            foreach (var item in items)
            {
                if (e == null)
                    e = item;
                else
                    e = Add(e, item);
            }

            if (e == null)
                throw new ArgumentException("No operands");
            return e;
        }


        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an arithmetic subtraction operation that does not have overflow checking.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Subtract"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Subtract(Expression left, Expression right)
        {
            return Subtract(Math.Max(left.LengthInBits, right.LengthInBits), left, right);
        }

        public static BinaryExpression Subtract(int lengthInBits, Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.Subtract, lengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an arithmetic division operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Divide"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Divide(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            return new BinaryExpression(ExpressionType.Divide, numberType, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an arithmetic remainder operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Modulo"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Modulo(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            return new BinaryExpression(ExpressionType.Modulo, numberType, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an arithmetic multiplication operation that does not have overflow checking.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Multiply"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Multiply(NumberType numberType, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            return Multiply(numberType, Math.Max(left.LengthInBits, right.LengthInBits), left, right);
        }

        public static BinaryExpression Multiply(NumberType numberType, int lengthInBits, Expression left, Expression right)
        {
            RequiresNumberType(numberType);
            return new BinaryExpression(ExpressionType.Multiply, numberType, lengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an bitwise left-shift operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.LeftShift"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression LeftShift(NumberType numberType, Expression left, Expression right)
        {
            return LeftShift(numberType, left.LengthInBits, left, right);
        }

        public static BinaryExpression LeftShift(NumberType numberType, int lengthInBits, Expression left, Expression right)
        {
            RequiresIntegerNumberType(numberType);
            return new BinaryExpression(ExpressionType.LeftShift, numberType, lengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an bitwise right-shift operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.RightShift"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression RightShift(NumberType numberType, Expression left, Expression right)
        {
            RequiresIntegerNumberType(numberType);
            return new BinaryExpression(ExpressionType.RightShift, numberType, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an bitwise AND operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.And"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression And(Expression left, Expression right)
        {
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.And, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents an bitwise OR operation.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Or"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Or(Expression left, Expression right)
        {
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.Or, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents a bitwise or logical XOR operation, using op_ExclusiveOr for user-defined types.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.ExclusiveOr"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression ExclusiveOr(Expression left, Expression right)
        {
            RequiresSameLengthInBits(left, right);
            return new BinaryExpression(ExpressionType.ExclusiveOr, left.LengthInBits, left, right);
        }

        /// <summary>
        /// Creates a <see cref="BinaryExpression"/> that represents raising a number to a power.
        /// </summary>
        /// <param name="left">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Left"/> property equal to.</param>
        /// <param name="right">An <see cref="Expression"/> to set the <see cref="BinaryExpression.Right"/> property equal to.</param>
        /// <returns>A <see cref="BinaryExpression"/> that has the <see cref="NodeType"/> property equal to <see cref="ExpressionType.Power"/>
        /// and the <see cref="BinaryExpression.Left"/> and <see cref="BinaryExpression.Right"/> properties set to the specified values.</returns>
        public static BinaryExpression Power(NumberType numberType, int lengthInBits, Expression left, Expression right)
        {
            return new BinaryExpression(ExpressionType.Power, numberType, lengthInBits, left, right);
        }

        #endregion

        #region Combine Expressions

        // Combine of ((value << offset) & mask).
        public static Expression Combine(int lengthInBits, params (Expression Value, int Offset, int Mask)[] sourceItems)
        {
            return Combine(lengthInBits, sourceItems.AsEnumerable());
        }

        // Combine of ((value << offset) & mask).
        public static Expression Combine(int lengthInBits, IEnumerable<(Expression Value, int Offset, int Mask)> sourceItems)
        {
            var resultMask = BinaryHelper.MaskInt32(lengthInBits);
            var resultItems = new List<(Expression Value, int Offset, int Mask)>();

            foreach (var sourceItem in sourceItems)
            {
                for (var i = 0; i < resultItems.Count; i++)
                {
                    var item = resultItems[i];
                    resultItems[i] = (item.Value, item.Offset, item.Mask & ~sourceItem.Mask & resultMask);
                }

                resultItems.Add(
                    (sourceItem.Value, sourceItem.Offset, BinaryHelper.MaskInt32(lengthInBits) & sourceItem.Mask & resultMask));
            }


            var constValue = 0;
            var constMask = 0;

            for (var i = 0; i < resultItems.Count; i++)
            {
                var item = resultItems[i];
                var shouldRemove = false;

                if (item.Mask == 0)
                {
                    shouldRemove = true;
                }
                else if (item.Value is ConstantExpression cv)
                {
                    constValue |= (cv.Value << item.Offset) & item.Mask;
                    constMask |= item.Mask;
                    shouldRemove = true;
                }

                if (shouldRemove)
                {
                    resultItems.RemoveAt(i);
                    i--;
                }
            }

            if (constValue != 0)
                resultItems.Add((Constant(constValue, lengthInBits), 0, constMask));


            resultItems = resultItems
                .GroupBy(
                    x => (x.Value, x.Offset),
                    (tuple, tuples) => (tuple.Value, tuple.Offset, tuples.Aggregate(0, (mask, valueTuple) => mask | valueTuple.Mask)))
                .ToList();


            if (resultItems.Count == 0)
                return Zero(lengthInBits);

            if (resultItems.Count == 1)
            {
                var item = resultItems[0];

                if (item.Value is ConstantExpression cv3)
                    return cv3;

                if (item.Offset == 0 && item.Mask == resultMask)
                    return item.Value;
            }


            Expression result = null;

            foreach (var (expression, offset, mask) in resultItems)
            {
                var e = expression;

                if (offset != 0 || lengthInBits != e.LengthInBits)
                    e = LeftShift(NumberType.UnsignedInteger, lengthInBits, e, Constant(offset, lengthInBits));

                if (mask != resultMask)
                    e = And(e, Constant(ConstantType.Hex, mask, lengthInBits));

                result = result == null ? e : Or(result, e);
            }

            return result;
        }

        #endregion

        #region UpdateFlags

        public static Expression UpdateFlags(RegisterInfo info, int flag, bool value)
        {
            return UpdateFlags(info, flag, Expression.Boolean(value));
        }

        public static Expression UpdateFlags(RegisterInfo info, int flag, Expression expression)
        {
            return UpdateFlags(info, (flag, expression));
        }

        public static Expression UpdateFlags(RegisterInfo info, params (int flag, Expression value)[] items)
        {
            return UpdateFlags(info, items.AsEnumerable());
        }

        public static Expression UpdateFlags(RegisterInfo info, IEnumerable<(int flag, Expression value)> items)
        {
            var register = RegisterAccess(info);

            var newValue = Expression.Combine(
                register.LengthInBits,
                Enumerable.Empty<(Expression Value, int Offset, int Mask)>()
                    .Append((register, 0, BinaryHelper.MaskInt32(register.LengthInBits)))
                    .Concat(
                        items.Select(
                            x =>
                            {
                                var (flags, value) = x;
                                if (flags == 0)
                                    throw new ArgumentException($"{nameof(flags)} is 0.");

                                var offset = 0;
                                while (((int) flags & (1 << offset)) == 0)
                                    offset++;

                                return (value, offset, 1 << offset);
                            })));

            return Assign(register, newValue);
        }

        #endregion


        protected static void RequiresSameLengthInBits(Expression left, Expression right)
        {
            if (left.LengthInBits != right.LengthInBits)
                throw new ArgumentException($"LengthInBits of the operands is different.");
        }

        protected static void RequiresLengthInBits(Expression e, int lengthInBits)
        {
            if (e.LengthInBits != lengthInBits)
                throw new ArgumentException($"Expected LengthInBits is {lengthInBits}.");
        }

        protected static void RequiresNumberType(NumberType numberType)
        {
            if (numberType == NumberType.Irrelevant)
                throw new ArgumentException($"Expected number type.");
        }

        protected static void RequiresIntegerNumberType(NumberType numberType)
        {
            if (numberType != NumberType.SignedInteger &&
                numberType != NumberType.UnsignedInteger)
            {
                throw new ArgumentException($"Expected 'Integer' number type, but passed {numberType}.");
            }
        }


        public virtual ExpressionType NodeType { get; }

        public virtual NumberType NumberType { get; }

        // Length in bits of result data or 0, if no result available by this type of Expression.
        public virtual int LengthInBits { get; }


        /// <summary>
        /// Creates a <see cref="String"/> representation of the Expression.
        /// </summary>
        /// <returns>A <see cref="String"/> representation of the Expression.</returns>
        public override string ToString()
        {
            return ExpressionStringBuilder.ExpressionToString(this);
        }


        protected Expression(ExpressionType nodeType, int lengthInBits)
        {
            NodeType = nodeType;
            NumberType = NumberType.Irrelevant;
            LengthInBits = lengthInBits;
        }

        protected Expression(ExpressionType nodeType, NumberType numberType, int lengthInBits)
        {
            NodeType = nodeType;
            NumberType = numberType;
            LengthInBits = lengthInBits;
        }

        protected internal virtual Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitDefault(this);
        }
    }
}