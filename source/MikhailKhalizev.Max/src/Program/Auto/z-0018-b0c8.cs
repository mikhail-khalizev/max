using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_b0c8-2f482404")]
        public void Method_0018_b0c8()
        {
            ii(0x18_b0c8, 4);  or(memb[ss, bp + 38], 1);               /* or byte [bp+0x26], 0x1 */
            ii(0x18_b0cc, 1);  push(ss);                               /* push ss */
            ii(0x18_b0cd, 1);  push(bp);                               /* push bp */
            ii(0x18_b0ce, 1);  sti();                                  /* sti */
            ii(0x18_b0cf, 3);  call(0x18_ca8e, 0x19bc);                /* call 0xca8e */
            ii(0x18_b0d2, 3);  if(jmp_func(0x18_b053, -0x82)) return;  /* jmp 0xb053 */
        }
    }
}
