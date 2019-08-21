using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1c28-afba4a6e")]
        public void Method_0019_1c28()
        {
            ii(0x19_1c28, 1); popw(bx);                                 /* pop bx */
            ii(0x19_1c29, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
            ii(0x19_1c2c, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_1c2f, 3); cmp(memb_a16[ds, bx], 0);                 /* cmp byte [bx], 0x0 */
            ii(0x19_1c32, 2); if(jnzw_func(0x19_1c22, -0x12)) return;   /* jnz 0x1c22 */
            ii(0x19_1c34, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_1c36, 3); sub(ax, 0x392c);                          /* sub ax, 0x392c */
            ii(0x19_1c39, 1); popw(ds);                                 /* pop ds */
            ii(0x19_1c3a, 1); leavew();                                 /* leave */
            ii(0x19_1c3b, 1); retfw(); return;                          /* retf */
        }
    }
}
