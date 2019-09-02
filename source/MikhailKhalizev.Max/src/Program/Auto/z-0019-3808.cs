using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3808-c486bb2b")]
        public void Method_0019_3808()
        {
            ii(0x19_3808, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x19_380a, 2); if(jcxz(0x19_3812, 6)) goto l_0x19_3812;  /* jcxz 0x3812 */
        l_0x19_380c:
            ii(0x19_380c, 2); shr(dx, 1);                               /* shr dx, 1 */
            ii(0x19_380e, 2); rcr(ax, 1);                               /* rcr ax, 1 */
            ii(0x19_3810, 2); if(loop(0x19_380c, -6)) goto l_0x19_380c; /* loop 0x380c */
        l_0x19_3812:
            ii(0x19_3812, 1); retf();                                   /* retf */
        }
    }
}
