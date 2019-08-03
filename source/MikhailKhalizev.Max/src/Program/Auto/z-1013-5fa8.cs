using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d35a2cff-8035-4740-8ea8-de3da322d1c8")]
        public void Method_1013_5fa8()
        {
            ii(0x1013_5fa8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1013_5fab, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1013_5fae, 5); cmp(memw_a32[ss, ebp - 0x14], 0xc);     /* cmp word [ebp-0x14], 0xc */
            ii(0x1013_5fb3, 2); jad_func(0x1013_5f6f, -0x46);           /* ja 0x10135f6f */
            ii(0x1013_5fb5, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_5fb7, 4); mov(ax, memw_a32[ss, ebp - 0x14]);      /* mov ax, [ebp-0x14] */
            ii(0x1013_5fbb, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1013_5fbe, 7); jmpd_abs(memd_a32[cs, eax + 0x1013_5f74]); return; /* jmp dword [cs:eax+0x10135f74] */
        }
    }
}
