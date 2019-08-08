using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0311bfd8-c2d3-4346-b30a-c56a2d1510c2")]
        public void Method_0000_fb11()
        {
            ii(0xfb11, 1);    pushw(bp);                                /* push bp */
            ii(0xfb12, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfb14, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0xfb19, 2);    if(jaew_func(0xfac7, -0x54)) return;      /* jae 0xfac7 */
            ii(0xfb1b, 1);    pushw(ds);                                /* push ds */
            ii(0xfb1c, 3);    callw(0xfb42, 0x23);                      /* call 0xfb42 */
            ii(0xfb1f, 2);    mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0xfb21, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
        }
    }
}
