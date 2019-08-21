using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b752-8e36211e")]
        public void Method_1015_b752()
        {
            ii(0x1015_b752, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b755, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_d97b); /* mov dword [eax+0xe], 0x101bd97b */
            ii(0x1015_b75c, 5); if(jmpd_func(0x1015_bcc1, 0x560)) return; /* jmp 0x1015bcc1 */
        }
    }
}
