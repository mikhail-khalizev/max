using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b151a88a-921b-4731-bb24-de9afbd02507")]
        public void Method_0000_9ea9()
        {
            ii(0x9ea9, 1);    pushw(si);                                /* push si */
            ii(0x9eaa, 3);    mov(si, 0x8000);                          /* mov si, 0x8000 */
            ii(0x9ead, 3);    mov(cx, 0x2000);                          /* mov cx, 0x2000 */
            ii(0x9eb0, 2);    if(jmpw_func(0x9e94, -0x1e)) return;      /* jmp 0x9e94 */
        }
    }
}
