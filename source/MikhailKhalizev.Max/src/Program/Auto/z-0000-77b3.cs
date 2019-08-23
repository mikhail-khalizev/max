using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x77b3-2333b8f8")]
        public void Method_0000_77b3()
        {
            ii(0x77b3, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x77b7, 3);    callw(0x4f61, -0x2859);                   /* call 0x4f61 */
            ii(0x77ba, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0x77bc, 3);    callw(0x5006, -0x27b9);                   /* call 0x5006 */
            ii(0x77bf, 1);    popw(bx);                                 /* pop bx */
            ii(0x77c0, 5);    mov(memw_a16[ss, bp - 0xe], 0x4201);      /* mov word [bp-0xe], 0x4201 */
            ii(0x77c5, 3);    mov(ax, memw_a16[ds, 0xe70]);             /* mov ax, [0xe70] */
            ii(0x77c8, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x77cb, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x77cd, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x77d0, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x77d3, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x77d6, 1);    pushw(ax);                                /* push ax */
            ii(0x77d7, 1);    pushw(ax);                                /* push ax */
            ii(0x77d8, 3);    callw(0x6470, -0x136b);                   /* call 0x6470 */
            ii(0x77db, 1);    popw(bx);                                 /* pop bx */
            ii(0x77dc, 1);    popw(bx);                                 /* pop bx */
            ii(0x77dd, 4);    mov(ah, memb_a16[ds, 0xf]);               /* mov ah, [0xf] */
            ii(0x77e1, 3);    and(ax, 0xfe00);                          /* and ax, 0xfe00 */
            ii(0x77e4, 3);    mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x77e7, 3);    and(ch, 0x1);                             /* and ch, 0x1 */
            ii(0x77ea, 2);    sub(ax, cx);                              /* sub ax, cx */
            ii(0x77ec, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x77ef, 4);    mov(memb_a16[ss, bp - 0xd], 0x3f);        /* mov byte [bp-0xd], 0x3f */
            ii(0x77f3, 3);    mov(ax, memw_a16[ds, 0xa]);               /* mov ax, [0xa] */
            ii(0x77f6, 3);    mov(memw_a16[ds, 0x11d0], ax);            /* mov [0x11d0], ax */
            ii(0x77f9, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x77fc, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x77ff, 1);    pushw(ax);                                /* push ax */
            ii(0x7800, 1);    pushw(ax);                                /* push ax */
            ii(0x7801, 3);    callw(0x6470, -0x1394);                   /* call 0x6470 */
            ii(0x7804, 1);    popw(bx);                                 /* pop bx */
            ii(0x7805, 1);    popw(bx);                                 /* pop bx */
            ii(0x7806, 4);    test(memb_a16[ss, bp - 0x2], 0x1);        /* test byte [bp-0x2], 0x1 */
            ii(0x780a, 2);    if(jzw(0x7811, 0x5)) goto l_0x7811;       /* jz 0x7811 */
            ii(0x780c, 5);    mov(memw_a16[ss, bp - 0xe], 0);           /* mov word [bp-0xe], 0x0 */
        l_0x7811:
            ii(0x7811, 3);    mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x7814, 4);    add(ax, memw_a16[ds, 0x11d0]);            /* add ax, [0x11d0] */
            ii(0x7818, 3);    mov(memw_a16[ds, 0x1208], ax);            /* mov [0x1208], ax */
            ii(0x781b, 3);    callw(0x572a, -0x20f4);                   /* call 0x572a */
            ii(0x781e, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0x7820, 3);    callw(0x5006, -0x281d);                   /* call 0x5006 */
            ii(0x7823, 1);    popw(bx);                                 /* pop bx */
            ii(0x7824, 3);    mov(ax, memw_a16[ss, bp - 0xe]);          /* mov ax, [bp-0xe] */
            ii(0x7827, 1);    leavew();                                 /* leave */
            ii(0x7828, 1);    retw();                                   /* ret */
        }
    }
}
