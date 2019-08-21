using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b9f5-b015685c")]
        public void Method_1015_b9f5()
        {
            ii(0x1015_b9f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b9f8, 7); mov(memd_a32[ds, eax + 0xe], 0x101b_dbc1); /* mov dword [eax+0xe], 0x101bdbc1 */
            ii(0x1015_b9ff, 5); if(jmpd_func(0x1015_bcc1, 0x2bd)) return; /* jmp 0x1015bcc1 */
        }
    }
}
