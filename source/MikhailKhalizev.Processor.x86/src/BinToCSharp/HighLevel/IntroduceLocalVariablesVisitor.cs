using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class IntroduceLocalVariablesVisitor : ExpressionVisitor
    {
        private readonly Dictionary<int /* register index */, (RegisterInfo RegisterInfo, Expression Value)> _registers =
            new Dictionary<int, (RegisterInfo, Expression)>();

        /// <inheritdoc />
        protected internal override Expression VisitLabel(LabelExpression node)
        {
            _registers.Clear();
            return base.VisitLabel(node);
        }

        /// <inheritdoc />
        protected internal override Expression VisitBinary(BinaryExpression node)
        {
            if (node.NodeType == ExpressionType.Assign && node.Left is RegisterExpression registerExpression)
            {
                var right = Visit(node.Right);

                if (right is ParameterExpression)
                {
                    var ex1 = SetRegister(registerExpression.RegisterInfo, right);
                    var ex2 = node.Update(node.Left, right);

                    if (ex1 == Expression.Empty)
                        return ex2;
                    else
                        return Expression.Block(
                            new[]
                            {
                                ex1,
                                ex2
                            });
                }

                if (right is BinaryExpression be && be.NodeType == ExpressionType.Assign && be.Left is ParameterExpression p1)
                {
                    return Expression.Block(
                        new[]
                        {
                            right,
                            SetRegister(registerExpression.RegisterInfo, p1),
                            Expression.Assign(node.Left, p1)
                        }.Where(x => x != Expression.Empty));
                }
                else
                {
                    var p2 = Expression.Parameter(right.LengthInBits);
                    
                    return Expression.Block(
                        new[]
                        {
                            Expression.Assign(p2, right),
                            SetRegister(registerExpression.RegisterInfo, p2),
                            Expression.Assign(node.Left, p2)
                        }.Where(x => x != Expression.Empty));
                }
            }

            return base.VisitBinary(node);
        }

        /// <inheritdoc />
        protected internal override Expression VisitRegisterAccess(RegisterExpression node)
        {
            var newNode = GetRegister(node.RegisterInfo);
            Debug.Assert(newNode.LengthInBits == node.LengthInBits);
            return newNode;
        }


        public Expression GetRegister(RegisterInfo registerInfo)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                var register = new RegisterExpression(registerInfo);
                var p1 = Expression.Parameter(register.LengthInBits);
                _registers[registerInfo.Index] = (registerInfo, p1);
                return Expression.Assign(p1, register); // TODO
            }

            if (item.RegisterInfo == registerInfo)
                return item.Value;

            // var p2 = Expression.Parameter(registerInfo.LengthInBits);
            // 
            // var val = Expression.Combine(
            //     registerInfo.LengthInBits,
            //     (item.Value,
            //     item.RegisterInfo.BitOffset - registerInfo.BitOffset,
            //     item.RegisterInfo.BitMask >> registerInfo.BitOffset));
            // 
            // SetRegister(registerInfo, p2);
            // return Expression.Assign(p2, val);

            return Expression.Combine(
                registerInfo.LengthInBits,
                (item.Value,
                    item.RegisterInfo.BitOffset - registerInfo.BitOffset,
                    item.RegisterInfo.BitMask >> registerInfo.BitOffset));
        }

        public Expression SetRegister(RegisterInfo registerInfo, Expression expression)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return Expression.Empty;
            }

            if (item.RegisterInfo == registerInfo)
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return Expression.Empty;
            }

            var combination = Expression.Combine(
                Math.Max(
                    item.RegisterInfo.LengthInBits + item.RegisterInfo.BitOffset,
                    registerInfo.LengthInBits + registerInfo.BitOffset),
                (item.Value, item.RegisterInfo.BitOffset, item.RegisterInfo.BitMask),
                (expression, registerInfo.BitOffset, registerInfo.BitMask));

            var resultRegisterInfo = new[] { registerInfo, item.RegisterInfo }
                .OrderBy(x => x.LengthInBits)
                .Concat(
                    RegisterInfo.Registers
                        .Where(x => x.Index == registerInfo.Index)
                        .OrderBy(x => x.LengthInBits)
                )
                .Where(x => x.BitOffset == 0)
                .First(x => combination.LengthInBits <= x.LengthInBits);

            var parameter = Expression.Parameter(resultRegisterInfo.LengthInBits);
            _registers[registerInfo.Index] = (resultRegisterInfo, parameter);
            return Expression.Assign(parameter, combination);
        }
    }
}