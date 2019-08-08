using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a89b5a52-3c1c-4c39-89b2-7ea35fae6a7f")]
        public void Method_0016_1056()
        {
            ii(0x16_1056, 1); popw(ax);                                 /* pop ax */
            ii(0x16_1057, 1); pushw(cs);                                /* push cs */
            ii(0x16_1058, 1); pushw(ax);                                /* push ax */
            ii(0x16_1059, 5); if(jmpw_far_abs(0x80, 0x220b)) return;    /* jmp word 0x80:0x220b */
        }
    }
}
