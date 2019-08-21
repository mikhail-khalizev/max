using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ba8b-56050310")]
        public void Method_1015_ba8b()
        {
            ii(0x1015_ba8b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ba8e, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dc70); /* mov dword [eax+0xe], 0x101bdc70 */
            ii(0x1015_ba95, 5); if(jmpd_func(0x1015_bcc1, 0x227)) return; /* jmp 0x1015bcc1 */
        }
    }
}
