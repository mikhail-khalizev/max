using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fa896bcb-4aad-45db-bb6d-29b19c541fde")]
        public void Method_0019_d518()
        {
            ii(0x19_d518, 1); pushw(bp);                                /* push bp */
            ii(0x19_d519, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d51b, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_d51e, 4); les(bx, es, bx + 0x1c);                   /* les bx, [es:bx+0x1c] */
            ii(0x19_d522, 4); mov(ah, memb_a16[es, bx + 0x11]);         /* mov ah, [es:bx+0x11] */
            ii(0x19_d526, 3); and(ax, 0x8000);                          /* and ax, 0x8000 */
            ii(0x19_d529, 1); leavew();                                 /* leave */
            ii(0x19_d52a, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
