using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5237-4b0e43fe")]
        public void Method_0000_5237()
        {
            ii(0x5237, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x5239, 3);    mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0x523c, 1);    pushw(ax);                                /* push ax */
            ii(0x523d, 1);    pushw(ax);                                /* push ax */
            ii(0x523e, 3);    callw(0x63c0, 0x117f);                    /* call 0x63c0 */
            ii(0x5241, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x5242, 1);    popw(ax);                                 /* pop ax */
            ii(0x5243, 1);    popw(dx);                                 /* pop dx */
            ii(0x5244, 3);    mov(bx, 0x2);                             /* mov bx, 0x2 */
            ii(0x5247, 2);    mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x5249, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x524b, 1);    retw(); return;                           /* ret */
        }
    }
}
