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
        public static Expression DecodeMethod(DetectedMethod method)
        {
            var rootExpression = GetRootExpression(method.Instructions);
            var rootExpressionStr = rootExpression.ToString();


            var r4 = SplitToScope.Process(rootExpression);
            var r4str = r4.ToString();

            var result3 = new IntroduceLocalVariablesVisitorV2(r4).Process();
            var result3Str = result3.ToString();
            

            var result2 = new IntroduceLocalVariablesVisitor().Visit(rootExpression);
            var result2Str = result2.ToString();

            // result = new SimplifyExpressionVisitor().Visit(result);
            // var result3Str = result.ToString();

            // result = new RemoveInnerBlockVisitor().Visit(result);
            // var result2Str = result.ToString();

            return rootExpression;
        }

        private static Expression GetRootExpression(IEnumerable<IInstruction> instructions)
        {
            var block = new List<Expression>();

            IInstruction prev = null;
            foreach (var instruction in instructions)
            {
                if (prev != null && prev.End != instruction.Begin)
                    throw new NotImplementedException("prev.End != instruction.Begin");

                if (instruction.Metadata.HasLabel)
                    block.Add(Expression.Label(instruction.Begin));

                block.Add(Expression.Comment(instruction.ToString()));
                block.AddRange(instruction.GetExpressions());

                prev = instruction;
            }

            return Expression.Block(block);
        }
    }
}