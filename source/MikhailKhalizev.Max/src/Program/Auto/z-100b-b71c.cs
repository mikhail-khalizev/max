using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b71c-722d39be")]
        public void Method_100b_b71c()
        {
            ii(0x100b_b71c, 6); mov(al, memb_a32[ss, ebp - 0xb4]);      /* mov al, [ebp-0xb4] */
            ii(0x100b_b722, 2); dec(al);                                /* dec al */
            ii(0x100b_b724, 6); mov(memb_a32[ss, ebp - 0xb8], al);      /* mov [ebp-0xb8], al */
            ii(0x100b_b72a, 7); cmp(memb_a32[ss, ebp - 0xb8], 0x6);     /* cmp byte [ebp-0xb8], 0x6 */
            ii(0x100b_b731, 2); if(jad_func(0x100b_b6f5, -0x3e)) return; /* ja 0x100bb6f5 */
            ii(0x100b_b733, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100b_b735, 6); mov(al, memb_a32[ss, ebp - 0xb8]);      /* mov al, [ebp-0xb8] */
            ii(0x100b_b73b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100b_b73e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100b_b700])) return; /* jmp dword [cs:eax+0x100bb700] */
        }
    }
}
