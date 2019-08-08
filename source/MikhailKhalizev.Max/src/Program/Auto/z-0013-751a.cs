using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("94455e1e-db4b-4c40-8d2a-6b08e3f984ef")]
        public void Method_0013_751a()
        {
            ii(0x13_751a, 1); pushw(bp);                                /* push bp */
            ii(0x13_751b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_751d, 1); pushw(ds);                                /* push ds */
            ii(0x13_751e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_7521, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_7523, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_7526, 1); cwd();                                    /* cwd */
            ii(0x13_7527, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_7529, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_752b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_752d, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_752f, 1); pushw(dx);                                /* push dx */
            ii(0x13_7530, 1); pushw(ax);                                /* push ax */
            ii(0x13_7531, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_7534, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_7537, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_7539, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_753b, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_753d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_753f, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_7541, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7543, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x13_7545, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x13_7547, 1); pushw(dx);                                /* push dx */
            ii(0x13_7548, 1); pushw(ax);                                /* push ax */
            ii(0x13_7549, 4); callw_a16_far_ind(ds, 0x1ea2);            /* call far word [0x1ea2] */
            ii(0x13_754d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_7550, 1); popw(ds);                                 /* pop ds */
            ii(0x13_7551, 1); leavew();                                 /* leave */
            ii(0x13_7552, 1); retfw(); return;                          /* retf */
        }
    }
}
