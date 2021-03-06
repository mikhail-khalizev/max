using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d3c-702db5cb")]
        public void Method_0000_9d3c()
        {
            ii(0x9d3c, 3);  mov(cx, 6);                                /* mov cx, 0x6 */
            ii(0x9d3f, 1);  pop(bx);                                   /* pop bx */
            ii(0x9d40, 1);  pop(ax);                                   /* pop ax */
            ii(0x9d41, 1);  push(ax);                                  /* push ax */
            ii(0x9d42, 2);  xor(dx, dx);                               /* xor dx, dx */
        l_0x9d44:
            ii(0x9d44, 2);  shl(ax, 1);                                /* shl ax, 1 */
            ii(0x9d46, 2);  rcl(dx, 1);                                /* rcl dx, 1 */
            ii(0x9d48, 2);  if(loop(0x9d44, -6)) goto l_0x9d44;        /* loop 0x9d44 */
            ii(0x9d4a, 2);  jmp_abs(bx);                               /* jmp bx */
        }
    }
}
