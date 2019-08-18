using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a3b1f790-52e2-4a4b-a686-91092464df60")]
        public void Method_0000_ffd4()
        {
            ii(0xffd4, 1);    pushw(bp);                                /* push bp */
            ii(0xffd5, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xffd7, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xffda, 2);    @int(0x15);                               /* int 0x15 */
            ii(0xffdc, 1);    leavew();                                 /* leave */
            ii(0xffdd, 3);    retw(0x2); return;                        /* ret 0x2 */
        }
    }
}
