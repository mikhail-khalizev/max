using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f8ec-3bea5ea")]
        public void Method_0019_f8ec()
        {
            ii(0x19_f8ec, 1); push(bp);                                 /* push bp */
            ii(0x19_f8ed, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_f8ef, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x19_f8f2, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x19_f8f5, 1); push(ds);                                 /* push ds */
            ii(0x19_f8f6, 3); push(0x30d6);                             /* push 0x30d6 */
            ii(0x19_f8f9, 5); call_far_abs(0x80, 0x2244);               /* call word 0x80:0x2244 */
            ii(0x19_f8fe, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_f900, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x19_f903, 4); push(memw[es, bx + 0xa]);                 /* push word [es:bx+0xa] */
            ii(0x19_f907, 4); push(memw[es, bx + 0x8]);                 /* push word [es:bx+0x8] */
            ii(0x19_f90b, 4); push(memw[es, bx + 0x6]);                 /* push word [es:bx+0x6] */
            ii(0x19_f90f, 4); push(memw[es, bx + 0x4]);                 /* push word [es:bx+0x4] */
            ii(0x19_f913, 4); push(memw[es, bx + 0x2]);                 /* push word [es:bx+0x2] */
            ii(0x19_f917, 1); push(ds);                                 /* push ds */
            ii(0x19_f918, 3); push(0x30ed);                             /* push 0x30ed */
            ii(0x19_f91b, 5); call_far_abs(0x80, 0x2244);               /* call word 0x80:0x2244 */
            ii(0x19_f920, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_f922, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x19_f925, 4); push(memw[es, bx + 0x22]);                /* push word [es:bx+0x22] */
            ii(0x19_f929, 4); push(memw[es, bx + 0x20]);                /* push word [es:bx+0x20] */
            ii(0x19_f92d, 4); push(memw[es, bx + 0x26]);                /* push word [es:bx+0x26] */
            ii(0x19_f931, 4); push(memw[es, bx + 0x24]);                /* push word [es:bx+0x24] */
            ii(0x19_f935, 4); push(memw[es, bx + 0x1e]);                /* push word [es:bx+0x1e] */
            ii(0x19_f939, 4); push(memw[es, bx + 0x1c]);                /* push word [es:bx+0x1c] */
            ii(0x19_f93d, 4); push(memw[es, bx + 0x2a]);                /* push word [es:bx+0x2a] */
            ii(0x19_f941, 4); push(memw[es, bx + 0x28]);                /* push word [es:bx+0x28] */
            ii(0x19_f945, 1); push(ds);                                 /* push ds */
            ii(0x19_f946, 3); push(0x3111);                             /* push 0x3111 */
            ii(0x19_f949, 5); call_far_abs(0x80, 0x2244);               /* call word 0x80:0x2244 */
            ii(0x19_f94e, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_f950, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x19_f953, 4); push(memw[es, bx + 0x1a]);                /* push word [es:bx+0x1a] */
            ii(0x19_f957, 4); push(memw[es, bx + 0x18]);                /* push word [es:bx+0x18] */
            ii(0x19_f95b, 4); push(memw[es, bx + 0x16]);                /* push word [es:bx+0x16] */
            ii(0x19_f95f, 4); push(memw[es, bx + 0x14]);                /* push word [es:bx+0x14] */
            ii(0x19_f963, 4); push(memw[es, bx + 0xe]);                 /* push word [es:bx+0xe] */
            ii(0x19_f967, 4); push(memw[es, bx + 0xc]);                 /* push word [es:bx+0xc] */
            ii(0x19_f96b, 4); push(memw[es, bx + 0x12]);                /* push word [es:bx+0x12] */
            ii(0x19_f96f, 4); push(memw[es, bx + 0x10]);                /* push word [es:bx+0x10] */
            ii(0x19_f973, 1); push(ds);                                 /* push ds */
            ii(0x19_f974, 3); push(0x3132);                             /* push 0x3132 */
            ii(0x19_f977, 5); call_far_abs(0x80, 0x2244);               /* call word 0x80:0x2244 */
            ii(0x19_f97c, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x19_f97e, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x19_f981, 4); push(memw[es, bx + 0x3c]);                /* push word [es:bx+0x3c] */
            ii(0x19_f985, 4); push(memw[es, bx + 0x3a]);                /* push word [es:bx+0x3a] */
            ii(0x19_f989, 4); push(memw[es, bx + 0x30]);                /* push word [es:bx+0x30] */
            ii(0x19_f98d, 4); push(memw[es, bx + 0x2e]);                /* push word [es:bx+0x2e] */
            ii(0x19_f991, 4); push(memw[es, bx + 0x2c]);                /* push word [es:bx+0x2c] */
            ii(0x19_f995, 4); push(memw[es, bx + 0x34]);                /* push word [es:bx+0x34] */
            ii(0x19_f999, 4); push(memw[es, bx + 0x32]);                /* push word [es:bx+0x32] */
            ii(0x19_f99d, 4); push(memw[es, bx + 0x36]);                /* push word [es:bx+0x36] */
            ii(0x19_f9a1, 1); push(ds);                                 /* push ds */
            ii(0x19_f9a2, 3); push(0x3153);                             /* push 0x3153 */
            ii(0x19_f9a5, 5); call_far_abs(0x80, 0x2244);               /* call word 0x80:0x2244 */
            ii(0x19_f9aa, 1); leave();                                  /* leave */
            ii(0x19_f9ab, 1); retf();                                   /* retf */
        }
    }
}
