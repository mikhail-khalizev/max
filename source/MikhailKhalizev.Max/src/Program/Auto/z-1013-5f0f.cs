using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5f0f-39d74cc1")]
        public void Method_1013_5f0f()
        {
            ii(0x1013_5f0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5f12, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5f15, 4); add(memw_a32[ds, edx + 0x12], ax);      /* add [edx+0x12], ax */
            ii(0x1013_5f19, 5); if(jmpd_func(0x1013_5fc5, 0xa7)) return; /* jmp 0x10135fc5 */
        }
    }
}
