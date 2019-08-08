using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0477ed99-77d2-4bbc-8789-47f2ecf03666")]
        public void Method_0015_fe84()
        {
            ii(0x15_fe84, 1); pushw(bp);                                /* push bp */
            ii(0x15_fe85, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fe87, 1); pushw(ds);                                /* push ds */
            ii(0x15_fe88, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fe8b, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fe8d, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_fe90, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fe93, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fe96, 1); nop();                                    /* nop */
            ii(0x15_fe97, 1); pushw(cs);                                /* push cs */
            ii(0x15_fe98, 3); callw(0x16_106e, 0x11d3);                 /* call 0x106e */
            ii(0x15_fe9b, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fe9c, 1); leavew();                                 /* leave */
            ii(0x15_fe9d, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
