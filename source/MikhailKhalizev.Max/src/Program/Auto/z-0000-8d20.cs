using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("56ecdb69-c258-4a8d-bb9a-160962c64d2e")]
        public void Method_0000_8d20()
        {
            ii(0x8d20, 3);    callw(0x8b3b, -0x1e8);                    /* call 0x8b3b */
            ii(0x8d23, 2);    mov(ax, bp);                              /* mov ax, bp */
            ii(0x8d25, 1);    pushw(ax);                                /* push ax */
            ii(0x8d26, 3);    callw(0x8c79, -0xb0);                     /* call 0x8c79 */
            ii(0x8d29, 1);    popw(bx);                                 /* pop bx */
            ii(0x8d2a, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x8d2c, 1);    popw(bp);                                 /* pop bp */
            ii(0x8d2d, 1);    retw(); return;                           /* ret */
        }
    }
}
