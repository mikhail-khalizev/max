using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11b68c6a-7b05-4f8d-b225-c4ccb46e0859")]
        public void Method_100b_a99c()
        {
            ii(0x100b_a99c, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100b_a99f, 2); dec(al);                                /* dec al */
            ii(0x100b_a9a1, 3); mov(memb_a32[ss, ebp - 0x1c], al);      /* mov [ebp-0x1c], al */
            ii(0x100b_a9a4, 4); cmp(memb_a32[ss, ebp - 0x1c], 0x8);     /* cmp byte [ebp-0x1c], 0x8 */
            ii(0x100b_a9a8, 2); if(jad_func(0x100b_a973, -0x37)) return; /* ja 0x100ba973 */
            ii(0x100b_a9aa, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_a9ac, 3); mov(al, memb_a32[ss, ebp - 0x1c]);      /* mov al, [ebp-0x1c] */
            ii(0x100b_a9af, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_a9b2, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100b_a978])) return; /* jmp dword [cs:eax+0x100ba978] */
        }
    }
}
