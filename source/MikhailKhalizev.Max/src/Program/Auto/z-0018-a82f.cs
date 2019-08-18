using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f10510db-f3f4-4aa0-a1e2-797853fffd77")]
        public void Method_0018_a82f()
        {
            ii(0x18_a82f, 3); mov(ax, memw_a16[ds, bx + 0x26]);         /* mov ax, [bx+0x26] */
            ii(0x18_a832, 3); and(ah, 0xe);                             /* and ah, 0xe */
            ii(0x18_a835, 3); mov(memw_a16[ss, bp + 0x26], ax);         /* mov [bp+0x26], ax */
        }
    }
}
