using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77b9dd47-6aa4-40db-9370-d77a52f6412b")]
        public void Method_0013_90b6()
        {
            ii(0x13_90b6, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x13_90ba, 4); ltr(memw_a16[ss, bp + 0x6]);              /* ltr word [bp+0x6] */
            ii(0x13_90be, 1); leavew();                                 /* leave */
            ii(0x13_90bf, 1); retfw(); return;                          /* retf */
        }
    }
}
