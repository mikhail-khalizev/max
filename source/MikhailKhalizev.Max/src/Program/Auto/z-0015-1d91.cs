using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6cbbc425-52f7-487d-85ef-c3b24b35f96d")]
        public void Method_0015_1d91()
        {
            ii(0x15_1d91, 1); pushw(bp);                                /* push bp */
            ii(0x15_1d92, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_1d94, 4); cmp(memw_a16[ss, bp + 0x4], 0x1);         /* cmp word [bp+0x4], 0x1 */
            ii(0x15_1d98, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_1d9a, 1); inc(ax);                                  /* inc ax */
            ii(0x15_1d9b, 4); sub(memw_a16[ds, 0x3af0], ax);            /* sub [0x3af0], ax */
            ii(0x15_1d9f, 5); cmp(memw_a16[ds, 0x3af2], 0);             /* cmp word [0x3af2], 0x0 */
            ii(0x15_1da4, 2); if(jnzw(0x15_1da9, 0x3)) goto l_0x15_1da9; /* jnz 0x1da9 */
            ii(0x15_1da6, 3); callw(0x15_1d7c, -0x2d);                  /* call 0x1d7c */
        l_0x15_1da9:
            ii(0x15_1da9, 4); cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x15_1dad, 2); if(jzw(0x15_1dbd, 0xe)) goto l_0x15_1dbd; /* jz 0x1dbd */
            ii(0x15_1daf, 3); mov(al, memb_a16[ss, bp + 0x4]);          /* mov al, [bp+0x4] */
            ii(0x15_1db2, 4); les(bx, ds, 0x3ad8);                      /* les bx, [0x3ad8] */
            ii(0x15_1db6, 4); inc(memw_a16[ds, 0x3ad8]);                /* inc word [0x3ad8] */
            ii(0x15_1dba, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
        l_0x15_1dbd:
            ii(0x15_1dbd, 1); leavew();                                 /* leave */
            ii(0x15_1dbe, 1); retw(); return;                           /* ret */
        }
    }
}
