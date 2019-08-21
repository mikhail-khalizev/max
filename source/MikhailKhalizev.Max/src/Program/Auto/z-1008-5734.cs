using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_5734-4f2a25fa")]
        public void Method_1008_5734()
        {
            ii(0x1008_5734, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_5737, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_5739, 1); inc(eax);                               /* inc eax */
            ii(0x1008_573a, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_573d, 2); if(jmpd_func(0x1008_577d, 0x3e)) return; /* jmp 0x1008577d */
        }
    }
}
