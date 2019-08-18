using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_90b6-7bd2f70d")]
        public void Method_0017_90b6()
        {
            ii(0x17_90b6, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x17_90ba, 4); ltr(memw_a16[ss, bp + 0x6]);              /* ltr word [bp+0x6] */
            ii(0x17_90be, 1); leavew();                                 /* leave */
            ii(0x17_90bf, 1); retfw(); return;                          /* retf */
        }
    }
}
