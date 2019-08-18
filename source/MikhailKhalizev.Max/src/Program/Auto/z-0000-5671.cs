using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a4ca94ff-1d55-4d4e-bd3c-5622dee3a069")]
        public void Method_0000_5671()
        {
            ii(0x5671, 3);    callw(0x3880, -0x1df4);                   /* call 0x3880 */
            ii(0x5674, 5);    if(jmpw_far_abs(0x70, 0x5593)) return;    /* jmp word 0x70:0x5593 */
        }
    }
}
