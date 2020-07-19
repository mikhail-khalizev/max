using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9d6a-b5eb8f7")]
        public void Method_0000_9d6a()
        {
            ii(0x9d6a, 2);  mov(bx, sp);                               /* mov bx, sp */
            ii(0x9d6c, 3);  mov(dx, memw[ds, bx + 2]);                 /* mov dx, [bx+0x2] */
            ii(0x9d6f, 3);  mov(cx, memw[ds, bx + 4]);                 /* mov cx, [bx+0x4] */
            ii(0x9d72, 4);  mov(bx, memw[ds, 0xe70]);                  /* mov bx, [0xe70] */
            ii(0x9d76, 3);  mov(ax, 0x4200);                           /* mov ax, 0x4200 */
            ii(0x9d79, 2);  @int(0x21);                                /* int 0x21 */
            ii(0x9d7b, 2);  sbb(bx, bx);                               /* sbb bx, bx */
            ii(0x9d7d, 2);  or(ax, bx);                                /* or ax, bx */
            ii(0x9d7f, 2);  or(dx, bx);                                /* or dx, bx */
            ii(0x9d81, 1);  ret();                                     /* ret */
        }
    }
}
