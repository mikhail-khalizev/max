using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3278-7d051930")]
        public void Method_0019_3278()
        {
            ii(0x19_3278, 1); push(bp);                                 /* push bp */
            ii(0x19_3279, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_327b, 1); push(si);                                 /* push si */
            ii(0x19_327c, 1); push(di);                                 /* push di */
            ii(0x19_327d, 2); mov(bl, 0);                               /* mov bl, 0x0 */
            ii(0x19_327f, 3); if(jmp_func(0x19_3c42, 0x9c0)) return;    /* jmp 0x3c42 */
        }
    }
}
