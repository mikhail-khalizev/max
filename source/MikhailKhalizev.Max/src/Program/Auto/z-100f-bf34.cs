using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9058c156-7e9a-4549-bad5-74e77797ee09")]
        public void Method_100f_bf34()
        {
            ii(0x100f_bf34, 3); mov(al, memb_a32[ss, ebp - 0x40]);      /* mov al, [ebp-0x40] */
            ii(0x100f_bf37, 3); mov(memb_a32[ss, ebp - 0x44], al);      /* mov [ebp-0x44], al */
            ii(0x100f_bf3a, 4); cmp(memb_a32[ss, ebp - 0x44], 0x6);     /* cmp byte [ebp-0x44], 0x6 */
            ii(0x100f_bf3e, 2); if(jad_func(0x100f_bf15, -0x2b)) return; /* ja 0x100fbf15 */
            ii(0x100f_bf40, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_bf42, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x100f_bf45, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_bf48, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100f_bf18])) return; /* jmp dword [cs:eax+0x100fbf18] */
        }
    }
}
