using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46cc-2d3d15cc")]
        public void Method_0000_46cc()
        {
            ii(0x46cc, 1);    nop();                                    /* nop */
            ii(0x46cd, 4);    jmpw_abs(memw_a16[ds, 0x9bc]);            /* jmp word [0x9bc] */
        }
    }
}
