using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9a47f076-d749-41ce-b2d6-12d19d5dd7ea")]
        public void Method_0014_accb()
        {
            ii(0x14_accb, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x14_acce, 4); cmp(cx, memw_a16[ds, 0xc42]);             /* cmp cx, [0xc42] */
            ii(0x14_acd2, 2); if(jzw(0x14_acd9, 0x5)) goto l_0x14_acd9; /* jz 0xacd9 */
            ii(0x14_acd4, 3); cmp(cx, 0x70);                            /* cmp cx, 0x70 */
            ii(0x14_acd7, 2); if(jnzw(0x14_ace0, 0x7)) goto l_0x14_ace0; /* jnz 0xace0 */
        l_0x14_acd9:
            ii(0x14_acd9, 2); xor(cx, cx);                              /* xor cx, cx */
            ii(0x14_acdb, 3); callw(0x14_acf3, 0x15);                   /* call 0xacf3 */
            ii(0x14_acde, 2); if(jmpw_func(0x14_ac85, -0x5b)) return;   /* jmp 0xac85 */
        l_0x14_ace0:
            ii(0x14_ace0, 3); callw(0x14_acf3, 0x10);                   /* call 0xacf3 */
            ii(0x14_ace3, 5); cmp(memb_a16[ds, 0x1181], 0);             /* cmp byte [0x1181], 0x0 */
            ii(0x14_ace8, 2); if(jnzw_func(0x14_ac98, -0x52)) return;   /* jnz 0xac98 */
            ii(0x14_acea, 3); mov(ax, 0x1130);                          /* mov ax, 0x1130 */
            ii(0x14_aced, 4); mov(si, memw_a16[ds, 0x9b6]);             /* mov si, [0x9b6] */
            ii(0x14_acf1, 2); if(jmpw_func(0x14_ac8d, -0x66)) return;   /* jmp 0xac8d */
        }
    }
}
