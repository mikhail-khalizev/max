using System;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class RegisterExpression : Expression
    {
        public RegisterInfo RegisterInfo { get; }

        public RegisterExpression(RegisterInfo registerInfo) : base(ExpressionType.Todo_Remove, registerInfo.LengthInBits)
        {
            RegisterInfo = registerInfo;
        }
    }
}