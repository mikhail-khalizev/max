using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Decoder;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    // NOTE
    // arg1  eax
    // arg2  edx
    // arg3  ebx
    // arg4  ecx
    // arg5  push

    // NOTE
    // pushd(ebp);
    // mov(ebp, esp);
    //   sub(esp, 0x14);
    //   mov(memd_a32(ss, ebp - 0x4), edx);
    // mov(esp, ebp);

    public class HighLevelEngine
    {
        public static HighLevelEngine DecodeMethod(DetectedMethod method)
        {
            var hl = new HighLevelEngine(method.Instructions);
            hl.Decode();
            return hl;
        }


        public List<X86Instruction> Instructions { get; }
        public Block CurrentBlock { get; private set; }

        private HighLevelEngine(IEnumerable<IInstruction> instructions)
        {
            Instructions = instructions.OfType<X86Instruction>().ToList();
        }

        public void Decode()
        {
            CurrentBlock = new Block();

            X86Instruction prev = null;
            foreach (var instruction in Instructions)
            {
                if (prev != null && prev.End != instruction.Begin)
                    throw new NotImplementedException("prev.End != instruction.Begin");

                switch (instruction.Mnemonic)
                {
                    case ud_mnemonic_code.UD_Ipush:
                    {
                        RegisterInfo spRegInfo;
                        switch (instruction.Mode)
                        {
                            case 32:
                                spRegInfo = ud_type.UD_R_ESP;
                                break;

                            default:
                                throw new NotImplementedException($"X86Instruction = {instruction}, Mode = {instruction.Mode}.");
                        }
                            
                        var sp = CurrentBlock.GetRegister(spRegInfo);

                        switch (instruction.Operands[0].type)
                        {
                            case ud_type.UD_OP_REG:
                                var src = GetOperandValue(instruction, 0);
                                var newSp = sp - src.LengthInBits / 8;

                                CurrentBlock.SetRegister(spRegInfo, newSp);
                                CurrentBlock.SetMemory(ud_type.UD_R_SS, newSp, src);
                                break;

                            default:
                                throw new NotImplementedException(
                                    $"X86Instruction = {instruction}, Operands[0].type = {instruction.Operands[0].type}.");
                        }

                        break;
                    }

                    case ud_mnemonic_code.UD_Imov:
                    {
                        var src = GetOperandValue(instruction, 1);
                        SetOperandValue(instruction, 0, src);
                        break;
                    }

                    case ud_mnemonic_code.UD_Ixor:
                    {
                        var src = GetOperandValue(instruction, 1);
                        var dst = GetOperandValue(instruction, 0);

                        dst ^= src;

                        SetOperandValue(instruction, 0, dst);

                        CurrentBlock.UpdateFlags(
                            GetDefaultFlags(dst)
                                .Append((EflagsMaskEnum.cf, Expression.False))
                                .Append((EflagsMaskEnum.of, Expression.False)));
                        break;
                    }

                    default:
                        throw new NotImplementedException($"X86Instruction = {instruction}.");
                }

                prev = instruction;
            }
        }


        // Set sf, zf, pf flags.
        public IEnumerable<(EflagsMaskEnum flags, Expression value)> GetDefaultFlags(Expression dst)
        {
            yield return (EflagsMaskEnum.sf, Expression.IsNegative(dst));
            yield return (EflagsMaskEnum.zf, Expression.IsZero(dst));

            // // pf - Сумма единиц в младшем байте + 1.
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

        public Expression GetOperandValue(X86Instruction instruction, int operandIndex)
        {
            var operand = instruction.Operands[operandIndex];
            var operandSize = operand.size != 0 ? operand.size : instruction.EffOprMode;

            switch (operand.type)
            {
                case ud_type.UD_OP_REG:
                    return CurrentBlock.GetRegister(operand.@base);

                case ud_type.UD_OP_MEM:
                {
                    var segment = instruction.GetEffectiveSegmentOfOperand(operand);
                    var address = GetOperandMemoryAddress(instruction, operandIndex, operand);
                    return CurrentBlock.GetMemory(segment, address, operandSize);
                }

                default:
                    throw new NotImplementedException($"X86Instruction: {instruction}, operandIndex: {operandIndex}.");
            }
        }

        public void SetOperandValue(X86Instruction instruction, int operandIndex, Expression expression)
        {
            var operand = instruction.Operands[operandIndex];
            var operandSize = operand.size != 0 ? operand.size : instruction.EffOprMode;

            if (expression.LengthInBits != operandSize)
                throw new InvalidOperationException(
                    $"Logic error: value.LengthInBits != operandSize. " +
                    $"X86Instruction: {instruction}, operandIndex: {operandIndex}, " +
                    $"value.LengthInBits: {expression.LengthInBits}, operandSize: {operandSize}.");

            switch (operand.type)
            {
                case ud_type.UD_OP_REG:
                    CurrentBlock.SetRegister(operand.@base, expression);
                    break;

                case ud_type.UD_OP_MEM:
                {
                    var segment = instruction.GetEffectiveSegmentOfOperand(operand);
                    var address = GetOperandMemoryAddress(instruction, operandIndex, operand);
                    CurrentBlock.SetMemory(segment, address, expression);
                    break;
                }

                default:
                    throw new NotImplementedException($"X86Instruction: {instruction}, operandIndex: {operandIndex}.");
            }
        }

        private Expression GetOperandMemoryAddress(X86Instruction instruction, int operandIndex, ud_operand operand)
        {
            var addressItems = new List<(int Count, Expression Value)>();

            if (operand.@base != ud_type.UD_NONE)
                addressItems.Add((1, CurrentBlock.GetRegister(operand.@base)));

            if (operand.index != ud_type.UD_NONE)
                addressItems.Add((1 < operand.scale ? operand.scale : 1, CurrentBlock.GetRegister(operand.index)));

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

                addressItems.Add((1, Expression.Number(val, instruction.AddrMode)));
            }

            var address = Operations.Sum(addressItems);

            if (address.LengthInBits != instruction.AddrMode)
                throw new InvalidOperationException(
                    $"Logic error: address.LengthInBits != instruction.AddrMode. " +
                    $"X86Instruction: {instruction}, operandIndex: {operandIndex}, " +
                    $"address.LengthInBits: {address.LengthInBits}, instruction.AddrMode: {instruction.AddrMode}.");

            return address;
        }
    }
}