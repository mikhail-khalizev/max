using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x60e7-2807acbf")]
        public void Method_0000_60e7()
        {
            ii(0x60e7, 5);  jmp_abs(memw[cs, 0x2fa]);                  /* jmp word [cs:0x2fa] */
        }
    }
}
