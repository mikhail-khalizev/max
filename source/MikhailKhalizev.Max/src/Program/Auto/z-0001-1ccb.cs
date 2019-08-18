using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("59108837-fffc-4a51-85ba-7cfcdfb73fca")]
        public void Method_0001_1ccb()
        {
            ii(0x1_1ccb, 1);  cmc();                                    /* cmc */
            ii(0x1_1ccc, 2);  sbb(bx, bx);                              /* sbb bx, bx */
            ii(0x1_1cce, 2);  and(ax, bx);                              /* and ax, bx */
            ii(0x1_1cd0, 1);  retw(); return;                           /* ret */
        }
    }
}
