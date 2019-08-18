using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa4ec-702db5cb")]
        public void Method_0000_a4ec()
        {
            ii(0xa4ec, 3);    mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0xa4ef, 1);    popw(bx);                                 /* pop bx */
            ii(0xa4f0, 1);    popw(ax);                                 /* pop ax */
            ii(0xa4f1, 1);    pushw(ax);                                /* push ax */
            ii(0xa4f2, 2);    xor(dx, dx);                              /* xor dx, dx */
        l_0xa4f4:
            ii(0xa4f4, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xa4f6, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xa4f8, 2);    if(loopw_a16(0xa4f4, -0x6)) goto l_0xa4f4; /* loop 0xa4f4 */
            ii(0xa4fa, 2);    if(jmpw_abs(bx)) return;                  /* jmp bx */
        }
    }
}
