using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_df48-d2c8952b")]
        public void Method_0017_df48()
        {
            ii(0x17_df48, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x17_df4a, 2); if(jcxzw(0x17_df52, 0x6)) goto l_0x17_df52; /* jcxz 0xdf52 */
        l_0x17_df4c:
            ii(0x17_df4c, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x17_df4e, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x17_df50, 2); if(loopw_a16(0x17_df4c, -0x6)) goto l_0x17_df4c; /* loop 0xdf4c */
        l_0x17_df52:
            ii(0x17_df52, 1); retfw();                                  /* retf */
        }
    }
}
