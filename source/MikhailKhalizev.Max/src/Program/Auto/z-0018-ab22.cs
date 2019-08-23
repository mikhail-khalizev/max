using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ab22-f4607124")]
        public void Method_0018_ab22()
        {
            ii(0x18_ab22, 3); mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0x18_ab25, 3); call(0x18_aae3, -0x45);                   /* call 0xaae3 */
            ii(0x18_ab28, 3); mov(memw[ds, bx + 0x6], ax);              /* mov [bx+0x6], ax */
            ii(0x18_ab2b, 1); ret();                                    /* ret */
        }
    }
}
