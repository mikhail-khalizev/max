using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1cd1-25eda015")]
        public void Method_0001_1cd1()
        {
            ii(0x1_1cd1, 2);  mov(bx, sp);                             /* mov bx, sp */
            ii(0x1_1cd3, 4);  mov(bx, memw[ss, bx + 2]);               /* mov bx, [ss:bx+0x2] */
            ii(0x1_1cd7, 3);  mov(ax, 1);                              /* mov ax, 0x1 */
            ii(0x1_1cda, 1);  push(cs);                                /* push cs */
            ii(0x1_1cdb, 3);  call(0xe389, -0x3955);                   /* call 0xe389 */
            ii(0x1_1cde, 2);  if(jmp_func(0x1_1ccb, -0x15)) return;    /* jmp 0x1ccb */
        }
    }
}
