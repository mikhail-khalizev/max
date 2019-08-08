using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6258f2a6-11d2-4e07-bc41-0bb6a82d6313")]
        public void Method_0015_ff4a()
        {
            ii(0x15_ff4a, 1); pushw(bp);                                /* push bp */
            ii(0x15_ff4b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_ff4d, 1); pushw(ds);                                /* push ds */
            ii(0x15_ff4e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_ff51, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_ff53, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ff56, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_ff59, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_ff5c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ff5f, 5); callw_far_abs(0x80, 0x457a);              /* call word 0x80:0x457a */
            ii(0x15_ff64, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_ff67, 1); popw(ds);                                 /* pop ds */
            ii(0x15_ff68, 1); leavew();                                 /* leave */
            ii(0x15_ff69, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
