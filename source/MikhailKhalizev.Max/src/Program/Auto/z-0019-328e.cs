using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_328e-e5d6827d")]
        public void Method_0019_328e()
        {
            ii(0x19_328e, 1); push(bp);                                 /* push bp */
            ii(0x19_328f, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_3291, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x19_3294, 5); test(memb[ds, bx + 0x3e4d], 2);           /* test byte [bx+0x3e4d], 0x2 */
            ii(0x19_3299, 2); if(jz(0x19_32a0, 5)) goto l_0x19_32a0;    /* jz 0x32a0 */
            ii(0x19_329b, 3); lea(ax, memw[ds, bx - 0x20]);             /* lea ax, [bx-0x20] */
            ii(0x19_329e, 2); jmp(0x19_32a2, 2); goto l_0x19_32a2;      /* jmp 0x32a2 */
        l_0x19_32a0:
            ii(0x19_32a0, 2); mov(ax, bx);                              /* mov ax, bx */
        l_0x19_32a2:
            ii(0x19_32a2, 1); pop(bp);                                  /* pop bp */
            ii(0x19_32a3, 1); retf();                                   /* retf */
        }
    }
}
