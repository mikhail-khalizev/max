using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("98bb8c7d-8fe4-4bf4-8c19-b7befba9ec83")]
        public void Method_0018_b0c8()
        {
            ii(0x18_b0c8, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x18_b0cc, 1); pushw(ss);                                /* push ss */
            ii(0x18_b0cd, 1); pushw(bp);                                /* push bp */
            ii(0x18_b0ce, 1); sti();                                    /* sti */
            ii(0x18_b0cf, 3); callw(0x18_ca8e, 0x19bc);                 /* call 0xca8e */
            ii(0x18_b0d2, 3); if(jmpw_func(0x18_b053, -0x82)) return;   /* jmp 0xb053 */
        }
    }
}
