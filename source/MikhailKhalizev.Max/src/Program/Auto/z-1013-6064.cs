using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6064-5954fe28")]
        public void Method_1013_6064()
        {
            ii(0x1013_6064, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_61b4); /* mov dword [ebp-0x20], 0x101c61b4 */
            ii(0x1013_606b, 2); if(jmpd_func(0x1013_60c5, 0x58)) return; /* jmp 0x101360c5 */
        }
    }
}
