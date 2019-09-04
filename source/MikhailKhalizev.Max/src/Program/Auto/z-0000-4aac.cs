using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4aac-f0db9d86")]
        public void Method_0000_4aac()
        {
            ii(0x4aac, 1);  cli();                                     /* cli */
            ii(0x4aad, 3);  push(0x1026);                              /* push 0x1026 */
            ii(0x4ab0, 3);  call(0x5038, 0x585);                       /* call 0x5038 */
            ii(0x4ab3, 1);  pop(cx);                                   /* pop cx */
            ii(0x4ab4, 1);  ret();                                     /* ret */
        }
    }
}
