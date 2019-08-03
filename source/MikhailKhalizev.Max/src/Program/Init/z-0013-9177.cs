using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cbe2e058-0360-462c-8b76-50f38d8b3b04")]
        public void Method_0013_9177()
        {
            ii(0x13_9177, 1); pushw(bp);                                /* push bp */
            ii(0x13_9178, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_917a, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x13_917d, 1); pushw(es);                                /* push es */
            ii(0x13_917e, 1); pushw(ds);                                /* push ds */
            ii(0x13_917f, 1); pushw(ds);                                /* push ds */
            ii(0x13_9180, 1); popw(es);                                 /* pop es */
            ii(0x13_9181, 3); lds(dx, ss, bp + 0x8);                    /* lds dx, [bp+0x8] */
            ii(0x13_9184, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x13_9187, 5); callw_a16_far_ind(es, 0x1fe0);            /* call far word [es:0x1fe0] */
            ii(0x13_918c, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x13_918e, 2); or(ax, bx);                               /* or ax, bx */
            ii(0x13_9190, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9191, 1); popw(es);                                 /* pop es */
            ii(0x13_9192, 1); popw(bp);                                 /* pop bp */
            ii(0x13_9193, 1); cld();                                    /* cld */
            ii(0x13_9194, 1); retfw(); return;                          /* retf */
        }
    }
}
