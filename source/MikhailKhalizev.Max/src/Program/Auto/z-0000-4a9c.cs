using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c703496a-f308-443f-9157-b3b23d921825")]
        public void Method_0000_4a9c()
        {
            ii(0x4a9c, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4a9e, 4);    pushw(memw_a16[ds, 0xac2]);               /* push word [0xac2] */
            ii(0x4aa2, 6);    mov(memw_a16[ds, 0xac2], 0x14c4);         /* mov word [0xac2], 0x14c4 */
            ii(0x4aa8, 4);    pushw(memw_a16[ss, bx + 0x2]);            /* push word [ss:bx+0x2] */
            ii(0x4aac, 3);    callw(0x589d, 0xdee);                     /* call 0x589d */
            ii(0x4aaf, 1);    popw(cx);                                 /* pop cx */
            ii(0x4ab0, 4);    popw(memw_a16[ds, 0xac2]);                /* pop word [0xac2] */
            ii(0x4ab4, 1);    retw(); return;                           /* ret */
        }
    }
}
