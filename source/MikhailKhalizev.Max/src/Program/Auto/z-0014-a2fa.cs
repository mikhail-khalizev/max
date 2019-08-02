using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6b5fb0bf-2320-44c3-bbd8-f183b7eeb4d1")]
        public void Method_0014_a2fa()
        {
            ii(0x14_a2fa, 1); pushw(bp);                                /* push bp */
            ii(0x14_a2fb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_a2fd, 1); pusha();                                  /* pusha */
            ii(0x14_a2fe, 1); pushw(ds);                                /* push ds */
            ii(0x14_a2ff, 1); pushw(es);                                /* push es */
            ii(0x14_a300, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x14_a303, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x14_a306, 4); mov(cx, memw_a16[es, bx + 0x4]);          /* mov cx, [es:bx+0x4] */
            ii(0x14_a30a, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x14_a30e, 4); mov(si, memw_a16[es, bx + 0x8]);          /* mov si, [es:bx+0x8] */
            ii(0x14_a312, 4); mov(di, memw_a16[es, bx + 0xa]);          /* mov di, [es:bx+0xa] */
            ii(0x14_a316, 4); mov(bx, memw_a16[es, bx + 0x2]);          /* mov bx, [es:bx+0x2] */
            ii(0x14_a31a, 1); pushw(bx);                                /* push bx */
            ii(0x14_a31b, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x14_a31e, 4); mov(ds, memw_a16[es, bx + 0x6]);          /* mov ds, [es:bx+0x6] */
            ii(0x14_a322, 3); mov(es, memw_a16[es, bx]);                /* mov es, [es:bx] */
            ii(0x14_a325, 1); popw(bx);                                 /* pop bx */
            ii(0x14_a326, 2); pushfd();                                 /* pushfd */
            ii(0x14_a328, 2); pushd(cs);                                /* o32 push cs */
            ii(0x14_a32a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x14_a32c, 3); callw(0x14_a7be, 0x48f);                  /* call 0xa7be */
            ii(0x14_a32f, 1); pushw(ax);                                /* push ax */
            ii(0x14_a330, 1); pushw(es);                                /* push es */
            ii(0x14_a331, 1); pushw(bx);                                /* push bx */
            ii(0x14_a332, 3); les(bx, ss, bp + 0xa);                    /* les bx, [bp+0xa] */
            ii(0x14_a335, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x14_a338, 4); mov(memw_a16[es, bx + 0x4], cx);          /* mov [es:bx+0x4], cx */
            ii(0x14_a33c, 4); mov(memw_a16[es, bx + 0x6], dx);          /* mov [es:bx+0x6], dx */
            ii(0x14_a340, 4); mov(memw_a16[es, bx + 0x8], si);          /* mov [es:bx+0x8], si */
            ii(0x14_a344, 4); mov(memw_a16[es, bx + 0xa], di);          /* mov [es:bx+0xa], di */
            ii(0x14_a348, 4); mov(memw_a16[es, bx + 0xa], di);          /* mov [es:bx+0xa], di */
            ii(0x14_a34c, 1); pushfw();                                 /* pushfw */
            ii(0x14_a34d, 4); popw(memw_a16[es, bx + 0xc]);             /* pop word [es:bx+0xc] */
            ii(0x14_a351, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a352, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x14_a356, 3); les(bx, ss, bp + 0xe);                    /* les bx, [bp+0xe] */
            ii(0x14_a359, 4); mov(memw_a16[es, bx + 0x6], di);          /* mov [es:bx+0x6], di */
            ii(0x14_a35d, 3); popw(memw_a16[es, bx]);                   /* pop word [es:bx] */
            ii(0x14_a360, 1); popw(ax);                                 /* pop ax */
            ii(0x14_a361, 1); popw(es);                                 /* pop es */
            ii(0x14_a362, 1); popw(ds);                                 /* pop ds */
            ii(0x14_a363, 1); popa();                                   /* popa */
            ii(0x14_a364, 1); popw(bp);                                 /* pop bp */
            ii(0x14_a365, 1); retfw(); return;                          /* retf */
        }
    }
}
