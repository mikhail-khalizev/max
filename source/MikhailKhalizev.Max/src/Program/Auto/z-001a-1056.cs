using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1056-2715b035")]
        public void Method_001a_1056()
        {
            ii(0x1a_1056, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1057, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1058, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1059, 5); if(jmpw_far_abs(0x80, 0x220b)) return;    /* jmp word 0x80:0x220b */
        }
    }
}
