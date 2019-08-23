using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1e1c-feb37d51")]
        public void Method_0019_1e1c()
        {
            ii(0x19_1e1c, 4); enter(0x6, 0);                            /* enter 0x6, 0x0 */
            ii(0x19_1e20, 3); lea(ax, bp + 0xc);                        /* lea ax, [bp+0xc] */
            ii(0x19_1e23, 1); push(ss);                                 /* push ss */
            ii(0x19_1e24, 1); push(ax);                                 /* push ax */
            ii(0x19_1e25, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_1e28, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_1e2b, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_1e2e, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_1e31, 1); push(cs);                                 /* push cs */
            ii(0x19_1e32, 3); call(0x19_1e37, 0x2);                     /* call 0x1e37 */
            ii(0x19_1e35, 1); leave();                                  /* leave */
            ii(0x19_1e36, 1); ret();                                    /* ret */
        }
    }
}
