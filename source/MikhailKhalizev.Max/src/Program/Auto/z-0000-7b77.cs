using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7b77-6d253b49")]
        public void Method_0000_7b77()
        {
            ii(0x7b77, 1);    pushw(bp);                                /* push bp */
            ii(0x7b78, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7b7a, 4);    cmp(memw_a16[ss, bp + 0x4], 0x1);         /* cmp word [bp+0x4], 0x1 */
            ii(0x7b7e, 2);    if(jzw(0x7b92, 0x12)) goto l_0x7b92;      /* jz 0x7b92 */
            ii(0x7b80, 4);    cmp(memw_a16[ss, bp + 0x4], 0x5);         /* cmp word [bp+0x4], 0x5 */
            ii(0x7b84, 2);    if(jzw(0x7b92, 0xc)) goto l_0x7b92;       /* jz 0x7b92 */
            ii(0x7b86, 4);    cmp(memw_a16[ss, bp + 0x4], 0xe);         /* cmp word [bp+0x4], 0xe */
            ii(0x7b8a, 2);    if(jzw(0x7b92, 0x6)) goto l_0x7b92;       /* jz 0x7b92 */
            ii(0x7b8c, 4);    cmp(memw_a16[ss, bp + 0x4], 0xf);         /* cmp word [bp+0x4], 0xf */
            ii(0x7b90, 2);    if(jnzw(0x7b97, 0x5)) goto l_0x7b97;      /* jnz 0x7b97 */
        l_0x7b92:
            ii(0x7b92, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x7b95, 1);    popw(bp);                                 /* pop bp */
            ii(0x7b96, 1);    retw(); return;                           /* ret */
        l_0x7b97:
            ii(0x7b97, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7b99, 1);    popw(bp);                                 /* pop bp */
            ii(0x7b9a, 1);    retw(); return;                           /* ret */
        }
    }
}
