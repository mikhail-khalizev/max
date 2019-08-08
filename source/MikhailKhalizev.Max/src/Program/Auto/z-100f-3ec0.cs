using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2e9c8766-2a7b-45b7-ae22-b46285da0b54")]
        public void Method_100f_3ec0()
        {
            ii(0x100f_3ec0, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100f_3ec3, 6); mov(memb_a32[ss, ebp - 0x154], al);     /* mov [ebp-0x154], al */
            ii(0x100f_3ec9, 7); cmp(memb_a32[ss, ebp - 0x154], 0x5);    /* cmp byte [ebp-0x154], 0x5 */
            ii(0x100f_3ed0, 2); if(jad_func(0x100f_3ea5, -0x2d)) return; /* ja 0x100f3ea5 */
            ii(0x100f_3ed2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_3ed4, 6); mov(al, memb_a32[ss, ebp - 0x154]);     /* mov al, [ebp-0x154] */
            ii(0x100f_3eda, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100f_3edd, 7); if(jmpd_abs(memd_a32[cs, eax + 0x100f_3ea8])) return; /* jmp dword [cs:eax+0x100f3ea8] */
        }
    }
}
