using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1d5b-113303f2")]
        public void Method_0019_1d5b()
        {
            ii(0x19_1d5b, 1); pushw(bp);                                /* push bp */
            ii(0x19_1d5c, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_1d5e, 2); jmpw(0x19_1d71, 0x11); goto l_0x19_1d71;  /* jmp 0x1d71 */
        l_0x19_1d60:
            ii(0x19_1d60, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x19_1d63, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x19_1d67, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x19_1d6a, 3); inc(memw_a16[ss, bp + 0x6]);              /* inc word [bp+0x6] */
            ii(0x19_1d6d, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
        l_0x19_1d71:
            ii(0x19_1d71, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_1d74, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x19_1d78, 2); if(jnzw(0x19_1d60, -0x1a)) goto l_0x19_1d60; /* jnz 0x1d60 */
            ii(0x19_1d7a, 1); leavew();                                 /* leave */
            ii(0x19_1d7b, 1); retfw(); return;                          /* retf */
        }
    }
}
