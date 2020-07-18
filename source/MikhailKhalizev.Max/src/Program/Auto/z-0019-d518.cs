using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d518-9b4f578d")]
        public void Method_0019_d518()
        {
            ii(0x19_d518, 1);  push(bp);                               /* push bp */
            ii(0x19_d519, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_d51b, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_d51e, 4);  les(bx, memw[es, bx + 28]);             /* les bx, [es:bx+0x1c] */
            ii(0x19_d522, 4);  mov(ah, memb[es, bx + 17]);             /* mov ah, [es:bx+0x11] */
            ii(0x19_d526, 3);  and(ax, 0x8000);                        /* and ax, 0x8000 */
            ii(0x19_d529, 1);  leave();                                /* leave */
            ii(0x19_d52a, 3);  ret(4);                                 /* ret 0x4 */
        }
    }
}
