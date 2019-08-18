using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b6d4d6af-4262-4f98-96dd-4c291e9724e7")]
        public void Method_0000_4a87()
        {
            ii(0x4a87, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4a89, 3);    mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x4a8c, 1);    pushw(ax);                                /* push ax */
            ii(0x4a8d, 1);    pushw(ax);                                /* push ax */
            ii(0x4a8e, 3);    callw(0x5c10, 0x117f);                    /* call 0x5c10 */
            ii(0x4a91, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x4a92, 1);    popw(ax);                                 /* pop ax */
            ii(0x4a93, 1);    popw(dx);                                 /* pop dx */
            ii(0x4a94, 3);    mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x4a97, 2);    mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x4a99, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x4a9b, 1);    retw(); return;                           /* ret */
        }
    }
}
