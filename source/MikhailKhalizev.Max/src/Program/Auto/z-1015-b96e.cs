using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b96e-626c859c")]
        public void Method_1015_b96e()
        {
            ii(0x1015_b96e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b971, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_db19); /* mov dword [eax+0xe], 0x101bdb19 */
            ii(0x1015_b978, 5); if(jmpd_func(0x1015_bcc1, 0x344)) return; /* jmp 0x1015bcc1 */
        }
    }
}
