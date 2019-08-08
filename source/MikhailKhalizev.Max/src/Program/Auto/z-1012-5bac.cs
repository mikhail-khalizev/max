using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cfdd56ad-2f56-4e55-8317-c57a03659d38")]
        public void Method_1012_5bac()
        {
            ii(0x1012_5bac, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1012_5baf, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1012_5bb2, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1012_5bb6, 2); if(jad_func(0x1012_5b8a, -0x2e)) return; /* ja 0x10125b8a */
            ii(0x1012_5bb8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_5bba, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x1012_5bbd, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_5bc0, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_5b8c])) return; /* jmp dword [cs:eax+0x10125b8c] */
        }
    }
}
