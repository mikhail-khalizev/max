using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_5ec5-4d7985cf")]
        public void Method_1013_5ec5()
        {
            ii(0x1013_5ec5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1013_5ec8, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1013_5ecb, 4); add(memw_a32[ds, edx + 0xa], ax);       /* add [edx+0xa], ax */
            ii(0x1013_5ecf, 5); if(jmpd_func(0x1013_5fc5, 0xf1)) return; /* jmp 0x10135fc5 */
        }
    }
}
