using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b2bc-7130a54b")]
        public void Method_0018_b2bc()
        {
            ii(0x18_b2bc, 3);  mov(cx, 0x10);                          /* mov cx, 0x10 */
            ii(0x18_b2bf, 2);  mul(cx);                                /* mul cx */
            ii(0x18_b2c1, 1);  xchg(dx, ax);                           /* xchg dx, ax */
            ii(0x18_b2c2, 1);  xchg(cx, ax);                           /* xchg cx, ax */
            ii(0x18_b2c3, 2);  xchg(di, bx);                           /* xchg di, bx */
            ii(0x18_b2c5, 3);  mov(ax, 7);                             /* mov ax, 0x7 */
            ii(0x18_b2c8, 1);  push(cs);                               /* push cs */
            ii(0x18_b2c9, 3);  call(0x18_a3b9, -0xf13);                /* call 0xa3b9 */
            ii(0x18_b2cc, 2);  xchg(di, bx);                           /* xchg di, bx */
            ii(0x18_b2ce, 1);  ret();                                  /* ret */
        }
    }
}
