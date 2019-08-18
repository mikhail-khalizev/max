using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cd5c-92674813")]
        public void Method_0019_cd5c()
        {
            ii(0x19_cd5c, 1); pushw(bp);                                /* push bp */
            ii(0x19_cd5d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_cd5f, 1); pushw(ds);                                /* push ds */
            ii(0x19_cd60, 3); pushw(0x284f);                            /* push 0x284f */
            ii(0x19_cd63, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_cd66, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_cd69, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_cd6c, 1); nop();                                    /* nop */
            ii(0x19_cd6d, 1); pushw(cs);                                /* push cs */
            ii(0x19_cd6e, 3); callw(0x1a_053f, 0x37ce);                 /* call 0x53f */
            ii(0x19_cd71, 1); leavew();                                 /* leave */
            ii(0x19_cd72, 1); retfw(); return;                          /* retf */
        }
    }
}
