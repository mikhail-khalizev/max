using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("87978d37-ba04-4744-aa46-794deff250bf")]
        public void Method_0013_61ca()
        {
            ii(0x13_61ca, 1); pushw(bp);                                /* push bp */
            ii(0x13_61cb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_61cd, 1); pushw(si);                                /* push si */
            ii(0x13_61ce, 1); pushw(ds);                                /* push ds */
            ii(0x13_61cf, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_61d2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_61d4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_61d7, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_61da, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_61dc, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_61de, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_61e0, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_61e2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_61e4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_61e6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_61e8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_61ea, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_61ec, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x13_61ef, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x13_61f3, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_61f6, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_61fa, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x13_61fc, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x13_61fe, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x13_6200, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x13_6202, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6204, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6206, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6208, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_620a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_620c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_620e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x13_6210, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_6212, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6213, 1); popw(si);                                 /* pop si */
            ii(0x13_6214, 1); leavew();                                 /* leave */
            ii(0x13_6215, 1); retfw(); return;                          /* retf */
        }
    }
}
