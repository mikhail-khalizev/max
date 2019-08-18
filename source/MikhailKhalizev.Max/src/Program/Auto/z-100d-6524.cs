using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("76ea521b-c7e8-4c82-8a51-3b7990a57450")]
        public void Method_100d_6524()
        {
            ii(0x100d_6524, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100d_6527, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100d_652a, 5); cmp(memw_a32[ss, ebp - 0x6c], 0x7);     /* cmp word [ebp-0x6c], 0x7 */
            ii(0x100d_652f, 2); if(jad_func(0x100d_6500, -0x31)) return; /* ja 0x100d6500 */
            ii(0x100d_6531, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_6533, 4); mov(ax, memw_a32[ss, ebp - 0x6c]);      /* mov ax, [ebp-0x6c] */
            ii(0x100d_6537, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_653a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100d_6504])) return; /* jmp dword [cs:eax+0x100d6504] */
        }
    }
}
