using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26ac690a-4df9-45d3-b1ad-9ec9d547bb11")]
        public void Method_0014_b069()
        {
            ii(0x14_b069, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x14_b06b, 3); mov(ax, memw_a16[ds, bx + 0x10]);         /* mov ax, [bx+0x10] */
            ii(0x14_b06e, 3); mov(memw_a16[ss, bp + 0x10], ax);         /* mov [bp+0x10], ax */
            ii(0x14_b071, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x14_b074, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x14_b077, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x14_b07a, 4); test(memb_a16[ds, bx + 0x26], 0x1);       /* test byte [bx+0x26], 0x1 */
            ii(0x14_b07e, 2); if(jzw(0x14_b082, 0x2)) goto l_0x14_b082; /* jz 0xb082 */
            ii(0x14_b080, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x14_b082:
            ii(0x14_b082, 1); popw(bp);                                 /* pop bp */
            ii(0x14_b083, 1); retw(); return;                           /* ret */
        }
    }
}
