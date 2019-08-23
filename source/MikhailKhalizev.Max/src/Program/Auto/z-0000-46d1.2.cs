using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x46d1-53cc6f46")]
        public void Method_0000_46d1_v2()
        {
            ii(0x46d1, 1);    wait();                                   /* wait */
            ii(0x46d2, 1);    pushw(ax);                                /* push ax */
            ii(0x46d3, 1);    pushw(bx);                                /* push bx */
            ii(0x46d4, 4);    jmpw_abs(memw_a16[ds, 0x9be]);            /* jmp word [0x9be] */
        }
    }
}
