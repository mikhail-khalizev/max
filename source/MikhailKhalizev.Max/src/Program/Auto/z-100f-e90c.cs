using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4c782768-484f-43f2-91b6-ade20f17d20e")]
        public void Method_100f_e90c()
        {
            ii(0x100f_e90c, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100f_e90f, 3); mov(memb_a32[ss, ebp - 0x18], al);      /* mov [ebp-0x18], al */
            ii(0x100f_e912, 4); cmp(memb_a32[ss, ebp - 0x18], 0x4);     /* cmp byte [ebp-0x18], 0x4 */
            ii(0x100f_e916, 2); if(jad_func(0x100f_e8f6, -0x22)) return; /* ja 0x100fe8f6 */
            ii(0x100f_e918, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_e91a, 3); mov(al, memb_a32[ss, ebp - 0x18]);      /* mov al, [ebp-0x18] */
            ii(0x100f_e91d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_e920, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100f_e8f8])) return; /* jmp dword [cs:eax+0x100fe8f8] */
        }
    }
}