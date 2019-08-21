using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b950-84f90171")]
        public void Method_1015_b950()
        {
            ii(0x1015_b950, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b953, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_daf3); /* mov dword [eax+0xe], 0x101bdaf3 */
            ii(0x1015_b95a, 5); if(jmpd_func(0x1015_bcc1, 0x362)) return; /* jmp 0x1015bcc1 */
        }
    }
}
