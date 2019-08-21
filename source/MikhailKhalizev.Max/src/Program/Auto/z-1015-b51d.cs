using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b51d-eb674426")]
        public void Method_1015_b51d()
        {
            ii(0x1015_b51d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b520, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b034); /* mov dword [eax+0xa], 0x101cb034 */
            ii(0x1015_b527, 5); if(jmpd_func(0x1015_b725, 0x1f9)) return; /* jmp 0x1015b725 */
        }
    }
}
