using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("73df8e3a-3847-453b-ace2-e3baf91ab268")]
        public void Method_0000_5d94()
        {
            ii(0x5d94, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x5d96, 2);    if(jcxzw(0x5d9e, 0x6)) goto l_0x5d9e;     /* jcxz 0x5d9e */
        l_0x5d98:
            ii(0x5d98, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x5d9a, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x5d9c, 2);    if(loopw_a16(0x5d98, -0x6)) goto l_0x5d98; /* loop 0x5d98 */
        l_0x5d9e:
            ii(0x5d9e, 1);    retw(); return;                           /* ret */
        }
    }
}
