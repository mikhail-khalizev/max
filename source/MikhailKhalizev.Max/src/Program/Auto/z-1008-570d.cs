using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_570d-63bb895a")]
        public void Method_1008_570d()
        {
            ii(0x1008_570d, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1008_5711, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1008_5714, 6); if(jged_func(0x1008_5897, 0x17d)) return; /* jge 0x10085897 */
            ii(0x1008_571a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1008_571d, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1008_5720, 2); if(jmpd_func(0x1008_5760, 0x3e)) return; /* jmp 0x10085760 */
        }
    }
}
