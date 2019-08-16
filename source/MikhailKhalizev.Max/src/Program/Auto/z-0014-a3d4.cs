using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("71ff21c6-0f60-45ac-b603-e3d75bb9bdb4")]
        public void Method_0014_a3d4()
        {
            ii(0x14_a3d4, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x14_a3d8, 2); xor(di, di);                              /* xor di, di */
            ii(0x14_a3da, 4); mov(memw_a16[ds, 0x38], di);              /* mov [0x38], di */
            ii(0x14_a3de, 3); mov(di, memw_a16[ss, bp + 0x12]);         /* mov di, [bp+0x12] */
            ii(0x14_a3e1, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x14_a3e3, 3); shr(di, 0x8);                             /* shr di, 0x8 */
            ii(0x14_a3e6, 4); cmp(di, 0x1a);                            /* cmp di, 0x1a */
            ii(0x14_a3ea, 2); if(jaw_func(0x14_a3fa, 0xe)) return;      /* ja 0xa3fa */
            ii(0x14_a3ec, 2); shl(di, 0x1);                             /* shl di, 1 */
            ii(0x14_a3ee, 5); if(callw_abs_up(memw_a16[cs, di + 0xc30])) return; /* call word [cs:di+0xc30] */
            ii(0x14_a3f3, 4); and(memb_a16[ss, bp + 0x26], -0x2 /* 0xfe */); /* and byte [bp+0x26], 0xfe */
        }
    }
}
