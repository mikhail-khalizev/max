using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("de0c98d3-714b-4460-b066-4581baba83dd")]
        public void Method_0013_4860()
        {
            ii(0x13_4860, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_4864, 1); pushw(ds);                                /* push ds */
            ii(0x13_4865, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_4868, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_486a, 4); mov(bx, memw_a16[ds, 0xd8]);              /* mov bx, [0xd8] */
            ii(0x13_486e, 4); inc(memw_a16[ds, 0xd8]);                  /* inc word [0xd8] */
            ii(0x13_4872, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x13_4874, 4); pushw(memw_a16[ds, bx + 0x1e8e]);         /* push word [bx+0x1e8e] */
            ii(0x13_4878, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x13_487b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_487e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_4881, 3); callw(0x13_489a, 0x16);                   /* call 0x489a */
            ii(0x13_4884, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_4887, 1); popw(ds);                                 /* pop ds */
            ii(0x13_4888, 1); leavew();                                 /* leave */
            ii(0x13_4889, 1); retfw(); return;                          /* retf */
        }
    }
}
