using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6b2b-b19fb225")]
        public void Method_0000_6b2b()
        {
            ii(0x6b2b, 3);    mov(al, memb_a16[ds, 0x1186]);            /* mov al, [0x1186] */
            ii(0x6b2e, 1);    cbw();                                    /* cbw */
            ii(0x6b2f, 1);    pushw(ax);                                /* push ax */
            ii(0x6b30, 3);    callw(0xa3f5, 0x38c2);                    /* call 0xa3f5 */
            ii(0x6b33, 1);    popw(bx);                                 /* pop bx */
            ii(0x6b34, 1);    retw();                                   /* ret */
        }
    }
}
