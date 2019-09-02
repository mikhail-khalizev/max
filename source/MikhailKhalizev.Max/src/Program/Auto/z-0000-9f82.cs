using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9f82-c486bb23")]
        public void Method_0000_9f82()
        {
            ii(0x9f82, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x9f84, 2);    if(jcxz(0x9f8c, 6)) goto l_0x9f8c;        /* jcxz 0x9f8c */
        l_0x9f86:
            ii(0x9f86, 2);    shr(dx, 1);                               /* shr dx, 1 */
            ii(0x9f88, 2);    rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x9f8a, 2);    if(loop(0x9f86, -6)) goto l_0x9f86;       /* loop 0x9f86 */
        l_0x9f8c:
            ii(0x9f8c, 1);    ret();                                    /* ret */
        }
    }
}
