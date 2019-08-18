using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x59f4-22d2681f")]
        public void Method_0000_59f4()
        {
            ii(0x59f4, 1);    pushw(bp);                                /* push bp */
            ii(0x59f5, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x59f7, 3);    sub(sp, 0xe);                             /* sub sp, 0xe */
            ii(0x59fa, 4);    mov(memb_a16[ss, bp - 0xd], 0x4c);        /* mov byte [bp-0xd], 0x4c */
            ii(0x59fe, 3);    mov(al, memb_a16[ss, bp + 0x4]);          /* mov al, [bp+0x4] */
            ii(0x5a01, 3);    mov(memb_a16[ss, bp - 0xe], al);          /* mov [bp-0xe], al */
            ii(0x5a04, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x5a07, 1);    pushw(ax);                                /* push ax */
            ii(0x5a08, 1);    pushw(ax);                                /* push ax */
            ii(0x5a09, 3);    callw(0x5cc0, 0x2b4);                     /* call 0x5cc0 */
            ii(0x5a0c, 1);    popw(bx);                                 /* pop bx */
            ii(0x5a0d, 1);    popw(bx);                                 /* pop bx */
            ii(0x5a0e, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5a10, 1);    popw(bp);                                 /* pop bp */
            ii(0x5a11, 1);    retw(); return;                           /* ret */
        }
    }
}
