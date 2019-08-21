using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b932-3af4e2ed")]
        public void Method_1015_b932()
        {
            ii(0x1015_b932, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b935, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dacd); /* mov dword [eax+0xe], 0x101bdacd */
            ii(0x1015_b93c, 5); if(jmpd_func(0x1015_bcc1, 0x380)) return; /* jmp 0x1015bcc1 */
        }
    }
}
