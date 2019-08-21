using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5f63-8377909f")]
        public void Method_1013_5f63()
        {
            ii(0x1013_5f63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5f66, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5f69, 4); add(memw_a32[ds, edx + 0x1f], ax);      /* add [edx+0x1f], ax */
            ii(0x1013_5f6d, 2); if(jmpd_func(0x1013_5fc5, 0x56)) return; /* jmp 0x10135fc5 */
        }
    }
}
