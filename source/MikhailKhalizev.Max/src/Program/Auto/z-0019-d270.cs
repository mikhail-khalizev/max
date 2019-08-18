using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d270-9c9afe5")]
        public void Method_0019_d270()
        {
            ii(0x19_d270, 1); pushw(bp);                                /* push bp */
            ii(0x19_d271, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d273, 1); pushw(ds);                                /* push ds */
            ii(0x19_d274, 3); pushw(0x29cc);                            /* push 0x29cc */
            ii(0x19_d277, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d27a, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d27d, 5); callw_far_abs(0x80, 0x4438);              /* call word 0x80:0x4438 */
            ii(0x19_d282, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_d284, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d286, 2); if(jnzw(0x19_d291, 0x9)) goto l_0x19_d291; /* jnz 0xd291 */
            ii(0x19_d288, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_d28b, 6); or(memb_a16[es, bx + 0x132], 0x2);        /* or byte [es:bx+0x132], 0x2 */
        l_0x19_d291:
            ii(0x19_d291, 1); leavew();                                 /* leave */
            ii(0x19_d292, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
