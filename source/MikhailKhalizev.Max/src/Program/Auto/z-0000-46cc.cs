using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46cc-a1c13dc")]
        public void Method_0000_46cc()
        {
            ii(0x46cc, 1);    nop();                                    /* nop */
            ii(0x46cd, 4);    if(jmpw_abs(memw_a16[ds, 0x9bc])) return; /* jmp word [0x9bc] */
        }
    }
}
