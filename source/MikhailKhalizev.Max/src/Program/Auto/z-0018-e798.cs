using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da3ba82f-77a2-43a3-999e-f944fc341274")]
        public void Method_0018_e798()
        {
            ii(0x18_e798, 1); popw(bp);                                 /* pop bp */
            ii(0x18_e799, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x18_e79b, 1); popw(ss);                                 /* pop ss */
            ii(0x18_e79c, 3); lea(sp, bx - 0x32);                       /* lea sp, [bx-0x32] */
            ii(0x18_e79f, 1); pushw(dx);                                /* push dx */
            ii(0x18_e7a0, 1); pushw(di);                                /* push di */
            ii(0x18_e7a1, 4); mov(dx, memw_a32[ds, esi + 0x20]);        /* mov dx, [esi+0x20] */
            ii(0x18_e7a5, 3); and(dh, 0xfe);                            /* and dh, 0xfe */
            ii(0x18_e7a8, 2); if(jmpw_abs(bp)) return;                  /* jmp bp */
        }
    }
}
