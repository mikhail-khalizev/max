using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5f00-3e43a732")]
        public void Method_1013_5f00()
        {
            ii(0x1013_5f00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5f03, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5f06, 4); add(memw_a32[ds, edx + 0x10], ax);      /* add [edx+0x10], ax */
            ii(0x1013_5f0a, 5); if(jmpd_func(0x1013_5fc5, 0xb6)) return; /* jmp 0x10135fc5 */
        }
    }
}
