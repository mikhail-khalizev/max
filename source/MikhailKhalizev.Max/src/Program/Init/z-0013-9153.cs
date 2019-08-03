using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ccd6dfd2-7405-4444-b16b-5e823be60918")]
        public void Method_0013_9153()
        {
            ii(0x13_9153, 1); pushw(bp);                                /* push bp */
            ii(0x13_9154, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_9156, 1); pushw(bx);                                /* push bx */
            ii(0x13_9157, 1); pushw(cx);                                /* push cx */
            ii(0x13_9158, 1); pushw(dx);                                /* push dx */
            ii(0x13_9159, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x13_915c, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_915f, 3); mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x13_9162, 3); mov(ax, 0x4200);                          /* mov ax, 0x4200 */
            ii(0x13_9165, 4); callw_a16_far_ind(ds, 0x1fe0);            /* call far word [0x1fe0] */
            ii(0x13_9169, 4); if(jbw(0x13_916f, 0x2)) goto l_0x13_916f; /* jb 0x916f */
            ii(0x13_916d, 2); xor(ax, ax);                              /* xor ax, ax */
        l_0x13_916f:
            ii(0x13_916f, 1); popw(dx);                                 /* pop dx */
            ii(0x13_9170, 1); popw(cx);                                 /* pop cx */
            ii(0x13_9171, 1); popw(bx);                                 /* pop bx */
            ii(0x13_9172, 1); popw(bp);                                 /* pop bp */
            ii(0x13_9173, 1); cld();                                    /* cld */
            ii(0x13_9174, 1); retfw(); return;                          /* retf */
        }
    }
}
