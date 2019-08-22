using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ab18-afe8c45a")]
        public void Method_0018_ab18()
        {
            ii(0x18_ab18, 3); mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x18_ab1b, 3); callw(0x18_aae3, -0x3b);                  /* call 0xaae3 */
            ii(0x18_ab1e, 3); mov(memw_a16[ds, bx + 0x4], ax);          /* mov [bx+0x4], ax */
            ii(0x18_ab21, 1); retw(); return;                           /* ret */
        }
    }
}