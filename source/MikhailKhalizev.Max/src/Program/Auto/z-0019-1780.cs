using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1780-f2eede54")]
        public void Method_0019_1780()
        {
            ii(0x19_1780, 1); pushw(bp);                                /* push bp */
            ii(0x19_1781, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_1783, 4); cmp(memb_a16[ss, bp + 0x4], 0xa);         /* cmp byte [bp+0x4], 0xa */
            ii(0x19_1787, 2); if(jnzw(0x19_178f, 0x6)) goto l_0x19_178f; /* jnz 0x178f */
            ii(0x19_1789, 2); pushw(0xd);                               /* push 0xd */
            ii(0x19_178b, 3); callw(0x19_1780, -0xe);                   /* call 0x1780 */
            ii(0x19_178e, 1); popw(bx);                                 /* pop bx */
        l_0x19_178f:
            ii(0x19_178f, 2); mov(ah, 0x6);                             /* mov ah, 0x6 */
            ii(0x19_1791, 3); mov(dl, memb_a16[ss, bp + 0x4]);          /* mov dl, [bp+0x4] */
            ii(0x19_1794, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_1796, 1); leavew();                                 /* leave */
            ii(0x19_1797, 1); retw(); return;                           /* ret */
        }
    }
}
