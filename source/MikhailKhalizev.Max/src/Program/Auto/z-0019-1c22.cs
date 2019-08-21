using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1c22-1193805c")]
        public void Method_0019_1c22()
        {
            ii(0x19_1c22, 2); mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x19_1c24, 1); pushw(ax);                                /* push ax */
            ii(0x19_1c25, 3); callw_abs(memw_a16[ss, bp - 0x8]);        /* call word [bp-0x8] */
        }
    }
}
