using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbf92-c486bb23")]
        public void Method_0000_bf92()
        {
            ii(0xbf92, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0xbf94, 2);    if(jcxzw(0xbf9c, 0x6)) goto l_0xbf9c;     /* jcxz 0xbf9c */
        l_0xbf96:
            ii(0xbf96, 2);    shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0xbf98, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0xbf9a, 2);    if(loopw_a16(0xbf96, -0x6)) goto l_0xbf96; /* loop 0xbf96 */
        l_0xbf9c:
            ii(0xbf9c, 1);    retw(); return;                           /* ret */
        }
    }
}
