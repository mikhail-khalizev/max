using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x573a-d6dede3b")]
        public void Method_0000_573a()
        {
            ii(0x573a, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x573e, 1);    pushw(si);                                /* push si */
            ii(0x573f, 3);    mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x5742, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5744, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x5746, 3);    callw(0x6544, 0xdfb);                     /* call 0x6544 */
            ii(0x5749, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x574b, 3);    mov(memw_a16[ds, 0x8e2], ax);             /* mov [0x8e2], ax */
            ii(0x574e, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x5750, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x5752, 4);    mov(memb_a16[ds, 0x8e4], bl);             /* mov [0x8e4], bl */
            ii(0x5756, 3);    mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x5759, 3);    mov(memw_a16[ss, bp - 0x6], si);          /* mov [bp-0x6], si */
            ii(0x575c, 4);    add(dx, 0x8c0);                           /* add dx, 0x8c0 */
            ii(0x5760, 3);    adc(si, 0);                               /* adc si, 0x0 */
            ii(0x5763, 4);    mov(memw_a16[ds, 0x976], dx);             /* mov [0x976], dx */
            ii(0x5767, 4);    mov(memw_a16[ds, 0x978], si);             /* mov [0x978], si */
            ii(0x576b, 6);    mov(memw_a16[ds, 0x8c8], 0x9f);           /* mov word [0x8c8], 0x9f */
            ii(0x5771, 3);    mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x5774, 3);    mov(memw_a16[ss, bp - 0xa], si);          /* mov [bp-0xa], si */
            ii(0x5777, 4);    mov(memw_a16[ds, 0x8ca], dx);             /* mov [0x8ca], dx */
            ii(0x577b, 3);    mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x577e, 3);    mov(memb_a16[ds, 0x8cc], al);             /* mov [0x8cc], al */
            ii(0x5781, 3);    mov(ax, 0x960);                           /* mov ax, 0x960 */
            ii(0x5784, 3);    sub(ax, 0x8c0);                           /* sub ax, 0x8c0 */
            ii(0x5787, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5789, 3);    add(ax, memw_a16[ss, bp - 0xc]);          /* add ax, [bp-0xc] */
            ii(0x578c, 2);    adc(dx, si);                              /* adc dx, si */
            ii(0x578e, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x5790, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x5792, 3);    mov(memw_a16[ds, 0x912], ax);             /* mov [0x912], ax */
            ii(0x5795, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x5797, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x5799, 4);    mov(memb_a16[ds, 0x914], bl);             /* mov [0x914], bl */
            ii(0x579d, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x579f, 3);    mov(memw_a16[ds, 0x8ce], ax);             /* mov [0x8ce], ax */
            ii(0x57a2, 3);    mov(memw_a16[ds, 0x916], ax);             /* mov [0x916], ax */
            ii(0x57a5, 3);    mov(ax, 0x960);                           /* mov ax, 0x960 */
            ii(0x57a8, 3);    sub(ax, 0xc0);                            /* sub ax, 0xc0 */
            ii(0x57ab, 2);    sub(dx, ax);                              /* sub dx, ax */
            ii(0x57ad, 3);    sbb(si, 0);                               /* sbb si, 0x0 */
            ii(0x57b0, 3);    mov(memw_a16[ss, bp - 0xe], si);          /* mov [bp-0xe], si */
            ii(0x57b3, 4);    mov(memw_a16[ds, 0x8d2], dx);             /* mov [0x8d2], dx */
            ii(0x57b7, 3);    mov(al, memb_a16[ss, bp - 0xe]);          /* mov al, [bp-0xe] */
            ii(0x57ba, 3);    mov(memb_a16[ds, 0x8d4], al);             /* mov [0x8d4], al */
            ii(0x57bd, 3);    mov(ax, memw_a16[ds, 0x9b6]);             /* mov ax, [0x9b6] */
            ii(0x57c0, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x57c2, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x57c4, 3);    callw(0x6544, 0xd7d);                     /* call 0x6544 */
            ii(0x57c7, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x57c9, 3);    mov(memw_a16[ds, 0x90a], ax);             /* mov [0x90a], ax */
            ii(0x57cc, 3);    mov(memw_a16[ds, 0x8da], ax);             /* mov [0x8da], ax */
            ii(0x57cf, 4);    mov(memb_a16[ds, 0x90c], bl);             /* mov [0x90c], bl */
            ii(0x57d3, 4);    mov(memb_a16[ds, 0x8dc], bl);             /* mov [0x8dc], bl */
            ii(0x57d7, 3);    mov(ax, 0xd74);                           /* mov ax, 0xd74 */
            ii(0x57da, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x57dc, 3);    add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x57df, 3);    adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x57e2, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x57e4, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x57e6, 3);    mov(memw_a16[ds, 0x91a], ax);             /* mov [0x91a], ax */
            ii(0x57e9, 4);    mov(memb_a16[ds, 0x91c], bl);             /* mov [0x91c], bl */
            ii(0x57ed, 3);    mov(ax, memw_a16[ds, 0xa10]);             /* mov ax, [0xa10] */
            ii(0x57f0, 4);    mov(dx, memw_a16[ds, 0xa12]);             /* mov dx, [0xa12] */
            ii(0x57f4, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x57f6, 3);    callw(0x6544, 0xd4b);                     /* call 0x6544 */
            ii(0x57f9, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x57fc, 3);    mov(memw_a16[ds, 0x932], ax);             /* mov [0x932], ax */
            ii(0x57ff, 3);    mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x5802, 3);    mov(memb_a16[ds, 0x934], al);             /* mov [0x934], al */
            ii(0x5805, 3);    mov(al, memb_a16[ss, bp - 0x1]);          /* mov al, [bp-0x1] */
            ii(0x5808, 1);    cbw();                                    /* cbw */
            ii(0x5809, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x580b, 2);    sub(al, al);                              /* sub al, al */
            ii(0x580d, 3);    mov(memw_a16[ds, 0x936], ax);             /* mov [0x936], ax */
            ii(0x5810, 6);    mov(memw_a16[ds, 0xd70], 0x80);           /* mov word [0xd70], 0x80 */
            ii(0x5816, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x581b, 2);    if(jlw(0x5823, 0x6)) goto l_0x5823;       /* jl 0x5823 */
            ii(0x581d, 6);    mov(memw_a16[ds, 0x8fe], 0x8f);           /* mov word [0x8fe], 0x8f */
        l_0x5823:
            ii(0x5823, 1);    popw(si);                                 /* pop si */
            ii(0x5824, 1);    leavew();                                 /* leave */
            ii(0x5825, 1);    retw(); return;                           /* ret */
        }
    }
}
