using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9e8e-508a0bfa")]
        public void Method_0000_9e8e()
        {
            ii(0x9e8e, 1);    pushw(si);                                /* push si */
            ii(0x9e8f, 2);    xor(si, si);                              /* xor si, si */
            ii(0x9e91, 3);    mov(cx, 0x4000);                          /* mov cx, 0x4000 */
        }
    }
}
