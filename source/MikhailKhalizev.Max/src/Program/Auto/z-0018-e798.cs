using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e798-f8693449")]
        public void Method_0018_e798()
        {
            ii(0x18_e798, 1); pop(bp);                                  /* pop bp */
            ii(0x18_e799, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_e79b, 1); pop(ss);                                  /* pop ss */
            ii(0x18_e79c, 3); lea(sp, memw[ds, bx - 0x32]);             /* lea sp, [bx-0x32] */
            ii(0x18_e79f, 1); push(dx);                                 /* push dx */
            ii(0x18_e7a0, 1); push(di);                                 /* push di */
            ii(0x18_e7a1, 4); mov(dx, memw_a32[ds, esi + 0x20]);        /* mov dx, [esi+0x20] */
            ii(0x18_e7a5, 3); and(dh, 0xfe);                            /* and dh, 0xfe */
            ii(0x18_e7a8, 2); jmp_abs(bp);                              /* jmp bp */
        }
    }
}
