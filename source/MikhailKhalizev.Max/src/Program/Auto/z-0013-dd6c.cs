using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3eda8dbb-1afe-4c1e-aaaf-f7813fb436a5")]
        public void Method_0013_dd6c()
        {
            ii(0x13_dd6c, 1); pushw(bp);                                /* push bp */
            ii(0x13_dd6d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_dd6f, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x13_dd72, 2); mov(ah, 0x41);                            /* mov ah, 0x41 */
            ii(0x13_dd74, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_dd76, 3); if(jmpw_func(0x13_d8a6, -0x4d3)) return;  /* jmp 0xd8a6 */
        }
    }
}
