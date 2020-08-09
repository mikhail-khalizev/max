using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class SimplifyExpressionVisitor : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, Expression> _parameters = new Dictionary<ParameterExpression, Expression>();

        private ConstantExpression TryReduceToConstant(Expression expression)
        {
            while (expression is ParameterExpression param)
            {
                if (_parameters.TryGetValue(param, out var value))
                    expression = value;
                else
                    break;
            }

            return expression as ConstantExpression;
        }

        /// <inheritdoc />
        protected internal override Expression VisitBinary(BinaryExpression node)
        {
            var left = Visit(node.Left);
            var right = Visit(node.Right);

            var cleft = TryReduceToConstant(left);
            var cright = TryReduceToConstant(right);

            if (cleft != null && cright != null)
            {
                switch (node.NodeType)
                {
                    case ExpressionType.LessThan when node.NumberType == NumberType.SignedInteger:
                        return Expression.Boolean(cleft.Value < cright.Value);
                    case ExpressionType.LessThan when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Boolean((uint)cleft.Value < (uint)cright.Value);

                    case ExpressionType.LessThanOrEqual when node.NumberType == NumberType.SignedInteger:
                        return Expression.Boolean(cleft.Value <= cright.Value);
                    case ExpressionType.LessThanOrEqual when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Boolean((uint)cleft.Value <= (uint)cright.Value);

                    case ExpressionType.GreaterThan when node.NumberType == NumberType.SignedInteger:
                        return Expression.Boolean(cleft.Value > cright.Value);
                    case ExpressionType.GreaterThan when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Boolean((uint)cleft.Value > (uint)cright.Value);

                    case ExpressionType.GreaterThanOrEqual when node.NumberType == NumberType.SignedInteger:
                        return Expression.Boolean(cleft.Value >= cright.Value);
                    case ExpressionType.GreaterThanOrEqual when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Boolean((uint)cleft.Value >= (uint)cright.Value);

                    case ExpressionType.Equal:
                        return Expression.Boolean(cleft.Value == cright.Value);
                    case ExpressionType.NotEqual:
                        return Expression.Boolean(cleft.Value != cright.Value);

                    case ExpressionType.LeftShift when node.NumberType == NumberType.SignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsSigned << cright.Value, node.LengthInBits);
                    case ExpressionType.LeftShift when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsUnsigned << cright.Value, node.LengthInBits);

                    case ExpressionType.RightShift when node.NumberType == NumberType.SignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsSigned >> cright.Value, node.LengthInBits);
                    case ExpressionType.RightShift when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsUnsigned >> cright.Value, node.LengthInBits);

                    case ExpressionType.Or when node.NumberType == NumberType.SignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsSigned | cright.AsSigned, node.LengthInBits);
                    case ExpressionType.Or when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsUnsigned | cright.AsUnsigned, node.LengthInBits);

                    case ExpressionType.And when node.NumberType == NumberType.SignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsSigned & cright.AsSigned, node.LengthInBits);
                    case ExpressionType.And when node.NumberType == NumberType.UnsignedInteger:
                        return Expression.Constant(ConstantType.Hex, cleft.AsUnsigned & cright.AsUnsigned, node.LengthInBits);
                }
            }


            if (cleft != null)
            {
                switch (node.NodeType)
                {
                    case ExpressionType.And when cleft.LengthInBits == 1:
                        return cleft.Value == 0 ? Expression.False : right;
                    case ExpressionType.Or when cleft.LengthInBits == 1:
                        return cleft.Value == 0 ? right : Expression.True;
                    case ExpressionType.AndAlso when cleft.LengthInBits == 1:
                        return cleft.Value == 0 ? Expression.False : right;
                    case ExpressionType.OrElse when cleft.LengthInBits == 1:
                        return cleft.Value == 0 ? right : Expression.True;
                }
            }
            
            if (cright != null)
            {
                switch (node.NodeType)
                {
                    case ExpressionType.And when cright.LengthInBits == 1:
                        return cright.Value == 0 ? Expression.False : left;
                    case ExpressionType.Or when cright.LengthInBits == 1:
                        return cright.Value == 0 ? left : Expression.True;
                    case ExpressionType.LeftShift when cright.Value == 0 && left.LengthInBits == node.LengthInBits:
                        return left;
                    case ExpressionType.RightShift when cright.Value == 0 && left.LengthInBits == node.LengthInBits:
                        return left;
                }
            }


            switch (node.NodeType)
            {
                case ExpressionType.Assign:
                {
                    if (left is ParameterExpression param)
                        _parameters[param] = right;
                    break;
                }

                case ExpressionType.ExclusiveOr:
                    if (left == right)
                        return Expression.Zero(node.LengthInBits);
                    break;

                case ExpressionType.Equal:
                    if (left == right)
                        return Expression.True;
                    break;

                case ExpressionType.NotEqual:
                    if (left == right)
                        return Expression.False;
                    break;

                case ExpressionType.Or:
                {
                    if (right is ConstantExpression cr1 && cr1.Value == 0)
                        return left;
                    if (left is ConstantExpression cr2 && cr2.Value == 0)
                        return right;
                    break;
                }
            }

            return node.Update(left, right);
        }
    }
}