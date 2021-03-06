using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_326e-7d049c9b")]
        public void Method_0019_326e()
        {
            ii(0x19_326e, 1);  push(bp);                               /* push bp */
            ii(0x19_326f, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x19_3271, 1);  push(si);                               /* push si */
            ii(0x19_3272, 1);  push(di);                               /* push di */
            ii(0x19_3273, 2);  mov(bl, 1);                             /* mov bl, 0x1 */
            ii(0x19_3275, 3);  jmp_func(0x19_3c42, 0x9ca);             /* jmp 0x3c42 */
        }
    }
}
