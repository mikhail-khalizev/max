using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dd6c-f21d6fbf")]
        public void Method_0017_dd6c()
        {
            ii(0x17_dd6c, 1);  push(bp);                               /* push bp */
            ii(0x17_dd6d, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_dd6f, 3);  mov(dx, memw[ss, bp + 6]);              /* mov dx, [bp+0x6] */
            ii(0x17_dd72, 2);  mov(ah, 0x41);                          /* mov ah, 0x41 */
            ii(0x17_dd74, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x17_dd76, 3);  jmp_func(0x17_d8a6, -0x4d3);            /* jmp 0xd8a6 */
        }
    }
}
