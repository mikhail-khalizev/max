using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5d94-d2c89523")]
        public void Method_0000_5d94()
        {
            ii(0x5d94, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x5d96, 2);    if(jcxz(0x5d9e, 6)) goto l_0x5d9e;        /* jcxz 0x5d9e */
        l_0x5d98:
            ii(0x5d98, 2);    shl(ax, 1);                               /* shl ax, 1 */
            ii(0x5d9a, 2);    rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x5d9c, 2);    if(loop(0x5d98, -6)) goto l_0x5d98;       /* loop 0x5d98 */
        l_0x5d9e:
            ii(0x5d9e, 1);    ret();                                    /* ret */
        }
    }
}
