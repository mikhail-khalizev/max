using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6076-464bda28")]
        public void Method_1013_6076()
        {
            ii(0x1013_6076, 7); mov(memd_a32[ss, ebp - 0x20], 0x101c_67ac); /* mov dword [ebp-0x20], 0x101c67ac */
            ii(0x1013_607d, 2); if(jmpd_func(0x1013_60c5, 0x46)) return; /* jmp 0x101360c5 */
        }
    }
}
