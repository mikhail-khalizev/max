using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_df60-c486bb2b")]
        public void Method_0017_df60()
        {
            ii(0x17_df60, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x17_df62, 2); if(jcxz(0x17_df6a, 6)) goto l_0x17_df6a;  /* jcxz 0xdf6a */
        l_0x17_df64:
            ii(0x17_df64, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x17_df66, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x17_df68, 2); if(loop(0x17_df64, -6)) goto l_0x17_df64; /* loop 0xdf64 */
        l_0x17_df6a:
            ii(0x17_df6a, 1); retf();                                   /* retf */
        }
    }
}
