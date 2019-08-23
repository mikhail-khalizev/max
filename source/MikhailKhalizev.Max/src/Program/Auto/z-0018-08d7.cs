using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_08d7-997fb17c")]
        public void Method_0018_08d7()
        {
            ii(0x18_08d7, 1); pushw(bp);                                /* push bp */
            ii(0x18_08d8, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_08da, 1); pushw(ds);                                /* push ds */
            ii(0x18_08db, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x18_08de, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x18_08e0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_08e2, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x18_08e4, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x18_08e7, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x18_08ea, 1); nop();                                    /* nop */
            ii(0x18_08eb, 1); pushw(cs);                                /* push cs */
            ii(0x18_08ec, 3); callw(0x18_05e3, -0x30c);                 /* call 0x5e3 */
            ii(0x18_08ef, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x18_08f2, 1); popw(ds);                                 /* pop ds */
            ii(0x18_08f3, 1); leavew();                                 /* leave */
            ii(0x18_08f4, 3); retfw(0x4);                               /* retf 0x4 */
        }
    }
}
