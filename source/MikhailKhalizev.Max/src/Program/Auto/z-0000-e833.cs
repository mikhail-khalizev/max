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
            ii(0xe834, 3);    lea(ax, bx + 0x4);                        /* lea ax, [bx+0x4] */
            ii(0xe837, 1);    pushw(ds);                                /* push ds */
            ii(0xe838, 1);    pushw(ax);                                /* push ax */
            ii(0xe839, 1);    pushw(ds);                                /* push ds */
            ii(0xe83a, 1);    pushw(ax);                                /* push ax */
            ii(0xe83b, 2);    pushw(0x21);                              /* push 0x21 */
            ii(0xe83d, 4);    callw_a16_far_ind(ds, 0x22);              /* call far word [0x22] */
            ii(0xe841, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe844, 4);    mov(bx, memw_a16[ds, 0x99e]);             /* mov bx, [0x99e] */
            ii(0xe848, 3);    mov(cx, memw_a16[ss, bp + 0x26]);         /* mov cx, [bp+0x26] */
            ii(0xe84b, 3);    and(ch, 0x2);                             /* and ch, 0x2 */
            ii(0xe84e, 3);    and(ah, 0xfd);                            /* and ah, 0xfd */
            ii(0xe851, 2);    or(ah, ch);                               /* or ah, ch */
            ii(0xe853, 3);    mov(memw_a16[ds, bx + 0x26], ax);         /* mov [bx+0x26], ax */
            ii(0xe856, 1);    pushw(ds);                                /* push ds */
            ii(0xe857, 1);    popw(es);                                 /* pop es */
            ii(0xe858, 1);    popa();                                   /* popa */
            ii(0xe859, 5);    cmp(memb_a16[ds, 0xc45], 0);              /* cmp byte [0xc45], 0x0 */
            ii(0xe85e, 2);    if(jnzw_func(0xe829, -0x37)) return;      /* jnz 0xe829 */
            ii(0xe860, 1);    cld();                                    /* cld */
            ii(0xe861, 1);    cli();                                    /* cli */
            ii(0xe862, 1);    retw();                                   /* ret */
        }
    }
}
