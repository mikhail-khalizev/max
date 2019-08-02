using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1efe9570-2725-4453-aeaf-36410877d1b4")]
        public void Method_0015_fef1()
        {
            ii(0x15_fef1, 1); pushw(bp);                                /* push bp */
            ii(0x15_fef2, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fef4, 1); pushw(ds);                                /* push ds */
            ii(0x15_fef5, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fef8, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fefa, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_fefd, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_ff00, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_ff03, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_ff06, 1); nop();                                    /* nop */
            ii(0x15_ff07, 1); pushw(cs);                                /* push cs */
            ii(0x15_ff08, 3); callw(0x16_1182, 0x1277);                 /* call 0x1182 */
            ii(0x15_ff0b, 1); popw(ds);                                 /* pop ds */
            ii(0x15_ff0c, 1); leavew();                                 /* leave */
            ii(0x15_ff0d, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
