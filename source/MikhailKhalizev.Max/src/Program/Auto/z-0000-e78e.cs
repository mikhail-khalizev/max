using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe78e-6cf6dc44")]
        public void Method_0000_e78e()
        {
            ii(0xe78e, 3);  sub(sp, 6);                                /* sub sp, 0x6 */
            ii(0xe791, 1);  pusha();                                   /* pusha */
            ii(0xe792, 1);  push(es);                                  /* push es */
            ii(0xe793, 1);  push(ds);                                  /* push ds */
            ii(0xe794, 1);  push(ss);                                  /* push ss */
            ii(0xe795, 2);  mov(bx, ss);                               /* mov bx, ss */
            ii(0xe797, 2);  mov(ds, bx);                               /* mov ds, bx */
            ii(0xe799, 5);  mov(dx, memw[cs, 0x5680]);                 /* mov dx, [cs:0x5680] */
            ii(0xe79e, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0xe7a0, 5);  mov(cx, memw[es, 0x99e]);                  /* mov cx, [es:0x99e] */
            ii(0xe7a5, 5);  mov(di, memw[es, 0x996]);                  /* mov di, [es:0x996] */
            ii(0xe7aa, 2);  or(cx, cx);                                /* or cx, cx */
            ii(0xe7ac, 2);  if(jnz_func(0xe76d, -0x41)) return;        /* jnz 0xe76d */
        }
    }
}
