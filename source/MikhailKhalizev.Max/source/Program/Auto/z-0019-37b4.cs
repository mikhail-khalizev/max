using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_37b4-d2c8952b")]
        public void Method_0019_37b4()
        {
            ii(0x19_37b4, 2);  xor(ch, ch);                            /* xor ch, ch */
            ii(0x19_37b6, 2);  if(jcxz(0x19_37be, 6)) goto l_0x19_37be;/* jcxz 0x37be */
        l_0x19_37b8:
            ii(0x19_37b8, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x19_37ba, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x19_37bc, 2);  if(loop(0x19_37b8, -6)) goto l_0x19_37b8;/* loop 0x37b8 */
        l_0x19_37be:
            ii(0x19_37be, 1);  retf();                                 /* retf */
        }
    }
}
