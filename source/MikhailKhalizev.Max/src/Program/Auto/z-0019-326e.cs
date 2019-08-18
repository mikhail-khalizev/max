using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc2addab-368a-41eb-b3b4-edcb6f460e8c")]
        public void Method_0019_326e()
        {
            ii(0x19_326e, 1); pushw(bp);                                /* push bp */
            ii(0x19_326f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3271, 1); pushw(si);                                /* push si */
            ii(0x19_3272, 1); pushw(di);                                /* push di */
            ii(0x19_3273, 2); mov(bl, 0x1);                             /* mov bl, 0x1 */
            ii(0x19_3275, 3); if(jmpw_func(0x19_3c42, 0x9ca)) return;   /* jmp 0x3c42 */
        }
    }
}
