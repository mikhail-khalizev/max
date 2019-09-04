using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe833-98e7ac15")]
        public void Method_0000_e833()
        {
            ii(0xe833, 1);    pusha();                                  /* pusha */
            ii(0xe834, 3);    lea(ax, memw[ds, bx + 4]);                /* lea ax, [bx+0x4] */
            ii(0xe837, 1);    push(ds);                                 /* push ds */
            ii(0xe838, 1);    push(ax);                                 /* push ax */
            ii(0xe839, 1);    push(ds);                                 /* push ds */
            ii(0xe83a, 1);    push(ax);                                 /* push ax */
            ii(0xe83b, 2);    push(0x21);                               /* push 0x21 */
            ii(0xe83d, 4);    call_far_ind(memw[ds, 0x22]);             /* call far word [0x22] */
            ii(0xe841, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe844, 4);    mov(bx, memw[ds, 0x99e]);                 /* mov bx, [0x99e] */
            ii(0xe848, 3);    mov(cx, memw[ss, bp + 38]);               /* mov cx, [bp+0x26] */
            ii(0xe84b, 3);    and(ch, 2);                               /* and ch, 0x2 */
            ii(0xe84e, 3);    and(ah, 0xfd);                            /* and ah, 0xfd */
            ii(0xe851, 2);    or(ah, ch);                               /* or ah, ch */
            ii(0xe853, 3);    mov(memw[ds, bx + 38], ax);               /* mov [bx+0x26], ax */
            ii(0xe856, 1);    push(ds);                                 /* push ds */
            ii(0xe857, 1);    pop(es);                                  /* pop es */
            ii(0xe858, 1);    popa();                                   /* popa */
            ii(0xe859, 5);    cmp(memb[ds, 0xc45], 0);                  /* cmp byte [0xc45], 0x0 */
            ii(0xe85e, 2);    if(jnz_func(0xe829, -0x37)) return;       /* jnz 0xe829 */
            ii(0xe860, 1);    cld();                                    /* cld */
            ii(0xe861, 1);    cli();                                    /* cli */
            ii(0xe862, 1);    ret();                                    /* ret */
        }
    }
}
