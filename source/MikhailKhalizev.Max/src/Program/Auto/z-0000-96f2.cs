using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d15e97cf-58c5-4511-816d-629687c6ee6c")]
        public void Method_0000_96f2()
        {
            ii(0x96f2, 1);    pushw(bp);                                /* push bp */
            ii(0x96f3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x96f5, 1);    pushw(si);                                /* push si */
            ii(0x96f6, 1);    pushw(di);                                /* push di */
            ii(0x96f7, 1);    pushw(ds);                                /* push ds */
            ii(0x96f8, 3);    mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0x96fb, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x96fe, 3);    mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x9701, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0x9704, 3);    mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x9707, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x9709, 1);    popw(ds);                                 /* pop ds */
            ii(0x970a, 1);    popw(di);                                 /* pop di */
            ii(0x970b, 1);    popw(si);                                 /* pop si */
            ii(0x970c, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x970e, 1);    popw(bp);                                 /* pop bp */
            ii(0x970f, 1);    retw(); return;                           /* ret */
        }
    }
}
