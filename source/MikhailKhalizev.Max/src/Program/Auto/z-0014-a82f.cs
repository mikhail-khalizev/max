using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("69394e19-a356-4777-b70f-2c6f781a795a")]
        public void Method_0014_a82f()
        {
            ii(0x14_a82f, 3); mov(ax, memw_a16[ds, bx + 0x26]);         /* mov ax, [bx+0x26] */
            ii(0x14_a832, 3); and(ah, 0xe);                             /* and ah, 0xe */
            ii(0x14_a835, 3); mov(memw_a16[ss, bp + 0x26], ax);         /* mov [bp+0x26], ax */
        }
    }
}
