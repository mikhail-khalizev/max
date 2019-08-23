using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x42fc-f0db9d86")]
        public void Method_0000_42fc()
        {
            ii(0x42fc, 1);    cli();                                    /* cli */
            ii(0x42fd, 3);    push(0x1026);                             /* push 0x1026 */
            ii(0x4300, 3);    call(0x4888, 0x585);                      /* call 0x4888 */
            ii(0x4303, 1);    pop(cx);                                  /* pop cx */
            ii(0x4304, 1);    ret();                                    /* ret */
        }
    }
}
