using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x97d2-c486bb23")]
        public void Method_0000_97d2()
        {
            ii(0x97d2, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x97d4, 2);    if(jcxzw(0x97dc, 0x6)) goto l_0x97dc;     /* jcxz 0x97dc */
        l_0x97d6:
            ii(0x97d6, 2);    shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x97d8, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x97da, 2);    if(loopw_a16(0x97d6, -0x6)) goto l_0x97d6; /* loop 0x97d6 */
        l_0x97dc:
            ii(0x97dc, 1);    retw(); return;                           /* ret */
        }
    }
}
