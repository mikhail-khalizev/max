using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_cd68-facf3d8e")]
        public void Method_1008_cd68()
        {
            ii(0x1008_cd68, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1008_cd6b, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1008_cd6e, 4); cmp(memb_a32[ss, ebp - 0x14], 0xb);     /* cmp byte [ebp-0x14], 0xb */
            ii(0x1008_cd72, 2); if(jad_func(0x1008_cd28, -0x4c)) return; /* ja 0x1008cd28 */
            ii(0x1008_cd74, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1008_cd76, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1008_cd79, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_cd7c, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1008_cd38])) return; /* jmp dword [cs:eax+0x1008cd38] */
        }
    }
}
