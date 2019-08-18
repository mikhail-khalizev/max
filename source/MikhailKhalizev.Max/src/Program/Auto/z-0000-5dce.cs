using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b4182d4-3bec-4de1-882e-b65328df3f74")]
        public void Method_0000_5dce()
        {
            ii(0x5dce, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x5dd0, 3);    callw(0x5dd4, 0x1);                       /* call 0x5dd4 */
            ii(0x5dd3, 1);    retw(); return;                           /* ret */
        }
    }
}
