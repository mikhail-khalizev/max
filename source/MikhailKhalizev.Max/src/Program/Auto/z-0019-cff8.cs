using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cff8-31b54e86")]
        public void Method_0019_cff8()
        {
            ii(0x19_cff8, 1); pushw(bp);                                /* push bp */
            ii(0x19_cff9, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_cffb, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_cffe, 3); callw(0x19_a14c, -0x2eb5);                /* call 0xa14c */
            ii(0x19_d001, 1); pushw(dx);                                /* push dx */
            ii(0x19_d002, 1); pushw(ax);                                /* push ax */
            ii(0x19_d003, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_d006, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d009, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d00c, 3); callw(0x19_ce70, -0x19f);                 /* call 0xce70 */
            ii(0x19_d00f, 1); leavew();                                 /* leave */
            ii(0x19_d010, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
