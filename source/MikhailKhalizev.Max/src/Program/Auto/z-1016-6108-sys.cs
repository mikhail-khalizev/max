using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("10b5e02b-01ed-43db-8690-c63ecbe27e26")]
        public void /* sys */ Method_1016_6108()
        {
            ii(0x1016_6108, 3); mov(eax, memd_a32[ds, eax + 0x4]);      /* mov eax, [eax+0x4] */
            ii(0x1016_610b, 3); mov(eax, memd_a32[ds, eax + edx * 8]);  /* mov eax, [eax+edx*8] */
            ii(0x1016_610e, 1); retd(); return;                         /* ret */
        }
    }
}
