using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5914e4b0-9466-44a4-b5d2-4545e50462f1")]
        public void Method_0000_fb27()
        {
            ii(0xfb27, 1);    pushw(bp);                                /* push bp */
            ii(0xfb28, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xfb2a, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0xfb2f, 2);    if(jaew_func(0xfaed, -0x44)) return;      /* jae 0xfaed */
            ii(0xfb31, 1);    pushw(ds);                                /* push ds */
            ii(0xfb32, 3);    callw(0xfb42, 0xd);                       /* call 0xfb42 */
            ii(0xfb35, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0xfb38, 3);    mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0xfb3b, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0xfb3d, 3);    mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0xfb40, 2);    if(jmpw_func(0xfb24, -0x1e)) return;      /* jmp 0xfb24 */
        }
    }
}
