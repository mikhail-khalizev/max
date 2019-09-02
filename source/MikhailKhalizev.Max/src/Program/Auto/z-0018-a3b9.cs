using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a3b9-a170dcc")]
        public void Method_0018_a3b9()
        {
            ii(0x18_a3b9, 1); push(ds);                                 /* push ds */
            ii(0x18_a3ba, 5); mov(ds, memw[cs, 0x5680]);                /* mov ds, [cs:0x5680] */
            ii(0x18_a3bf, 5); cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0x18_a3c4, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a3c5, 2); if(jnz(0x18_a3ca, 3)) goto l_0x18_a3ca;   /* jnz 0xa3ca */
            ii(0x18_a3c7, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_a3c9, 1); retf(); return;                           /* retf */
        l_0x18_a3ca:
            ii(0x18_a3ca, 2); pushfd();                                 /* pushfd */
            ii(0x18_a3cc, 2); pushd(cs);                                /* o32 push cs */
            ii(0x18_a3ce, 2); push(0);                                  /* push 0x0 */
            ii(0x18_a3d0, 3); call(0x18_dff6, 0x3c23);                  /* call 0xdff6 */
            ii(0x18_a3d3, 1); retf();                                   /* retf */
        }
    }
}
