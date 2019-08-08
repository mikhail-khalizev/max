using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("14a919c3-448f-4262-8db2-bfd2ee5d7f13")]
        public void Method_0014_ab22()
        {
            ii(0x14_ab22, 3); mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x14_ab25, 3); callw(0x14_aae3, -0x45);                  /* call 0xaae3 */
            ii(0x14_ab28, 3); mov(memw_a16[ds, bx + 0x6], ax);          /* mov [bx+0x6], ax */
            ii(0x14_ab2b, 1); retw(); return;                           /* ret */
        }
    }
}
