using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1056-2715b035")]
        public void Method_001a_1056()
        {
            ii(0x1a_1056, 1);  pop(ax);                                /* pop ax */
            ii(0x1a_1057, 1);  push(cs);                               /* push cs */
            ii(0x1a_1058, 1);  push(ax);                               /* push ax */
            ii(0x1a_1059, 5);  jmp_far_abs(0x80, 0x220b);              /* jmp word 0x80:0x220b */
        }
    }
}
