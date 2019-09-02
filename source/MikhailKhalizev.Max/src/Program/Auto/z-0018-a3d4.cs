using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a3d4-614dce75")]
        public void Method_0018_a3d4()
        {
            ii(0x18_a3d4, 4); or(memb[ss, bp + 0x26], 1);               /* or byte [bp+0x26], 0x1 */
            ii(0x18_a3d8, 2); xor(di, di);                              /* xor di, di */
            ii(0x18_a3da, 4); mov(memw[ds, 0x38], di);                  /* mov [0x38], di */
            ii(0x18_a3de, 3); mov(di, memw[ss, bp + 0x12]);             /* mov di, [bp+0x12] */
            ii(0x18_a3e1, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x18_a3e3, 3); shr(di, 8);                               /* shr di, 0x8 */
            ii(0x18_a3e6, 4); cmp(di, 0x1a);                            /* cmp di, 0x1a */
            ii(0x18_a3ea, 2); if(ja(0x18_a3fa, 0xe)) goto l_0x18_a3fa;  /* ja 0xa3fa */
            ii(0x18_a3ec, 2); shl(di, 1);                               /* shl di, 1 */
            ii(0x18_a3ee, 5); if(call_abs_up(memw[cs, di + 0xc30])) return; /* call word [cs:di+0xc30] */
            ii(0x18_a3f3, 4); and(memb[ss, bp + 0x26], -2 /* 0xfe */);  /* and byte [bp+0x26], 0xfe */
            ii(0x18_a3f7, 3); mov(memw[ss, bp + 0x16], ax);             /* mov [bp+0x16], ax */
        l_0x18_a3fa:
            ii(0x18_a3fa, 3); if(jmp_func(0x18_a838, 0x43b)) return;    /* jmp 0xa838 */
        }
    }
}
