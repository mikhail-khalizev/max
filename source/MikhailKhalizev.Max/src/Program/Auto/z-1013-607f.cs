using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_607f-3ca5795a")]
        public void Method_1013_607f()
        {
            ii(0x1013_607f, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6aa8); /* mov dword [ebp-0x20], 0x101c6aa8 */
            ii(0x1013_6086, 2); if(jmpd_func(0x1013_60c5, 0x3d)) return; /* jmp 0x101360c5 */
        }
    }
}
