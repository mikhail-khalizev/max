using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b5a4-2778930a")]
        public void Method_1015_b5a4()
        {
            ii(0x1015_b5a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b5a7, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_afcc); /* mov dword [eax+0xa], 0x101cafcc */
            ii(0x1015_b5ae, 5); if(jmpd_func(0x1015_b725, 0x172)) return; /* jmp 0x1015b725 */
        }
    }
}
