using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7d83046e-2f89-4e49-9b32-b73ba95f29c1")]
        public void Method_100c_67b4()
        {
            ii(0x100c_67b4, 3); mov(al, memb_a32[ss, ebp - 0x20]);      /* mov al, [ebp-0x20] */
            ii(0x100c_67b7, 2); sub(al, 0x2);                           /* sub al, 0x2 */
            ii(0x100c_67b9, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100c_67bc, 4); cmp(memb_a32[ss, ebp - 0x24], 0x6);     /* cmp byte [ebp-0x24], 0x6 */
            ii(0x100c_67c0, 2); if(jad_func(0x100c_6796, -0x2c)) return; /* ja 0x100c6796 */
            ii(0x100c_67c2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_67c4, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100c_67c7, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_67ca, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100c_6798])) return; /* jmp dword [cs:eax+0x100c6798] */
        }
    }
}
