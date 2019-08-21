using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a50c-86aa62b8")]
        public void Method_0019_a50c()
        {
            ii(0x19_a50c, 3); mov(bx, memw_a16[ss, bp - 0x42]);         /* mov bx, [bp-0x42] */
            ii(0x19_a50f, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_a511, 5); cmp(memw_a16[ds, bx + 0x1f24], 0);        /* cmp word [bx+0x1f24], 0x0 */
            ii(0x19_a516, 2); if(jzw_func(0x19_a54f, 0x37)) return;     /* jz 0xa54f */
            ii(0x19_a518, 3); mov(ax, memw_a16[ds, 0x1f1c]);            /* mov ax, [0x1f1c] */
            ii(0x19_a51b, 4); or(ax, memw_a16[ds, 0x1f1a]);             /* or ax, [0x1f1a] */
            ii(0x19_a51f, 2); if(jzw_func(0x19_a54f, 0x2e)) return;     /* jz 0xa54f */
            ii(0x19_a521, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_a525, 4); lea(bx, bx + 0x1352);                     /* lea bx, [bx+0x1352] */
            ii(0x19_a529, 3); mov(si, memw_a16[ss, bp - 0x42]);         /* mov si, [bp-0x42] */
            ii(0x19_a52c, 4); cmp(memb_a16[es, bx + si], 0);            /* cmp byte [es:bx+si], 0x0 */
            ii(0x19_a530, 2); if(jzw_func(0x19_a54f, 0x1d)) return;     /* jz 0xa54f */
            ii(0x19_a532, 4); imul(ax, si, 0x134);                      /* imul ax, si, 0x134 */
            ii(0x19_a536, 4); add(ax, memw_a16[ds, 0x1f1a]);            /* add ax, [0x1f1a] */
            ii(0x19_a53a, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_a53c, 3); add(ax, 0xfc);                            /* add ax, 0xfc */
            ii(0x19_a53f, 1); pushw(dx);                                /* push dx */
            ii(0x19_a540, 1); pushw(ax);                                /* push ax */
            ii(0x19_a541, 1); pushw(ds);                                /* push ds */
            ii(0x19_a542, 3); pushw(0x203c);                            /* push 0x203c */
            ii(0x19_a545, 3); callw(0x1a_1066, 0x6b1e);                 /* call 0x1066 */
            ii(0x19_a548, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_a54b, 1); pushw(si);                                /* push si */
            ii(0x19_a54c, 3); callw(0x19_a1f7, -0x358);                 /* call 0xa1f7 */
        }
    }
}
