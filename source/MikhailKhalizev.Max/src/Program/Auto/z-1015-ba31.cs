using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ba31-410931cc")]
        public void Method_1015_ba31()
        {
            ii(0x1015_ba31, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ba34, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dc0a); /* mov dword [eax+0xe], 0x101bdc0a */
            ii(0x1015_ba3b, 5); if(jmpd_func(0x1015_bcc1, 0x281)) return; /* jmp 0x1015bcc1 */
        }
    }
}
