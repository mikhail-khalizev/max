using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95736de4-585f-4eaa-b57d-337ee3d85a5f")]
        public void Method_0017_61ca()
        {
            ii(0x17_61ca, 1); pushw(bp);                                /* push bp */
            ii(0x17_61cb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_61cd, 1); pushw(si);                                /* push si */
            ii(0x17_61ce, 1); pushw(ds);                                /* push ds */
            ii(0x17_61cf, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_61d2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_61d4, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_61d7, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_61da, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_61dc, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_61de, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_61e0, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_61e2, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_61e4, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_61e6, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_61e8, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_61ea, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_61ec, 3); and(bl, 0xfc);                            /* and bl, 0xfc */
            ii(0x17_61ef, 4); les(si, ds, 0x4fec);                      /* les si, [0x4fec] */
            ii(0x17_61f3, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x17_61f6, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x17_61fa, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_61fc, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_61fe, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_6200, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_6202, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6204, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6206, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6208, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_620a, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_620c, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_620e, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_6210, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_6212, 1); popw(ds);                                 /* pop ds */
            ii(0x17_6213, 1); popw(si);                                 /* pop si */
            ii(0x17_6214, 1); leavew();                                 /* leave */
            ii(0x17_6215, 1); retfw(); return;                          /* retf */
        }
    }
}
