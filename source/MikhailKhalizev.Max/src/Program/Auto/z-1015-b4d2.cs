using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_b4d2-58cc0f18")]
        public void Method_1015_b4d2()
        {
            ii(0x1015_b4d2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_b4d5, 7); mov(memd_a32[ds, eax + 0xa], 0x101c_b014); /* mov dword [eax+0xa], 0x101cb014 */
            ii(0x1015_b4dc, 5); if(jmpd_func(0x1015_b725, 0x244)) return; /* jmp 0x1015b725 */
        }
    }
}
