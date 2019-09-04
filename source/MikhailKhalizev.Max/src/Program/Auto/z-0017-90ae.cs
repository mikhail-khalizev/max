using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_90ae-cc41cb58")]
        public void Method_0017_90ae()
        {
            ii(0x17_90ae, 1); push(bp);                                 /* push bp */
            ii(0x17_90af, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_90b1, 3); mov(gs, memw[ss, bp + 4]);                /* mov gs, [bp+0x4] */
            ii(0x17_90b4, 1); pop(bp);                                  /* pop bp */
            ii(0x17_90b5, 1); ret();                                    /* ret */
        }
    }
}
