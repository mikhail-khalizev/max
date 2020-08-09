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

        private readonly List<Expression> _preinit = new List<Expression>();
        private Expression _main = null;

        /// <inheritdoc />
        public override Expression Visit(Expression node)
        {
            if (_main == null)
                _main = node;

            var newNode = base.Visit(node);

            if (_main == node && _preinit.Count != 0)
            {
                if (newNode is BlockExpression block)
                    return Expression.Block(_preinit.Concat(block.Expressions));

                return Expression.Block(_preinit.Append(newNode));
            }

            return newNode;
        }

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
                    SetRegister(registerExpression.RegisterInfo, right);
                    return node.Update(node.Left, right);
                }

                if (right is BinaryExpression be && be.NodeType == ExpressionType.Assign && be.Left is ParameterExpression p1)
                {
                    SetRegister(registerExpression.RegisterInfo, p1);
                    return node.Update(node.Left, right);
                }
                else
                {
                    var p2 = Expression.Parameter(right.LengthInBits);
                    SetRegister(registerExpression.RegisterInfo, p2);
                    return node.Update(node.Left, Expression.Assign(p2, right));
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
                var parameter = Expression.Parameter(register.LengthInBits);
                _preinit.Add(Expression.Assign(parameter, register));

                _registers[registerInfo.Index] = (registerInfo, parameter);
                return parameter;
            }
    
            if (item.RegisterInfo == registerInfo)
                return item.Value;
    
            return Expression.Combine(
                registerInfo.LengthInBits,
                (item.Value,
                item.RegisterInfo.BitOffset - registerInfo.BitOffset,
                item.RegisterInfo.BitMask >> registerInfo.BitOffset));
        }
    
        public void SetRegister(RegisterInfo registerInfo, Expression expression)
        {
            if (!_registers.TryGetValue(registerInfo.Index, out var item))
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return;
            }
    
            if (item.RegisterInfo == registerInfo)
            {
                _registers[registerInfo.Index] = (registerInfo, expression);
                return;
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
    
            _registers[registerInfo.Index] = (resultRegisterInfo, combination);
        }
    }
}