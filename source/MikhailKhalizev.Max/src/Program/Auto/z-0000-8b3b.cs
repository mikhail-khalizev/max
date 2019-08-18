using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8b3b-b19fb225")]
        public void Method_0000_8b3b()
        {
            ii(0x8b3b, 3);    mov(al, memb_a16[ds, 0x1186]);            /* mov al, [0x1186] */
            ii(0x8b3e, 1);    cbw();                                    /* cbw */
            ii(0x8b3f, 1);    pushw(ax);                                /* push ax */
            ii(0x8b40, 3);    callw(0xc405, 0x38c2);                    /* call 0xc405 */
            ii(0x8b43, 1);    popw(bx);                                 /* pop bx */
            ii(0x8b44, 1);    retw(); return;                           /* ret */
        }
    }
}
