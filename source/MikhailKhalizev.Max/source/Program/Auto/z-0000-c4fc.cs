using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xc4fc-702db5cb")]
        public void Method_0000_c4fc()
        {
            ii(0xc4fc, 3);  mov(cx, 6);                                /* mov cx, 0x6 */
            ii(0xc4ff, 1);  pop(bx);                                   /* pop bx */
            ii(0xc500, 1);  pop(ax);                                   /* pop ax */
            ii(0xc501, 1);  push(ax);                                  /* push ax */
            ii(0xc502, 2);  xor(dx, dx);                               /* xor dx, dx */
        l_0xc504:
            ii(0xc504, 2);  shl(ax, 1);                                /* shl ax, 1 */
            ii(0xc506, 2);  rcl(dx, 1);                                /* rcl dx, 1 */
            ii(0xc508, 2);  if(loop(0xc504, -6)) goto l_0xc504;        /* loop 0xc504 */
            ii(0xc50a, 2);  jmp_abs(bx);                               /* jmp bx */
        }
    }
}
