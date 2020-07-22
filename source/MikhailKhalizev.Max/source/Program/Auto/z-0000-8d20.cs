using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8d20-1b42e8ec")]
        public void Method_0000_8d20()
        {
            ii(0x8d20, 3);  call(0x8b3b, -0x1e8);                      /* call 0x8b3b */
            ii(0x8d23, 2);  mov(ax, bp);                               /* mov ax, bp */
            ii(0x8d25, 1);  push(ax);                                  /* push ax */
            ii(0x8d26, 3);  call(0x8c79, -0xb0);                       /* call 0x8c79 */
            ii(0x8d29, 1);  pop(bx);                                   /* pop bx */
            ii(0x8d2a, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x8d2c, 1);  pop(bp);                                   /* pop bp */
            ii(0x8d2d, 1);  ret();                                     /* ret */
        }
    }
}
