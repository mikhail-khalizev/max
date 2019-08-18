using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("07db651c-ef81-44e2-99d4-d7483612bcd0")]
        public void Method_0018_ab22()
        {
            ii(0x18_ab22, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x18_ab25, 3); callw(0x18_aae3, -0x45);                  /* call 0xaae3 */
            ii(0x18_ab28, 3); mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x18_ab2b, 1); retw(); return;                           /* ret */
        }
    }
}
