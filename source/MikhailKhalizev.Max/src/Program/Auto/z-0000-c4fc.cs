using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09437cdd-8742-42f5-a207-7d599f059528")]
        public void Method_0000_c4fc()
        {
            ii(0xc4fc, 3);    mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0xc4ff, 1);    popw(bx);                                 /* pop bx */
            ii(0xc500, 1);    popw(ax);                                 /* pop ax */
            ii(0xc501, 1);    pushw(ax);                                /* push ax */
            ii(0xc502, 2);    xor(dx, dx);                              /* xor dx, dx */
        l_0xc504:
            ii(0xc504, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xc506, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0xc508, 2);    if(loopw_a16(0xc504, -0x6)) goto l_0xc504; /* loop 0xc504 */
            ii(0xc50a, 2);    if(jmpw_abs(bx)) return;                  /* jmp bx */
        }
    }
}
