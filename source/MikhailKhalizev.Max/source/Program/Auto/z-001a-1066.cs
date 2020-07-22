using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1066-275ab7f7")]
        public void Method_001a_1066()
        {
            ii(0x1a_1066, 1);  pop(ax);                                /* pop ax */
            ii(0x1a_1067, 1);  push(cs);                               /* push cs */
            ii(0x1a_1068, 1);  push(ax);                               /* push ax */
            ii(0x1a_1069, 5);  jmp_far_abs(0x80, 0x2289);              /* jmp word 0x80:0x2289 */
        }
    }
}
