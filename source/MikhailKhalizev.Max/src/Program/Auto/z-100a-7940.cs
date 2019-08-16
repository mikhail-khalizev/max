using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3ae81877-2cf1-4c00-8f92-60b0e84512cb")]
        public void Method_100a_7940()
        {
            ii(0x100a_7940, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100a_7943, 3); mov(memb_a32[ss, ebp - 0x14], al);      /* mov [ebp-0x14], al */
            ii(0x100a_7946, 4); cmp(memb_a32[ss, ebp - 0x14], 0x4);     /* cmp byte [ebp-0x14], 0x4 */
            ii(0x100a_794a, 2); if(jad_func(0x100a_7927, -0x25)) return; /* ja 0x100a7927 */
            ii(0x100a_794c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_794e, 3); mov(al, memb_a32[ss, ebp - 0x14]);      /* mov al, [ebp-0x14] */
            ii(0x100a_7951, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100a_7954, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100a_792c])) return; /* jmp dword [cs:eax+0x100a792c] */
        }
    }
}
