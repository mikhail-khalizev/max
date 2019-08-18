using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c860c654-e773-495f-ada8-1022de077bab")]
        public void Method_0017_9177()
        {
            ii(0x17_9177, 1); pushw(bp);                                /* push bp */
            ii(0x17_9178, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_917a, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x17_917d, 1); pushw(es);                                /* push es */
            ii(0x17_917e, 1); pushw(ds);                                /* push ds */
            ii(0x17_917f, 1); pushw(ds);                                /* push ds */
            ii(0x17_9180, 1); popw(es);                                 /* pop es */
            ii(0x17_9181, 3); lds(dx, ss, bp + 0x8);                    /* lds dx, [bp+0x8] */
            ii(0x17_9184, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x17_9187, 5); callw_a16_far_ind(es, 0x1fe0);            /* call far word [es:0x1fe0] */
            ii(0x17_918c, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x17_918e, 2); or(ax, bx);                               /* or ax, bx */
            ii(0x17_9190, 1); popw(ds);                                 /* pop ds */
            ii(0x17_9191, 1); popw(es);                                 /* pop es */
            ii(0x17_9192, 1); popw(bp);                                 /* pop bp */
            ii(0x17_9193, 1); cld();                                    /* cld */
            ii(0x17_9194, 1); retfw(); return;                          /* retf */
        }
    }
}
