using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b478-ff927232")]
        public void Method_1015_b478()
        {
            ii(0x1015_b478, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b47b, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b024); /* mov dword [eax+0xa], 0x101cb024 */
            ii(0x1015_b482, 5); if(jmpd_func(0x1015_b725, 0x29e)) return; /* jmp 0x1015b725 */
        }
    }
}
