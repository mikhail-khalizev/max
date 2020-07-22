using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_df48-d2c8952b")]
        public void Method_0017_df48()
        {
            ii(0x17_df48, 2);  xor(ch, ch);                            /* xor ch, ch */
            ii(0x17_df4a, 2);  if(jcxz(0x17_df52, 6)) goto l_0x17_df52;/* jcxz 0xdf52 */
        l_0x17_df4c:
            ii(0x17_df4c, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_df4e, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_df50, 2);  if(loop(0x17_df4c, -6)) goto l_0x17_df4c;/* loop 0xdf4c */
        l_0x17_df52:
            ii(0x17_df52, 1);  retf();                                 /* retf */
        }
    }
}
