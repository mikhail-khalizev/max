using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9f4a-90e2c3e6")]
        public void Method_0000_9f4a()
        {
            ii(0x9f4a, 1);    pushw(bp);                                /* push bp */
            ii(0x9f4b, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9f4d, 1);    pushw(bx);                                /* push bx */
            ii(0x9f4e, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x9f51, 2);    mov(ax, memw_a16[ds, bx]);                /* mov ax, [bx] */
            ii(0x9f53, 3);    mov(dx, memw_a16[ds, bx + 0x2]);          /* mov dx, [bx+0x2] */
            ii(0x9f56, 3);    mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x9f59, 3);    callw(0x6544, -0x3a18);                   /* call 0x6544 */
            ii(0x9f5c, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x9f5e, 3);    mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x9f61, 1);    popw(bx);                                 /* pop bx */
            ii(0x9f62, 1);    popw(bp);                                 /* pop bp */
            ii(0x9f63, 3);    retw(0x4);                                /* ret 0x4 */
        }
    }
}
