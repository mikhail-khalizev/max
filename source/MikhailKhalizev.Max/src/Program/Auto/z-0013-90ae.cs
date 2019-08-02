using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b542a1f6-469c-4138-849e-f4bef37beead")]
        public void Method_0013_90ae()
        {
            ii(0x13_90ae, 1); pushw(bp);                                /* push bp */
            ii(0x13_90af, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_90b1, 3); mov(gs, memw_a16[ss, bp + 0x4]);          /* mov gs, [bp+0x4] */
            ii(0x13_90b4, 1); popw(bp);                                 /* pop bp */
            ii(0x13_90b5, 1); retw(); return;                           /* ret */
        }
    }
}
