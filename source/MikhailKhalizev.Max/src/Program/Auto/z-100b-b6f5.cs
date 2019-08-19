using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b6f5-e5004a32")]
        public void Method_100b_b6f5()
        {
            ii(0x100b_b6f5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6f8, 4); mov(memb_a32[ds, eax + 0x2], 0x8);      /* mov byte [eax+0x2], 0x8 */
            ii(0x100b_b6fc, 2); if(jmpd_func(0x100b_b745, 0x47)) return; /* jmp 0x100bb745 */
        }
    }
}
