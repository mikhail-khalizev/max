using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3b77-2ddb7e96")]
        public void Method_1016_3b77()
        {
            ii(0x1016_3b77, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3b7a, 3); add(eax, 0x14);                         /* add eax, 0x14 */
            ii(0x1016_3b7d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3b80, 5); if(jmpd_func(0x1016_3c47, 0xc2)) return; /* jmp 0x10163c47 */
        }
    }
}
