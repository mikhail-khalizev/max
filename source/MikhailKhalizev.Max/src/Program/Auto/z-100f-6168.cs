using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("936cd980-fe3f-48c6-b3c5-e82ad4d29b2e")]
        public void Method_100f_6168()
        {
            ii(0x100f_6168, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_616b, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_616e, 5); cmp(memw_a32[ss, ebp - 0x3c], 0x4);     /* cmp word [ebp-0x3c], 0x4 */
            ii(0x100f_6173, 2); jad_func(0x100f_6151, -0x24);           /* ja 0x100f6151 */
            ii(0x100f_6175, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_6177, 4); mov(ax, memw_a32[ss, ebp - 0x3c]);      /* mov ax, [ebp-0x3c] */
            ii(0x100f_617b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_617e, 7); jmpd_abs(memd_a32[cs, eax + 0x100f_6154]); return; /* jmp dword [cs:eax+0x100f6154] */
        }
    }
}
