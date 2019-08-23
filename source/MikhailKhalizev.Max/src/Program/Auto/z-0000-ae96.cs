using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xae96-2ccb058d")]
        public void Method_0000_ae96()
        {
            ii(0xae96, 2);    push(0x17);                               /* push 0x17 */
            ii(0xae98, 3);    call(0x589d, -0x55fe);                    /* call 0x589d */
        }
    }
}
