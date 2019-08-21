using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fe83-2a84596d")]
        public void Method_100d_fe83()
        {
            ii(0x100d_fe83, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fe89, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe8d, 5); calld(0x1013_3743, 0x5_38b1);           /* call 0x10133743 */
            ii(0x100d_fe92, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_fe95, 5); if(jmpd_func(0x100d_ff75, 0xdb)) return; /* jmp 0x100dff75 */
        }
    }
}
