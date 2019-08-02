using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("929c9122-155d-4481-9b8d-7a22c1892706")]
        public void Method_0015_61c1()
        {
            ii(0x15_61c1, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_61c5, 1); pushw(di);                                /* push di */
            ii(0x15_61c6, 1); pushw(si);                                /* push si */
            ii(0x15_61c7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_61c9, 1); nop();                                    /* nop */
            ii(0x15_61ca, 1); pushw(cs);                                /* push cs */
            ii(0x15_61cb, 3); callw(0x14_f57c, -0x6c52);                /* call 0xf57c */
            ii(0x15_61ce, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_61d1, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_61d4, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_61d7, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_61da, 5); callw_far_abs(0x80, 0xbe4);               /* call word 0x80:0xbe4 */
            ii(0x15_61df, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_61e2, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_61e4, 1); nop();                                    /* nop */
            ii(0x15_61e5, 1); pushw(cs);                                /* push cs */
            ii(0x15_61e6, 3); callw(0x14_f57c, -0x6c6d);                /* call 0xf57c */
            ii(0x15_61e9, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_61ec, 1); popw(si);                                 /* pop si */
            ii(0x15_61ed, 1); popw(di);                                 /* pop di */
            ii(0x15_61ee, 1); leavew();                                 /* leave */
            ii(0x15_61ef, 1); retw(); return;                           /* ret */
        }
    }
}