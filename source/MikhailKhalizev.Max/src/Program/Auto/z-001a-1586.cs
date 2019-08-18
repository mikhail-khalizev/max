using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1586-d54a7f44")]
        public void Method_001a_1586()
        {
            ii(0x1a_1586, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x1a_158a, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x1a_158d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_1590, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_1593, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_1596, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_1599, 1); pushw(cs);                                /* push cs */
            ii(0x1a_159a, 3); callw(0x1a_13a6, -0x1f7);                 /* call 0x13a6 */
            ii(0x1a_159d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x1a_15a0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x1a_15a2, 2); if(jnzw(0x1a_15b7, 0x13)) goto l_0x1a_15b7; /* jnz 0x15b7 */
            ii(0x1a_15a4, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x1a_15a7, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_15aa, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_15ad, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_15b0, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_15b3, 1); pushw(cs);                                /* push cs */
            ii(0x1a_15b4, 3); callw(0x1a_148c, -0x12b);                 /* call 0x148c */
        l_0x1a_15b7:
            ii(0x1a_15b7, 1); leavew();                                 /* leave */
            ii(0x1a_15b8, 1); retfw(); return;                          /* retf */
        }
    }
}
