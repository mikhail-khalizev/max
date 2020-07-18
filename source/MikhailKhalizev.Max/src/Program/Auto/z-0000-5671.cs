using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5671-864c8aaa")]
        public void Method_0000_5671()
        {
            ii(0x5671, 3);  call(0x3880, -0x1df4);                     /* call 0x3880 */
            ii(0x5674, 5);  jmp_far_abs(0x70, 0x5593);                 /* jmp word 0x70:0x5593 */
        }
    }
}
