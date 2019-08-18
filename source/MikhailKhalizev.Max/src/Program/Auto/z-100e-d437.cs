using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a6ad7aec-e2d6-4f40-8187-aaeea2571236")]
        public void Method_100e_d437()
        {
            ii(0x100e_d437, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_d43d, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_d440, 5); if(jmpd_func(0x100e_d710, 0x2cb)) return; /* jmp 0x100ed710 */
        }
    }
}
