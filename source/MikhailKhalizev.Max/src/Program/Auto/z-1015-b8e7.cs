using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b8e7-5244c790")]
        public void Method_1015_b8e7()
        {
            ii(0x1015_b8e7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b8ea, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_da9b); /* mov dword [eax+0xe], 0x101bda9b */
            ii(0x1015_b8f1, 5); if(jmpd_func(0x1015_bcc1, 0x3cb)) return; /* jmp 0x1015bcc1 */
        }
    }
}
