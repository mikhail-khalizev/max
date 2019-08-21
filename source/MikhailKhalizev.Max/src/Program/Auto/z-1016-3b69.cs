using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_3b69-73adaede")]
        public void Method_1016_3b69()
        {
            ii(0x1016_3b69, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_3b6c, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1016_3b6f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1016_3b72, 5); if(jmpd_func(0x1016_3c47, 0xd0)) return; /* jmp 0x10163c47 */
        }
    }
}
