using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b6e3-e4fffce3")]
        public void Method_100b_b6e3()
        {
            ii(0x100b_b6e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6e6, 4); mov(memb_a32[ds, eax + 0x2], 0x7);      /* mov byte [eax+0x2], 0x7 */
            ii(0x100b_b6ea, 2); if(jmpd_func(0x100b_b745, 0x59)) return; /* jmp 0x100bb745 */
        }
    }
}
