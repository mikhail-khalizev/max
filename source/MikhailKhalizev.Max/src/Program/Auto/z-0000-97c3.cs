using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x97c3-2333b8f8")]
        public void Method_0000_97c3()
        {
            ii(0x97c3, 4);    enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x97c7, 3);    call(0x6f71, -0x2859);                    /* call 0x6f71 */
            ii(0x97ca, 2);    push(1);                                  /* push 0x1 */
            ii(0x97cc, 3);    call(0x7016, -0x27b9);                    /* call 0x7016 */
            ii(0x97cf, 1);    pop(bx);                                  /* pop bx */
            ii(0x97d0, 5);    mov(memw[ss, bp - 0xe], 0x4201);          /* mov word [bp-0xe], 0x4201 */
            ii(0x97d5, 3);    mov(ax, memw[ds, 0xe70]);                 /* mov ax, [0xe70] */
            ii(0x97d8, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x97db, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x97dd, 3);    mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x97e0, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x97e3, 3);    lea(ax, memw[ss, bp - 0xe]);              /* lea ax, [bp-0xe] */
            ii(0x97e6, 1);    push(ax);                                 /* push ax */
            ii(0x97e7, 1);    push(ax);                                 /* push ax */
            ii(0x97e8, 3);    call(0x8480, -0x136b);                    /* call 0x8480 */
            ii(0x97eb, 1);    pop(bx);                                  /* pop bx */
            ii(0x97ec, 1);    pop(bx);                                  /* pop bx */
            ii(0x97ed, 4);    mov(ah, memb[ds, 0xf]);                   /* mov ah, [0xf] */
            ii(0x97f1, 3);    and(ax, 0xfe00);                          /* and ax, 0xfe00 */
            ii(0x97f4, 3);    mov(cx, memw[ss, bp - 0xe]);              /* mov cx, [bp-0xe] */
            ii(0x97f7, 3);    and(ch, 1);                               /* and ch, 0x1 */
            ii(0x97fa, 2);    sub(ax, cx);                              /* sub ax, cx */
            ii(0x97fc, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x97ff, 4);    mov(memb[ss, bp - 0xd], 0x3f);            /* mov byte [bp-0xd], 0x3f */
            ii(0x9803, 3);    mov(ax, memw[ds, 0xa]);                   /* mov ax, [0xa] */
            ii(0x9806, 3);    mov(memw[ds, 0x11d0], ax);                /* mov [0x11d0], ax */
            ii(0x9809, 3);    mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x980c, 3);    lea(ax, memw[ss, bp - 0xe]);              /* lea ax, [bp-0xe] */
            ii(0x980f, 1);    push(ax);                                 /* push ax */
            ii(0x9810, 1);    push(ax);                                 /* push ax */
            ii(0x9811, 3);    call(0x8480, -0x1394);                    /* call 0x8480 */
            ii(0x9814, 1);    pop(bx);                                  /* pop bx */
            ii(0x9815, 1);    pop(bx);                                  /* pop bx */
            ii(0x9816, 4);    test(memb[ss, bp - 2], 1);                /* test byte [bp-0x2], 0x1 */
            ii(0x981a, 2);    if(jz(0x9821, 5)) goto l_0x9821;          /* jz 0x9821 */
            ii(0x981c, 5);    mov(memw[ss, bp - 0xe], 0);               /* mov word [bp-0xe], 0x0 */
        l_0x9821:
            ii(0x9821, 3);    mov(ax, memw[ss, bp - 0xe]);              /* mov ax, [bp-0xe] */
            ii(0x9824, 4);    add(ax, memw[ds, 0x11d0]);                /* add ax, [0x11d0] */
            ii(0x9828, 3);    mov(memw[ds, 0x1208], ax);                /* mov [0x1208], ax */
            ii(0x982b, 3);    call(0x773a, -0x20f4);                    /* call 0x773a */
            ii(0x982e, 2);    push(1);                                  /* push 0x1 */
            ii(0x9830, 3);    call(0x7016, -0x281d);                    /* call 0x7016 */
            ii(0x9833, 1);    pop(bx);                                  /* pop bx */
            ii(0x9834, 3);    mov(ax, memw[ss, bp - 0xe]);              /* mov ax, [bp-0xe] */
            ii(0x9837, 1);    leave();                                  /* leave */
            ii(0x9838, 1);    ret();                                    /* ret */
        }
    }
}
