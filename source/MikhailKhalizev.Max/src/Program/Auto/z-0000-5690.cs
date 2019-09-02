using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5690-8e317bd0")]
        public void Method_0000_5690()
        {
            ii(0x5690, 1);    push(di);                                 /* push di */
            ii(0x5691, 1);    push(si);                                 /* push si */
            ii(0x5692, 3);    mov(al, memb[ds, 0xcda]);                 /* mov al, [0xcda] */
            ii(0x5695, 4);    inc(memb[ds, 0xcda]);                     /* inc byte [0xcda] */
            ii(0x5699, 2);    or(al, al);                               /* or al, al */
            ii(0x569b, 2);    if(jnz(0x56a0, 3)) goto l_0x56a0;         /* jnz 0x56a0 */
            ii(0x569d, 3);    call(0x4a31, -0xc6f);                     /* call 0x4a31 */
        l_0x56a0:
            ii(0x56a0, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x56a4, 4);    cmp(memw[ds, bx + 0x18], 0x21);           /* cmp word [bx+0x18], 0x21 */
            ii(0x56a8, 2);    if(jnz(0x56b3, 9)) goto l_0x56b3;         /* jnz 0x56b3 */
            ii(0x56aa, 3);    mov(al, memb[ds, bx + 0x16]);             /* mov al, [bx+0x16] */
            ii(0x56ad, 1);    cbw();                                    /* cbw */
            ii(0x56ae, 1);    push(ax);                                 /* push ax */
            ii(0x56af, 3);    call(0x3622, -0x2090);                    /* call 0x3622 */
            ii(0x56b2, 1);    pop(bx);                                  /* pop bx */
        l_0x56b3:
            ii(0x56b3, 3);    call(0x47b7, -0xeff);                     /* call 0x47b7 */
            ii(0x56b6, 3);    call(0x4dc8, -0x8f1);                     /* call 0x4dc8 */
            ii(0x56b9, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x56bd, 4);    cmp(memw[ds, bx + 0x18], 0);              /* cmp word [bx+0x18], 0x0 */
            ii(0x56c1, 2);    if(jge(0x56c6, 3)) goto l_0x56c6;         /* jge 0x56c6 */
            ii(0x56c3, 3);    jmp(0x5857, 0x191); goto l_0x5857;        /* jmp 0x5857 */
        l_0x56c6:
            ii(0x56c6, 3);    mov(ax, 0xc4e);                           /* mov ax, 0xc4e */
            ii(0x56c9, 1);    push(ax);                                 /* push ax */
            ii(0x56ca, 3);    call(0x4a87, -0xc46);                     /* call 0x4a87 */
            ii(0x56cd, 1);    pop(bx);                                  /* pop bx */
            ii(0x56ce, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x56d2, 4);    cmp(memw[ds, bx + 0x18], 0xd);            /* cmp word [bx+0x18], 0xd */
            ii(0x56d6, 2);    if(jnz(0x56dd, 5)) goto l_0x56dd;         /* jnz 0x56dd */
            ii(0x56d8, 3);    mov(ax, 0xc5b);                           /* mov ax, 0xc5b */
            ii(0x56db, 2);    jmp(0x56e6, 9); goto l_0x56e6;            /* jmp 0x56e6 */
        l_0x56dd:
            ii(0x56dd, 4);    cmp(memw[ds, bx + 0x18], 6);              /* cmp word [bx+0x18], 0x6 */
            ii(0x56e1, 2);    if(jnz(0x56ec, 9)) goto l_0x56ec;         /* jnz 0x56ec */
            ii(0x56e3, 3);    mov(ax, 0xc74);                           /* mov ax, 0xc74 */
        l_0x56e6:
            ii(0x56e6, 1);    push(ax);                                 /* push ax */
            ii(0x56e7, 3);    call(0x4a87, -0xc63);                     /* call 0x4a87 */
            ii(0x56ea, 2);    jmp(0x5712, 0x26); goto l_0x5712;         /* jmp 0x5712 */
        l_0x56ec:
            ii(0x56ec, 4);    cmp(memw[ds, bx + 0x18], 0xe);            /* cmp word [bx+0x18], 0xe */
            ii(0x56f0, 2);    if(jnz(0x5707, 0x15)) goto l_0x5707;      /* jnz 0x5707 */
            ii(0x56f2, 4);    push(memw[ds, 0xd32]);                    /* push word [0xd32] */
            ii(0x56f6, 3);    mov(ax, 0xc83);                           /* mov ax, 0xc83 */
            ii(0x56f9, 1);    push(ax);                                 /* push ax */
            ii(0x56fa, 3);    call(0x4e37, -0x8c6);                     /* call 0x4e37 */
            ii(0x56fd, 1);    pop(bx);                                  /* pop bx */
            ii(0x56fe, 1);    pop(bx);                                  /* pop bx */
            ii(0x56ff, 4);    push(memw[ds, 0xd30]);                    /* push word [0xd30] */
            ii(0x5703, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5705, 2);    jmp(0x570d, 6); goto l_0x570d;            /* jmp 0x570d */
        l_0x5707:
            ii(0x5707, 3);    push(memw[ds, bx + 0x18]);                /* push word [bx+0x18] */
            ii(0x570a, 3);    mov(ax, 0xc8e);                           /* mov ax, 0xc8e */
        l_0x570d:
            ii(0x570d, 1);    push(ax);                                 /* push ax */
            ii(0x570e, 3);    call(0x4e37, -0x8da);                     /* call 0x4e37 */
            ii(0x5711, 1);    pop(bx);                                  /* pop bx */
        l_0x5712:
            ii(0x5712, 1);    pop(bx);                                  /* pop bx */
            ii(0x5713, 3);    mov(ax, 0xca3);                           /* mov ax, 0xca3 */
            ii(0x5716, 1);    push(ax);                                 /* push ax */
            ii(0x5717, 3);    call(0x4a87, -0xc93);                     /* call 0x4a87 */
            ii(0x571a, 1);    pop(bx);                                  /* pop bx */
            ii(0x571b, 4);    mov(si, memw[ds, 0x11f8]);                /* mov si, [0x11f8] */
            ii(0x571f, 4);    add(si, 0x1190);                          /* add si, 0x1190 */
            ii(0x5723, 2);    jmp(0x572f, 0xa); goto l_0x572f;          /* jmp 0x572f */
        l_0x5725:
            ii(0x5725, 3);    cmp(memb[ds, si], 0x3a);                  /* cmp byte [si], 0x3a */
            ii(0x5728, 2);    if(jz(0x5736, 0xc)) goto l_0x5736;        /* jz 0x5736 */
            ii(0x572a, 3);    cmp(memb[ds, si], 0x5c);                  /* cmp byte [si], 0x5c */
            ii(0x572d, 2);    if(jz(0x5736, 7)) goto l_0x5736;          /* jz 0x5736 */
        l_0x572f:
            ii(0x572f, 1);    dec(si);                                  /* dec si */
            ii(0x5730, 4);    cmp(si, 0x1190);                          /* cmp si, 0x1190 */
            ii(0x5734, 2);    if(jae(0x5725, -0x11)) goto l_0x5725;     /* jae 0x5725 */
        l_0x5736:
            ii(0x5736, 3);    lea(ax, memw[ds, si + 1]);                /* lea ax, [si+0x1] */
            ii(0x5739, 1);    push(ax);                                 /* push ax */
            ii(0x573a, 3);    call(0x4a87, -0xcb6);                     /* call 0x4a87 */
            ii(0x573d, 1);    pop(bx);                                  /* pop bx */
            ii(0x573e, 3);    mov(ax, 0xca8);                           /* mov ax, 0xca8 */
            ii(0x5741, 1);    push(ax);                                 /* push ax */
            ii(0x5742, 3);    call(0x4a87, -0xcbe);                     /* call 0x4a87 */
            ii(0x5745, 1);    pop(bx);                                  /* pop bx */
            ii(0x5746, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x574a, 3);    push(memw[ds, bx + 0x22]);                /* push word [bx+0x22] */
            ii(0x574d, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x574f, 1);    push(ax);                                 /* push ax */
            ii(0x5750, 3);    call(0x4e37, -0x91c);                     /* call 0x4e37 */
            ii(0x5753, 1);    pop(bx);                                  /* pop bx */
            ii(0x5754, 1);    pop(bx);                                  /* pop bx */
            ii(0x5755, 3);    mov(ax, 0xcad);                           /* mov ax, 0xcad */
            ii(0x5758, 1);    push(ax);                                 /* push ax */
            ii(0x5759, 3);    call(0x4a87, -0xcd5);                     /* call 0x4a87 */
            ii(0x575c, 1);    pop(bx);                                  /* pop bx */
            ii(0x575d, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5761, 3);    push(memw[ds, bx + 0x1e]);                /* push word [bx+0x1e] */
            ii(0x5764, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5766, 1);    push(ax);                                 /* push ax */
            ii(0x5767, 3);    call(0x4e37, -0x933);                     /* call 0x4e37 */
            ii(0x576a, 1);    pop(bx);                                  /* pop bx */
            ii(0x576b, 1);    pop(bx);                                  /* pop bx */
            ii(0x576c, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5770, 3);    push(memw[ds, bx + 0x22]);                /* push word [bx+0x22] */
            ii(0x5773, 3);    call(0x5862, 0xec);                       /* call 0x5862 */
            ii(0x5776, 1);    pop(bx);                                  /* pop bx */
            ii(0x5777, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x5779, 2);    or(di, di);                               /* or di, di */
            ii(0x577b, 2);    if(jz(0x5787, 0xa)) goto l_0x5787;        /* jz 0x5787 */
            ii(0x577d, 1);    push(di);                                 /* push di */
            ii(0x577e, 3);    mov(ax, 0xcaf);                           /* mov ax, 0xcaf */
            ii(0x5781, 1);    push(ax);                                 /* push ax */
            ii(0x5782, 3);    call(0x4e37, -0x94e);                     /* call 0x4e37 */
            ii(0x5785, 1);    pop(bx);                                  /* pop bx */
            ii(0x5786, 1);    pop(bx);                                  /* pop bx */
        l_0x5787:
            ii(0x5787, 3);    call(0x4dc8, -0x9c2);                     /* call 0x4dc8 */
            ii(0x578a, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x578e, 3);    push(memw[ds, bx + 0x1a]);                /* push word [bx+0x1a] */
            ii(0x5791, 3);    mov(ax, 0xcb4);                           /* mov ax, 0xcb4 */
            ii(0x5794, 1);    push(ax);                                 /* push ax */
            ii(0x5795, 3);    call(0x4e37, -0x961);                     /* call 0x4e37 */
            ii(0x5798, 1);    pop(bx);                                  /* pop bx */
            ii(0x5799, 1);    pop(bx);                                  /* pop bx */
            ii(0x579a, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x579e, 3);    push(memw[ds, bx + 2]);                   /* push word [bx+0x2] */
            ii(0x57a1, 3);    mov(ax, 0xcb9);                           /* mov ax, 0xcb9 */
            ii(0x57a4, 1);    push(ax);                                 /* push ax */
            ii(0x57a5, 3);    call(0x4e37, -0x971);                     /* call 0x4e37 */
            ii(0x57a8, 1);    pop(bx);                                  /* pop bx */
            ii(0x57a9, 1);    pop(bx);                                  /* pop bx */
            ii(0x57aa, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x57ae, 3);    push(memw[ds, bx + 4]);                   /* push word [bx+0x4] */
            ii(0x57b1, 3);    mov(ax, 0xcbc);                           /* mov ax, 0xcbc */
            ii(0x57b4, 1);    push(ax);                                 /* push ax */
            ii(0x57b5, 3);    call(0x4e37, -0x981);                     /* call 0x4e37 */
            ii(0x57b8, 1);    pop(bx);                                  /* pop bx */
            ii(0x57b9, 1);    pop(bx);                                  /* pop bx */
            ii(0x57ba, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x57be, 3);    push(memw[ds, bx + 6]);                   /* push word [bx+0x6] */
            ii(0x57c1, 3);    mov(ax, 0xcbf);                           /* mov ax, 0xcbf */
            ii(0x57c4, 1);    push(ax);                                 /* push ax */
            ii(0x57c5, 3);    call(0x4e37, -0x991);                     /* call 0x4e37 */
            ii(0x57c8, 1);    pop(bx);                                  /* pop bx */
            ii(0x57c9, 1);    pop(bx);                                  /* pop bx */
            ii(0x57ca, 3);    call(0x4dc8, -0xa05);                     /* call 0x4dc8 */
            ii(0x57cd, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x57d1, 3);    push(memw[ds, bx + 0x16]);                /* push word [bx+0x16] */
            ii(0x57d4, 3);    mov(ax, 0xcc2);                           /* mov ax, 0xcc2 */
            ii(0x57d7, 1);    push(ax);                                 /* push ax */
            ii(0x57d8, 3);    call(0x4e37, -0x9a4);                     /* call 0x4e37 */
            ii(0x57db, 1);    pop(bx);                                  /* pop bx */
            ii(0x57dc, 1);    pop(bx);                                  /* pop bx */
            ii(0x57dd, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x57e1, 3);    push(memw[ds, bx + 0x10]);                /* push word [bx+0x10] */
            ii(0x57e4, 3);    mov(ax, 0xcc5);                           /* mov ax, 0xcc5 */
            ii(0x57e7, 1);    push(ax);                                 /* push ax */
            ii(0x57e8, 3);    call(0x4e37, -0x9b4);                     /* call 0x4e37 */
            ii(0x57eb, 1);    pop(bx);                                  /* pop bx */
            ii(0x57ec, 1);    pop(bx);                                  /* pop bx */
            ii(0x57ed, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x57f1, 3);    push(memw[ds, bx + 0x14]);                /* push word [bx+0x14] */
            ii(0x57f4, 3);    mov(ax, 0xcc8);                           /* mov ax, 0xcc8 */
            ii(0x57f7, 1);    push(ax);                                 /* push ax */
            ii(0x57f8, 3);    call(0x4e37, -0x9c4);                     /* call 0x4e37 */
            ii(0x57fb, 1);    pop(bx);                                  /* pop bx */
            ii(0x57fc, 1);    pop(bx);                                  /* pop bx */
            ii(0x57fd, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5801, 3);    push(memw[ds, bx + 0x12]);                /* push word [bx+0x12] */
            ii(0x5804, 3);    mov(ax, 0xccb);                           /* mov ax, 0xccb */
            ii(0x5807, 1);    push(ax);                                 /* push ax */
            ii(0x5808, 3);    call(0x4e37, -0x9d4);                     /* call 0x4e37 */
            ii(0x580b, 1);    pop(bx);                                  /* pop bx */
            ii(0x580c, 1);    pop(bx);                                  /* pop bx */
            ii(0x580d, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5811, 3);    push(memw[ds, bx + 0xe]);                 /* push word [bx+0xe] */
            ii(0x5814, 3);    mov(ax, 0xcce);                           /* mov ax, 0xcce */
            ii(0x5817, 1);    push(ax);                                 /* push ax */
            ii(0x5818, 3);    call(0x4e37, -0x9e4);                     /* call 0x4e37 */
            ii(0x581b, 1);    pop(bx);                                  /* pop bx */
            ii(0x581c, 1);    pop(bx);                                  /* pop bx */
            ii(0x581d, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5821, 3);    push(memw[ds, bx + 0xc]);                 /* push word [bx+0xc] */
            ii(0x5824, 3);    mov(ax, 0xcd1);                           /* mov ax, 0xcd1 */
            ii(0x5827, 1);    push(ax);                                 /* push ax */
            ii(0x5828, 3);    call(0x4e37, -0x9f4);                     /* call 0x4e37 */
            ii(0x582b, 1);    pop(bx);                                  /* pop bx */
            ii(0x582c, 1);    pop(bx);                                  /* pop bx */
            ii(0x582d, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5831, 3);    push(memw[ds, bx + 0xa]);                 /* push word [bx+0xa] */
            ii(0x5834, 3);    mov(ax, 0xcd4);                           /* mov ax, 0xcd4 */
            ii(0x5837, 1);    push(ax);                                 /* push ax */
            ii(0x5838, 3);    call(0x4e37, -0xa04);                     /* call 0x4e37 */
            ii(0x583b, 1);    pop(bx);                                  /* pop bx */
            ii(0x583c, 1);    pop(bx);                                  /* pop bx */
            ii(0x583d, 4);    mov(bx, memw[ds, 0x996]);                 /* mov bx, [0x996] */
            ii(0x5841, 3);    push(memw[ds, bx + 8]);                   /* push word [bx+0x8] */
            ii(0x5844, 3);    mov(ax, 0xcd7);                           /* mov ax, 0xcd7 */
            ii(0x5847, 1);    push(ax);                                 /* push ax */
            ii(0x5848, 3);    call(0x4e37, -0xa14);                     /* call 0x4e37 */
            ii(0x584b, 1);    pop(bx);                                  /* pop bx */
            ii(0x584c, 1);    pop(bx);                                  /* pop bx */
            ii(0x584d, 5);    test(memb[ds, 0x15], 0x80);               /* test byte [0x15], 0x80 */
            ii(0x5852, 2);    if(jz(0x5857, 3)) goto l_0x5857;          /* jz 0x5857 */
            ii(0x5854, 3);    call(0x486a, -0xfed);                     /* call 0x486a */
        l_0x5857:
            ii(0x5857, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x585a, 1);    push(ax);                                 /* push ax */
            ii(0x585b, 3);    call(0x3622, -0x223c);                    /* call 0x3622 */
            ii(0x585e, 1);    pop(bx);                                  /* pop bx */
            ii(0x585f, 1);    pop(si);                                  /* pop si */
            ii(0x5860, 1);    pop(di);                                  /* pop di */
            ii(0x5861, 1);    ret();                                    /* ret */
        }
    }
}
