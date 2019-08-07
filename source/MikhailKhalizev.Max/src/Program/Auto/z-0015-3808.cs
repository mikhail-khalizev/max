using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7aee632f-30e0-4dee-a635-7bd15e01d5c5")]
        public void Method_0015_3808()
        {
            ii(0x15_3808, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x15_380a, 2); if(jcxzw(0x15_3812, 0x6)) goto l_0x15_3812; /* jcxz 0x3812 */
        l_0x15_380c:
            ii(0x15_380c, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x15_380e, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x15_3810, 2); if(loopw_a16(0x15_380c, -0x6)) goto l_0x15_380c; /* loop 0x380c */
        l_0x15_3812:
            ii(0x15_3812, 1); retfw(); return;                          /* retf */
        }
    }
}
