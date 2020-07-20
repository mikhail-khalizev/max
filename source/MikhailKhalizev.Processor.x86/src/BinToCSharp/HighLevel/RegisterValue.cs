using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class RegisterValue : Value
    {
        public RegisterInfo RegisterInfo { get; }

        public RegisterValue(RegisterInfo registerInfo) : base(registerInfo.LengthInBits)
        {
            RegisterInfo = registerInfo;
        }
    }
}