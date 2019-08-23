using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_105e-26f2251a")]
        public void Method_001a_105e()
        {
            ii(0x1a_105e, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_105f, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1060, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1061, 5); jmpw_far_abs(0x80, 0x2244);               /* jmp word 0x80:0x2244 */
        }
    }
}
