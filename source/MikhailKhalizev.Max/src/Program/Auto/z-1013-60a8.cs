using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_60a8-82e54df1")]
        public void Method_1013_60a8()
        {
            ii(0x1013_60a8, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1013_60ab, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1013_60ae, 5); cmp(memw_a32[ss, ebp - 0x24], 0x4);     /* cmp word [ebp-0x24], 0x4 */
            ii(0x1013_60b3, 2); if(jad_func(0x1013_6091, -0x24)) return; /* ja 0x10136091 */
            ii(0x1013_60b5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_60b7, 4); mov(ax, memw_a32[ss, ebp - 0x24]);      /* mov ax, [ebp-0x24] */
            ii(0x1013_60bb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_60be, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1013_6094])) return; /* jmp dword [cs:eax+0x10136094] */
        }
    }
}
