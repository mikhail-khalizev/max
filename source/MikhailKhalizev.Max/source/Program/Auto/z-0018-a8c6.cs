using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a8c6-a4806222")]
        public void Method_0018_a8c6()
        {
            ii(0x18_a8c6, 3);  call(0x18_a8f3, 0x2a);                  /* call 0xa8f3 */
            ii(0x18_a8c9, 3);  call(0x18_a893, -0x39);                 /* call 0xa893 */
            ii(0x18_a8cc, 3);  jmp_func(0x18_b03d, 0x76e);             /* jmp 0xb03d */
        }
    }
}
