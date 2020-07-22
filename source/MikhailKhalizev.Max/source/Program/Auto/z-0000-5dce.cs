using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5dce-fc6525ec")]
        public void Method_0000_5dce()
        {
            ii(0x5dce, 2);  xor(ah, ah);                               /* xor ah, ah */
            ii(0x5dd0, 3);  call(0x5dd4, 1);                           /* call 0x5dd4 */
            ii(0x5dd3, 1);  ret();                                     /* ret */
        }
    }
}
