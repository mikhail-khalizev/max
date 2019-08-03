using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f2415f2-0f77-4f23-adee-56638ead3475")]
        public void Method_1016_2988()
        {
            ii(0x1016_2988, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1016_298b, 3); mov(memb_a32[ss, ebp - 0x80], al);      /* mov [ebp-0x80], al */
            ii(0x1016_298e, 4); cmp(memb_a32[ss, ebp - 0x80], 0x1f);    /* cmp byte [ebp-0x80], 0x1f */
            ii(0x1016_2992, 6); jad_func(0x1016_2903, -0x95);           /* ja 0x10162903 */
            ii(0x1016_2998, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_299a, 3); mov(al, memb_a32[ss, ebp - 0x80]);      /* mov al, [ebp-0x80] */
            ii(0x1016_299d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1016_29a0, 7); jmpd_abs(memd_a32[cs, eax + 0x1016_2908]); return; /* jmp dword [cs:eax+0x10162908] */
        }
    }
}
