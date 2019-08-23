using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_a0da-d8b124a2")]
        public void Method_0017_a0da()
        {
            ii(0x17_a0da, 1); pushw(bp);                                /* push bp */
            ii(0x17_a0db, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_a0dd, 1); pushw(ds);                                /* push ds */
            ii(0x17_a0de, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_a0e1, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_a0e3, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_a0e6, 6); mov(memw_a16[es, bx + 0x20], 0x8001);     /* mov word [es:bx+0x20], 0x8001 */
            ii(0x17_a0ec, 6); mov(memw_a16[es, bx + 0x22], 0);          /* mov word [es:bx+0x22], 0x0 */
            ii(0x17_a0f2, 5); or(memb_a16[es, bx + 0x2c], 0x1);         /* or byte [es:bx+0x2c], 0x1 */
            ii(0x17_a0f7, 1); popw(ds);                                 /* pop ds */
            ii(0x17_a0f8, 1); leavew();                                 /* leave */
            ii(0x17_a0f9, 1); retfw();                                  /* retf */
        }
    }
}
