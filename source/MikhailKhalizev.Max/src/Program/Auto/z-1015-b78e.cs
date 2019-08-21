using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b78e-4ee3620d")]
        public void Method_1015_b78e()
        {
            ii(0x1015_b78e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b791, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_d9ac); /* mov dword [eax+0xe], 0x101bd9ac */
            ii(0x1015_b798, 5); if(jmpd_func(0x1015_bcc1, 0x524)) return; /* jmp 0x1015bcc1 */
        }
    }
}
