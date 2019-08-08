using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66e517e4-3591-40cc-9f63-2d773f3292c6")]
        public void Method_100d_62d1()
        {
            ii(0x100d_62d1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100d_62d4, 3); inc(memd_a32[ss, ebp - 0x38]);          /* inc dword [ebp-0x38] */
        }
    }
}
