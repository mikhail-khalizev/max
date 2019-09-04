using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8554-d2c89523")]
        public void Method_0000_8554()
        {
            ii(0x8554, 2);    xor(ch, ch);                              /* xor ch, ch */
            ii(0x8556, 2);    if(jcxz(0x855e, 6)) goto l_0x855e;        /* jcxz 0x855e */
        l_0x8558:
            ii(0x8558, 2);    shl(ax, 1);                               /* shl ax, 1 */
            ii(0x855a, 2);    rcl(dx, 1);                               /* rcl dx, 1 */
            ii(0x855c, 2);    if(loop(0x8558, -6)) goto l_0x8558;       /* loop 0x8558 */
        l_0x855e:
            ii(0x855e, 1);    ret();                                    /* ret */
        }
    }
}
