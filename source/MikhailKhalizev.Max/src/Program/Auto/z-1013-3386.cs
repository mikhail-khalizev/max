using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8753de93-17a9-411b-817e-973136fda90e")]
        public void Method_1013_3386()
        {
            ii(0x1013_3386, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1013_3389, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        }
    }
}
