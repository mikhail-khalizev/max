using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1066-275ab7f7")]
        public void Method_001a_1066()
        {
            ii(0x1a_1066, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1067, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1068, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1069, 5); jmpw_far_abs(0x80, 0x2289);               /* jmp word 0x80:0x2289 */
        }
    }
}
