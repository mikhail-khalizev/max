using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("777f5da9-35df-438b-9eb0-a6ab4ab58fa0")]
        public void Method_0018_b053()
        {
            ii(0x18_b053, 1); popw(cx);                                 /* pop cx */
            ii(0x18_b054, 1); popw(cx);                                 /* pop cx */
            ii(0x18_b055, 3); if(jmpw_func(0x18_a838, -0x820)) return;  /* jmp 0xa838 */
            ii(0x18_b058, 1); pushw(bp);                                /* push bp */
            ii(0x18_b059, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_b05b, 3); mov(bp, memw_a16[ss, bp + 0x4]);          /* mov bp, [bp+0x4] */
            ii(0x18_b05e, 4); mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0x18_b062, 4); mov(memb_a16[ds, bx + 0x17], 0x48);       /* mov byte [bx+0x17], 0x48 */
            ii(0x18_b066, 3); callw(0x18_a893, -0x7d6);                 /* call 0xa893 */
        }
    }
}
