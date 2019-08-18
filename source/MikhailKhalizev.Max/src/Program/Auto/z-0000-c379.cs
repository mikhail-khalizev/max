using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c01fc709-569a-4d14-be5d-9ebd53094eb3")]
        public void Method_0000_c379()
        {
            ii(0xc379, 1);    pushw(ds);                                /* push ds */
            ii(0xc37a, 5);    mov(ds, memw_a16[cs, 0x5680]);            /* mov ds, [cs:0x5680] */
            ii(0xc37f, 5);    cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0xc384, 1);    popw(ds);                                 /* pop ds */
            ii(0xc385, 2);    if(jnzw(0xc38a, 0x3)) goto l_0xc38a;      /* jnz 0xc38a */
            ii(0xc387, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xc389, 1);    retfw(); return;                          /* retf */
        l_0xc38a:
            ii(0xc38a, 2);    pushfd();                                 /* pushfd */
            ii(0xc38c, 2);    pushd(cs);                                /* o32 push cs */
            ii(0xc38e, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xc390, 3);    callw(0xffb6, 0x3c23);                    /* call 0xffb6 */
            ii(0xc393, 1);    retfw(); return;                          /* retf */
        }
    }
}
