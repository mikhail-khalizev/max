using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b79d-354ae083")]
        public void Method_1015_b79d()
        {
            ii(0x1015_b79d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b7a0, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_d9b3); /* mov dword [eax+0xe], 0x101bd9b3 */
            ii(0x1015_b7a7, 5); if(jmpd_func(0x1015_bcc1, 0x515)) return; /* jmp 0x1015bcc1 */
        }
    }
}
