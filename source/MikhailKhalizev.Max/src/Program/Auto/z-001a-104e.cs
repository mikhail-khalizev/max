using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_104e-2732d58f")]
        public void Method_001a_104e()
        {
            ii(0x1a_104e, 1); popw(ax);                                 /* pop ax */
            ii(0x1a_104f, 1); pushw(cs);                                /* push cs */
            ii(0x1a_1050, 1); pushw(ax);                                /* push ax */
            ii(0x1a_1051, 5); if(jmpw_far_abs(0x80, 0x21d2)) return;    /* jmp word 0x80:0x21d2 */
        }
    }
}
