using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b9e6-56365de2")]
        public void Method_1015_b9e6()
        {
            ii(0x1015_b9e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b9e9, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dbae); /* mov dword [eax+0xe], 0x101bdbae */
            ii(0x1015_b9f0, 5); if(jmpd_func(0x1015_bcc1, 0x2cc)) return; /* jmp 0x1015bcc1 */
        }
    }
}
