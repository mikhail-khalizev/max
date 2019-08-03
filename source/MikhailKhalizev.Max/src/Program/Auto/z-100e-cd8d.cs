using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c8f5a83-5c1e-4374-ba18-8524fc9e1b91")]
        public void Method_100e_cd8d()
        {
            ii(0x100e_cd8d, 6); mov(ax, memw_a32[ds, 0x101c_3982]);     /* mov ax, [0x101c3982] */
            ii(0x100e_cd93, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_cd96, 5); jmpd_func(0x100e_d2dc, 0x541); return;  /* jmp 0x100ed2dc */
        }
    }
}