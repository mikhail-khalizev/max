using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaf1b-c1b2cd2c")]
        public void Method_0000_af1b()
        {
            ii(0xaf1b, 3);  call(0x60cb, -0x4e53);                     /* call 0x60cb */
            ii(0xaf1e, 2);  push(0x19);                                /* push 0x19 */
            ii(0xaf20, 3);  call(0x589d, -0x5686);                     /* call 0x589d */
        }
    }
}
