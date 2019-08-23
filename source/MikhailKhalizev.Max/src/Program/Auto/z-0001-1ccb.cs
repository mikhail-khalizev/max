using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_1ccb-c257c466")]
        public void Method_0001_1ccb()
        {
            ii(0x1_1ccb, 1);  cmc();                                    /* cmc */
            ii(0x1_1ccc, 2);  sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x1_1cce, 2);  and(ax, bx);                              /* and ax, bx */
            ii(0x1_1cd0, 1);  ret();                                    /* ret */
        }
    }
}
