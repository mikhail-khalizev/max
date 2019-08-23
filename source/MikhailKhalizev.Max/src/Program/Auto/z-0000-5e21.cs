using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5e21-864c8aaa")]
        public void Method_0000_5e21()
        {
            ii(0x5e21, 3);    call(0x4030, -0x1df4);                    /* call 0x4030 */
            ii(0x5e24, 5);    jmp_far_abs(0x70, 0x5593);                /* jmp word 0x70:0x5593 */
        }
    }
}
