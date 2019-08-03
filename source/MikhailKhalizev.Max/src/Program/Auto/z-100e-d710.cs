using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b60b932-2cc7-4afc-98e9-e97558a3e996")]
        public void Method_100e_d710()
        {
            ii(0x100e_d710, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_d713, 1); dec(eax);                               /* dec eax */
            ii(0x100e_d714, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_d717, 5); cmp(memw_a32[ss, ebp - 0x34], 0x8);     /* cmp word [ebp-0x34], 0x8 */
            ii(0x100e_d71c, 6); jad_func(0x100e_d68c, -0x96);           /* ja 0x100ed68c */
            ii(0x100e_d722, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100e_d724, 4); mov(ax, memw_a32[ss, ebp - 0x34]);      /* mov ax, [ebp-0x34] */
            ii(0x100e_d728, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_d72b, 7); jmpd_abs(memd_a32[cs, eax + 0x100e_d6ec]); return; /* jmp dword [cs:eax+0x100ed6ec] */
        }
    }
}
