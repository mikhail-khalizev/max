using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("debff7b3-6409-44fa-a4de-329af550973b")]
        public void Method_0015_cd9f()
        {
            ii(0x15_cd9f, 1); pushw(bp);                                /* push bp */
            ii(0x15_cda0, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_cda2, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_cda5, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_cda8, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_cdab, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_cdae, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_cdb1, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_cdb4, 1); pushw(ds);                                /* push ds */
            ii(0x15_cdb5, 3); pushw(0x28bb);                            /* push 0x28bb */
            ii(0x15_cdb8, 3); pushw(0x8fc);                             /* push 0x8fc */
            ii(0x15_cdbb, 5); callw_far_abs(0x80, 0x21d2);              /* call word 0x80:0x21d2 */
            ii(0x15_cdc0, 1); leavew();                                 /* leave */
            ii(0x15_cdc1, 3); retw(0xc); return;                        /* ret 0xc */
        }
    }
}
