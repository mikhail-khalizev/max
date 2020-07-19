using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb11-14efad08")]
        public void Method_0000_fb11()
        {
            ii(0xfb11, 1);  push(bp);                                  /* push bp */
            ii(0xfb12, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xfb14, 5);  cmp(memb[ds, 0x2f], 3);                    /* cmp byte [0x2f], 0x3 */
            ii(0xfb19, 2);  if(jae_func(0xfac7, -0x54)) return;        /* jae 0xfac7 */
            ii(0xfb1b, 1);  push(ds);                                  /* push ds */
            ii(0xfb1c, 3);  call(0xfb42, 0x23);                        /* call 0xfb42 */
            ii(0xfb1f, 2);  mov(ax, memw[ds, bx]);                     /* mov ax, [bx] */
            ii(0xfb21, 3);  mov(dx, memw[ds, bx + 2]);                 /* mov dx, [bx+0x2] */
        }
    }
}
