using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_ffd5-f8232716")]
        public void Method_0019_ffd5()
        {
            ii(0x19_ffd5, 1); pushw(bp);                                /* push bp */
            ii(0x19_ffd6, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_ffd8, 1); pushw(ds);                                /* push ds */
            ii(0x19_ffd9, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_ffdc, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_ffde, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_ffe1, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_ffe4, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_ffe7, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_ffea, 5); callw_far_abs(0x80, 0x45c0);              /* call word 0x80:0x45c0 */
            ii(0x19_ffef, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_fff2, 1); popw(ds);                                 /* pop ds */
            ii(0x19_fff3, 1); leavew();                                 /* leave */
            ii(0x19_fff4, 3); retw(0x8);                                /* ret 0x8 */
        }
    }
}
