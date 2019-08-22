using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b069-4d0edad4")]
        public void Method_0018_b069()
        {
            ii(0x18_b069, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x18_b06b, 3); mov(ax, memw_a16[ds, bx + 0x10]);         /* mov ax, [bx+0x10] */
            ii(0x18_b06e, 3); mov(memw_a16[ss, bp + 0x10], ax);         /* mov [bp+0x10], ax */
            ii(0x18_b071, 3); mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0x18_b074, 3); mov(ax, memw_a16[ds, bx + 0x16]);         /* mov ax, [bx+0x16] */
            ii(0x18_b077, 3); mov(memw_a16[ss, bp + 0x16], ax);         /* mov [bp+0x16], ax */
            ii(0x18_b07a, 4); test(memb_a16[ds, bx + 0x26], 0x1);       /* test byte [bx+0x26], 0x1 */
            ii(0x18_b07e, 2); if(jzw(0x18_b082, 0x2)) goto l_0x18_b082; /* jz 0xb082 */
            ii(0x18_b080, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x18_b082:
            ii(0x18_b082, 1); popw(bp);                                 /* pop bp */
            ii(0x18_b083, 1); retw(); return;                           /* ret */
        }
    }
}