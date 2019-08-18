using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f7846ed5-58cf-4f86-9022-f8549951b155")]
        public void Method_0000_b436()
        {
            ii(0xb436, 4);    enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0xb43a, 1);    pushw(di);                                /* push di */
            ii(0xb43b, 1);    pushw(si);                                /* push si */
            ii(0xb43c, 4);    pushw(memw_a16[ds, 0x120e]);              /* push word [0x120e] */
            ii(0xb440, 3);    callw(0xc4fc, 0x10b9);                    /* call 0xc4fc */
            ii(0xb443, 1);    popw(bx);                                 /* pop bx */
            ii(0xb444, 4);    les(bx, ds, 0xa0);                        /* les bx, [0xa0] */
            ii(0xb448, 4);    mov(cx, memw_a16[es, bx + 0xc]);          /* mov cx, [es:bx+0xc] */
            ii(0xb44c, 4);    mov(si, memw_a16[es, bx + 0xe]);          /* mov si, [es:bx+0xe] */
            ii(0xb450, 3);    add(cx, 0x1);                             /* add cx, 0x1 */
            ii(0xb453, 3);    adc(si, 0);                               /* adc si, 0x0 */
            ii(0xb456, 2);    cmp(si, dx);                              /* cmp si, dx */
            ii(0xb458, 2);    if(jgw(0xb466, 0xc)) goto l_0xb466;       /* jg 0xb466 */
            ii(0xb45a, 2);    if(jlw(0xb460, 0x4)) goto l_0xb460;       /* jl 0xb460 */
            ii(0xb45c, 2);    cmp(cx, ax);                              /* cmp cx, ax */
            ii(0xb45e, 2);    if(jaew(0xb466, 0x6)) goto l_0xb466;      /* jae 0xb466 */
        l_0xb460:
            ii(0xb460, 2);    pushw(0x28);                              /* push 0x28 */
            ii(0xb462, 3);    callw(0x805d, -0x3408);                   /* call 0x805d */
            ii(0xb465, 1);    popw(bx);                                 /* pop bx */
        l_0xb466:
            ii(0xb466, 3);    callw(0x774a, -0x3d1f);                   /* call 0x774a */
            ii(0xb469, 3);    callw(0x5f1c, -0x5550);                   /* call 0x5f1c */
            ii(0xb46c, 4);    pushw(memw_a16[ds, 0x97c]);               /* push word [0x97c] */
            ii(0xb470, 3);    callw(0x6f8d, -0x44e6);                   /* call 0x6f8d */
            ii(0xb473, 1);    popw(bx);                                 /* pop bx */
            ii(0xb474, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0xb477, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xb479, 1);    pushw(ax);                                /* push ax */
            ii(0xb47a, 3);    callw(0x6f8d, -0x44f0);                   /* call 0x6f8d */
            ii(0xb47d, 1);    popw(bx);                                 /* pop bx */
            ii(0xb47e, 3);    mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0xb481, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xb484, 3);    add(ax, memw_a16[ss, bp - 0xa]);          /* add ax, [bp-0xa] */
            ii(0xb487, 1);    pushw(ax);                                /* push ax */
            ii(0xb488, 5);    cmp(memb_a16[ds, 0x981], 0);              /* cmp byte [0x981], 0x0 */
            ii(0xb48d, 2);    if(jzw(0xb494, 0x5)) goto l_0xb494;       /* jz 0xb494 */
            ii(0xb48f, 3);    mov(ax, 0x395c);                          /* mov ax, 0x395c */
            ii(0xb492, 2);    jmpw(0xb497, 0x3); goto l_0xb497;         /* jmp 0xb497 */
        l_0xb494:
            ii(0xb494, 3);    mov(ax, 0x38af);                          /* mov ax, 0x38af */
        l_0xb497:
            ii(0xb497, 2);    callw_abs(ax);                            /* call ax */
            ii(0xb499, 1);    popw(bx);                                 /* pop bx */
            ii(0xb49a, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb49c, 3);    callw(0x8554, -0x2f4b);                   /* call 0x8554 */
            ii(0xb49f, 3);    mov(memw_a16[ds, 0x98e], ax);             /* mov [0x98e], ax */
            ii(0xb4a2, 4);    mov(memw_a16[ds, 0x990], dx);             /* mov [0x990], dx */
            ii(0xb4a6, 6);    mov(memw_a16[ds, 0x11d4], 0xb);           /* mov word [0x11d4], 0xb */
            ii(0xb4ac, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0xb4ae, 4);    or(ax, memw_a16[ds, 0x98e]);              /* or ax, [0x98e] */
            ii(0xb4b2, 2);    if(jnzw(0xb4ba, 0x6)) goto l_0xb4ba;      /* jnz 0xb4ba */
            ii(0xb4b4, 2);    pushw(0xa);                               /* push 0xa */
            ii(0xb4b6, 3);    callw(0x805d, -0x345c);                   /* call 0x805d */
            ii(0xb4b9, 1);    popw(bx);                                 /* pop bx */
        l_0xb4ba:
            ii(0xb4ba, 6);    mov(memw_a16[ds, 0x11d4], 0xa);           /* mov word [0x11d4], 0xa */
            ii(0xb4c0, 4);    shl(memw_a16[ss, bp - 0xa], 0x4);         /* shl word [bp-0xa], 0x4 */
            ii(0xb4c4, 3);    mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0xb4c7, 1);    dec(ax);                                  /* dec ax */
            ii(0xb4c8, 3);    mov(memw_a16[ds, 0x910], ax);             /* mov [0x910], ax */
            ii(0xb4cb, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xb4ce, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0xb4d0, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb4d2, 3);    callw(0x8554, -0x2f81);                   /* call 0x8554 */
            ii(0xb4d5, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0xb4d9, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0xb4dd, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0xb4df, 3);    mov(memw_a16[ds, 0x912], ax);             /* mov [0x912], ax */
            ii(0xb4e2, 4);    mov(memb_a16[ds, 0x914], bl);             /* mov [0x914], bl */
            ii(0xb4e6, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0xb4e8, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0xb4ea, 1);    cbw();                                    /* cbw */
            ii(0xb4eb, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0xb4ed, 2);    sub(al, al);                              /* sub al, al */
            ii(0xb4ef, 3);    mov(memw_a16[ds, 0x916], ax);             /* mov [0x916], ax */
            ii(0xb4f2, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0xb4f5, 3);    mov(memw_a16[ds, 0x938], ax);             /* mov [0x938], ax */
            ii(0xb4f8, 3);    mov(memw_a16[ds, 0x928], ax);             /* mov [0x928], ax */
            ii(0xb4fb, 4);    mov(cx, memw_a16[ds, 0x98e]);             /* mov cx, [0x98e] */
            ii(0xb4ff, 4);    mov(memw_a16[ds, 0x93a], cx);             /* mov [0x93a], cx */
            ii(0xb503, 4);    mov(memw_a16[ds, 0x92a], cx);             /* mov [0x92a], cx */
            ii(0xb507, 4);    mov(cl, memb_a16[ds, 0x990]);             /* mov cl, [0x990] */
            ii(0xb50b, 4);    mov(memb_a16[ds, 0x93c], cl);             /* mov [0x93c], cl */
            ii(0xb50f, 4);    mov(memb_a16[ds, 0x92c], cl);             /* mov [0x92c], cl */
            ii(0xb513, 3);    mov(al, memb_a16[ds, 0x991]);             /* mov al, [0x991] */
            ii(0xb516, 1);    cbw();                                    /* cbw */
            ii(0xb517, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0xb519, 2);    sub(al, al);                              /* sub al, al */
            ii(0xb51b, 3);    mov(memw_a16[ds, 0x93e], ax);             /* mov [0x93e], ax */
            ii(0xb51e, 3);    mov(memw_a16[ds, 0x92e], ax);             /* mov [0x92e], ax */
            ii(0xb521, 2);    mov(al, 0x92);                            /* mov al, 0x92 */
            ii(0xb523, 3);    mov(memb_a16[ds, 0x915], al);             /* mov [0x915], al */
            ii(0xb526, 3);    mov(memb_a16[ds, 0x93d], al);             /* mov [0x93d], al */
            ii(0xb529, 4);    pushw(memw_a16[ds, 0x97c]);               /* push word [0x97c] */
            ii(0xb52d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xb52f, 2);    pushw(0x78);                              /* push 0x78 */
            ii(0xb531, 3);    callw(0xc4b1, 0xf7d);                     /* call 0xc4b1 */
            ii(0xb534, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xb537, 3);    mov(ax, memw_a16[ds, 0x8c8]);             /* mov ax, [0x8c8] */
            ii(0xb53a, 1);    inc(ax);                                  /* inc ax */
            ii(0xb53b, 1);    pushw(ax);                                /* push ax */
            ii(0xb53c, 3);    pushw(0x8c0);                             /* push 0x8c0 */
            ii(0xb53f, 4);    pushw(memw_a16[ds, 0x990]);               /* push word [0x990] */
            ii(0xb543, 4);    pushw(memw_a16[ds, 0x98e]);               /* push word [0x98e] */
            ii(0xb547, 3);    callw(0x6fd2, -0x4578);                   /* call 0x6fd2 */
            ii(0xb54a, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb54d, 3);    pushw(0xff);                              /* push 0xff */
            ii(0xb550, 4);    pushw(memw_a16[ds, 0xcec]);               /* push word [0xcec] */
            ii(0xb554, 2);    pushw(0x5);                               /* push 0x5 */
            ii(0xb556, 3);    callw(0x7aab, -0x3aae);                   /* call 0x7aab */
            ii(0xb559, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xb55c, 3);    pushw(0x7fff);                            /* push 0x7fff */
            ii(0xb55f, 4);    pushw(memw_a16[ds, 0x9b8]);               /* push word [0x9b8] */
            ii(0xb563, 2);    pushw(0x6);                               /* push 0x6 */
            ii(0xb565, 3);    callw(0x7aab, -0x3abd);                   /* call 0x7aab */
            ii(0xb568, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xb56b, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0xb56d, 3);    pushw(0x938);                             /* push 0x938 */
            ii(0xb570, 3);    mov(ax, memw_a16[ds, 0x98e]);             /* mov ax, [0x98e] */
            ii(0xb573, 4);    mov(dx, memw_a16[ds, 0x990]);             /* mov dx, [0x990] */
            ii(0xb577, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0xb57a, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb57d, 1);    pushw(dx);                                /* push dx */
            ii(0xb57e, 1);    pushw(ax);                                /* push ax */
            ii(0xb57f, 3);    callw(0x6fd2, -0x45b0);                   /* call 0x6fd2 */
            ii(0xb582, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb585, 3);    mov(ax, 0x8c8);                           /* mov ax, 0x8c8 */
            ii(0xb588, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0xb58a, 3);    mov(si, 0x938);                           /* mov si, 0x938 */
            ii(0xb58d, 1);    pushw(ds);                                /* push ds */
            ii(0xb58e, 1);    popw(es);                                 /* pop es */
            ii(0xb58f, 1);    movsw_a16();                              /* movsw */
            ii(0xb590, 1);    movsw_a16();                              /* movsw */
            ii(0xb591, 1);    movsw_a16();                              /* movsw */
            ii(0xb592, 1);    movsw_a16();                              /* movsw */
            ii(0xb593, 3);    mov(ax, memw_a16[ds, 0x98e]);             /* mov ax, [0x98e] */
            ii(0xb596, 4);    mov(dx, memw_a16[ds, 0x990]);             /* mov dx, [0x990] */
            ii(0xb59a, 3);    mov(memw_a16[ds, 0x976], ax);             /* mov [0x976], ax */
            ii(0xb59d, 4);    mov(memw_a16[ds, 0x978], dx);             /* mov [0x978], dx */
            ii(0xb5a1, 3);    mov(ax, memw_a16[ds, 0x97c]);             /* mov ax, [0x97c] */
            ii(0xb5a4, 3);    mov(memw_a16[ds, 0x974], ax);             /* mov [0x974], ax */
            ii(0xb5a7, 3);    pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0xb5aa, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xb5ac, 2);    pushw(0x50);                              /* push 0x50 */
            ii(0xb5ae, 3);    callw(0xc4b1, 0xf00);                     /* call 0xc4b1 */
            ii(0xb5b1, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xb5b4, 3);    callw(0x8d77, -0x2840);                   /* call 0x8d77 */
            ii(0xb5b7, 3);    mov(ax, 0x1c);                            /* mov ax, 0x1c */
            ii(0xb5ba, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xb5bd, 1);    pushw(ax);                                /* push ax */
            ii(0xb5be, 3);    callw(0x997c, -0x1c45);                   /* call 0x997c */
            ii(0xb5c1, 1);    popw(bx);                                 /* pop bx */
            ii(0xb5c2, 3);    mov(memw_a16[ds, 0xf54], ax);             /* mov [0xf54], ax */
            ii(0xb5c5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb5c7, 2);    if(jnzw(0xb5cf, 0x6)) goto l_0xb5cf;      /* jnz 0xb5cf */
            ii(0xb5c9, 2);    pushw(0xb);                               /* push 0xb */
            ii(0xb5cb, 3);    callw(0x805d, -0x3571);                   /* call 0x805d */
            ii(0xb5ce, 1);    popw(bx);                                 /* pop bx */
        l_0xb5cf:
            ii(0xb5cf, 3);    mov(ax, memw_a16[ds, 0xf54]);             /* mov ax, [0xf54] */
            ii(0xb5d2, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0xb5d5, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0xb5d8, 3);    mov(memw_a16[ds, 0xa9c], ax);             /* mov [0xa9c], ax */
            ii(0xb5db, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0xb5de, 3);    mov(memw_a16[ds, 0xc14], ax);             /* mov [0xc14], ax */
            ii(0xb5e1, 2);    jmpw(0xb5f6, 0x13); goto l_0xb5f6;        /* jmp 0xb5f6 */
        l_0xb5e3:
            ii(0xb5e3, 2);    pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0xb5e5, 3);    pushw(0xe000);                            /* push 0xe000 */
            ii(0xb5e8, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xb5eb, 4);    add(ax, memw_a16[ds, 0xf54]);             /* add ax, [0xf54] */
            ii(0xb5ef, 1);    pushw(ax);                                /* push ax */
            ii(0xb5f0, 3);    callw(0x7aab, -0x3b48);                   /* call 0x7aab */
            ii(0xb5f3, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0xb5f6:
            ii(0xb5f6, 3);    dec(memw_a16[ss, bp - 0x4]);              /* dec word [bp-0x4] */
            ii(0xb5f9, 2);    if(jnsw(0xb5e3, -0x18)) goto l_0xb5e3;    /* jns 0xb5e3 */
            ii(0xb5fb, 5);    shl(memw_a16[ds, 0xf54], 0x3);            /* shl word [0xf54], 0x3 */
            ii(0xb600, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0xb605, 2);    if(jlw(0xb638, 0x31)) goto l_0xb638;      /* jl 0xb638 */
            ii(0xb607, 3);    mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0xb60a, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xb60d, 1);    pushw(ax);                                /* push ax */
            ii(0xb60e, 3);    callw(0x997c, -0x1c95);                   /* call 0x997c */
            ii(0xb611, 1);    popw(bx);                                 /* pop bx */
            ii(0xb612, 3);    mov(memw_a16[ds, 0xa87], ax);             /* mov [0xa87], ax */
            ii(0xb615, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb617, 2);    if(jzw(0xb638, 0x1f)) goto l_0xb638;      /* jz 0xb638 */
            ii(0xb619, 2);    jmpw(0xb62e, 0x13); goto l_0xb62e;        /* jmp 0xb62e */
        l_0xb61b:
            ii(0xb61b, 2);    pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0xb61d, 3);    pushw(0xd000);                            /* push 0xd000 */
            ii(0xb620, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xb623, 4);    add(ax, memw_a16[ds, 0xa87]);             /* add ax, [0xa87] */
            ii(0xb627, 1);    pushw(ax);                                /* push ax */
            ii(0xb628, 3);    callw(0x7aab, -0x3b80);                   /* call 0x7aab */
            ii(0xb62b, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0xb62e:
            ii(0xb62e, 3);    dec(memw_a16[ss, bp - 0x4]);              /* dec word [bp-0x4] */
            ii(0xb631, 2);    if(jnsw(0xb61b, -0x18)) goto l_0xb61b;    /* jns 0xb61b */
            ii(0xb633, 5);    shl(memw_a16[ds, 0xa87], 0x3);            /* shl word [0xa87], 0x3 */
        l_0xb638:
            ii(0xb638, 3);    callw(0xd420, 0x1de5);                    /* call 0xd420 */
            ii(0xb63b, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0xb640, 2);    if(jzw(0xb658, 0x16)) goto l_0xb658;      /* jz 0xb658 */
            ii(0xb642, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xb645, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xb649, 4);    cmp(memw_a16[ds, 0xac], ax);              /* cmp [0xac], ax */
            ii(0xb64d, 2);    if(jnzw(0xb658, 0x9)) goto l_0xb658;      /* jnz 0xb658 */
            ii(0xb64f, 4);    cmp(memw_a16[ds, 0xae], dx);              /* cmp [0xae], dx */
            ii(0xb653, 2);    if(jnzw(0xb658, 0x3)) goto l_0xb658;      /* jnz 0xb658 */
            ii(0xb655, 3);    callw(0xb190, -0x4c8);                    /* call 0xb190 */
        l_0xb658:
            ii(0xb658, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0xb65d, 2);    if(jnzw(0xb692, 0x33)) goto l_0xb692;     /* jnz 0xb692 */
            ii(0xb65f, 2);    pushw(0x3);                               /* push 0x3 */
            ii(0xb661, 3);    callw(0x997c, -0x1ce8);                   /* call 0x997c */
            ii(0xb664, 1);    popw(bx);                                 /* pop bx */
            ii(0xb665, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xb668, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb66a, 2);    if(jnzw(0xb672, 0x6)) goto l_0xb672;      /* jnz 0xb672 */
            ii(0xb66c, 2);    pushw(0xc);                               /* push 0xc */
            ii(0xb66e, 3);    callw(0x805d, -0x3614);                   /* call 0x805d */
            ii(0xb671, 1);    popw(bx);                                 /* pop bx */
        l_0xb672:
            ii(0xb672, 2);    pushw(0x18);                              /* push 0x18 */
            ii(0xb674, 3);    pushw(0x940);                             /* push 0x940 */
            ii(0xb677, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xb67a, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0xb67d, 3);    mov(memw_a16[ds, 0xd70], ax);             /* mov [0xd70], ax */
            ii(0xb680, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0xb682, 4);    add(ax, memw_a16[ds, 0x98e]);             /* add ax, [0x98e] */
            ii(0xb686, 4);    adc(dx, memw_a16[ds, 0x990]);             /* adc dx, [0x990] */
            ii(0xb68a, 1);    pushw(dx);                                /* push dx */
            ii(0xb68b, 1);    pushw(ax);                                /* push ax */
            ii(0xb68c, 3);    callw(0x6fd2, -0x46bd);                   /* call 0x6fd2 */
            ii(0xb68f, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
        l_0xb692:
            ii(0xb692, 1);    popw(si);                                 /* pop si */
            ii(0xb693, 1);    popw(di);                                 /* pop di */
            ii(0xb694, 1);    leavew();                                 /* leave */
            ii(0xb695, 1);    retw(); return;                           /* ret */
        }
    }
}
