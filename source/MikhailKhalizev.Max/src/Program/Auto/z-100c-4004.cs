using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_4004-98b16aa6")]
        public void Method_100c_4004()
        {
            ii(0x100c_4004, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x100c_4007, 2); dec(al);                                /* dec al */
            ii(0x100c_4009, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100c_400c, 4); cmp(memb_a32[ss, ebp - 0x14], 0x8);     /* cmp byte [ebp-0x14], 0x8 */
            ii(0x100c_4010, 2); if(jad_func(0x100c_3fdd, -0x35)) return; /* ja 0x100c3fdd */
            ii(0x100c_4012, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_4014, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100c_4017, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_401a, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100c_3fe0])) return; /* jmp dword [cs:eax+0x100c3fe0] */
        }
    }
}
