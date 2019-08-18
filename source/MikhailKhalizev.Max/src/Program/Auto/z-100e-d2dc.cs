using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_d2dc-b62802af")]
        public void Method_100e_d2dc()
        {
            ii(0x100e_d2dc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_d2df, 1); dec(eax);                               /* dec eax */
            ii(0x100e_d2e0, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_d2e3, 5); cmp(memw_a32[ss, ebp - 0x24], 0xe);     /* cmp word [ebp-0x24], 0xe */
            ii(0x100e_d2e8, 2); if(jad_func(0x100e_d29d, -0x4d)) return; /* ja 0x100ed29d */
            ii(0x100e_d2ea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_d2ec, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x100e_d2f0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_d2f3, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100e_d2a0])) return; /* jmp dword [cs:eax+0x100ed2a0] */
        }
    }
}
