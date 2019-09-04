using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_78c6-bcbbe76d")]
        public void Method_0019_78c6()
        {
            ii(0x19_78c6, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_78ca, 1);  push(di);                               /* push di */
            ii(0x19_78cb, 1);  push(si);                               /* push si */
            ii(0x19_78cc, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_78d0, 1);  pop(si);                                /* pop si */
            ii(0x19_78d1, 1);  pop(di);                                /* pop di */
            ii(0x19_78d2, 1);  leave();                                /* leave */
            ii(0x19_78d3, 1);  retf();                                 /* retf */
        }
    }
}
