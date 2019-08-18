using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_100a-8f680e38")]
        public void Method_0018_100a()
        {
            ii(0x18_100a, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x18_100e, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x18_1011, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x18_1014, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x18_1017, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x18_101a, 1); pushw(ss);                                /* push ss */
            ii(0x18_101b, 1); pushw(ax);                                /* push ax */
            ii(0x18_101c, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_101f, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_1022, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_1024, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_1026, 4); pushw(memw_a16[ds, 0x1b6a]);              /* push word [0x1b6a] */
            ii(0x18_102a, 4); pushw(memw_a16[ds, 0x1b68]);              /* push word [0x1b68] */
            ii(0x18_102e, 1); pushw(cs);                                /* push cs */
            ii(0x18_102f, 3); callw(0x18_0f0c, -0x126);                 /* call 0xf0c */
            ii(0x18_1032, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x18_1035, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x18_1037, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_103a, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x18_103d, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x18_1040, 1); leavew();                                 /* leave */
            ii(0x18_1041, 1); retfw(); return;                          /* retf */
        }
    }
}
