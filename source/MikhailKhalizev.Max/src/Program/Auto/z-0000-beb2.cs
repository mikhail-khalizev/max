using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("edeab6a3-8305-40b7-98fb-df6e58ab645d")]
        public void Method_0000_beb2()
        {
            ii(0xbeb2, 1);    pushw(bp);                                /* push bp */
            ii(0xbeb3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xbeb5, 1);    pushw(si);                                /* push si */
            ii(0xbeb6, 1);    pushw(di);                                /* push di */
            ii(0xbeb7, 1);    pushw(ds);                                /* push ds */
            ii(0xbeb8, 3);    mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0xbebb, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0xbebe, 3);    mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0xbec1, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0xbec4, 3);    mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0xbec7, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0xbec9, 1);    popw(ds);                                 /* pop ds */
            ii(0xbeca, 1);    popw(di);                                 /* pop di */
            ii(0xbecb, 1);    popw(si);                                 /* pop si */
            ii(0xbecc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0xbece, 1);    popw(bp);                                 /* pop bp */
            ii(0xbecf, 1);    retw(); return;                           /* ret */
        }
    }
}
