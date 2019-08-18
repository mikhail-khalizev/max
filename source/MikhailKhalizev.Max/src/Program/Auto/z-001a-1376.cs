using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("08a2d8ad-9bcd-41c0-b1b5-304aca482c64")]
        public void Method_001a_1376()
        {
            ii(0x1a_1376, 1); pushw(bp);                                /* push bp */
            ii(0x1a_1377, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x1a_1379, 1); pushw(ds);                                /* push ds */
            ii(0x1a_137a, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_137d, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_137f, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x1a_1382, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x1a_1385, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_1388, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_138b, 5); callw_far_abs(0x80, 0x4544);              /* call word 0x80:0x4544 */
            ii(0x1a_1390, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x1a_1393, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_1396, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_1399, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x1a_139e, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_139f, 1); popw(bx);                                 /* pop bx */
            ii(0x1a_13a0, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_13a1, 1); leavew();                                 /* leave */
            ii(0x1a_13a2, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
