using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6544-d2c89523")]
        public void Method_0000_6544()
        {
            ii(0x6544, 2);  xor(ch, ch);                               /* xor ch, ch */
            ii(0x6546, 2);  if(jcxz(0x654e, 6)) goto l_0x654e;         /* jcxz 0x654e */
        l_0x6548:
            ii(0x6548, 2);  shl(ax, 1);                                /* shl ax, 1 */
            ii(0x654a, 2);  rcl(dx, 1);                                /* rcl dx, 1 */
            ii(0x654c, 2);  if(loop(0x6548, -6)) goto l_0x6548;        /* loop 0x6548 */
        l_0x654e:
            ii(0x654e, 1);  ret();                                     /* ret */
        }
    }
}
