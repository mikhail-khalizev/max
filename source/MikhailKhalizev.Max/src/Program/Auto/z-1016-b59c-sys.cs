using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b59c-3f2af543")]
        public void /* sys */ Method_1016_b59c()
        {
            ii(0x1016_b59c, 5); mov(memd[ds, 0x101c_fb64], eax);        /* mov [0x101cfb64], eax */
            ii(0x1016_b5a1, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b5a3, 2); if(jnz(0x1016_b5aa, 5)) goto l_0x1016_b5aa; /* jnz 0x1016b5aa */
            ii(0x1016_b5a5, 5); mov(edx, /* sys */ 0x1016_b4a0);        /* mov edx, 0x1016b4a0 */
        l_0x1016_b5aa:
            ii(0x1016_b5aa, 6); mov(memd[ds, 0x101c_fb74], edx);        /* mov [0x101cfb74], edx */
            ii(0x1016_b5b0, 1); ret();                                  /* ret */
        }
    }
}
