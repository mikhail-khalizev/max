using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc00e054-6879-4aed-aeef-14c7386998f8")]
        public void Method_0015_326e()
        {
            ii(0x15_326e, 1); pushw(bp);                                /* push bp */
            ii(0x15_326f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_3271, 1); pushw(si);                                /* push si */
            ii(0x15_3272, 1); pushw(di);                                /* push di */
            ii(0x15_3273, 2); mov(bl, 0x1);                             /* mov bl, 0x1 */
            ii(0x15_3275, 3); if(jmpw_func(0x15_3c42, 0x9ca)) return;   /* jmp 0x3c42 */
        }
    }
}
