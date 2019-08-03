using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf4a7ed8-15e8-4364-a1d8-20de848e931c")]
        public void Method_0013_5622()
        {
            ii(0x13_5622, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_5626, 1); pushw(ds);                                /* push ds */
            ii(0x13_5627, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_562a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_562c, 5); mov(memw_a16[ss, bp - 0x2], 0x8);         /* mov word [bp-0x2], 0x8 */
            ii(0x13_5631, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_5634, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_5637, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_563a, 4); mov(al, memb_a16[es, bx + 0x5]);          /* mov al, [es:bx+0x5] */
            ii(0x13_563e, 2); and(al, 0xf3);                            /* and al, 0xf3 */
            ii(0x13_5640, 2); or(al, 0x13);                             /* or al, 0x13 */
            ii(0x13_5642, 4); mov(memb_a16[es, bx + 0x5], al);          /* mov [es:bx+0x5], al */
            ii(0x13_5646, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5647, 1); leavew();                                 /* leave */
            ii(0x13_5648, 1); retfw(); return;                          /* retf */
        }
    }
}
