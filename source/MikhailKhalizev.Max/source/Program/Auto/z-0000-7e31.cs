using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7e31-864c8aaa")]
        public void Method_0000_7e31()
        {
            ii(0x7e31, 3);  call(0x6040, -0x1df4);                     /* call 0x6040 */
            ii(0x7e34, 5);  jmp_far_abs(0x70, 0x5593);                 /* jmp word 0x70:0x5593 */
        }
    }
}
