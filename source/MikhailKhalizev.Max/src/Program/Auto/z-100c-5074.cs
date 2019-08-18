using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_5074-c90e04f1")]
        public void Method_100c_5074()
        {
            ii(0x100c_5074, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x100c_5077, 2); dec(al);                                /* dec al */
            ii(0x100c_5079, 3); mov(memb_a32[ss, ebp - 0x34], al);      /* mov [ebp-0x34], al */
            ii(0x100c_507c, 4); cmp(memb_a32[ss, ebp - 0x34], 0x8);     /* cmp byte [ebp-0x34], 0x8 */
            ii(0x100c_5080, 2); if(jad_func(0x100c_504d, -0x35)) return; /* ja 0x100c504d */
            ii(0x100c_5082, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_5084, 3); mov(al, memb_a32[ss, ebp - 0x34]);      /* mov al, [ebp-0x34] */
            ii(0x100c_5087, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_508a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100c_5050])) return; /* jmp dword [cs:eax+0x100c5050] */
        }
    }
}
