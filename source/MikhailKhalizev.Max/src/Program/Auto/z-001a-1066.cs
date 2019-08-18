using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("290bc2ac-95ec-4696-8085-c271026c899b")]
        public void Method_001a_1066()
        {
            ii(0x1a_1066, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_1067, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1068, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1069, 5); if(jmpw_far_abs(0x80, 0x2289)) return;    /* jmp word 0x80:0x2289 */
        }
    }
}
