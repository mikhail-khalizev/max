using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.Decoder;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class HighLevelEngine
    {
        public List<X86Instruction> Instructions { get; }

        public HighLevelEngine(IEnumerable<IInstruction> instructions)
        {
            Instructions = instructions.OfType<X86Instruction>().ToList();
        }

        public void Decode()
        {
            var currentBlock = new Block();

            X86Instruction prev = null;
            foreach (var instruction in Instructions)
            {
                if (prev != null && prev.End != instruction.Begin)
                    throw new NotImplementedException("prev.End != instruction.Begin");

                switch (instruction.Mnemonic)
                {
                    case ud_mnemonic_code.UD_Ipush:
                    {
                        RegisterInfo spInfo;
                        switch (instruction.Mode)
                        {
                            case 32:
                                spInfo = ud_type.UD_R_ESP;
                                break;

                            default:
                                throw new NotImplementedException($"X86Instruction = {instruction}, Mode = {instruction.Mode}.");
                        }
                            
                        var sp = currentBlock.GetRegister(spInfo);

                        switch (instruction.Operands[0].type)
                        {
                            case ud_type.UD_OP_REG:
                                var src = currentBlock.GetRegister(instruction.Operands[0].@base);
                                var newSp = sp - src.Bits / 8;

                                currentBlock.SetRegister(spInfo, newSp);
                                currentBlock.SetMemory(newSp, src);
                                break;

                            default:
                                throw new NotImplementedException(
                                    $"X86Instruction = {instruction}, Operands[0].type = {instruction.Operands[0].type}.");
                        }

                        break;
                    }

                    default:
                        throw new NotImplementedException($"X86Instruction = {instruction}.");
                }

                prev = instruction;
            }
        }
    }
}