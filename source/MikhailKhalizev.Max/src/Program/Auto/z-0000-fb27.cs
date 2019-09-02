using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xfb27-3dbc1da9")]
        public void Method_0000_fb27()
        {
            ii(0xfb27, 1);    push(bp);                                 /* push bp */
            ii(0xfb28, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfb2a, 5);    cmp(memb[ds, 0x2f], 3);                   /* cmp byte [0x2f], 0x3 */
            ii(0xfb2f, 2);    if(jae_func(0xfaed, -0x44)) return;       /* jae 0xfaed */
            ii(0xfb31, 1);    push(ds);                                 /* push ds */
            ii(0xfb32, 3);    call(0xfb42, 0xd);                        /* call 0xfb42 */
            ii(0xfb35, 3);    mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0xfb38, 3);    mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
            ii(0xfb3b, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0xfb3d, 3);    mov(memw[ds, bx + 2], dx);                /* mov [bx+0x2], dx */
            ii(0xfb40, 2);    if(jmp_func(0xfb24, -0x1e)) return;       /* jmp 0xfb24 */
        }
    }
}
