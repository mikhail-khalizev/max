using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9aba0ff3-3041-4203-9326-d4b2c25387e3")]
        public void Method_100c_70f8()
        {
            ii(0x100c_70f8, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x100c_70fb, 2); dec(al);                                /* dec al */
            ii(0x100c_70fd, 3); mov(memb_a32[ss, ebp - 0x30], al);      /* mov [ebp-0x30], al */
            ii(0x100c_7100, 4); cmp(memb_a32[ss, ebp - 0x30], 0x8);     /* cmp byte [ebp-0x30], 0x8 */
            ii(0x100c_7104, 2); if(jad_func(0x100c_70d1, -0x35)) return; /* ja 0x100c70d1 */
            ii(0x100c_7106, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_7108, 3); mov(al, memb_a32[ss, ebp - 0x30]);      /* mov al, [ebp-0x30] */
            ii(0x100c_710b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_710e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100c_70d4])) return; /* jmp dword [cs:eax+0x100c70d4] */
        }
    }
}
