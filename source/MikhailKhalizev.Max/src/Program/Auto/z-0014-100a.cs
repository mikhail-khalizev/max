using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("84a5124c-c4d5-4631-98fb-719340f66e3a")]
        public void Method_0014_100a()
        {
            ii(0x14_100a, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x14_100e, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x14_1011, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x14_1014, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x14_1017, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x14_101a, 1); pushw(ss);                                /* push ss */
            ii(0x14_101b, 1); pushw(ax);                                /* push ax */
            ii(0x14_101c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x14_101f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_1022, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_1024, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_1026, 4); pushw(memw_a16[ds, 0x1b6a]);              /* push word [0x1b6a] */
            ii(0x14_102a, 4); pushw(memw_a16[ds, 0x1b68]);              /* push word [0x1b68] */
            ii(0x14_102e, 1); pushw(cs);                                /* push cs */
            ii(0x14_102f, 3); callw(0x14_0f0c, -0x126);                 /* call 0xf0c */
            ii(0x14_1032, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x14_1035, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x14_1037, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_103a, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x14_103d, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x14_1040, 1); leavew();                                 /* leave */
            ii(0x14_1041, 1); retfw(); return;                          /* retf */
        }
    }
}
