using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c49842c8-1b0e-44f6-870f-f1d548a4bfe7")]
        public void Method_0000_3f21()
        {
            ii(0x3f21, 1);    nop();                                    /* nop */
            ii(0x3f22, 1);    pushw(ax);                                /* push ax */
            ii(0x3f23, 1);    pushw(bx);                                /* push bx */
            ii(0x3f24, 4);    if(jmpw_abs(memw_a16[ds, 0x9be])) return; /* jmp word [0x9be] */
        }
    }
}
