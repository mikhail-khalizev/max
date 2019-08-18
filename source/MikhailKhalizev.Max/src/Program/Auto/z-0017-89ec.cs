using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_89ec-2e93c268")]
        public void Method_0017_89ec()
        {
            ii(0x17_89ec, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_89f0, 1); pushw(si);                                /* push si */
            ii(0x17_89f1, 1); pushw(ds);                                /* push ds */
            ii(0x17_89f2, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_89f5, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_89f7, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x17_89fb, 4); mov(al, memb_a16[es, bx + 0x13]);         /* mov al, [es:bx+0x13] */
            ii(0x17_89ff, 3); mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x17_8a02, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x17_8a05, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x17_8a07, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x17_8a09, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_8a0b, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x17_8a0d, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x17_8a0f, 2); mov(cx, es);                              /* mov cx, es */
            ii(0x17_8a11, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x17_8a15, 4); mov(dl, memb_a16[es, bx + si + 0x4]);     /* mov dl, [es:bx+si+0x4] */
            ii(0x17_8a19, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x17_8a1b, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x17_8a1d, 4); mov(memb_a16[es, bx + 0x13], dl);         /* mov [es:bx+0x13], dl */
            ii(0x17_8a21, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x17_8a24, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_8a27, 2); pushw(0x13);                              /* push 0x13 */
            ii(0x17_8a29, 1); nop();                                    /* nop */
            ii(0x17_8a2a, 1); pushw(cs);                                /* push cs */
            ii(0x17_8a2b, 3); callw(0x17_9153, 0x725);                  /* call 0x9153 */
            ii(0x17_8a2e, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_8a31, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_8a34, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x17_8a37, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x17_8a3b, 4); mov(memb_a16[es, bx + 0x13], al);         /* mov [es:bx+0x13], al */
            ii(0x17_8a3f, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x17_8a42, 1); popw(ds);                                 /* pop ds */
            ii(0x17_8a43, 1); popw(si);                                 /* pop si */
            ii(0x17_8a44, 1); leavew();                                 /* leave */
            ii(0x17_8a45, 1); retfw(); return;                          /* retf */
        }
    }
}
