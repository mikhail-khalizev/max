using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa87b-2cc6e6e0")]
        public void Method_0000_a87b()
        {
            ii(0xa87b, 2);    pushw(0x1f);                              /* push 0x1f */
            ii(0xa87d, 3);    callw(0x589d, -0x4fe3);                   /* call 0x589d */
        }
    }
}
