using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ae78daa6-c065-4127-95bc-0053f8e201d6")]
        public void Method_1008_daf9()
        {
            ii(0x1008_daf9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dafc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_daff, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_db02, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_db05, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_db08, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_db0b, 5); calld(0x1007_65d0, -0x1_7540);          /* call 0x100765d0 */
            ii(0x1008_db10, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_db12, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_db15, 3); calld_abs(memd_a32[ds, ebx + 0x44]);    /* call dword [ebx+0x44] */
            ii(0x1008_db18, 2); if(jmpd_func(0x1008_db55, 0x3b)) return; /* jmp 0x1008db55 */
        }
    }
}
