using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6322e5d8-1934-440f-b7b7-e8e6649537a5")]
        public void Method_0017_df60()
        {
            ii(0x17_df60, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x17_df62, 2); if(jcxzw(0x17_df6a, 0x6)) goto l_0x17_df6a; /* jcxz 0xdf6a */
        l_0x17_df64:
            ii(0x17_df64, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_df66, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_df68, 2); if(loopw_a16(0x17_df64, -0x6)) goto l_0x17_df64; /* loop 0xdf64 */
        l_0x17_df6a:
            ii(0x17_df6a, 1); retfw(); return;                          /* retf */
        }
    }
}
