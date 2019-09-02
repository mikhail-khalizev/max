using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_15b9-836688c")]
        public void Method_001a_15b9()
        {
            ii(0x1a_15b9, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x1a_15bd, 3); lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x1a_15c0, 1); push(ss);                                 /* push ss */
            ii(0x1a_15c1, 1); push(ax);                                 /* push ax */
            ii(0x1a_15c2, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x1a_15c5, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x1a_15c8, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x1a_15cb, 1); push(cs);                                 /* push cs */
            ii(0x1a_15cc, 3); call(0x1a_1586, -0x49);                   /* call 0x1586 */
            ii(0x1a_15cf, 1); leave();                                  /* leave */
            ii(0x1a_15d0, 1); retf();                                   /* retf */
        }
    }
}
