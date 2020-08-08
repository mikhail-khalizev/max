using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Decoder;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public partial class X86Instruction
    {
        /// <inheritdoc />
        public virtual IEnumerable<Expression> GetExpressions()
        {
            switch (Mnemonic)
            {
                case ud_mnemonic_code.UD_Ipush:
                {
                    RegisterInfo spRegInfo;
                    switch (Mode)
                    {
                        case 32:
                            spRegInfo = ud_type.UD_R_ESP;
                            break;

                        default:
                            throw new NotImplementedException($"X86Instruction = {this}, Mode = {Mode}.");
                    }

                    var sp = Expression.RegisterAccess(spRegInfo);

                    var src = GetOperandValue(0);
                    var newSp = sp - src.LengthInBits / 8;

                    yield return Expression.Assign(sp, newSp);
                    yield return Expression.MemoryWrite(ud_type.UD_R_SS, newSp, src);

                    break;
                }

                case ud_mnemonic_code.UD_Imov:
                {
                    var src = GetOperandValue(1);
                    yield return SetOperandValue(0, src);
                    break;
                }

                case ud_mnemonic_code.UD_Ixor:
                {
                    var src = GetOperandValue(1);
                    var dst = GetOperandValue(0);

                    dst ^= src;

                    yield return SetOperandValue(0, dst);
                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(dst)
                            .Append(((int) EflagsMaskEnum.cf, Expression.False))
                            .Append(((int) EflagsMaskEnum.of, Expression.False)));
                    break;
                }

                default:
                    throw new NotImplementedException($"X86Instruction = {this}.");
            }
        }

        /// <summary>
        /// Set sf, zf, pf flags. 
        /// </summary>
        public static IEnumerable<(int flags, Expression value)> GetDefaultFlags(Expression dst)
        {
            yield return ((int) EflagsMaskEnum.sf, Expression.LessThan(NumberType.SignedInteger, dst, Expression.Zero(dst.LengthInBits)));
            yield return ((int) EflagsMaskEnum.zf, Expression.IsZero(dst));

            // pf - Сумма единиц в младшем байте + 1.
            // На практике не используется. Пропускаем.
            // 
            // var pf = true;
            // var x = dstValue;
            // for (var i = 0; i < 8; i++)
            // {
            //     pf ^= 0 != (x & 1);
            //     x >>= 1;
            // }
            // 
            // eflags.pf = pf;
        }

        public Expression GetOperandValue(int operandIndex)
        {
            var operand = Operands[operandIndex];
            var operandSize = operand.size != 0 ? operand.size : EffOprMode;

            switch (operand.type)
            {
                case ud_type.UD_OP_REG:
                    return Expression.RegisterAccess(operand.@base);

                case ud_type.UD_OP_MEM:
                {
                    var segment = GetEffectiveSegmentOfOperand(operand);
                    var address = GetOperandMemoryAddress(operandIndex, operand);
                    return Expression.MemoryAccess(segment, address, operandSize);
                }

                default:
                    throw new NotImplementedException($"X86Instruction: {this}, operandIndex: {operandIndex}.");
            }
        }

        public Expression SetOperandValue(int operandIndex, Expression expression)
        {
            var operand = Operands[operandIndex];
            var operandSize = operand.size != 0 ? operand.size : EffOprMode;

            if (expression.LengthInBits != operandSize)
                throw new InvalidOperationException(
                    $"Logic error: value.LengthInBits != operandSize. " +
                    $"X86Instruction: {this}, operandIndex: {operandIndex}, " +
                    $"value.LengthInBits: {expression.LengthInBits}, operandSize: {operandSize}.");

            switch (operand.type)
            {
                case ud_type.UD_OP_REG:
                    return Expression.Assign(Expression.RegisterAccess(operand.@base), expression);

                case ud_type.UD_OP_MEM:
                {
                    var segment = GetEffectiveSegmentOfOperand(operand);
                    var address = GetOperandMemoryAddress(operandIndex, operand);
                    return Expression.MemoryWrite(segment, address, expression);
                }

                default:
                    throw new NotImplementedException($"X86Instruction: {this}, operandIndex: {operandIndex}.");
            }
        }

        private Expression GetOperandMemoryAddress(int operandIndex, ud_operand operand)
        {
            var addressItems = new List<Expression>();

            if (operand.@base != ud_type.UD_NONE)
                addressItems.Add(Expression.RegisterAccess(operand.@base));

            if (operand.index != ud_type.UD_NONE)
            {
                Expression e = Expression.RegisterAccess(operand.index);

                if (1 < operand.scale)
                {
                    e = Expression.Multiply(
                        NumberType.UnsignedInteger,
                        Expression.Constant(operand.scale, e.LengthInBits),
                        e);
                }

                addressItems.Add(e);
            }

            if (operand.offset != 0)
            {
                int val;
                switch (operand.offset)
                {
                    case 8:
                        val = operand.lval.@sbyte;
                        break;
                    case 16:
                        val = operand.lval.sword;
                        break;
                    case 32:
                        val = operand.lval.sdword;
                        break;
                    default:
                        throw new NotImplementedException($"operand.offset: {operand.offset}");
                }

                addressItems.Add(Expression.Constant(val, AddrMode));
            }

            var address = Expression.Add(addressItems);

            if (address.LengthInBits != AddrMode)
                throw new InvalidOperationException(
                    $"Logic error: address.LengthInBits != AddrMode. " +
                    $"X86Instruction: {this}, operandIndex: {operandIndex}, " +
                    $"address.LengthInBits: {address.LengthInBits}, AddrMode: {AddrMode}.");

            return address;
        }
    }
}