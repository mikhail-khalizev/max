using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b95f-96d5d674")]
        public void Method_1015_b95f()
        {
            ii(0x1015_b95f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b962, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_db06); /* mov dword [eax+0xe], 0x101bdb06 */
            ii(0x1015_b969, 5); if(jmpd_func(0x1015_bcc1, 0x353)) return; /* jmp 0x1015bcc1 */
        }
    }
}
