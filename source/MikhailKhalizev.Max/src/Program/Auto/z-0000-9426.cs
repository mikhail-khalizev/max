using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9426-13213b89")]
        public void Method_0000_9426()
        {
            ii(0x9426, 4);    enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x942a, 1);    push(di);                                 /* push di */
            ii(0x942b, 1);    push(si);                                 /* push si */
            ii(0x942c, 4);    push(memw[ds, 0x120e]);                   /* push word [0x120e] */
            ii(0x9430, 3);    call(0xa4ec, 0x10b9);                     /* call 0xa4ec */
            ii(0x9433, 1);    pop(bx);                                  /* pop bx */
            ii(0x9434, 4);    les(bx, ds, 0xa0);                        /* les bx, [0xa0] */
            ii(0x9438, 4);    mov(cx, memw[es, bx + 0xc]);              /* mov cx, [es:bx+0xc] */
            ii(0x943c, 4);    mov(si, memw[es, bx + 0xe]);              /* mov si, [es:bx+0xe] */
            ii(0x9440, 3);    add(cx, 0x1);                             /* add cx, 0x1 */
            ii(0x9443, 3);    adc(si, 0);                               /* adc si, 0x0 */
            ii(0x9446, 2);    cmp(si, dx);                              /* cmp si, dx */
            ii(0x9448, 2);    if(jg(0x9456, 0xc)) goto l_0x9456;        /* jg 0x9456 */
            ii(0x944a, 2);    if(jl(0x9450, 0x4)) goto l_0x9450;        /* jl 0x9450 */
            ii(0x944c, 2);    cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x944e, 2);    if(jae(0x9456, 0x6)) goto l_0x9456;       /* jae 0x9456 */
        l_0x9450:
            ii(0x9450, 2);    push(0x28);                               /* push 0x28 */
            ii(0x9452, 3);    call(0x604d, -0x3408);                    /* call 0x604d */
            ii(0x9455, 1);    pop(bx);                                  /* pop bx */
        l_0x9456:
            ii(0x9456, 3);    call(0x573a, -0x3d1f);                    /* call 0x573a */
            ii(0x9459, 3);    call(0x3f0c, -0x5550);                    /* call 0x3f0c */
            ii(0x945c, 4);    push(memw[ds, 0x97c]);                    /* push word [0x97c] */
            ii(0x9460, 3);    call(0x4f7d, -0x44e6);                    /* call 0x4f7d */
            ii(0x9463, 1);    pop(bx);                                  /* pop bx */
            ii(0x9464, 3);    mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x9467, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x9469, 1);    push(ax);                                 /* push ax */
            ii(0x946a, 3);    call(0x4f7d, -0x44f0);                    /* call 0x4f7d */
            ii(0x946d, 1);    pop(bx);                                  /* pop bx */
            ii(0x946e, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x9471, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x9474, 3);    add(ax, memw[ss, bp - 0xa]);              /* add ax, [bp-0xa] */
            ii(0x9477, 1);    push(ax);                                 /* push ax */
            ii(0x9478, 5);    cmp(memb[ds, 0x981], 0);                  /* cmp byte [0x981], 0x0 */
            ii(0x947d, 2);    if(jz(0x9484, 0x5)) goto l_0x9484;        /* jz 0x9484 */
            ii(0x947f, 3);    mov(ax, 0x395c);                          /* mov ax, 0x395c */
            ii(0x9482, 2);    jmp(0x9487, 0x3); goto l_0x9487;          /* jmp 0x9487 */
        l_0x9484:
            ii(0x9484, 3);    mov(ax, 0x38af);                          /* mov ax, 0x38af */
        l_0x9487:
            ii(0x9487, 2);    call_abs(ax);                             /* call ax */
            ii(0x9489, 1);    pop(bx);                                  /* pop bx */
            ii(0x948a, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x948c, 3);    call(0x6544, -0x2f4b);                    /* call 0x6544 */
            ii(0x948f, 3);    mov(memw[ds, 0x98e], ax);                 /* mov [0x98e], ax */
            ii(0x9492, 4);    mov(memw[ds, 0x990], dx);                 /* mov [0x990], dx */
            ii(0x9496, 6);    mov(memw[ds, 0x11d4], 0xb);               /* mov word [0x11d4], 0xb */
            ii(0x949c, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x949e, 4);    or(ax, memw[ds, 0x98e]);                  /* or ax, [0x98e] */
            ii(0x94a2, 2);    if(jnz(0x94aa, 0x6)) goto l_0x94aa;       /* jnz 0x94aa */
            ii(0x94a4, 2);    push(0xa);                                /* push 0xa */
            ii(0x94a6, 3);    call(0x604d, -0x345c);                    /* call 0x604d */
            ii(0x94a9, 1);    pop(bx);                                  /* pop bx */
        l_0x94aa:
            ii(0x94aa, 6);    mov(memw[ds, 0x11d4], 0xa);               /* mov word [0x11d4], 0xa */
            ii(0x94b0, 4);    shl(memw[ss, bp - 0xa], 0x4);             /* shl word [bp-0xa], 0x4 */
            ii(0x94b4, 3);    mov(ax, memw[ss, bp - 0xa]);              /* mov ax, [bp-0xa] */
            ii(0x94b7, 1);    dec(ax);                                  /* dec ax */
            ii(0x94b8, 3);    mov(memw[ds, 0x910], ax);                 /* mov [0x910], ax */
            ii(0x94bb, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x94be, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x94c0, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x94c2, 3);    call(0x6544, -0x2f81);                    /* call 0x6544 */
            ii(0x94c5, 4);    add(ax, memw[ds, 0x98e]);                 /* add ax, [0x98e] */
            ii(0x94c9, 4);    adc(dx, memw[ds, 0x990]);                 /* adc dx, [0x990] */
            ii(0x94cd, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x94cf, 3);    mov(memw[ds, 0x912], ax);                 /* mov [0x912], ax */
            ii(0x94d2, 4);    mov(memb[ds, 0x914], bl);                 /* mov [0x914], bl */
            ii(0x94d6, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x94d8, 2);    mov(al, ah);                              /* mov al, ah */
            ii(0x94da, 1);    cbw();                                    /* cbw */
            ii(0x94db, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x94dd, 2);    sub(al, al);                              /* sub al, al */
            ii(0x94df, 3);    mov(memw[ds, 0x916], ax);                 /* mov [0x916], ax */
            ii(0x94e2, 3);    mov(ax, memw[ds, 0x97c]);                 /* mov ax, [0x97c] */
            ii(0x94e5, 3);    mov(memw[ds, 0x938], ax);                 /* mov [0x938], ax */
            ii(0x94e8, 3);    mov(memw[ds, 0x928], ax);                 /* mov [0x928], ax */
            ii(0x94eb, 4);    mov(cx, memw[ds, 0x98e]);                 /* mov cx, [0x98e] */
            ii(0x94ef, 4);    mov(memw[ds, 0x93a], cx);                 /* mov [0x93a], cx */
            ii(0x94f3, 4);    mov(memw[ds, 0x92a], cx);                 /* mov [0x92a], cx */
            ii(0x94f7, 4);    mov(cl, memb[ds, 0x990]);                 /* mov cl, [0x990] */
            ii(0x94fb, 4);    mov(memb[ds, 0x93c], cl);                 /* mov [0x93c], cl */
            ii(0x94ff, 4);    mov(memb[ds, 0x92c], cl);                 /* mov [0x92c], cl */
            ii(0x9503, 3);    mov(al, memb[ds, 0x991]);                 /* mov al, [0x991] */
            ii(0x9506, 1);    cbw();                                    /* cbw */
            ii(0x9507, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x9509, 2);    sub(al, al);                              /* sub al, al */
            ii(0x950b, 3);    mov(memw[ds, 0x93e], ax);                 /* mov [0x93e], ax */
            ii(0x950e, 3);    mov(memw[ds, 0x92e], ax);                 /* mov [0x92e], ax */
            ii(0x9511, 2);    mov(al, 0x92);                            /* mov al, 0x92 */
            ii(0x9513, 3);    mov(memb[ds, 0x915], al);                 /* mov [0x915], al */
            ii(0x9516, 3);    mov(memb[ds, 0x93d], al);                 /* mov [0x93d], al */
            ii(0x9519, 4);    push(memw[ds, 0x97c]);                    /* push word [0x97c] */
            ii(0x951d, 2);    push(0);                                  /* push 0x0 */
            ii(0x951f, 2);    push(0x78);                               /* push 0x78 */
            ii(0x9521, 3);    call(0xa4a1, 0xf7d);                      /* call 0xa4a1 */
            ii(0x9524, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x9527, 3);    mov(ax, memw[ds, 0x8c8]);                 /* mov ax, [0x8c8] */
            ii(0x952a, 1);    inc(ax);                                  /* inc ax */
            ii(0x952b, 1);    push(ax);                                 /* push ax */
            ii(0x952c, 3);    push(0x8c0);                              /* push 0x8c0 */
            ii(0x952f, 4);    push(memw[ds, 0x990]);                    /* push word [0x990] */
            ii(0x9533, 4);    push(memw[ds, 0x98e]);                    /* push word [0x98e] */
            ii(0x9537, 3);    call(0x4fc2, -0x4578);                    /* call 0x4fc2 */
            ii(0x953a, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x953d, 3);    push(0xff);                               /* push 0xff */
            ii(0x9540, 4);    push(memw[ds, 0xcec]);                    /* push word [0xcec] */
            ii(0x9544, 2);    push(0x5);                                /* push 0x5 */
            ii(0x9546, 3);    call(0x5a9b, -0x3aae);                    /* call 0x5a9b */
            ii(0x9549, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x954c, 3);    push(0x7fff);                             /* push 0x7fff */
            ii(0x954f, 4);    push(memw[ds, 0x9b8]);                    /* push word [0x9b8] */
            ii(0x9553, 2);    push(0x6);                                /* push 0x6 */
            ii(0x9555, 3);    call(0x5a9b, -0x3abd);                    /* call 0x5a9b */
            ii(0x9558, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x955b, 2);    push(0x8);                                /* push 0x8 */
            ii(0x955d, 3);    push(0x938);                              /* push 0x938 */
            ii(0x9560, 3);    mov(ax, memw[ds, 0x98e]);                 /* mov ax, [0x98e] */
            ii(0x9563, 4);    mov(dx, memw[ds, 0x990]);                 /* mov dx, [0x990] */
            ii(0x9567, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0x956a, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x956d, 1);    push(dx);                                 /* push dx */
            ii(0x956e, 1);    push(ax);                                 /* push ax */
            ii(0x956f, 3);    call(0x4fc2, -0x45b0);                    /* call 0x4fc2 */
            ii(0x9572, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x9575, 3);    mov(ax, 0x8c8);                           /* mov ax, 0x8c8 */
            ii(0x9578, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x957a, 3);    mov(si, 0x938);                           /* mov si, 0x938 */
            ii(0x957d, 1);    push(ds);                                 /* push ds */
            ii(0x957e, 1);    pop(es);                                  /* pop es */
            ii(0x957f, 1);    movsw();                                  /* movsw */
            ii(0x9580, 1);    movsw();                                  /* movsw */
            ii(0x9581, 1);    movsw();                                  /* movsw */
            ii(0x9582, 1);    movsw();                                  /* movsw */
            ii(0x9583, 3);    mov(ax, memw[ds, 0x98e]);                 /* mov ax, [0x98e] */
            ii(0x9586, 4);    mov(dx, memw[ds, 0x990]);                 /* mov dx, [0x990] */
            ii(0x958a, 3);    mov(memw[ds, 0x976], ax);                 /* mov [0x976], ax */
            ii(0x958d, 4);    mov(memw[ds, 0x978], dx);                 /* mov [0x978], dx */
            ii(0x9591, 3);    mov(ax, memw[ds, 0x97c]);                 /* mov ax, [0x97c] */
            ii(0x9594, 3);    mov(memw[ds, 0x974], ax);                 /* mov [0x974], ax */
            ii(0x9597, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0x959a, 2);    push(0);                                  /* push 0x0 */
            ii(0x959c, 2);    push(0x50);                               /* push 0x50 */
            ii(0x959e, 3);    call(0xa4a1, 0xf00);                      /* call 0xa4a1 */
            ii(0x95a1, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x95a4, 3);    call(0x6d67, -0x2840);                    /* call 0x6d67 */
            ii(0x95a7, 3);    mov(ax, 0x1c);                            /* mov ax, 0x1c */
            ii(0x95aa, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x95ad, 1);    push(ax);                                 /* push ax */
            ii(0x95ae, 3);    call(0x796c, -0x1c45);                    /* call 0x796c */
            ii(0x95b1, 1);    pop(bx);                                  /* pop bx */
            ii(0x95b2, 3);    mov(memw[ds, 0xf54], ax);                 /* mov [0xf54], ax */
            ii(0x95b5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x95b7, 2);    if(jnz(0x95bf, 0x6)) goto l_0x95bf;       /* jnz 0x95bf */
            ii(0x95b9, 2);    push(0xb);                                /* push 0xb */
            ii(0x95bb, 3);    call(0x604d, -0x3571);                    /* call 0x604d */
            ii(0x95be, 1);    pop(bx);                                  /* pop bx */
        l_0x95bf:
            ii(0x95bf, 3);    mov(ax, memw[ds, 0xf54]);                 /* mov ax, [0xf54] */
            ii(0x95c2, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0x95c5, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x95c8, 3);    mov(memw[ds, 0xa9c], ax);                 /* mov [0xa9c], ax */
            ii(0x95cb, 3);    add(ax, 0x8);                             /* add ax, 0x8 */
            ii(0x95ce, 3);    mov(memw[ds, 0xc14], ax);                 /* mov [0xc14], ax */
            ii(0x95d1, 2);    jmp(0x95e6, 0x13); goto l_0x95e6;         /* jmp 0x95e6 */
        l_0x95d3:
            ii(0x95d3, 2);    push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0x95d5, 3);    push(0xe000);                             /* push 0xe000 */
            ii(0x95d8, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x95db, 4);    add(ax, memw[ds, 0xf54]);                 /* add ax, [0xf54] */
            ii(0x95df, 1);    push(ax);                                 /* push ax */
            ii(0x95e0, 3);    call(0x5a9b, -0x3b48);                    /* call 0x5a9b */
            ii(0x95e3, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x95e6:
            ii(0x95e6, 3);    dec(memw[ss, bp - 0x4]);                  /* dec word [bp-0x4] */
            ii(0x95e9, 2);    if(jns(0x95d3, -0x18)) goto l_0x95d3;     /* jns 0x95d3 */
            ii(0x95eb, 5);    shl(memw[ds, 0xf54], 0x3);                /* shl word [0xf54], 0x3 */
            ii(0x95f0, 5);    cmp(memb[ds, 0x2f], 0x3);                 /* cmp byte [0x2f], 0x3 */
            ii(0x95f5, 2);    if(jl(0x9628, 0x31)) goto l_0x9628;       /* jl 0x9628 */
            ii(0x95f7, 3);    mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0x95fa, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x95fd, 1);    push(ax);                                 /* push ax */
            ii(0x95fe, 3);    call(0x796c, -0x1c95);                    /* call 0x796c */
            ii(0x9601, 1);    pop(bx);                                  /* pop bx */
            ii(0x9602, 3);    mov(memw[ds, 0xa87], ax);                 /* mov [0xa87], ax */
            ii(0x9605, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9607, 2);    if(jz(0x9628, 0x1f)) goto l_0x9628;       /* jz 0x9628 */
            ii(0x9609, 2);    jmp(0x961e, 0x13); goto l_0x961e;         /* jmp 0x961e */
        l_0x960b:
            ii(0x960b, 2);    push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0x960d, 3);    push(0xd000);                             /* push 0xd000 */
            ii(0x9610, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x9613, 4);    add(ax, memw[ds, 0xa87]);                 /* add ax, [0xa87] */
            ii(0x9617, 1);    push(ax);                                 /* push ax */
            ii(0x9618, 3);    call(0x5a9b, -0x3b80);                    /* call 0x5a9b */
            ii(0x961b, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x961e:
            ii(0x961e, 3);    dec(memw[ss, bp - 0x4]);                  /* dec word [bp-0x4] */
            ii(0x9621, 2);    if(jns(0x960b, -0x18)) goto l_0x960b;     /* jns 0x960b */
            ii(0x9623, 5);    shl(memw[ds, 0xa87], 0x3);                /* shl word [0xa87], 0x3 */
        l_0x9628:
            ii(0x9628, 3);    call(0xb410, 0x1de5);                     /* call 0xb410 */
            ii(0x962b, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x9630, 2);    if(jz(0x9648, 0x16)) goto l_0x9648;       /* jz 0x9648 */
            ii(0x9632, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0x9635, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0x9639, 4);    cmp(memw[ds, 0xac], ax);                  /* cmp [0xac], ax */
            ii(0x963d, 2);    if(jnz(0x9648, 0x9)) goto l_0x9648;       /* jnz 0x9648 */
            ii(0x963f, 4);    cmp(memw[ds, 0xae], dx);                  /* cmp [0xae], dx */
            ii(0x9643, 2);    if(jnz(0x9648, 0x3)) goto l_0x9648;       /* jnz 0x9648 */
            ii(0x9645, 3);    call(0x9180, -0x4c8);                     /* call 0x9180 */
        l_0x9648:
            ii(0x9648, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x964d, 2);    if(jnz(0x9682, 0x33)) goto l_0x9682;      /* jnz 0x9682 */
            ii(0x964f, 2);    push(0x3);                                /* push 0x3 */
            ii(0x9651, 3);    call(0x796c, -0x1ce8);                    /* call 0x796c */
            ii(0x9654, 1);    pop(bx);                                  /* pop bx */
            ii(0x9655, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x9658, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x965a, 2);    if(jnz(0x9662, 0x6)) goto l_0x9662;       /* jnz 0x9662 */
            ii(0x965c, 2);    push(0xc);                                /* push 0xc */
            ii(0x965e, 3);    call(0x604d, -0x3614);                    /* call 0x604d */
            ii(0x9661, 1);    pop(bx);                                  /* pop bx */
        l_0x9662:
            ii(0x9662, 2);    push(0x18);                               /* push 0x18 */
            ii(0x9664, 3);    push(0x940);                              /* push 0x940 */
            ii(0x9667, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x966a, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x966d, 3);    mov(memw[ds, 0xd70], ax);                 /* mov [0xd70], ax */
            ii(0x9670, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x9672, 4);    add(ax, memw[ds, 0x98e]);                 /* add ax, [0x98e] */
            ii(0x9676, 4);    adc(dx, memw[ds, 0x990]);                 /* adc dx, [0x990] */
            ii(0x967a, 1);    push(dx);                                 /* push dx */
            ii(0x967b, 1);    push(ax);                                 /* push ax */
            ii(0x967c, 3);    call(0x4fc2, -0x46bd);                    /* call 0x4fc2 */
            ii(0x967f, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x9682:
            ii(0x9682, 1);    pop(si);                                  /* pop si */
            ii(0x9683, 1);    pop(di);                                  /* pop di */
            ii(0x9684, 1);    leave();                                  /* leave */
            ii(0x9685, 1);    ret();                                    /* ret */
        }
    }
}
