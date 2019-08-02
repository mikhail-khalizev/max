using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f39453fd-437f-44cd-b485-441401e8a152")]
        public void Method_0016_104e()
        {
            ii(0x16_104e, 1); popw(ax);                                 /* pop ax */
            ii(0x16_104f, 1); pushw(cs);                                /* push cs */
            ii(0x16_1050, 1); pushw(ax);                                /* push ax */
            ii(0x16_1051, 5); jmpw_far_abs(0x80, 0x21d2); return;       /* jmp word 0x80:0x21d2 */
        }
    }
}
