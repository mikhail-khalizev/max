using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_338a-60ba34df")]
        public void Method_0019_338a()
        {
            ii(0x19_338a, 1); push(bp);                                 /* push bp */
            ii(0x19_338b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_338d, 1); push(si);                                 /* push si */
            ii(0x19_338e, 1); push(di);                                 /* push di */
            ii(0x19_338f, 1); push(ds);                                 /* push ds */
            ii(0x19_3390, 3); mov(ds, memw[ss, bp + 6]);                /* mov ds, [bp+0x6] */
            ii(0x19_3393, 3); mov(si, memw[ss, bp + 8]);                /* mov si, [bp+0x8] */
            ii(0x19_3396, 3); mov(es, memw[ss, bp + 10]);               /* mov es, [bp+0xa] */
            ii(0x19_3399, 3); mov(di, memw[ss, bp + 12]);               /* mov di, [bp+0xc] */
            ii(0x19_339c, 3); mov(cx, memw[ss, bp + 14]);               /* mov cx, [bp+0xe] */
            ii(0x19_339f, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x19_33a1, 1); pop(ds);                                  /* pop ds */
            ii(0x19_33a2, 1); pop(di);                                  /* pop di */
            ii(0x19_33a3, 1); pop(si);                                  /* pop si */
            ii(0x19_33a4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_33a6, 1); pop(bp);                                  /* pop bp */
            ii(0x19_33a7, 1); retf();                                   /* retf */
        }
    }
}
