using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_90f0-dd699cb7")]
        public void Method_0017_90f0()
        {
            ii(0x17_90f0, 1); push(bp);                                 /* push bp */
            ii(0x17_90f1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_90f3, 1); push(ds);                                 /* push ds */
            ii(0x17_90f4, 1); push(cx);                                 /* push cx */
            ii(0x17_90f5, 1); push(dx);                                 /* push dx */
            ii(0x17_90f6, 2); mov(ah, 0x5a);                            /* mov ah, 0x5a */
            ii(0x17_90f8, 3); mov(cx, 0);                               /* mov cx, 0x0 */
            ii(0x17_90fb, 3); lds(dx, memw[ss, bp + 6]);                /* lds dx, [bp+0x6] */
            ii(0x17_90fe, 4); call_far_ind(memw[ds, 0x1fe0]);           /* call far word [0x1fe0] */
            ii(0x17_9102, 4); if(jb(0x17_9117, 0x11)) goto l_0x17_9117; /* jb 0x9117 */
            ii(0x17_9106, 1); push(bx);                                 /* push bx */
            ii(0x17_9107, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_9109, 2); mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x17_910b, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_910d, 1); pop(bx);                                  /* pop bx */
            ii(0x17_910e, 2); mov(ah, 0x41);                            /* mov ah, 0x41 */
            ii(0x17_9110, 3); lds(dx, memw[ss, bp + 6]);                /* lds dx, [bp+0x6] */
            ii(0x17_9113, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_9115, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x17_9117:
            ii(0x17_9117, 1); pop(dx);                                  /* pop dx */
            ii(0x17_9118, 1); pop(cx);                                  /* pop cx */
            ii(0x17_9119, 1); pop(ds);                                  /* pop ds */
            ii(0x17_911a, 1); pop(bp);                                  /* pop bp */
            ii(0x17_911b, 1); retf();                                   /* retf */
        }
    }
}
