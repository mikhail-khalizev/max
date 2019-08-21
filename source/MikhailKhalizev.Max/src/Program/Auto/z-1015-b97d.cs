using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b97d-afc1bbb8")]
        public void Method_1015_b97d()
        {
            ii(0x1015_b97d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b980, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_db2c); /* mov dword [eax+0xe], 0x101bdb2c */
            ii(0x1015_b987, 5); if(jmpd_func(0x1015_bcc1, 0x335)) return; /* jmp 0x1015bcc1 */
        }
    }
}
