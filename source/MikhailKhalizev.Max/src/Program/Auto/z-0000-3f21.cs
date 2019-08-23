using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3f21-26567ecd")]
        public void Method_0000_3f21()
        {
            ii(0x3f21, 1);    nop();                                    /* nop */
            ii(0x3f22, 1);    push(ax);                                 /* push ax */
            ii(0x3f23, 1);    push(bx);                                 /* push bx */
            ii(0x3f24, 4);    jmp_abs(memw[ds, 0x9be]);                 /* jmp word [0x9be] */
        }
    }
}
