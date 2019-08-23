using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0f0c-921ed6bb")]
        public void Method_0018_0f0c()
        {
            ii(0x18_0f0c, 1); push(bp);                                 /* push bp */
            ii(0x18_0f0d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_0f0f, 5); test(memb[ds, 0x19a3], 0x2);              /* test byte [0x19a3], 0x2 */
            ii(0x18_0f14, 2); if(jz(0x18_0f1a, 0x4)) goto l_0x18_0f1a;  /* jz 0xf1a */
            ii(0x18_0f16, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_0f18, 1); leave();                                  /* leave */
            ii(0x18_0f19, 1); retf(); return;                           /* retf */
        l_0x18_0f1a:
            ii(0x18_0f1a, 3); push(memw[ss, bp + 0x14]);                /* push word [bp+0x14] */
            ii(0x18_0f1d, 3); push(memw[ss, bp + 0x12]);                /* push word [bp+0x12] */
            ii(0x18_0f20, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x18_0f23, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x18_0f26, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x18_0f29, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x18_0f2c, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x18_0f2f, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x18_0f32, 4); call_far_ind(memw[ds, 0x1b60]);           /* call far word [0x1b60] */
            ii(0x18_0f36, 1); leave();                                  /* leave */
            ii(0x18_0f37, 1); retf();                                   /* retf */
        }
    }
}
