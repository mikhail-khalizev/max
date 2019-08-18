using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2708fcdf-af10-4b45-8d65-663df1788c86")]
        public void Method_0017_dd6c()
        {
            ii(0x17_dd6c, 1); pushw(bp);                                /* push bp */
            ii(0x17_dd6d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_dd6f, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x17_dd72, 2); mov(ah, 0x41);                            /* mov ah, 0x41 */
            ii(0x17_dd74, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_dd76, 3); if(jmpw_func(0x17_d8a6, -0x4d3)) return;  /* jmp 0xd8a6 */
        }
    }
}
