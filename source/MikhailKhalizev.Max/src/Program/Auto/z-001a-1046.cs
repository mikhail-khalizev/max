using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1046-26de39b3")]
        public void Method_001a_1046()
        {
            ii(0x1a_1046, 1);  pop(ax);                                /* pop ax */
            ii(0x1a_1047, 1);  push(cs);                               /* push cs */
            ii(0x1a_1048, 1);  push(ax);                               /* push ax */
            ii(0x1a_1049, 5);  jmp_far_abs(0x80, 0x216e);              /* jmp word 0x80:0x216e */
        }
    }
}
