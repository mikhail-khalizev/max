using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6102-391629ee")]
        public void Method_1013_6102()
        {
            ii(0x1013_6102, 1); inc(ebp);                               /* inc ebp */
            ii(0x1013_6103, 1); cld();                                  /* cld */
            ii(0x1013_6104, 2); add(al, 0x6b);                          /* add al, 0x6b */
            ii(0x1013_6106, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1013_6109, 5); calld(0x100c_aafc, -0x6_b612);          /* call 0x100caafc */
        }
    }
}
