using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbf5a-90e2c3e6")]
        public void Method_0000_bf5a()
        {
            ii(0xbf5a, 1);    pushw(bp);                                /* push bp */
            ii(0xbf5b, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xbf5d, 1);    pushw(bx);                                /* push bx */
            ii(0xbf5e, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0xbf61, 2);    mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0xbf63, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0xbf66, 3);    mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0xbf69, 3);    callw(0x8554, -0x3a18);                   /* call 0x8554 */
            ii(0xbf6c, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0xbf6e, 3);    mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0xbf71, 1);    popw(bx);                                 /* pop bx */
            ii(0xbf72, 1);    popw(bp);                                 /* pop bp */
            ii(0xbf73, 3);    retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
