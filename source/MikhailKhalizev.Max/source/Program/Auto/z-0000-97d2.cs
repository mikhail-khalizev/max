using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x97d2-c486bb23")]
        public void Method_0000_97d2()
        {
            ii(0x97d2, 2);  xor(ch, ch);                               /* xor ch, ch */
            ii(0x97d4, 2);  if(jcxz(0x97dc, 6)) goto l_0x97dc;         /* jcxz 0x97dc */
        l_0x97d6:
            ii(0x97d6, 2);  shr(dx, 1);                                /* shr dx, 1 */
            ii(0x97d8, 2);  rcr(ax, 1);                                /* rcr ax, 1 */
            ii(0x97da, 2);  if(loop(0x97d6, -6)) goto l_0x97d6;        /* loop 0x97d6 */
        l_0x97dc:
            ii(0x97dc, 1);  ret();                                     /* ret */
        }
    }
}
