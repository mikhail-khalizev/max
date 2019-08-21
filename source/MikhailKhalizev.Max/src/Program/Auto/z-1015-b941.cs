using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b941-8b5f1991")]
        public void Method_1015_b941()
        {
            ii(0x1015_b941, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b944, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dae0); /* mov dword [eax+0xe], 0x101bdae0 */
            ii(0x1015_b94b, 5); if(jmpd_func(0x1015_bcc1, 0x371)) return; /* jmp 0x1015bcc1 */
        }
    }
}
