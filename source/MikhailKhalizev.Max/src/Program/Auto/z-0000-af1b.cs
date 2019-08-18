using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("80adf5c4-9734-40e2-ac18-a18e48d958cf")]
        public void Method_0000_af1b()
        {
            ii(0xaf1b, 3);    callw(0x60cb, -0x4e53);                   /* call 0x60cb */
            ii(0xaf1e, 2);    pushw(0x19);                              /* push 0x19 */
            ii(0xaf20, 3);    callw(0x589d, -0x5686);                   /* call 0x589d */
        }
    }
}
