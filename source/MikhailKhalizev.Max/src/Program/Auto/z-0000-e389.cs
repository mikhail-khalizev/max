using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe389-a170dcc")]
        public void Method_0000_e389()
        {
            ii(0xe389, 1);    push(ds);                                 /* push ds */
            ii(0xe38a, 5);    mov(ds, memw[cs, 0x5680]);                /* mov ds, [cs:0x5680] */
            ii(0xe38f, 5);    cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0xe394, 1);    pop(ds);                                  /* pop ds */
            ii(0xe395, 2);    if(jnz(0xe39a, 0x3)) goto l_0xe39a;       /* jnz 0xe39a */
            ii(0xe397, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xe399, 1);    retf(); return;                           /* retf */
        l_0xe39a:
            ii(0xe39a, 2);    pushfd();                                 /* pushfd */
            ii(0xe39c, 2);    pushd(cs);                                /* o32 push cs */
            ii(0xe39e, 2);    push(0);                                  /* push 0x0 */
            ii(0xe3a0, 3);    call(0x1_1fc6, 0x3c23);                   /* call 0x1fc6 */
            ii(0xe3a3, 1);    retf();                                   /* retf */
        }
    }
}
