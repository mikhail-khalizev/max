using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f8a-d6dede3b")]
        public void Method_0000_4f8a()
        {
            ii(0x4f8a, 4);    enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x4f8e, 1);    pushw(si);                                /* push si */
            ii(0x4f8f, 3);    mov(ax, memw_a16[ds, 0x9b4]);             /* mov ax, [0x9b4] */
            ii(0x4f92, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x4f94, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x4f96, 3);    callw(0x5d94, 0xdfb);                     /* call 0x5d94 */
            ii(0x4f99, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x4f9b, 3);    mov(memw_a16[ds, 0x8e2], ax);             /* mov [0x8e2], ax */
            ii(0x4f9e, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x4fa0, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x4fa2, 4);    mov(memb_a16[ds, 0x8e4], bl);             /* mov [0x8e4], bl */
            ii(0x4fa6, 3);    mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x4fa9, 3);    mov(memw_a16[ss, bp - 0x6], si);          /* mov [bp-0x6], si */
            ii(0x4fac, 4);    add(dx, 0x8c0);                           /* add dx, 0x8c0 */
            ii(0x4fb0, 3);    adc(si, 0);                               /* adc si, 0x0 */
            ii(0x4fb3, 4);    mov(memw_a16[ds, 0x976], dx);             /* mov [0x976], dx */
            ii(0x4fb7, 4);    mov(memw_a16[ds, 0x978], si);             /* mov [0x978], si */
            ii(0x4fbb, 6);    mov(memw_a16[ds, 0x8c8], 0x9f);           /* mov word [0x8c8], 0x9f */
            ii(0x4fc1, 3);    mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x4fc4, 3);    mov(memw_a16[ss, bp - 0xa], si);          /* mov [bp-0xa], si */
            ii(0x4fc7, 4);    mov(memw_a16[ds, 0x8ca], dx);             /* mov [0x8ca], dx */
            ii(0x4fcb, 3);    mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x4fce, 3);    mov(memb_a16[ds, 0x8cc], al);             /* mov [0x8cc], al */
            ii(0x4fd1, 3);    mov(ax, 0x960);                           /* mov ax, 0x960 */
            ii(0x4fd4, 3);    sub(ax, 0x8c0);                           /* sub ax, 0x8c0 */
            ii(0x4fd7, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x4fd9, 3);    add(ax, memw_a16[ss, bp - 0xc]);          /* add ax, [bp-0xc] */
            ii(0x4fdc, 2);    adc(dx, si);                              /* adc dx, si */
            ii(0x4fde, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x4fe0, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x4fe2, 3);    mov(memw_a16[ds, 0x912], ax);             /* mov [0x912], ax */
            ii(0x4fe5, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x4fe7, 2);    mov(si, bx);                              /* mov si, bx */
            ii(0x4fe9, 4);    mov(memb_a16[ds, 0x914], bl);             /* mov [0x914], bl */
            ii(0x4fed, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x4fef, 3);    mov(memw_a16[ds, 0x8ce], ax);             /* mov [0x8ce], ax */
            ii(0x4ff2, 3);    mov(memw_a16[ds, 0x916], ax);             /* mov [0x916], ax */
            ii(0x4ff5, 3);    mov(ax, 0x960);                           /* mov ax, 0x960 */
            ii(0x4ff8, 3);    sub(ax, 0xc0);                            /* sub ax, 0xc0 */
            ii(0x4ffb, 2);    sub(dx, ax);                              /* sub dx, ax */
            ii(0x4ffd, 3);    sbb(si, 0);                               /* sbb si, 0x0 */
            ii(0x5000, 3);    mov(memw_a16[ss, bp - 0xe], si);          /* mov [bp-0xe], si */
            ii(0x5003, 4);    mov(memw_a16[ds, 0x8d2], dx);             /* mov [0x8d2], dx */
            ii(0x5007, 3);    mov(al, memb_a16[ss, bp - 0xe]);          /* mov al, [bp-0xe] */
            ii(0x500a, 3);    mov(memb_a16[ds, 0x8d4], al);             /* mov [0x8d4], al */
            ii(0x500d, 3);    mov(ax, memw_a16[ds, 0x9b6]);             /* mov ax, [0x9b6] */
            ii(0x5010, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5012, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x5014, 3);    callw(0x5d94, 0xd7d);                     /* call 0x5d94 */
            ii(0x5017, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x5019, 3);    mov(memw_a16[ds, 0x90a], ax);             /* mov [0x90a], ax */
            ii(0x501c, 3);    mov(memw_a16[ds, 0x8da], ax);             /* mov [0x8da], ax */
            ii(0x501f, 4);    mov(memb_a16[ds, 0x90c], bl);             /* mov [0x90c], bl */
            ii(0x5023, 4);    mov(memb_a16[ds, 0x8dc], bl);             /* mov [0x8dc], bl */
            ii(0x5027, 3);    mov(ax, 0xd74);                           /* mov ax, 0xd74 */
            ii(0x502a, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x502c, 3);    add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x502f, 3);    adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x5032, 2);    mov(cx, ax);                              /* mov cx, ax */
            ii(0x5034, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x5036, 3);    mov(memw_a16[ds, 0x91a], ax);             /* mov [0x91a], ax */
            ii(0x5039, 4);    mov(memb_a16[ds, 0x91c], bl);             /* mov [0x91c], bl */
            ii(0x503d, 3);    mov(ax, memw_a16[ds, 0xa10]);             /* mov ax, [0xa10] */
            ii(0x5040, 4);    mov(dx, memw_a16[ds, 0xa12]);             /* mov dx, [0xa12] */
            ii(0x5044, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x5046, 3);    callw(0x5d94, 0xd4b);                     /* call 0x5d94 */
            ii(0x5049, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x504c, 3);    mov(memw_a16[ds, 0x932], ax);             /* mov [0x932], ax */
            ii(0x504f, 3);    mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x5052, 3);    mov(memb_a16[ds, 0x934], al);             /* mov [0x934], al */
            ii(0x5055, 3);    mov(al, memb_a16[ss, bp - 0x1]);          /* mov al, [bp-0x1] */
            ii(0x5058, 1);    cbw();                                    /* cbw */
            ii(0x5059, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x505b, 2);    sub(al, al);                              /* sub al, al */
            ii(0x505d, 3);    mov(memw_a16[ds, 0x936], ax);             /* mov [0x936], ax */
            ii(0x5060, 6);    mov(memw_a16[ds, 0xd70], 0x80);           /* mov word [0xd70], 0x80 */
            ii(0x5066, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x506b, 2);    if(jlw(0x5073, 0x6)) goto l_0x5073;       /* jl 0x5073 */
            ii(0x506d, 6);    mov(memw_a16[ds, 0x8fe], 0x8f);           /* mov word [0x8fe], 0x8f */
        l_0x5073:
            ii(0x5073, 1);    popw(si);                                 /* pop si */
            ii(0x5074, 1);    leavew();                                 /* leave */
            ii(0x5075, 1);    retw();                                   /* ret */
        }
    }
}
