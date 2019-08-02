using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ffa9d781-5431-47f3-9950-0687ab06b428")]
        public void Method_0013_90f0()
        {
            ii(0x13_90f0, 1); pushw(bp);                                /* push bp */
            ii(0x13_90f1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_90f3, 1); pushw(ds);                                /* push ds */
            ii(0x13_90f4, 1); pushw(cx);                                /* push cx */
            ii(0x13_90f5, 1); pushw(dx);                                /* push dx */
            ii(0x13_90f6, 2); mov(ah, 0x5a);                            /* mov ah, 0x5a */
            ii(0x13_90f8, 3); mov(cx, 0);                               /* mov cx, 0x0 */
            ii(0x13_90fb, 3); lds(dx, ss, bp + 0x6);                    /* lds dx, [bp+0x6] */
            ii(0x13_90fe, 4); callw_a16_far_ind(ds, 0x1fe0);            /* call far word [0x1fe0] */
            ii(0x13_9102, 4); if(jbw(0x13_9117, 0x11)) goto l_0x13_9117; /* jb 0x9117 */
            ii(0x13_9106, 1); pushw(bx);                                /* push bx */
            ii(0x13_9107, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_9109, 2); mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x13_910b, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_910d, 1); popw(bx);                                 /* pop bx */
            ii(0x13_910e, 2); mov(ah, 0x41);                            /* mov ah, 0x41 */
            ii(0x13_9110, 3); lds(dx, ss, bp + 0x6);                    /* lds dx, [bp+0x6] */
            ii(0x13_9113, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_9115, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x13_9117:
            ii(0x13_9117, 1); popw(dx);                                 /* pop dx */
            ii(0x13_9118, 1); popw(cx);                                 /* pop cx */
            ii(0x13_9119, 1); popw(ds);                                 /* pop ds */
            ii(0x13_911a, 1); popw(bp);                                 /* pop bp */
            ii(0x13_911b, 1); retfw(); return;                          /* retf */
        }
    }
}