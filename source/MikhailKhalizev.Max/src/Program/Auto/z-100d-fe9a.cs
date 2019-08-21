using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fe9a-93eff69")]
        public void Method_100d_fe9a()
        {
            ii(0x100d_fe9a, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe9e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_fea3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fea7, 5); calld(0x1013_3743, 0x5_3897);           /* call 0x10133743 */
            ii(0x100d_feac, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_feaf, 5); if(jmpd_func(0x100d_ff75, 0xc1)) return; /* jmp 0x100dff75 */
        }
    }
}
