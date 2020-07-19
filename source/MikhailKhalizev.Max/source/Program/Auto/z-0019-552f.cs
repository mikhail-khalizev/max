using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_552f-cfc52c52")]
        public void Method_0019_552f()
        {
            ii(0x19_552f, 4);  enter(0, 0);                            /* enter 0x0, 0x0 */
            ii(0x19_5533, 1);  push(di);                               /* push di */
            ii(0x19_5534, 1);  push(si);                               /* push si */
            ii(0x19_5535, 1);  pop(si);                                /* pop si */
            ii(0x19_5536, 1);  pop(di);                                /* pop di */
            ii(0x19_5537, 1);  leave();                                /* leave */
            ii(0x19_5538, 1);  ret();                                  /* ret */
        }
    }
}
