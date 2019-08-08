using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("25b8342c-a0c1-409b-b40d-72c457252854")]
        public void Method_0014_b0c8()
        {
            ii(0x14_b0c8, 4); or(memb_a16[ss, bp + 0x26], 0x1);         /* or byte [bp+0x26], 0x1 */
            ii(0x14_b0cc, 1); pushw(ss);                                /* push ss */
            ii(0x14_b0cd, 1); pushw(bp);                                /* push bp */
            ii(0x14_b0ce, 1); sti();                                    /* sti */
            ii(0x14_b0cf, 3); callw(0x14_ca8e, 0x19bc);                 /* call 0xca8e */
            ii(0x14_b0d2, 3); if(jmpw_func(0x14_b053, -0x82)) return;   /* jmp 0xb053 */
        }
    }
}
