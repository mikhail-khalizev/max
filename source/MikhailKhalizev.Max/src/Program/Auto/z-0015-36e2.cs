using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("77fb2842-50b3-419b-9fec-1aaeed4353b1")]
        public void Method_0015_36e2()
        {
            ii(0x15_36e2, 1); pushw(bp);                                /* push bp */
            ii(0x15_36e3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_36e5, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_36e8, 3); mov(cx, memw_a16[ss, bp + 0xc]);          /* mov cx, [bp+0xc] */
            ii(0x15_36eb, 2); or(cx, ax);                               /* or cx, ax */
            ii(0x15_36ed, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x15_36f0, 2); if(jnzw(0x15_36fb, 0x9)) goto l_0x15_36fb; /* jnz 0x36fb */
            ii(0x15_36f2, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_36f5, 2); mul(cx);                                  /* mul cx */
            ii(0x15_36f7, 1); popw(bp);                                 /* pop bp */
            ii(0x15_36f8, 3); retfw(0x8); return;                       /* retf 0x8 */
        l_0x15_36fb:
            ii(0x15_36fb, 1); pushw(bx);                                /* push bx */
            ii(0x15_36fc, 2); mul(cx);                                  /* mul cx */
            ii(0x15_36fe, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_3700, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_3703, 3); mul(memw_a16[ss, bp + 0xc]);              /* mul word [bp+0xc] */
            ii(0x15_3706, 2); add(bx, ax);                              /* add bx, ax */
            ii(0x15_3708, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_370b, 2); mul(cx);                                  /* mul cx */
            ii(0x15_370d, 2); add(dx, bx);                              /* add dx, bx */
            ii(0x15_370f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_3710, 1); popw(bp);                                 /* pop bp */
            ii(0x15_3711, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
