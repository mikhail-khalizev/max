using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a2e9000a-55ce-4d62-909e-16a59055d402")]
        public void Method_1007_0880()
        {
            ii(0x1007_0880, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1007_0883, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1007_0886, 5); cmp(memw_a32[ss, ebp - 0x2c], 0x3);     /* cmp word [ebp-0x2c], 0x3 */
            ii(0x1007_088b, 2); if(jad_func(0x1007_086c, -0x21)) return; /* ja 0x1007086c */
            ii(0x1007_088d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_088f, 4); mov(ax, memw_a32[ss, ebp - 0x2c]);      /* mov ax, [ebp-0x2c] */
            ii(0x1007_0893, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1007_0896, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1007_0870])) return; /* jmp dword [cs:eax+0x10070870] */
        }
    }
}
