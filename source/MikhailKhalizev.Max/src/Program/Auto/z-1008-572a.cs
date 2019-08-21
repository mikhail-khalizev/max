using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_572a-c6e2222d")]
        public void Method_1008_572a()
        {
            ii(0x1008_572a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1008_572d, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1008_572f, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_5732, 2); if(jmpd_func(0x1008_577d, 0x49)) return; /* jmp 0x1008577d */
        }
    }
}
