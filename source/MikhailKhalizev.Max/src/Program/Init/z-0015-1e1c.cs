using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c2dcc7ce-bdb3-41ea-a50f-d3ca5f477ab4")]
        public void Method_0015_1e1c()
        {
            ii(0x15_1e1c, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_1e20, 3); lea(ax, bp + 0xc);                        /* lea ax, [bp+0xc] */
            ii(0x15_1e23, 1); pushw(ss);                                /* push ss */
            ii(0x15_1e24, 1); pushw(ax);                                /* push ax */
            ii(0x15_1e25, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_1e28, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_1e2b, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_1e2e, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_1e31, 1); pushw(cs);                                /* push cs */
            ii(0x15_1e32, 3); callw(0x15_1e37, 0x2);                    /* call 0x1e37 */
            ii(0x15_1e35, 1); leavew();                                 /* leave */
            ii(0x15_1e36, 1); retw(); return;                           /* ret */
        }
    }
}
