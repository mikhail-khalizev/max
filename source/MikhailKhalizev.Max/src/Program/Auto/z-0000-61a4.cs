using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x61a4-22d2681f")]
        public void Method_0000_61a4()
        {
            ii(0x61a4, 1);    push(bp);                                 /* push bp */
            ii(0x61a5, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x61a7, 3);    sub(sp, 0xe);                             /* sub sp, 0xe */
            ii(0x61aa, 4);    mov(memb[ss, bp - 0xd], 0x4c);            /* mov byte [bp-0xd], 0x4c */
            ii(0x61ae, 3);    mov(al, memb[ss, bp + 0x4]);              /* mov al, [bp+0x4] */
            ii(0x61b1, 3);    mov(memb[ss, bp - 0xe], al);              /* mov [bp-0xe], al */
            ii(0x61b4, 3);    lea(ax, memw[ss, bp - 0xe]);              /* lea ax, [bp-0xe] */
            ii(0x61b7, 1);    push(ax);                                 /* push ax */
            ii(0x61b8, 1);    push(ax);                                 /* push ax */
            ii(0x61b9, 3);    call(0x6470, 0x2b4);                      /* call 0x6470 */
            ii(0x61bc, 1);    pop(bx);                                  /* pop bx */
            ii(0x61bd, 1);    pop(bx);                                  /* pop bx */
            ii(0x61be, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x61c0, 1);    pop(bp);                                  /* pop bp */
            ii(0x61c1, 1);    ret();                                    /* ret */
        }
    }
}
