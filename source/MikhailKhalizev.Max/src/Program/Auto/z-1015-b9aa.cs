using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b9aa-186cd921")]
        public void Method_1015_b9aa()
        {
            ii(0x1015_b9aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b9ad, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_db68); /* mov dword [eax+0xe], 0x101bdb68 */
            ii(0x1015_b9b4, 5); if(jmpd_func(0x1015_bcc1, 0x308)) return; /* jmp 0x1015bcc1 */
        }
    }
}
