using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b28513db-ca3b-4635-ada0-415eb153bf80")]
        public void Method_0015_fed2()
        {
            ii(0x15_fed2, 1); pushw(bp);                                /* push bp */
            ii(0x15_fed3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fed5, 1); pushw(ds);                                /* push ds */
            ii(0x15_fed6, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fed9, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fedb, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_fede, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_fee1, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fee4, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fee7, 1); nop();                                    /* nop */
            ii(0x15_fee8, 1); pushw(cs);                                /* push cs */
            ii(0x15_fee9, 3); callw(0x16_1135, 0x1249);                 /* call 0x1135 */
            ii(0x15_feec, 1); popw(ds);                                 /* pop ds */
            ii(0x15_feed, 1); leavew();                                 /* leave */
            ii(0x15_feee, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
