using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5ed8fab4-4ade-4647-92c6-6fab6e209dfb")]
        public void Method_0019_3229()
        {
            ii(0x19_3229, 3); mov(sp, memw_a16[ss, bp - 0x8]);          /* mov sp, [bp-0x8] */
            ii(0x19_322c, 1); popw(si);                                 /* pop si */
            ii(0x19_322d, 1); popw(di);                                 /* pop di */
            ii(0x19_322e, 3); mov(ds, memw_a16[ss, bp - 0x6]);          /* mov ds, [bp-0x6] */
        }
    }
}
