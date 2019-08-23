using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9e60-95337e2")]
        public void Method_0019_9e60()
        {
            ii(0x19_9e60, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x19_9e64, 5); mov(memw_a16[ss, bp - 0xc], 0);           /* mov word [bp-0xc], 0x0 */
            ii(0x19_9e69, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_9e6c, 6); cmp(memw_a16[es, bx + 0x12a], 0);         /* cmp word [es:bx+0x12a], 0x0 */
            ii(0x19_9e72, 2); if(jlw(0x19_9e84, 0x10)) goto l_0x19_9e84; /* jl 0x9e84 */
            ii(0x19_9e74, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x19_9e76, 4); lea(ax, bx + 0x12a);                      /* lea ax, [bx+0x12a] */
            ii(0x19_9e7a, 1); pushw(es);                                /* push es */
            ii(0x19_9e7b, 1); pushw(ax);                                /* push ax */
            ii(0x19_9e7c, 3); lea(ax, bp - 0x22);                       /* lea ax, [bp-0x22] */
            ii(0x19_9e7f, 1); pushw(ss);                                /* push ss */
            ii(0x19_9e80, 1); pushw(ax);                                /* push ax */
            ii(0x19_9e81, 3); callw(0x19_9bb6, -0x2ce);                 /* call 0x9bb6 */
        l_0x19_9e84:
            ii(0x19_9e84, 1); leavew();                                 /* leave */
            ii(0x19_9e85, 3); retw(0x4);                                /* ret 0x4 */
        }
    }
}
