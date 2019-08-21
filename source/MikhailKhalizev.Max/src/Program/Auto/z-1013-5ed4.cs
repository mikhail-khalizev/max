using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5ed4-5aa8a5fa")]
        public void Method_1013_5ed4()
        {
            ii(0x1013_5ed4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5ed7, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5eda, 4); add(memw_a32[ds, edx + 0xc], ax);       /* add [edx+0xc], ax */
            ii(0x1013_5ede, 5); if(jmpd_func(0x1013_5fc5, 0xe2)) return; /* jmp 0x10135fc5 */
        }
    }
}
