using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4860-e302e99b")]
        public void Method_0017_4860()
        {
            ii(0x17_4860, 4); enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x17_4864, 1); push(ds);                                 /* push ds */
            ii(0x17_4865, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4868, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_486a, 4); mov(bx, memw[ds, 0xd8]);                  /* mov bx, [0xd8] */
            ii(0x17_486e, 4); inc(memw[ds, 0xd8]);                      /* inc word [0xd8] */
            ii(0x17_4872, 2); shl(bx, 1);                               /* shl bx, 1 */
            ii(0x17_4874, 4); push(memw[ds, bx + 0x1e8e]);              /* push word [bx+0x1e8e] */
            ii(0x17_4878, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x17_487b, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x17_487e, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x17_4881, 3); call(0x17_489a, 0x16);                    /* call 0x489a */
            ii(0x17_4884, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x17_4887, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4888, 1); leave();                                  /* leave */
            ii(0x17_4889, 1); retf();                                   /* retf */
        }
    }
}
