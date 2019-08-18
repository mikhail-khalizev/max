using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("73ba4e95-22c0-4642-8336-c9e8f82595a0")]
        public void Method_0019_3808()
        {
            ii(0x19_3808, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x19_380a, 2); if(jcxzw(0x19_3812, 0x6)) goto l_0x19_3812; /* jcxz 0x3812 */
        l_0x19_380c:
            ii(0x19_380c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x19_380e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x19_3810, 2); if(loopw_a16(0x19_380c, -0x6)) goto l_0x19_380c; /* loop 0x380c */
        l_0x19_3812:
            ii(0x19_3812, 1); retfw(); return;                          /* retf */
        }
    }
}
