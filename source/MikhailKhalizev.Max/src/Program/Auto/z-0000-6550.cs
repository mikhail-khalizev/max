using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6550-a165b933")]
        public void Method_0000_6550()
        {
            ii(0x6550, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x6552, 2);    if(jcxzw(0x655a, 0x6)) goto l_0x655a;     /* jcxz 0x655a */
        l_0x6554:
            ii(0x6554, 2);    sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x6556, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x6558, 2);    if(loopw_a16(0x6554, -0x6)) goto l_0x6554; /* loop 0x6554 */
        l_0x655a:
            ii(0x655a, 1);    retw();                                   /* ret */
        }
    }
}
