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
                case ud_mnemonic_code.UD_Iand:
                {
                    var left = GetOperandValue(0);
                    var right = GetOperandValue(1, left.LengthInBits);
                    var res = left & right;

                    yield return SetOperandValue(0, res);

                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(res)
                            .Append(((int) EflagsMaskEnum.cf, Expression.False))
                            .Append(((int) EflagsMaskEnum.of, Expression.False)));
                    break;
                }

                case ud_mnemonic_code.UD_Iadd:
                {
                    var left = GetOperandValue(0);
                    var right = GetOperandValue(1, left.LengthInBits);
                    var res = left + right;

                    var ss = Expression.IsSignedIntegerPositive(right);
                    var ds = Expression.IsSignedIntegerPositive(left);
                    var rs = Expression.IsSignedIntegerPositive(res);

                    yield return SetOperandValue(0, res);

                    // NOTE. af на практике не используется. Пропускаем.
                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(left)
                            .Append(
                                ((int) EflagsMaskEnum.cf,
                                    Expression.OrElse(
                                        Expression.LessThan(NumberType.UnsignedInteger, res, right),
                                        Expression.LessThan(NumberType.UnsignedInteger, res, left))))
                            .Append(
                                ((int) EflagsMaskEnum.of,
                                    Expression.AndAlso(
                                        Expression.Equal(ds, ss),
                                        Expression.NotEqual(ss, rs)))));
                    break;
                }
                
                case ud_mnemonic_code.UD_Iinc:
                {
                    var dst = GetOperandValue(0);
                    var res = dst + Expression.Constant(1, dst.LengthInBits);

                    var ss = Expression.True;
                    var ds = Expression.IsSignedIntegerPositive(dst);
                    var rs = Expression.IsSignedIntegerPositive(res);

                    yield return SetOperandValue(0, res);

                    // NOTE. af на практике не используется. Пропускаем.
                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(dst)
                            .Append(
                                ((int) EflagsMaskEnum.of,
                                    Expression.AndAlso(
                                        Expression.Equal(ds, ss),
                                        Expression.NotEqual(ss, rs)))));
                    break;
                }

                case ud_mnemonic_code.UD_Isub:
                {
                    foreach (var expression in SubOrCmpExpression(true))
                        yield return expression;
                    break;
                }

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

                    if (src is RegisterExpression re && re.RegisterInfo == spRegInfo)
                    {
                        yield return Expression.MemoryWrite(newSp, src);
                        yield return Expression.Assign(sp, newSp);
                    }
                    else
                    {
                        yield return Expression.Assign(sp, newSp);

                        sp = Expression.RegisterAccess(spRegInfo); // Read newSp.
                        yield return Expression.MemoryWrite(sp, src);
                    }

                    break;
                }

                case ud_mnemonic_code.UD_Ipop:
                {
                    foreach (var expression in PopExpression(GetOperandValue(0)))
                        yield return expression;
                    break;
                }

                case ud_mnemonic_code.UD_Imov:
                {
                    var src = GetOperandValue(1, GetOperandValue(0).LengthInBits);
                    yield return SetOperandValue(0, src);
                    break;
                }

                case ud_mnemonic_code.UD_Ixor:
                {
                    var left = GetOperandValue(0);
                    var right = GetOperandValue(1, left.LengthInBits);

                    left ^= right;

                    yield return SetOperandValue(0, left);
                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(left)
                            .Append(((int) EflagsMaskEnum.cf, Expression.False))
                            .Append(((int) EflagsMaskEnum.of, Expression.False)));
                    break;
                }

                case ud_mnemonic_code.UD_Icmp:
                {
                    foreach (var expression in SubOrCmpExpression(false))
                        yield return expression;
                    break;
                }

                case ud_mnemonic_code.UD_Itest:
                {
                    var left = GetOperandValue(0);
                    var right = GetOperandValue(1, left.LengthInBits);
                    var res = left & right;

                    yield return Expression.UpdateFlags(
                        RegisterInfo.Eflags,
                        GetDefaultFlags(res)
                            .Append(((int) EflagsMaskEnum.cf, Expression.False))
                            .Append(((int) EflagsMaskEnum.of, Expression.False)));
                    break;
                }
                    
                case ud_mnemonic_code.UD_Ijmp:
                {
                    yield return Expression.Goto(GetOperandValue(0));
                    break;
                }

                case ud_mnemonic_code.UD_Ijl:
                {
                    // Signed less.
                    // left < right
                    // eflags.sf != eflags.of

                    // left - right < 0 !=
                    //   (0 <= left   !=  0 <= right) &&
                    //   (0 <= right  ==  0 <= left - right )

                    /* l  r  rr sf of sf!=of
                     * +  +  +   0  0     0
                     * +  +  -   1  0     1
                     * +  -  +   0  0     0
                     * +  -  -   1  1     0
                     * -  +  +   0  1     1
                     * -  +  -   1  0     1
                     * -  -  +   0  0     0
                     * -  -  -   1  0     1  */

                    var eflags = Expression.RegisterAccess(RegisterInfo.Eflags);

                    var sf = Expression.IsNonZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.sf, eflags.LengthInBits));
                    var of = Expression.IsNonZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.of, eflags.LengthInBits));

                    yield return Expression.IfThen(
                        Expression.NotEqual(sf, of),
                        Expression.Goto(GetOperandValue(0))
                    );
                    break;
                }

                case ud_mnemonic_code.UD_Ijg:
                {
                    // Signed greater.
                    // left > right
                    // !eflags.zf && eflags.sf == eflags.of

                    var eflags = Expression.RegisterAccess(RegisterInfo.Eflags);

                    var nzf = Expression.IsZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.zf, eflags.LengthInBits));
                    var sf = Expression.IsNonZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.sf, eflags.LengthInBits));
                    var of = Expression.IsNonZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.of, eflags.LengthInBits));

                    yield return Expression.IfThen(
                        Expression.AndAlso(
                            nzf,
                            Expression.Equal(sf, of)),
                        Expression.Goto(GetOperandValue(0))
                    );
                    break;
                }

                case ud_mnemonic_code.UD_Ijz:
                {
                    var eflags = Expression.RegisterAccess(RegisterInfo.Eflags);
                    var zf = Expression.IsNonZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.zf, eflags.LengthInBits));

                    yield return Expression.IfThen(
                        zf,
                        Expression.Goto(GetOperandValue(0))
                    );
                    break;
                }

                case ud_mnemonic_code.UD_Ijnz:
                {
                    var eflags = Expression.RegisterAccess(RegisterInfo.Eflags);
                    var nzf = Expression.IsZero(eflags & Expression.Constant(ConstantType.Hex, (int) EflagsMaskEnum.zf, eflags.LengthInBits));

                    yield return Expression.IfThen(
                        nzf,
                        Expression.Goto(GetOperandValue(0))
                    );
                    break;
                }

                case ud_mnemonic_code.UD_Iret:
                {
                    foreach (var expression in PopExpression(Expression.RegisterAccess(RegisterInfo.Eip)))
                        yield return expression;
                    yield return Expression.Return();
                    break;
                }

                default:
                    throw new NotImplementedException($"X86Instruction = {this}.");
            }
        }

        public IEnumerable<Expression> PopExpression(Expression dst)
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
            
            yield return Expression.Assign(dst, Expression.MemoryAccess(sp, dst.LengthInBits));

            if (!(dst is RegisterExpression re && re.RegisterInfo == spRegInfo))
            {
                var newSp = sp + dst.LengthInBits / 8;
                yield return Expression.Assign(sp, newSp);
            }
        }

        private IEnumerable<Expression> SubOrCmpExpression(bool isSub)
        {
            var left = GetOperandValue(0);
            var right = GetOperandValue(1, left.LengthInBits);

            var res = left - right;
            var leftSign = Expression.IsSignedIntegerPositive(left);
            var rightSign = Expression.IsSignedIntegerPositive(right);
            var resultSign = Expression.IsSignedIntegerPositive(res);

            if (isSub)
                yield return SetOperandValue(0, res);
                        
            // NOTE. af на практике не используется. Пропускаем.
            yield return Expression.UpdateFlags(
                RegisterInfo.Eflags,
                GetDefaultFlags(res)
                    .Append(
                        ((int)
                            EflagsMaskEnum.cf,
                            Expression.LessThan(NumberType.UnsignedInteger, left, right)))
                    .Append(
                        ((int)
                            EflagsMaskEnum.of,
                            Expression.AndAlso(
                                Expression.NotEqual(leftSign, rightSign),
                                Expression.Equal(rightSign, resultSign)))));
        }


        /// <summary>
        /// Set sf, zf, pf flags. 
        /// </summary>
        public static IEnumerable<(int flags, Expression value)> GetDefaultFlags(Expression dst)
        {
            yield return ((int) EflagsMaskEnum.sf, Expression.IsSignedIntegerNegative(dst));
            yield return ((int) EflagsMaskEnum.zf, Expression.IsZero(dst));

            // NOTE. pf - Сумма единиц в младшем байте + 1.
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
            return GetOperandValue(operandIndex, EffOprMode);
        }

        public Expression GetOperandValue(int operandIndex, int lengthInBits)
        {
            var operand = Operands[operandIndex];
            var operandSize = operand.size != 0 ? operand.size : EffOprMode;

            switch (operand.type)
            {
                case ud_type.UD_OP_REG:
                    return Expression.RegisterAccess(operand.@base);

                case ud_type.UD_OP_MEM:
                {
                    var address = GetOperandMemoryAddress(operandIndex, operand);
                    return Expression.MemoryAccess(address, operandSize);
                }

                case ud_type.UD_OP_IMM:
                {
                    switch (operandSize)
                    {
                        case 8:
                        {
                            var needSignExtend = new[]
                            {
                                ud_mnemonic_code.UD_Iimul,
                                ud_mnemonic_code.UD_Ipush,
                                ud_mnemonic_code.UD_Iadc,
                                ud_mnemonic_code.UD_Iadd,
                                ud_mnemonic_code.UD_Isbb,
                                ud_mnemonic_code.UD_Isub,
                                ud_mnemonic_code.UD_Icmp
                            }.Contains(Mnemonic);

                            // Работа не с 8-битной инструкцией.
                            if (!(ud_type.UD_R_AL <= Operands[0].@base && Operands[0].@base <= ud_type.UD_R_BH))
                                needSignExtend = needSignExtend ||
                                    Mnemonic == ud_mnemonic_code.UD_Iand ||
                                    Mnemonic == ud_mnemonic_code.UD_Ior ||
                                    Mnemonic == ud_mnemonic_code.UD_Ixor;

                            if (needSignExtend)
                                return Expression.Constant(operand.lval.@sbyte, lengthInBits);
                            else
                                return Expression.Constant(operand.lval.@ubyte, lengthInBits);
                        }

                        case 16:
                            return Expression.Constant(operand.lval.uword, lengthInBits);

                        case 32:
                            return Expression.Constant(operand.lval.udword, lengthInBits);

                        default:
                            throw new NotImplementedException($"oprSize: {operandSize}");
                    }
                }

                case ud_type.UD_OP_JIMM:
                {
                    int val;
                    switch (operandSize)
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
                        default: throw new NotImplementedException($"oprSize: {operandSize}");
                    }

                    return Expression.Constant(ConstantType.Address, (int) End + val, AddrMode);
                }

                case ud_type.UD_OP_CONST:
                    return Expression.Constant(operand.lval.udword, lengthInBits);

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
                    var address = GetOperandMemoryAddress(operandIndex, operand);
                    return Expression.MemoryWrite(address, expression);
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