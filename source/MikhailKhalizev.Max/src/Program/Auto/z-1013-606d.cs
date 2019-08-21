using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_606d-50369d3e")]
        public void Method_1013_606d()
        {
            ii(0x1013_606d, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_64b0); /* mov dword [ebp-0x20], 0x101c64b0 */
            ii(0x1013_6074, 2); if(jmpd_func(0x1013_60c5, 0x4f)) return; /* jmp 0x101360c5 */
        }
    }
}
