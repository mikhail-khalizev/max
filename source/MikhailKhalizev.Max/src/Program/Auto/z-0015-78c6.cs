using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b33aa7ac-a327-4c56-8fa5-9ad4e5ebe576")]
        public void Method_0015_78c6()
        {
            ii(0x15_78c6, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_78ca, 1); pushw(di);                                /* push di */
            ii(0x15_78cb, 1); pushw(si);                                /* push si */
            ii(0x15_78cc, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x15_78d0, 1); popw(si);                                 /* pop si */
            ii(0x15_78d1, 1); popw(di);                                 /* pop di */
            ii(0x15_78d2, 1); leavew();                                 /* leave */
            ii(0x15_78d3, 1); retfw(); return;                          /* retf */
        }
    }
}
