using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbf5a-90e2c3e6")]
        public void Method_0000_bf5a()
        {
            ii(0xbf5a, 1);  push(bp);                                  /* push bp */
            ii(0xbf5b, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0xbf5d, 1);  push(bx);                                  /* push bx */
            ii(0xbf5e, 3);  mov(bx, memw[ss, bp + 4]);                 /* mov bx, [bp+0x4] */
            ii(0xbf61, 2);  mov(ax, memw[ds, bx]);                     /* mov ax, [bx] */
            ii(0xbf63, 3);  mov(dx, memw[ds, bx + 2]);                 /* mov dx, [bx+0x2] */
            ii(0xbf66, 3);  mov(cx, memw[ss, bp + 6]);                 /* mov cx, [bp+0x6] */
            ii(0xbf69, 3);  call(0x8554, -0x3a18);                     /* call 0x8554 */
            ii(0xbf6c, 2);  mov(memw[ds, bx], ax);                     /* mov [bx], ax */
            ii(0xbf6e, 3);  mov(memw[ds, bx + 2], dx);                 /* mov [bx+0x2], dx */
            ii(0xbf71, 1);  pop(bx);                                   /* pop bx */
            ii(0xbf72, 1);  pop(bp);                                   /* pop bp */
            ii(0xbf73, 3);  ret(4);                                    /* ret 0x4 */
        }
    }
}
