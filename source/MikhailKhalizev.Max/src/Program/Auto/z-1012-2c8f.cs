using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b8c4c1f-3da2-4730-bece-4883ae7fc389")]
        public void Method_1012_2c8f()
        {
            ii(0x1012_2c8f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_2c92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2c95, 5); calld(0x1012_2716, -0x584);             /* call 0x10122716 */
            ii(0x1012_2c9a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_2c9c, 6); if(jnzd_func(0x1012_31ce, 0x52c)) return; /* jnz 0x101231ce */
        }
    }
}
