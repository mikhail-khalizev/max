using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_bda2-57a7336")]
        public void Method_0018_bda2()
        {
            ii(0x18_bda2, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x18_bda6, 5); cmp(memw_a16[ds, 0xa2], 0);               /* cmp word [0xa2], 0x0 */
            ii(0x18_bdab, 2); if(jzw(0x18_bdd9, 0x2c)) goto l_0x18_bdd9; /* jz 0xbdd9 */
            ii(0x18_bdad, 3); mov(ax, memw_a16[ds, 0xa0]);              /* mov ax, [0xa0] */
            ii(0x18_bdb0, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x18_bdb3, 5); mov(memw_a16[ss, bp - 0x2], 0x60);        /* mov word [bp-0x2], 0x60 */
            ii(0x18_bdb8, 3); pushw(0x92);                              /* push 0x92 */
            ii(0x18_bdbb, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x18_bdbd, 2); pushw(0);                                 /* push 0x0 */
            ii(0x18_bdbf, 4); pushw(memw_a16[ds, 0xa2]);                /* push word [0xa2] */
            ii(0x18_bdc3, 2); pushw(0x60);                              /* push 0x60 */
            ii(0x18_bdc5, 3); callw(0x18_da94, 0x1ccc);                 /* call 0xda94 */
            ii(0x18_bdc8, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_bdcb, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_bdce, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x18_bdd1, 4); add(memw_a16[es, bx + 0xc], ax);          /* add [es:bx+0xc], ax */
            ii(0x18_bdd5, 4); adc(memw_a16[es, bx + 0xe], dx);          /* adc [es:bx+0xe], dx */
        l_0x18_bdd9:
            ii(0x18_bdd9, 1); leavew();                                 /* leave */
            ii(0x18_bdda, 1); retw(); return;                           /* ret */
        }
    }
}
