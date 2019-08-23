using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a2fa-bd11c435")]
        public void Method_0018_a2fa()
        {
            ii(0x18_a2fa, 1); push(bp);                                 /* push bp */
            ii(0x18_a2fb, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x18_a2fd, 1); pusha();                                  /* pusha */
            ii(0x18_a2fe, 1); push(ds);                                 /* push ds */
            ii(0x18_a2ff, 1); push(es);                                 /* push es */
            ii(0x18_a300, 3); les(bx, memw[ss, bp + 0x6]);              /* les bx, [bp+0x6] */
            ii(0x18_a303, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x18_a306, 4); mov(cx, memw[es, bx + 0x4]);              /* mov cx, [es:bx+0x4] */
            ii(0x18_a30a, 4); mov(dx, memw[es, bx + 0x6]);              /* mov dx, [es:bx+0x6] */
            ii(0x18_a30e, 4); mov(si, memw[es, bx + 0x8]);              /* mov si, [es:bx+0x8] */
            ii(0x18_a312, 4); mov(di, memw[es, bx + 0xa]);              /* mov di, [es:bx+0xa] */
            ii(0x18_a316, 4); mov(bx, memw[es, bx + 0x2]);              /* mov bx, [es:bx+0x2] */
            ii(0x18_a31a, 1); push(bx);                                 /* push bx */
            ii(0x18_a31b, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x18_a31e, 4); mov(ds, memw[es, bx + 0x6]);              /* mov ds, [es:bx+0x6] */
            ii(0x18_a322, 3); mov(es, memw[es, bx]);                    /* mov es, [es:bx] */
            ii(0x18_a325, 1); pop(bx);                                  /* pop bx */
            ii(0x18_a326, 2); pushfd();                                 /* pushfd */
            ii(0x18_a328, 2); pushd(cs);                                /* o32 push cs */
            ii(0x18_a32a, 2); push(0);                                  /* push 0x0 */
            ii(0x18_a32c, 3); call(0x18_a7be, 0x48f);                   /* call 0xa7be */
            ii(0x18_a32f, 1); push(ax);                                 /* push ax */
            ii(0x18_a330, 1); push(es);                                 /* push es */
            ii(0x18_a331, 1); push(bx);                                 /* push bx */
            ii(0x18_a332, 3); les(bx, memw[ss, bp + 0xa]);              /* les bx, [bp+0xa] */
            ii(0x18_a335, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x18_a338, 4); mov(memw[es, bx + 0x4], cx);              /* mov [es:bx+0x4], cx */
            ii(0x18_a33c, 4); mov(memw[es, bx + 0x6], dx);              /* mov [es:bx+0x6], dx */
            ii(0x18_a340, 4); mov(memw[es, bx + 0x8], si);              /* mov [es:bx+0x8], si */
            ii(0x18_a344, 4); mov(memw[es, bx + 0xa], di);              /* mov [es:bx+0xa], di */
            ii(0x18_a348, 4); mov(memw[es, bx + 0xa], di);              /* mov [es:bx+0xa], di */
            ii(0x18_a34c, 1); pushfw();                                 /* pushfw */
            ii(0x18_a34d, 4); pop(memw[es, bx + 0xc]);                  /* pop word [es:bx+0xc] */
            ii(0x18_a351, 1); pop(ax);                                  /* pop ax */
            ii(0x18_a352, 4); mov(memw[es, bx + 0x2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x18_a356, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x18_a359, 4); mov(memw[es, bx + 0x6], di);              /* mov [es:bx+0x6], di */
            ii(0x18_a35d, 3); pop(memw[es, bx]);                        /* pop word [es:bx] */
            ii(0x18_a360, 1); pop(ax);                                  /* pop ax */
            ii(0x18_a361, 1); pop(es);                                  /* pop es */
            ii(0x18_a362, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a363, 1); popa();                                   /* popa */
            ii(0x18_a364, 1); pop(bp);                                  /* pop bp */
            ii(0x18_a365, 1); retf();                                   /* retf */
        }
    }
}
