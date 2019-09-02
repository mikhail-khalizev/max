using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9153-9f66e991")]
        public void Method_0017_9153()
        {
            ii(0x17_9153, 1); push(bp);                                 /* push bp */
            ii(0x17_9154, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_9156, 1); push(bx);                                 /* push bx */
            ii(0x17_9157, 1); push(cx);                                 /* push cx */
            ii(0x17_9158, 1); push(dx);                                 /* push dx */
            ii(0x17_9159, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x17_915c, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_915f, 3); mov(cx, memw[ss, bp + 0xa]);              /* mov cx, [bp+0xa] */
            ii(0x17_9162, 3); mov(ax, 0x4200);                          /* mov ax, 0x4200 */
            ii(0x17_9165, 4); call_far_ind(memw[ds, 0x1fe0]);           /* call far word [0x1fe0] */
            ii(0x17_9169, 4); if(jb(0x17_916f, 2)) goto l_0x17_916f;    /* jb 0x916f */
            ii(0x17_916d, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x17_916f:
            ii(0x17_916f, 1); pop(dx);                                  /* pop dx */
            ii(0x17_9170, 1); pop(cx);                                  /* pop cx */
            ii(0x17_9171, 1); pop(bx);                                  /* pop bx */
            ii(0x17_9172, 1); pop(bp);                                  /* pop bp */
            ii(0x17_9173, 1); cld();                                    /* cld */
            ii(0x17_9174, 1); retf();                                   /* retf */
        }
    }
}
