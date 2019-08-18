using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("580077a1-5bd9-41bd-b67e-447a80e80cb4")]
        public void Method_1015_bca0()
        {
            ii(0x1015_bca0, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1015_bca3, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1015_bca6, 5); cmp(memw_a32[ss, ebp - 0x20], 0x53);    /* cmp word [ebp-0x20], 0x53 */
            ii(0x1015_bcab, 6); if(jad_func(0x1015_bb3f, -0x172)) return; /* ja 0x1015bb3f */
            ii(0x1015_bcb1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_bcb3, 4); mov(ax, memw_a32[ss, ebp - 0x20]);      /* mov ax, [ebp-0x20] */
            ii(0x1015_bcb7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_bcba, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1015_bb50])) return; /* jmp dword [cs:eax+0x1015bb50] */
        }
    }
}
