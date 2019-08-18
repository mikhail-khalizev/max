using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b39f4aae-32b5-4d8e-94ec-8e1f8af416b5")]
        public void Method_001a_1046()
        {
            ii(0x1a_1046, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1047, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1048, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1049, 5); if(jmpw_far_abs(0x80, 0x216e)) return;    /* jmp word 0x80:0x216e */
        }
    }
}
