using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("231ee2b2-3f2c-4966-bbdb-5f58db9fea24")]
        public void Method_0013_8f00()
        {
            ii(0x13_8f00, 1); pushw(ss);                                /* push ss */
            ii(0x13_8f01, 1); popw(ax);                                 /* pop ax */
            ii(0x13_8f02, 1); retfw(); return;                          /* retf */
        }
    }
}
