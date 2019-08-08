using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("725a614b-44ff-4e72-8063-8056e7f68b00")]
        public void Method_0014_e395()
        {
            ii(0x14_e395, 4); mov(bl, memb_a32[ss, ebp + 0x14]);        /* mov bl, [ebp+0x14] */
            ii(0x14_e399, 3); cmp(bl, 0x10);                            /* cmp bl, 0x10 */
            ii(0x14_e39c, 2); if(jaw_func(0x14_e392, -0xc)) return;     /* ja 0xe392 */
            ii(0x14_e39e, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e3a0, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e3a1, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x14_e3a3, 1); pushw(bx);                                /* push bx */
            ii(0x14_e3a4, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_e3a6, 3); callw(0x14_e868, 0x4bf);                  /* call 0xe868 */
            ii(0x14_e3a9, 3); callw(0x14_e958, 0x5ac);                  /* call 0xe958 */
        }
    }
}
