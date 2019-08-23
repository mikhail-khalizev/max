using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a863-98e7ac15")]
        public void Method_0018_a863()
        {
            ii(0x18_a863, 1); pusha();                                  /* pusha */
            ii(0x18_a864, 3); lea(ax, bx + 0x4);                        /* lea ax, [bx+0x4] */
            ii(0x18_a867, 1); push(ds);                                 /* push ds */
            ii(0x18_a868, 1); push(ax);                                 /* push ax */
            ii(0x18_a869, 1); push(ds);                                 /* push ds */
            ii(0x18_a86a, 1); push(ax);                                 /* push ax */
            ii(0x18_a86b, 2); push(0x21);                               /* push 0x21 */
            ii(0x18_a86d, 4); call_far_ind(ds, 0x22);                   /* call far word [0x22] */
            ii(0x18_a871, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x18_a874, 4); mov(bx, memw[ds, 0x99e]);                 /* mov bx, [0x99e] */
            ii(0x18_a878, 3); mov(cx, memw[ss, bp + 0x26]);             /* mov cx, [bp+0x26] */
            ii(0x18_a87b, 3); and(ch, 0x2);                             /* and ch, 0x2 */
            ii(0x18_a87e, 3); and(ah, 0xfd);                            /* and ah, 0xfd */
            ii(0x18_a881, 2); or(ah, ch);                               /* or ah, ch */
            ii(0x18_a883, 3); mov(memw[ds, bx + 0x26], ax);             /* mov [bx+0x26], ax */
            ii(0x18_a886, 1); push(ds);                                 /* push ds */
            ii(0x18_a887, 1); pop(es);                                  /* pop es */
            ii(0x18_a888, 1); popa();                                   /* popa */
            ii(0x18_a889, 5); cmp(memb[ds, 0xc45], 0);                  /* cmp byte [0xc45], 0x0 */
            ii(0x18_a88e, 2); if(jnz_func(0x18_a859, -0x37)) return;    /* jnz 0xa859 */
            ii(0x18_a890, 1); cld();                                    /* cld */
            ii(0x18_a891, 1); cli();                                    /* cli */
            ii(0x18_a892, 1); ret();                                    /* ret */
        }
    }
}
