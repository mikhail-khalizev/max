using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9d478e9-a395-4fce-9ffd-9a28ab29f8c3")]
        public void Method_0000_858e()
        {
            ii(0x858e, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x8590, 3);    callw(0x8594, 0x1);                       /* call 0x8594 */
            ii(0x8593, 1);    retw(); return;                           /* ret */
        }
    }
}
