using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("df52c892-b3f3-4d3d-bb1a-fcc27beb4bdf")]
        public void Method_001a_15b9()
        {
            ii(0x1a_15b9, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x1a_15bd, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x1a_15c0, 1); pushw(ss);                                /* push ss */
            ii(0x1a_15c1, 1); pushw(ax);                                /* push ax */
            ii(0x1a_15c2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_15c5, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_15c8, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_15cb, 1); pushw(cs);                                /* push cs */
            ii(0x1a_15cc, 3); callw(0x1a_1586, -0x49);                  /* call 0x1586 */
            ii(0x1a_15cf, 1); leavew();                                 /* leave */
            ii(0x1a_15d0, 1); retfw(); return;                          /* retf */
        }
    }
}
