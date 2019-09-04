using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_61df-fcf62442")]
        public void Method_0019_61df()
        {
            ii(0x19_61df, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_61e2, 2); push(1);                                  /* push 0x1 */
            ii(0x19_61e4, 1); nop();                                    /* nop */
            ii(0x19_61e5, 1); push(cs);                                 /* push cs */
            ii(0x19_61e6, 3); call(0x18_f57c, -0x6c6d);                 /* call 0xf57c */
            ii(0x19_61e9, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x19_61ec, 1); pop(si);                                  /* pop si */
            ii(0x19_61ed, 1); pop(di);                                  /* pop di */
            ii(0x19_61ee, 1); leave();                                  /* leave */
            ii(0x19_61ef, 1); ret();                                    /* ret */
        }
    }
}
