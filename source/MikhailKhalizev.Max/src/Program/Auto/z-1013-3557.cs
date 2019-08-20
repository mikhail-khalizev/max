using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3557-ce2dfb0b")]
        public void Method_1013_3557()
        {
            ii(0x1013_3557, 4); cmp(memb_a32[ss, ebp - 0x4], 0x7);      /* cmp byte [ebp-0x4], 0x7 */
            ii(0x1013_355b, 2); if(jnzd_func(0x1013_35d5, 0x78)) return; /* jnz 0x101335d5 */
        }
    }
}
