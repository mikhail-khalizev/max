using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d983c4ba-0c1c-4db3-8c0f-326772a53a1f")]
        public void Method_0000_f07f()
        {
            ii(0xf07f, 1);    pushw(bp);                                /* push bp */
            ii(0xf080, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xf082, 3);    mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
            ii(0xf085, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0xf089, 4);    mov(memb_a16[ds, bx + 0x17], 0x49);       /* mov byte [bx+0x17], 0x49 */
            ii(0xf08d, 3);    callw(0xe863, -0x82d);                    /* call 0xe863 */
            ii(0xf090, 3);    mov(al, memb_a16[ds, bx + 0x26]);         /* mov al, [bx+0x26] */
            ii(0xf093, 3);    and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0xf096, 1);    popw(bp);                                 /* pop bp */
            ii(0xf097, 1);    retw(); return;                           /* ret */
        }
    }
}
