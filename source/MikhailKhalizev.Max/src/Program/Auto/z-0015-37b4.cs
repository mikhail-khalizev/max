using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d440f8ed-1a00-4c97-98be-c48342dd29a9")]
        public void Method_0015_37b4()
        {
            ii(0x15_37b4, 2); xor(ch, ch);                              /* xor ch, ch */
            ii(0x15_37b6, 2); if(jcxzw(0x15_37be, 0x6)) goto l_0x15_37be; /* jcxz 0x37be */
        l_0x15_37b8:
            ii(0x15_37b8, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x15_37ba, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x15_37bc, 2); if(loopw_a16(0x15_37b8, -0x6)) goto l_0x15_37b8; /* loop 0x37b8 */
        l_0x15_37be:
            ii(0x15_37be, 1); retfw(); return;                          /* retf */
        }
    }
}
