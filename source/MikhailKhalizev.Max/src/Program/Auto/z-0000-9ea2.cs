using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9ea2-4358619d")]
        public void Method_0000_9ea2()
        {
            ii(0x9ea2, 1);    pushw(bp);                                /* push bp */
            ii(0x9ea3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9ea5, 1);    pushw(si);                                /* push si */
            ii(0x9ea6, 1);    pushw(di);                                /* push di */
            ii(0x9ea7, 1);    pushw(ds);                                /* push ds */
            ii(0x9ea8, 3);    mov(ds, memw_a16[ss, bp + 0x4]);          /* mov ds, [bp+0x4] */
            ii(0x9eab, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x9eae, 3);    mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x9eb1, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0x9eb4, 3);    mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x9eb7, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x9eb9, 1);    popw(ds);                                 /* pop ds */
            ii(0x9eba, 1);    popw(di);                                 /* pop di */
            ii(0x9ebb, 1);    popw(si);                                 /* pop si */
            ii(0x9ebc, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9ebe, 1);    popw(bp);                                 /* pop bp */
            ii(0x9ebf, 1);    retw();                                   /* ret */
        }
    }
}
