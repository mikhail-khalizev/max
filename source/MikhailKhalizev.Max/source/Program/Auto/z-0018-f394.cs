using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f394-26f491a8")]
        public void Method_0018_f394()
        {
            ii(0x18_f394, 1);  pop(ax);                                /* pop ax */
            ii(0x18_f395, 1);  push(cs);                               /* push cs */
            ii(0x18_f396, 1);  push(ax);                               /* push ax */
            ii(0x18_f397, 5);  jmp_far_abs(0x18, 0x2b47);              /* jmp word 0x18:0x2b47 */
        }
    }
}
