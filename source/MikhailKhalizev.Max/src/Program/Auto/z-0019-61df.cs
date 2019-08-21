using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_61df-fcf62442")]
        public void Method_0019_61df()
        {
            ii(0x19_61df, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_61e2, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_61e4, 1); nop();                                    /* nop */
            ii(0x19_61e5, 1); pushw(cs);                                /* push cs */
            ii(0x19_61e6, 3); if(callw_up(0x18_f57c, -0x6c6d)) return;  /* call 0xf57c */
            ii(0x19_61e9, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x19_61ec, 1); popw(si);                                 /* pop si */
            ii(0x19_61ed, 1); popw(di);                                 /* pop di */
            ii(0x19_61ee, 1); leavew();                                 /* leave */
            ii(0x19_61ef, 1); retw(); return;                           /* ret */
        }
    }
}
