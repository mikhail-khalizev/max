using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8560-a165b933")]
        public void Method_0000_8560()
        {
            ii(0x8560, 2);  xor(ch, ch);                               /* xor ch, ch */
            ii(0x8562, 2);  if(jcxz(0x856a, 6)) goto l_0x856a;         /* jcxz 0x856a */
        l_0x8564:
            ii(0x8564, 2);  sar(dx, 1);                                /* sar dx, 1 */
            ii(0x8566, 2);  rcr(ax, 1);                                /* rcr ax, 1 */
            ii(0x8568, 2);  if(loop(0x8564, -6)) goto l_0x8564;        /* loop 0x8564 */
        l_0x856a:
            ii(0x856a, 1);  ret();                                     /* ret */
        }
    }
}
