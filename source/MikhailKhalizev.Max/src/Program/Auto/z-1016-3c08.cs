using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f66171f2-5599-48ce-ac00-6dafc093d48e")]
        public void Method_1016_3c08()
        {
            ii(0x1016_3c08, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1016_3c0b, 2); dec(al);                                /* dec al */
            ii(0x1016_3c0d, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x1016_3c10, 4); cmp(memb_a32[ss, ebp - 0x14], 0x8);     /* cmp byte [ebp-0x14], 0x8 */
            ii(0x1016_3c14, 2); if(jad_func(0x1016_3be1, -0x35)) return; /* ja 0x10163be1 */
            ii(0x1016_3c16, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_3c18, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x1016_3c1b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_3c1e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1016_3be4])) return; /* jmp dword [cs:eax+0x10163be4] */
        }
    }
}
