using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1354-26f491a8")]
        public void Method_0001_1354()
        {
            ii(0x1_1354, 1);  pop(ax);                                 /* pop ax */
            ii(0x1_1355, 1);  push(cs);                                /* push cs */
            ii(0x1_1356, 1);  push(ax);                                /* push ax */
            ii(0x1_1357, 5);  jmp_far_abs(0x18, 0x2b47);               /* jmp word 0x18:0x2b47 */
        }
    }
}
