using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e811cac-8ea7-4d7d-bc01-59ce6b724635")]
        public void Method_1009_4764()
        {
            ii(0x1009_4764, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x1009_4767, 2); dec(al);                                /* dec al */
            ii(0x1009_4769, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1009_476c, 4); cmp(memb_a32[ss, ebp - 0x28], 0x8);     /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1009_4770, 2); if(jad_func(0x1009_473e, -0x34)) return; /* ja 0x1009473e */
            ii(0x1009_4772, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_4774, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x1009_4777, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_477a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1009_4740])) return; /* jmp dword [cs:eax+0x10094740] */
        }
    }
}
