using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_dcfb-c257c466")]
        public void Method_0018_dcfb()
        {
            ii(0x18_dcfb, 1); cmc();                                    /* cmc */
            ii(0x18_dcfc, 2); sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x18_dcfe, 2); and(ax, bx);                              /* and ax, bx */
            ii(0x18_dd00, 1); retw(); return;                           /* ret */
        }
    }
}
