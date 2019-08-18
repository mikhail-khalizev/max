using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9098cf88-5569-46a4-bc32-3eae0aad9c7f")]
        public void Method_1015_b704()
        {
            ii(0x1015_b704, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1015_b707, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1015_b70a, 5); cmp(memw_a32[ss, ebp - 0x18], 0x53);    /* cmp word [ebp-0x18], 0x53 */
            ii(0x1015_b70f, 6); if(jad_func(0x1015_b5a4, -0x171)) return; /* ja 0x1015b5a4 */
            ii(0x1015_b715, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_b717, 4); mov(ax, memw_a32[ss, ebp - 0x18]);      /* mov ax, [ebp-0x18] */
            ii(0x1015_b71b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1015_b71e, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1015_b5b4])) return; /* jmp dword [cs:eax+0x1015b5b4] */
        }
    }
}
