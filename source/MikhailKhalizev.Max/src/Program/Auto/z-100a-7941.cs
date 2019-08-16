using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ec7aeea5-4eb5-44e5-9975-6c16457c6f4d")]
        public void Method_100a_7941()
        {
            ii(0x100a_7941, 1); inc(ebp);                               /* inc ebp */
            ii(0x100a_7942, 4); mov(memb_a32[ss, ebp - 0x14], al);      /* lock mov [ebp-0x14], al */
            ii(0x100a_7946, 4); cmp(memb_a32[ss, ebp - 0x14], 0x4);     /* cmp byte [ebp-0x14], 0x4 */
            ii(0x100a_794a, 2); if(jad_func(0x100a_7927, -0x25)) return; /* ja 0x100a7927 */
            ii(0x100a_794c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_794e, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100a_7951, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7954, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100a_792c])) return; /* jmp dword [cs:eax+0x100a792c] */
        }
    }
}
