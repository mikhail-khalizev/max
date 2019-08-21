using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_ba40-b236d802")]
        public void Method_1015_ba40()
        {
            ii(0x1015_ba40, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_ba43, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dc17); /* mov dword [eax+0xe], 0x101bdc17 */
            ii(0x1015_ba4a, 5); if(jmpd_func(0x1015_bcc1, 0x272)) return; /* jmp 0x1015bcc1 */
        }
    }
}
