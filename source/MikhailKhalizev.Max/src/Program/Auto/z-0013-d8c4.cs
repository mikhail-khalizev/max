using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("124aed03-8e45-4929-b923-db2669fcf6af")]
        public void Method_0013_d8c4()
        {
            ii(0x13_d8c4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x13_d8c6, 1); popw(bp);                                 /* pop bp */
            ii(0x13_d8c7, 1); retfw(); return;                          /* retf */
        }
    }
}
