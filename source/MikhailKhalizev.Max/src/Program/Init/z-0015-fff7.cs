using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b0583cd-ea40-48aa-ae1d-b51d50c71eae")]
        public void Method_0015_fff7()
        {
            ii(0x15_fff7, 1); pushw(bp);                                /* push bp */
            ii(0x15_fff8, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fffa, 1); pushw(ds);                                /* push ds */
            ii(0x15_fffb, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fffe, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x16_0000, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x16_0003, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x16_0006, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x16_0009, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x16_000c, 1); nop();                                    /* nop */
            ii(0x16_000d, 1); pushw(cs);                                /* push cs */
            ii(0x16_000e, 3); callw(0x16_1376, 0x1365);                 /* call 0x1376 */
            ii(0x16_0011, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0012, 1); leavew();                                 /* leave */
            ii(0x16_0013, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
