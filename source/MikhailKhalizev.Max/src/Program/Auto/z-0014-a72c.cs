using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abec1187-426a-43b5-b6cb-6575fd7cc1d1")]
        public void Method_0014_a72c()
        {
            ii(0x14_a72c, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x14_a72e, 1); pushw(ds);                                /* push ds */
            ii(0x14_a72f, 5); mov(ds, memw_a16[cs, 0x5680]);            /* mov ds, [cs:0x5680] */
            ii(0x14_a734, 4); mov(ds, memw_a16[ds, 0xc28]);             /* mov ds, [0xc28] */
            ii(0x14_a738, 4); pushw(memw_a16[ss, bx + 0xa]);            /* push word [ss:bx+0xa] */
            ii(0x14_a73c, 4); pushw(memw_a16[ss, bx + 0x8]);            /* push word [ss:bx+0x8] */
            ii(0x14_a740, 4); pushw(memw_a16[ss, bx + 0x6]);            /* push word [ss:bx+0x6] */
            ii(0x14_a744, 4); pushw(memw_a16[ss, bx + 0x4]);            /* push word [ss:bx+0x4] */
            ii(0x14_a748, 2); callw_abs(ax);                            /* call ax */
            ii(0x14_a74a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x14_a74d, 1); popw(ds);                                 /* pop ds */
            ii(0x14_a74e, 1); retfw(); return;                          /* retf */
        }
    }
}
