using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xdfc4-f99da11a")]
        public void Method_0000_dfc4()
        {
            ii(0xdfc4, 1);    pushw(bp);                                /* push bp */
            ii(0xdfc5, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xdfc7, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xdfca, 2);    @int(0x15);                               /* int 0x15 */
            ii(0xdfcc, 1);    leavew();                                 /* leave */
            ii(0xdfcd, 3);    retw(0x2);                                /* ret 0x2 */
        }
    }
}
