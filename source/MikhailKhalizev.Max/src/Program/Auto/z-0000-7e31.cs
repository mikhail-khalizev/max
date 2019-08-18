using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f7ec4b7-3a87-44e3-aa0c-bf84628d0567")]
        public void Method_0000_7e31()
        {
            ii(0x7e31, 3);    callw(0x6040, -0x1df4);                   /* call 0x6040 */
            ii(0x7e34, 5);    if(jmpw_far_abs(0x70, 0x5593)) return;    /* jmp word 0x70:0x5593 */
        }
    }
}
