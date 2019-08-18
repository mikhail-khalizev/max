using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1d4b-f6f5462c")]
        public void Method_0019_1d4b()
        {
            ii(0x19_1d4b, 1); pushw(bp);                                /* push bp */
            ii(0x19_1d4c, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_1d4e, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_1d51, 3); cmp(memw_a16[ss, bp + 0x6], ax);          /* cmp [bp+0x6], ax */
            ii(0x19_1d54, 2); if(jlw(0x19_1d59, 0x3)) goto l_0x19_1d59; /* jl 0x1d59 */
            ii(0x19_1d56, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
        l_0x19_1d59:
            ii(0x19_1d59, 1); leavew();                                 /* leave */
            ii(0x19_1d5a, 1); retw(); return;                           /* ret */
        }
    }
}
