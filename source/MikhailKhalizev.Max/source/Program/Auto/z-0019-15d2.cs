using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_15d2-f816531f")]
        public void Method_0019_15d2()
        {
            ii(0x19_15d2, 1);  push(bp);                               /* push bp */
            ii(0x19_15d3, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_15d5, 5);  test(memb[ds, 0x36f7], 2);              /* test byte [0x36f7], 0x2 */
            ii(0x19_15da, 2);  if(jz(0x19_15e0, 4)) goto l_0x19_15e0;  /* jz 0x15e0 */
            ii(0x19_15dc, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_15de, 1);  leave();                                /* leave */
            ii(0x19_15df, 1);  retf(); return;                         /* retf */
        l_0x19_15e0:
            ii(0x19_15e0, 3);  push(memw[ss, bp + 20]);                /* push word [bp+0x14] */
            ii(0x19_15e3, 3);  push(memw[ss, bp + 18]);                /* push word [bp+0x12] */
            ii(0x19_15e6, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_15e9, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_15ec, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_15ef, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_15f2, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_15f5, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_15f8, 4);  call_far_ind(memw[ds, 0x38bc]);         /* call far word [0x38bc] */
            ii(0x19_15fc, 1);  leave();                                /* leave */
            ii(0x19_15fd, 1);  retf();                                 /* retf */
        }
    }
}
