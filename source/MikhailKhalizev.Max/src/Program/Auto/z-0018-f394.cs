using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("468ac94e-3216-4c1c-b8ee-9ba28213e6c6")]
        public void Method_0018_f394()
        {
            ii(0x18_f394, 1); popw(ax);                                 /* pop ax */
            ii(0x18_f395, 1); pushw(cs);                                /* push cs */
            ii(0x18_f396, 1); pushw(ax);                                /* push ax */
            ii(0x18_f397, 5); if(jmpw_far_abs(0x18, 0x2b47)) return;    /* jmp word 0x18:0x2b47 */
        }
    }
}
