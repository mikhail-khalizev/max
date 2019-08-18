using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f2be1e5-af49-4c3c-9196-25530fbb9548")]
        public void Method_0000_5e21()
        {
            ii(0x5e21, 3);    callw(0x4030, -0x1df4);                   /* call 0x4030 */
            ii(0x5e24, 5);    if(jmpw_far_abs(0x70, 0x5593)) return;    /* jmp word 0x70:0x5593 */
        }
    }
}
