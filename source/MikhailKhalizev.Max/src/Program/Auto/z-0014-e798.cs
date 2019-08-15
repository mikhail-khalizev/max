using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("09865146-8fc2-4c77-99c0-b9e905585f8a")]
        public void Method_0014_e798()
        {
            ii(0x14_e798, 1); popw(bp);                                 /* pop bp */
            ii(0x14_e799, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e79b, 1); popw(ss);                                 /* pop ss */
            ii(0x14_e79c, 3); lea(sp, bx - 0x32);                       /* lea sp, [bx-0x32] */
            ii(0x14_e79f, 1); pushw(dx);                                /* push dx */
            ii(0x14_e7a0, 1); pushw(di);                                /* push di */
            ii(0x14_e7a1, 4); mov(dx, memw_a32[ds, esi + 0x20]);        /* mov dx, [esi+0x20] */
            ii(0x14_e7a5, 3); and(dh, 0xfe);                            /* and dh, 0xfe */
            ii(0x14_e7a8, 2); if(jmpw_abs(bp)) return;                  /* jmp bp */
        }
    }
}
