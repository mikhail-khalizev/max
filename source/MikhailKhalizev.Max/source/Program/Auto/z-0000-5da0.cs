using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5da0-a165b933")]
        public void Method_0000_5da0()
        {
            ii(0x5da0, 2);  xor(ch, ch);                               /* xor ch, ch */
            ii(0x5da2, 2);  if(jcxz(0x5daa, 6)) goto l_0x5daa;         /* jcxz 0x5daa */
        l_0x5da4:
            ii(0x5da4, 2);  sar(dx, 1);                                /* sar dx, 1 */
            ii(0x5da6, 2);  rcr(ax, 1);                                /* rcr ax, 1 */
            ii(0x5da8, 2);  if(loop(0x5da4, -6)) goto l_0x5da4;        /* loop 0x5da4 */
        l_0x5daa:
            ii(0x5daa, 1);  ret();                                     /* ret */
        }
    }
}
