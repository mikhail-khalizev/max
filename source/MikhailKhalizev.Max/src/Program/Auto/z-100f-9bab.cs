using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1b8932a-bd62-46d7-94a6-952fc6672f83")]
        public void Method_100f_9bab()
        {
            ii(0x100f_9bab, 7); test(memb_a32[ds, 0x101c_38d4], 0x10);  /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bb2, 2); if(jzd(0x100f_9bb9, 0x5)) goto l_0x100f_9bb9; /* jz 0x100f9bb9 */
            ii(0x100f_9bb4, 5); calld(0x1011_606c, 0x1_c4b3);           /* call 0x1011606c */
        l_0x100f_9bb9:
            ii(0x100f_9bb9, 5); if(jmpd_func(0x100f_a7df, 0xc21)) return; /* jmp 0x100fa7df */
        }
    }
}
