using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1c3c2e59-150e-4e5a-b067-2eb35cc8ad23")]
        public void Method_0000_9ea9()
        {
            ii(0x9ea9, 1);    pushw(si);                                /* push si */
            ii(0x9eaa, 3);    mov(si, 0x8000);                          /* mov si, 0x8000 */
            ii(0x9ead, 3);    mov(cx, 0x2000);                          /* mov cx, 0x2000 */
            ii(0x9eb0, 2);    if(jmpw_func(0x9e94, -0x1e)) return;      /* jmp 0x9e94 */
        }
    }
}
