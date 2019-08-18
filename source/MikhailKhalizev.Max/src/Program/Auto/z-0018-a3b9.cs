using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a3b9-a170dcc")]
        public void Method_0018_a3b9()
        {
            ii(0x18_a3b9, 1); pushw(ds);                                /* push ds */
            ii(0x18_a3ba, 5); mov(ds, memw_a16[cs, 0x5680]);            /* mov ds, [cs:0x5680] */
            ii(0x18_a3bf, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_a3c4, 1); popw(ds);                                 /* pop ds */
            ii(0x18_a3c5, 2); if(jnzw(0x18_a3ca, 0x3)) goto l_0x18_a3ca; /* jnz 0xa3ca */
            ii(0x18_a3c7, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_a3c9, 1); retfw(); return;                          /* retf */
        l_0x18_a3ca:
            ii(0x18_a3ca, 2); pushfd();                                 /* pushfd */
            ii(0x18_a3cc, 2); pushd(cs);                                /* o32 push cs */
            ii(0x18_a3ce, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_a3d0, 3); callw(0x18_dff6, 0x3c23);                 /* call 0xdff6 */
            ii(0x18_a3d3, 1); retfw(); return;                          /* retf */
        }
    }
}
