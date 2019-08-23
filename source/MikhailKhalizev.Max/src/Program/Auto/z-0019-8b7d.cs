using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8b7d-235947aa")]
        public void Method_0019_8b7d()
        {
            ii(0x19_8b7d, 1); pushw(bp);                                /* push bp */
            ii(0x19_8b7e, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_8b80, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_8b83, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_8b86, 3); pushw(0x1a14);                            /* push 0x1a14 */
            ii(0x19_8b89, 3); callw(0x19_8b20, -0x6c);                  /* call 0x8b20 */
            ii(0x19_8b8c, 1); leavew();                                 /* leave */
            ii(0x19_8b8d, 3); retw(0x4);                                /* ret 0x4 */
        }
    }
}
