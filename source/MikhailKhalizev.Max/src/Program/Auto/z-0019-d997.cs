using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("afbf3c36-bf82-487c-b14a-230172bd3f22")]
        public void Method_0019_d997()
        {
            ii(0x19_d997, 1); pushw(bp);                                /* push bp */
            ii(0x19_d998, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d99a, 2); mov(ax, fs);                              /* mov ax, fs */
            ii(0x19_d99c, 3); cmp(ax, memw_a16[ss, bp + 0x6]);          /* cmp ax, [bp+0x6] */
            ii(0x19_d99f, 2); if(jnzw(0x19_d9a5, 0x4)) goto l_0x19_d9a5; /* jnz 0xd9a5 */
            ii(0x19_d9a1, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_d9a3, 2); mov(fs, ax);                              /* mov fs, ax */
        l_0x19_d9a5:
            ii(0x19_d9a5, 1); leavew();                                 /* leave */
            ii(0x19_d9a6, 1); retfw(); return;                          /* retf */
        }
    }
}
