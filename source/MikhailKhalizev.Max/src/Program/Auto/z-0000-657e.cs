using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("34b6a12b-ffaa-4417-9db8-8ab6b2f46d36")]
        public void Method_0000_657e()
        {
            ii(0x657e, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x6580, 3);    callw(0x6584, 0x1);                       /* call 0x6584 */
            ii(0x6583, 1);    retw(); return;                           /* ret */
        }
    }
}
