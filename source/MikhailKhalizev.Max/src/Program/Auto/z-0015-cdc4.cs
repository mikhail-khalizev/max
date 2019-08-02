using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d7a2c3b0-8748-4417-b379-479fd44e6e1d")]
        public void Method_0015_cdc4()
        {
            ii(0x15_cdc4, 1); pushw(bp);                                /* push bp */
            ii(0x15_cdc5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_cdc7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_cdca, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_cdcd, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_cdd0, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_cdd3, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_cdd6, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_cdd9, 1); pushw(ds);                                /* push ds */
            ii(0x15_cdda, 3); pushw(0x28e3);                            /* push 0x28e3 */
            ii(0x15_cddd, 3); pushw(0x8fd);                             /* push 0x8fd */
            ii(0x15_cde0, 5); callw_far_abs(0x80, 0x21d2);              /* call word 0x80:0x21d2 */
            ii(0x15_cde5, 1); leavew();                                 /* leave */
            ii(0x15_cde6, 3); retw(0xc); return;                        /* ret 0xc */
        }
    }
}
