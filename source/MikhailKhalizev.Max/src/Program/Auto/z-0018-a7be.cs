using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a7be-6cf6dc44")]
        public void Method_0018_a7be()
        {
            ii(0x18_a7be, 3);  sub(sp, 6);                             /* sub sp, 0x6 */
            ii(0x18_a7c1, 1);  pusha();                                /* pusha */
            ii(0x18_a7c2, 1);  push(es);                               /* push es */
            ii(0x18_a7c3, 1);  push(ds);                               /* push ds */
            ii(0x18_a7c4, 1);  push(ss);                               /* push ss */
            ii(0x18_a7c5, 2);  mov(bx, ss);                            /* mov bx, ss */
            ii(0x18_a7c7, 2);  mov(ds, bx);                            /* mov ds, bx */
            ii(0x18_a7c9, 5);  mov(dx, memw[cs, 0x5680]);              /* mov dx, [cs:0x5680] */
            ii(0x18_a7ce, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x18_a7d0, 5);  mov(cx, memw[es, 0x99e]);               /* mov cx, [es:0x99e] */
            ii(0x18_a7d5, 5);  mov(di, memw[es, 0x996]);               /* mov di, [es:0x996] */
            ii(0x18_a7da, 2);  or(cx, cx);                             /* or cx, cx */
            ii(0x18_a7dc, 2);  jnz_func(0x18_a79d, -0x41);             /* jnz 0xa79d */
        }
    }
}
