using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("beeaa9db-58c7-475f-a50e-ae2e91f69ba5")]
        public void Method_1012_2dfe()
        {
            ii(0x1012_2dfe, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2e01, 4); mov(memb_a32[ds, eax + 0x31], 0x1);     /* mov byte [eax+0x31], 0x1 */
            ii(0x1012_2e05, 5); if(jmpd_func(0x1012_31ce, 0x3c4)) return; /* jmp 0x101231ce */
        }
    }
}
