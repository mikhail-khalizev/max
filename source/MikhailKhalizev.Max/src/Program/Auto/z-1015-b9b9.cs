using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b9b9-400fee1")]
        public void Method_1015_b9b9()
        {
            ii(0x1015_b9b9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b9bc, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_db78); /* mov dword [eax+0xe], 0x101bdb78 */
            ii(0x1015_b9c3, 5); if(jmpd_func(0x1015_bcc1, 0x2f9)) return; /* jmp 0x1015bcc1 */
        }
    }
}
