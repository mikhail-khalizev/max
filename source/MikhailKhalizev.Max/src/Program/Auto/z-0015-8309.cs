using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3dedff61-262d-4d2e-94cd-d62683fefd8c")]
        public void Method_0015_8309()
        {
            ii(0x15_8309, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_830d, 1); pushw(di);                                /* push di */
            ii(0x15_830e, 1); pushw(si);                                /* push si */
            ii(0x15_830f, 1); pushw(ds);                                /* push ds */
            ii(0x15_8310, 3); pushw(0x16da);                            /* push 0x16da */
            ii(0x15_8313, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8316, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x15_831a, 3); callw(0x15_5c7a, -0x26a3);                /* call 0x5c7a */
            ii(0x15_831d, 1); pushw(ds);                                /* push ds */
            ii(0x15_831e, 3); pushw(0x16dd);                            /* push 0x16dd */
            ii(0x15_8321, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8324, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_8328, 3); callw(0x15_5c7a, -0x26b1);                /* call 0x5c7a */
            ii(0x15_832b, 1); pushw(ds);                                /* push ds */
            ii(0x15_832c, 3); pushw(0x16e0);                            /* push 0x16e0 */
            ii(0x15_832f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8332, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_8336, 3); callw(0x15_5c7a, -0x26bf);                /* call 0x5c7a */
            ii(0x15_8339, 1); pushw(ds);                                /* push ds */
            ii(0x15_833a, 3); pushw(0x16e3);                            /* push 0x16e3 */
            ii(0x15_833d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8340, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x15_8344, 3); callw(0x15_5c7a, -0x26cd);                /* call 0x5c7a */
            ii(0x15_8347, 1); pushw(ds);                                /* push ds */
            ii(0x15_8348, 3); pushw(0x16e6);                            /* push 0x16e6 */
            ii(0x15_834b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_834e, 4); pushw(memw_a16[es, bx + 0x8]);            /* push word [es:bx+0x8] */
            ii(0x15_8352, 3); callw(0x15_5c7a, -0x26db);                /* call 0x5c7a */
            ii(0x15_8355, 1); pushw(ds);                                /* push ds */
            ii(0x15_8356, 3); pushw(0x16e9);                            /* push 0x16e9 */
            ii(0x15_8359, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_835c, 4); pushw(memw_a16[es, bx + 0xa]);            /* push word [es:bx+0xa] */
            ii(0x15_8360, 3); callw(0x15_5c7a, -0x26e9);                /* call 0x5c7a */
            ii(0x15_8363, 1); popw(si);                                 /* pop si */
            ii(0x15_8364, 1); popw(di);                                 /* pop di */
            ii(0x15_8365, 1); leavew();                                 /* leave */
            ii(0x15_8366, 1); retfw(); return;                          /* retf */
        }
    }
}