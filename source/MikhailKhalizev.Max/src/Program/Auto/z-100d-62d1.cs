using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_62d1-e8a5c894")]
        public void Method_100d_62d1()
        {
            ii(0x100d_62d1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_62d4, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
        }
    }
}
