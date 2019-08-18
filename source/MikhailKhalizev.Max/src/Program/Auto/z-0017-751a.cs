using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81bb029d-68a4-472d-8100-7afc1d3421f5")]
        public void Method_0017_751a()
        {
            ii(0x17_751a, 1); pushw(bp);                                /* push bp */
            ii(0x17_751b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_751d, 1); pushw(ds);                                /* push ds */
            ii(0x17_751e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_7521, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_7523, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x17_7526, 1); cwd();                                    /* cwd */
            ii(0x17_7527, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x17_7529, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x17_752b, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x17_752d, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_752f, 1); pushw(dx);                                /* push dx */
            ii(0x17_7530, 1); pushw(ax);                                /* push ax */
            ii(0x17_7531, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_7534, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x17_7537, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x17_7539, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_753b, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x17_753d, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_753f, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x17_7541, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_7543, 2); sar(dx, 0x1);                             /* sar dx, 1 */
            ii(0x17_7545, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_7547, 1); pushw(dx);                                /* push dx */
            ii(0x17_7548, 1); pushw(ax);                                /* push ax */
            ii(0x17_7549, 4); callw_a16_far_ind(ds, 0x1ea2);            /* call far word [0x1ea2] */
            ii(0x17_754d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x17_7550, 1); popw(ds);                                 /* pop ds */
            ii(0x17_7551, 1); leavew();                                 /* leave */
            ii(0x17_7552, 1); retfw(); return;                          /* retf */
        }
    }
}
