using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abe7cdcc-3fe3-459e-9859-4c691c371859")]
        public void Method_0000_9e8e()
        {
            ii(0x9e8e, 1);    pushw(si);                                /* push si */
            ii(0x9e8f, 2);    xor(si, si);                              /* xor si, si */
            ii(0x9e91, 3);    mov(cx, 0x4000);                          /* mov cx, 0x4000 */
        }
    }
}
