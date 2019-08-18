using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e70769e-80e7-42db-b3d8-9b126e4ce96d")]
        public void Method_0000_8560()
        {
            ii(0x8560, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x8562, 2);    if(jcxzw(0x856a, 0x6)) goto l_0x856a;     /* jcxz 0x856a */
        l_0x8564:
            ii(0x8564, 2);    sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x8566, 2);    rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x8568, 2);    if(loopw_a16(0x8564, -0x6)) goto l_0x8564; /* loop 0x8564 */
        l_0x856a:
            ii(0x856a, 1);    retw(); return;                           /* ret */
        }
    }
}
