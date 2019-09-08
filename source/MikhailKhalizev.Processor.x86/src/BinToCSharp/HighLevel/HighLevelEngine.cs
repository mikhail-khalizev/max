using System;
using System.Collections.Generic;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class HighLevelEngine
    {
        public List<CSharpInstruction> Instructions { get; }

        public HighLevelEngine(List<CSharpInstruction> instructions)
        {
            Instructions = instructions;
        }

        public void Decode()
        {
            CSharpInstruction prev = null;
            foreach (var instruction in Instructions)
            {
                if (prev != null && prev.End != instruction.Begin)
                    throw new NotImplementedException("prev.End != instruction.Begin");

                switch (instruction.Mnemonic)
                {
                    case ud_mnemonic_code.UD_Ipush:

                        //break;

                    default:
                        throw new NotImplementedException($"Instruction = {instruction}");
                }

                prev = instruction;
            }
        }
    }
}