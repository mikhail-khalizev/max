using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_bb3f-b916b76")]
        public void Method_1015_bb3f()
        {
            ii(0x1015_bb3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_bb42, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_d924); /* mov dword [eax+0xe], 0x101bd924 */
            ii(0x1015_bb49, 5); if(jmpd_func(0x1015_bcc1, 0x173)) return; /* jmp 0x1015bcc1 */
        }
    }
}
