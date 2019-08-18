using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e7bc16a3-e519-49ba-ae92-bc17b560a1d6")]
        public void Method_0019_338a()
        {
            ii(0x19_338a, 1); pushw(bp);                                /* push bp */
            ii(0x19_338b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_338d, 1); pushw(si);                                /* push si */
            ii(0x19_338e, 1); pushw(di);                                /* push di */
            ii(0x19_338f, 1); pushw(ds);                                /* push ds */
            ii(0x19_3390, 3); mov(ds, memw_a16[ss, bp + 0x6]);          /* mov ds, [bp+0x6] */
            ii(0x19_3393, 3); mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x19_3396, 3); mov(es, memw_a16[ss, bp + 0xa]);          /* mov es, [bp+0xa] */
            ii(0x19_3399, 3); mov(di, memw_a16[ss, bp + 0xc]);          /* mov di, [bp+0xc] */
            ii(0x19_339c, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x19_339f, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x19_33a1, 1); popw(ds);                                 /* pop ds */
            ii(0x19_33a2, 1); popw(di);                                 /* pop di */
            ii(0x19_33a3, 1); popw(si);                                 /* pop si */
            ii(0x19_33a4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_33a6, 1); popw(bp);                                 /* pop bp */
            ii(0x19_33a7, 1); retfw(); return;                          /* retf */
        }
    }
}
