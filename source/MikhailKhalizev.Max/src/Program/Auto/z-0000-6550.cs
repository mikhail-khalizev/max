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
            ii(0x6552, 2);    if(jcxz(0x655a, 6)) goto l_0x655a;        /* jcxz 0x655a */
        l_0x6554:
            ii(0x6554, 2);    sar(dx, 1);                               /* sar dx, 1 */
            ii(0x6556, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x6558, 2);    if(loop(0x6554, -6)) goto l_0x6554;       /* loop 0x6554 */
        l_0x655a:
            ii(0x655a, 1);    ret();                                    /* ret */
        }
    }
}
