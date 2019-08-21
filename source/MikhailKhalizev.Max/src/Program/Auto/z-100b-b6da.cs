using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_b6da-e4fff09d")]
        public void Method_100b_b6da()
        {
            ii(0x100b_b6da, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_b6dd, 4); mov(memb_a32[ds, eax + 0x2], 0x2);      /* mov byte [eax+0x2], 0x2 */
            ii(0x100b_b6e1, 2); if(jmpd_func(0x100b_b745, 0x62)) return; /* jmp 0x100bb745 */
        }
    }
}
