using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b45a-9ee30eb8")]
        public void Method_1015_b45a()
        {
            ii(0x1015_b45a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b45d, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b04c); /* mov dword [eax+0xa], 0x101cb04c */
            ii(0x1015_b464, 5); if(jmpd_func(0x1015_b725, 0x2bc)) return; /* jmp 0x1015b725 */
        }
    }
}
