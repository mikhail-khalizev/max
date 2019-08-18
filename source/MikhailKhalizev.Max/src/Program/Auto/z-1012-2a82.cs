using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b403b29-1051-4f20-89aa-610cf86e6b8f")]
        public void Method_1012_2a82()
        {
            ii(0x1012_2a82, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_2a85, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a88, 5); calld(0x1012_2716, -0x377);             /* call 0x10122716 */
            ii(0x1012_2a8d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_2a8f, 6); if(jnzd_func(0x1012_31ce, 0x739)) return; /* jnz 0x101231ce */
        }
    }
}
