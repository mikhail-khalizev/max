using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_9bab-ceb53d08")]
        public void Method_100f_9bab()
        {
            ii(0x100f_9bab, 7); test(memb[ds, 0x101c_38d4], 0x10);      /* test byte [0x101c38d4], 0x10 */
            ii(0x100f_9bb2, 2); if(jz(0x100f_9bb9, 5)) goto l_0x100f_9bb9; /* jz 0x100f9bb9 */
            ii(0x100f_9bb4, 5); call(0x1011_606c, 0x1_c4b3);            /* call 0x1011606c */
        l_0x100f_9bb9:
            ii(0x100f_9bb9, 5); if(jmp_func(0x100f_a7df, 0xc21)) return; /* jmp 0x100fa7df */
        }
    }
}
