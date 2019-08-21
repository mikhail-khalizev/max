using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5ee3-562abf69")]
        public void Method_1013_5ee3()
        {
            ii(0x1013_5ee3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5ee6, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5ee9, 4); add(memw_a32[ds, edx + 0xe], ax);       /* add [edx+0xe], ax */
            ii(0x1013_5eed, 5); if(jmpd_func(0x1013_5fc5, 0xd3)) return; /* jmp 0x10135fc5 */
        }
    }
}
