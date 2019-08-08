using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e5fc3be-f740-4b0b-b080-ae022f9848fc")]
        public void Method_0015_3278()
        {
            ii(0x15_3278, 1); pushw(bp);                                /* push bp */
            ii(0x15_3279, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_327b, 1); pushw(si);                                /* push si */
            ii(0x15_327c, 1); pushw(di);                                /* push di */
            ii(0x15_327d, 2); mov(bl, 0);                               /* mov bl, 0x0 */
            ii(0x15_327f, 3); if(jmpw_func(0x15_3c42, 0x9c0)) return;   /* jmp 0x3c42 */
        }
    }
}
