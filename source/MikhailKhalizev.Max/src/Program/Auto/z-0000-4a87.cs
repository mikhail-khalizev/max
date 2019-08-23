using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4a87-4b0e43fe")]
        public void Method_0000_4a87()
        {
            ii(0x4a87, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x4a89, 3);    mov(ax, memw[ds, bx + 0x2]);              /* mov ax, [bx+0x2] */
            ii(0x4a8c, 1);    push(ax);                                 /* push ax */
            ii(0x4a8d, 1);    push(ax);                                 /* push ax */
            ii(0x4a8e, 3);    call(0x5c10, 0x117f);                     /* call 0x5c10 */
            ii(0x4a91, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x4a92, 1);    pop(ax);                                  /* pop ax */
            ii(0x4a93, 1);    pop(dx);                                  /* pop dx */
            ii(0x4a94, 3);    mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x4a97, 2);    mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x4a99, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x4a9b, 1);    ret();                                    /* ret */
        }
    }
}
