using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7b9b-f1eaff34")]
        public void Method_0000_7b9b()
        {
            ii(0x7b9b, 1);    pushw(bp);                                /* push bp */
            ii(0x7b9c, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x7b9e, 4);    cmp(memw_a16[ss, bp + 0x4], 0x30);        /* cmp word [bp+0x4], 0x30 */
            ii(0x7ba2, 2);    if(jlw(0x7baf, 0xb)) goto l_0x7baf;       /* jl 0x7baf */
            ii(0x7ba4, 4);    cmp(memw_a16[ss, bp + 0x4], 0x39);        /* cmp word [bp+0x4], 0x39 */
            ii(0x7ba8, 2);    if(jgw(0x7baf, 0x5)) goto l_0x7baf;       /* jg 0x7baf */
            ii(0x7baa, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x7bad, 1);    popw(bp);                                 /* pop bp */
            ii(0x7bae, 1);    retw(); return;                           /* ret */
        l_0x7baf:
            ii(0x7baf, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7bb1, 1);    popw(bp);                                 /* pop bp */
            ii(0x7bb2, 1);    retw(); return;                           /* ret */
        }
    }
}
