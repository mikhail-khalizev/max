using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_ff2e-43e9a797")]
        public void Method_100d_ff2e()
        {
            ii(0x100d_ff2e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_ff35, 2); if(jmpd_func(0x100d_ff75, 0x3e)) return; /* jmp 0x100dff75 */
        }
    }
}
