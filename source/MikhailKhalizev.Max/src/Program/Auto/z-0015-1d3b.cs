using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8652b72d-3584-4c81-8c85-b05a5fe8d5c1")]
        public void Method_0015_1d3b()
        {
            ii(0x15_1d3b, 1); pushw(bp);                                /* push bp */
            ii(0x15_1d3c, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_1d3e, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_1d41, 3); cmp(memw_a16[ss, bp + 0x6], ax);          /* cmp [bp+0x6], ax */
            ii(0x15_1d44, 2); if(jgw(0x15_1d49, 0x3)) goto l_0x15_1d49; /* jg 0x1d49 */
            ii(0x15_1d46, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        l_0x15_1d49:
            ii(0x15_1d49, 1); leavew();                                 /* leave */
            ii(0x15_1d4a, 1); retw(); return;                           /* ret */
        }
    }
}
