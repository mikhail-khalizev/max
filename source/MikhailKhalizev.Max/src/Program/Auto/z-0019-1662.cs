using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1662-bd4b0b49")]
        public void Method_0019_1662()
        {
            ii(0x19_1662, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x19_1666, 3); lea(ax, bp + 0xc);                        /* lea ax, [bp+0xc] */
            ii(0x19_1669, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_166c, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x19_166f, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x19_1672, 1); pushw(ss);                                /* push ss */
            ii(0x19_1673, 1); pushw(ax);                                /* push ax */
            ii(0x19_1674, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_1677, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_167a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_167d, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x19_167f, 4); pushw(memw_a16[ds, 0x38c6]);              /* push word [0x38c6] */
            ii(0x19_1683, 4); pushw(memw_a16[ds, 0x38c4]);              /* push word [0x38c4] */
            ii(0x19_1687, 1); pushw(cs);                                /* push cs */
            ii(0x19_1688, 3); if(callw_up(0x19_15d2, -0xb9)) return;    /* call 0x15d2 */
            ii(0x19_168b, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_168e, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_1690, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_1693, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x19_1696, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_1699, 1); leavew();                                 /* leave */
            ii(0x19_169a, 1); retfw(); return;                          /* retf */
        }
    }
}
