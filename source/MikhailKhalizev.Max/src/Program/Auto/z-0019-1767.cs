using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1767-9d987b15")]
        public void Method_0019_1767()
        {
            ii(0x19_1767, 1); pushw(bp);                                /* push bp */
            ii(0x19_1768, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_176a, 1); pushw(ds);                                /* push ds */
            ii(0x19_176b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_176e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_1770, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_1773, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_1776, 4); callw_a16_far_ind(ds, 0x38c0);            /* call far word [0x38c0] */
            ii(0x19_177a, 1); popw(ds);                                 /* pop ds */
            ii(0x19_177b, 1); leavew();                                 /* leave */
            ii(0x19_177c, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}