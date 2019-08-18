using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("307b0ebf-3bb7-4439-affb-130138763e46")]
        public void Method_1012_2ddc()
        {
            ii(0x1012_2ddc, 3); mov(al, memb_a32[ss, ebp - 0x4c]);      /* mov al, [ebp-0x4c] */
            ii(0x1012_2ddf, 2); sub(al, 0x36);                          /* sub al, 0x36 */
            ii(0x1012_2de1, 3); mov(memb_a32[ss, ebp - 0x50], al);      /* mov [ebp-0x50], al */
            ii(0x1012_2de4, 4); cmp(memb_a32[ss, ebp - 0x50], 0x5);     /* cmp byte [ebp-0x50], 0x5 */
            ii(0x1012_2de8, 2); if(jad_func(0x1012_2dc0, -0x2a)) return; /* ja 0x10122dc0 */
            ii(0x1012_2dea, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_2dec, 3); mov(al, memb_a32[ss, ebp - 0x50]);      /* mov al, [ebp-0x50] */
            ii(0x1012_2def, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_2df2, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_2dc4])) return; /* jmp dword [cs:eax+0x10122dc4] */
        }
    }
}
