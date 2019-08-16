using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ae4217ee-b049-415e-84c9-48dbb6fa8a8b")]
        public void Method_0015_0074()
        {
            ii(0x15_0074, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x15_0078, 1); pushw(si);                                /* push si */
            ii(0x15_0079, 1); pushw(di);                                /* push di */
            ii(0x15_007a, 1); pushw(ds);                                /* push ds */
            ii(0x15_007b, 5); movzx(edi, memw_a16[ss, bp + 0x6]);       /* movzx edi, word [bp+0x6] */
            ii(0x15_0080, 5); movzx(esi, memw_a16[ss, bp + 0x8]);       /* movzx esi, word [bp+0x8] */
            ii(0x15_0085, 2); xchg(bx, bx);                             /* xchg bx, bx */
            ii(0x15_0087, 1); nop();                                    /* nop */
        }
    }
}
