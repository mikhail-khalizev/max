using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6088-34579a58")]
        public void Method_1013_6088()
        {
            ii(0x1013_6088, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_6da4); /* mov dword [ebp-0x20], 0x101c6da4 */
            ii(0x1013_608f, 2); if(jmpd_func(0x1013_60c5, 0x34)) return; /* jmp 0x101360c5 */
        }
    }
}
