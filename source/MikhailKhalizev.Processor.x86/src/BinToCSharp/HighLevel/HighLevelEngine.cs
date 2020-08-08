using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
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
        public List<Expression> Expressions { get; } = new List<Expression>();

        private HighLevelEngine(IEnumerable<IInstruction> instructions)
        {
            Instructions = instructions.OfType<X86Instruction>().ToList();
        }

        public void Decode()
        {
            X86Instruction prev = null;
            foreach (var instruction in Instructions)
            {
                if (prev != null && prev.End != instruction.Begin)
                    throw new NotImplementedException("prev.End != instruction.Begin");
                
                if (instruction.Metadata.HasLabel)
                    Expressions.Add(Expression.Label(instruction.Begin));
                Expressions.Add(Expression.Comment(instruction.ToString()));
                Expressions.AddRange(instruction.GetExpressions());

                prev = instruction;
            }

            var result = Expression.Block(Expressions);
            var str = result.ToString();
        }
    }
}