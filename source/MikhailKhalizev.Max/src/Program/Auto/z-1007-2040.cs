using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("956bc074-f2ae-4795-98cb-7edeca21e0e6")]
        public void Method_1007_2040()
        {
            ii(0x1007_2040, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_2043, 3); sub(eax, 0x1c);                         /* sub eax, 0x1c */
            ii(0x1007_2046, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_2049, 5); cmp(memw_a32[ss, ebp - 0x10], 0x4);     /* cmp word [ebp-0x10], 0x4 */
            ii(0x1007_204e, 2); if(jad_func(0x1007_202a, -0x26)) return; /* ja 0x1007202a */
            ii(0x1007_2050, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_2052, 4); mov(ax, memw_a32[ss, ebp - 0x10]);      /* mov ax, [ebp-0x10] */
            ii(0x1007_2056, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_2059, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1007_202c])) return; /* jmp dword [cs:eax+0x1007202c] */
        }
    }
}
