using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_bad6-bf704a6d")]
        public void Method_1015_bad6()
        {
            ii(0x1015_bad6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bad9, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dcd5); /* mov dword [eax+0xe], 0x101bdcd5 */
            ii(0x1015_bae0, 5); if(jmpd_func(0x1015_bcc1, 0x1dc)) return; /* jmp 0x1015bcc1 */
        }
    }
}
