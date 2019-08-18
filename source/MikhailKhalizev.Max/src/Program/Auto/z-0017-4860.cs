using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d4b8caf6-d503-4d4d-a903-fe6c0c2aee83")]
        public void Method_0017_4860()
        {
            ii(0x17_4860, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x17_4864, 1); pushw(ds);                                /* push ds */
            ii(0x17_4865, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4868, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_486a, 4); mov(bx, memw_a16[ds, 0xd8]);              /* mov bx, [0xd8] */
            ii(0x17_486e, 4); inc(memw_a16[ds, 0xd8]);                  /* inc word [0xd8] */
            ii(0x17_4872, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x17_4874, 4); pushw(memw_a16[ds, bx + 0x1e8e]);         /* push word [bx+0x1e8e] */
            ii(0x17_4878, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_487b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_487e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_4881, 3); callw(0x17_489a, 0x16);                   /* call 0x489a */
            ii(0x17_4884, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_4887, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4888, 1); leavew();                                 /* leave */
            ii(0x17_4889, 1); retfw(); return;                          /* retf */
        }
    }
}
