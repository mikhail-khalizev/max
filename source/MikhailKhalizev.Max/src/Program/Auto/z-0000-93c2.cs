using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x93c2-a28034a4")]
        public void Method_0000_93c2()
        {
            ii(0x93c2, 1);    push(bp);                                 /* push bp */
            ii(0x93c3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x93c5, 3);    sub(sp, 0x26);                            /* sub sp, 0x26 */
            ii(0x93c8, 1);    push(di);                                 /* push di */
            ii(0x93c9, 1);    push(si);                                 /* push si */
            ii(0x93ca, 4);    mov(si, memw[ds, 0x1188]);                /* mov si, [0x1188] */
            ii(0x93ce, 3);    mov(memb[ds, si], 0x4d);                  /* mov byte [si], 0x4d */
            ii(0x93d1, 3);    mov(ax, 0x1b);                            /* mov ax, 0x1b */
            ii(0x93d4, 1);    push(ax);                                 /* push ax */
            ii(0x93d5, 3);    lea(ax, si + 0x1);                        /* lea ax, [si+0x1] */
            ii(0x93d8, 1);    push(ax);                                 /* push ax */
            ii(0x93d9, 3);    call(0x95d2, 0x1f6);                      /* call 0x95d2 */
            ii(0x93dc, 1);    pop(bx);                                  /* pop bx */
            ii(0x93dd, 1);    pop(bx);                                  /* pop bx */
            ii(0x93de, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x93e0, 2);    if(jl(0x9438, 0x56)) goto l_0x9438;       /* jl 0x9438 */
            ii(0x93e2, 3);    mov(ax, memw[ds, si + 0x8]);              /* mov ax, [si+0x8] */
            ii(0x93e5, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x93e8, 1);    push(ax);                                 /* push ax */
            ii(0x93e9, 1);    push(ax);                                 /* push ax */
            ii(0x93ea, 3);    call(0x9369, -0x84);                      /* call 0x9369 */
            ii(0x93ed, 1);    pop(bx);                                  /* pop bx */
            ii(0x93ee, 1);    pop(bx);                                  /* pop bx */
            ii(0x93ef, 3);    mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x93f2, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x93f4, 2);    if(jz(0x9438, 0x42)) goto l_0x9438;       /* jz 0x9438 */
            ii(0x93f6, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x93f8, 3);    shl(memw[ss, bp - 0x1a], cl);             /* shl word [bp-0x1a], cl */
            ii(0x93fb, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x93fe, 3);    sub(ax, 0x1c);                            /* sub ax, 0x1c */
            ii(0x9401, 3);    mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x9404, 1);    push(ax);                                 /* push ax */
            ii(0x9405, 3);    mov(cx, memw[ss, bp - 0x1c]);             /* mov cx, [bp-0x1c] */
            ii(0x9408, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x940a, 1);    push(cx);                                 /* push cx */
            ii(0x940b, 1);    push(dx);                                 /* push dx */
            ii(0x940c, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x940e, 3);    call(0x95f3, 0x1e2);                      /* call 0x95f3 */
            ii(0x9411, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x9414, 2);    cmp(ax, di);                              /* cmp ax, di */
            ii(0x9416, 2);    if(jl(0x9438, 0x20)) goto l_0x9438;       /* jl 0x9438 */
            ii(0x9418, 2);    mov(cl, 0x5);                             /* mov cl, 0x5 */
            ii(0x941a, 3);    mov(ax, memw[ds, si + 0x4]);              /* mov ax, [si+0x4] */
            ii(0x941d, 2);    shl(ax, cl);                              /* shl ax, cl */
            ii(0x941f, 3);    mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x9422, 3);    push(memw[ds, si + 0xc]);                 /* push word [si+0xc] */
            ii(0x9425, 3);    add(ax, memw[ds, si + 0xa]);              /* add ax, [si+0xa] */
            ii(0x9428, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x942b, 1);    push(ax);                                 /* push ax */
            ii(0x942c, 3);    call(0x9369, -0xc6);                      /* call 0x9369 */
            ii(0x942f, 1);    pop(bx);                                  /* pop bx */
            ii(0x9430, 1);    pop(bx);                                  /* pop bx */
            ii(0x9431, 3);    mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x9434, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9436, 2);    if(jnz(0x943b, 0x3)) goto l_0x943b;       /* jnz 0x943b */
        l_0x9438:
            ii(0x9438, 3);    jmp(0x9595, 0x15a); goto l_0x9595;        /* jmp 0x9595 */
        l_0x943b:
            ii(0x943b, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x943d, 3);    shl(memw[ss, bp - 0x1e], cl);             /* shl word [bp-0x1e], cl */
            ii(0x9440, 4);    cmp(memw[ds, si + 0x2], 0);               /* cmp word [si+0x2], 0x0 */
            ii(0x9444, 2);    if(jz(0x944f, 0x9)) goto l_0x944f;        /* jz 0x944f */
            ii(0x9446, 3);    mov(ax, memw[ds, si + 0x2]);              /* mov ax, [si+0x2] */
            ii(0x9449, 3);    sub(ax, 0x200);                           /* sub ax, 0x200 */
            ii(0x944c, 3);    add(memw[ss, bp - 0x1e], ax);             /* add [bp-0x1e], ax */
        l_0x944f:
            ii(0x944f, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x9452, 3);    sub(memw[ss, bp - 0x1e], ax);             /* sub [bp-0x1e], ax */
            ii(0x9455, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x9458, 3);    add(ax, 0x10);                            /* add ax, 0x10 */
            ii(0x945b, 2);    sub(cx, cx);                              /* sub cx, cx */
            ii(0x945d, 3);    mov(memw[ss, bp - 0x18], cx);             /* mov [bp-0x18], cx */
            ii(0x9460, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x9463, 3);    push(memw[ss, bp - 0x1e]);                /* push word [bp-0x1e] */
            ii(0x9466, 1);    push(ax);                                 /* push ax */
            ii(0x9467, 1);    push(cx);                                 /* push cx */
            ii(0x9468, 3);    call(0x95f3, 0x188);                      /* call 0x95f3 */
            ii(0x946b, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x946e, 3);    cmp(ax, memw[ss, bp - 0x1e]);             /* cmp ax, [bp-0x1e] */
            ii(0x9471, 2);    if(jge(0x9476, 0x3)) goto l_0x9476;       /* jge 0x9476 */
            ii(0x9473, 3);    jmp(0x9595, 0x11f); goto l_0x9595;        /* jmp 0x9595 */
        l_0x9476:
            ii(0x9476, 4);    mov(memb[ss, bp - 0x13], 0x26);           /* mov byte [bp-0x13], 0x26 */
            ii(0x947a, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x947d, 3);    mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x9480, 3);    lea(cx, bp - 0x14);                       /* lea cx, [bp-0x14] */
            ii(0x9483, 1);    push(cx);                                 /* push cx */
            ii(0x9484, 1);    push(cx);                                 /* push cx */
            ii(0x9485, 3);    call(0x5cc0, -0x37c8);                    /* call 0x5cc0 */
            ii(0x9488, 1);    pop(bx);                                  /* pop bx */
            ii(0x9489, 1);    pop(bx);                                  /* pop bx */
            ii(0x948a, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x948d, 1);    dec(ax);                                  /* dec ax */
            ii(0x948e, 3);    mov(bx, 0x3);                             /* mov bx, 0x3 */
            ii(0x9491, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x9493, 3);    mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x9496, 3);    mov(cx, memw[ss, bp - 0x2]);              /* mov cx, [bp-0x2] */
            ii(0x9499, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x949b, 3);    mov(memw[ss, bp - 0x26], bx);             /* mov [bp-0x26], bx */
            ii(0x949e, 3);    mov(memw[ss, bp - 0x24], cx);             /* mov [bp-0x24], cx */
            ii(0x94a1, 3);    or(bl, 0x2);                              /* or bl, 0x2 */
            ii(0x94a4, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x94a6, 3);    mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x94a9, 3);    mov(ax, memw[ss, bp - 0x26]);             /* mov ax, [bp-0x26] */
            ii(0x94ac, 3);    mov(dx, memw[ss, bp - 0x24]);             /* mov dx, [bp-0x24] */
            ii(0x94af, 2);    or(al, 0x18);                             /* or al, 0x18 */
            ii(0x94b1, 3);    mov(cx, 0x18);                            /* mov cx, 0x18 */
            ii(0x94b4, 4);    mov(bx, memw[ds, 0xcec]);                 /* mov bx, [0xcec] */
            ii(0x94b8, 1);    push(si);                                 /* push si */
            ii(0x94b9, 1);    push(ds);                                 /* push ds */
            ii(0x94ba, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x94bc, 2);    mov(si, cx);                              /* mov si, cx */
            ii(0x94be, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x94c0, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x94c2, 3);    mov(cx, 0xa);                             /* mov cx, 0xa */
            ii(0x94c5, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0x94c7, 1);    pop(ds);                                  /* pop ds */
            ii(0x94c8, 1);    pop(si);                                  /* pop si */
            ii(0x94c9, 3);    mov(ax, memw[ds, si + 0x18]);             /* mov ax, [si+0x18] */
            ii(0x94cc, 3);    sub(ax, 0x1c);                            /* sub ax, 0x1c */
            ii(0x94cf, 3);    mov(cx, memw[ss, bp - 0x1c]);             /* mov cx, [bp-0x1c] */
            ii(0x94d2, 3);    mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x94d5, 3);    mov(memw[ss, bp - 0x4], cx);              /* mov [bp-0x4], cx */
            ii(0x94d8, 3);    mov(ax, memw[ds, si + 0x6]);              /* mov ax, [si+0x6] */
            ii(0x94db, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x94de, 2);    jmp(0x94fb, 0x1b); goto l_0x94fb;         /* jmp 0x94fb */
        l_0x94e0:
            ii(0x94e0, 3);    mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x94e3, 3);    les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x94e6, 4);    mov(cx, memw[es, bx + 0x2]);              /* mov cx, [es:bx+0x2] */
            ii(0x94ea, 3);    mov(bx, memw[es, bx]);                    /* mov bx, [es:bx] */
            ii(0x94ed, 3);    add(bx, memw[ss, bp - 0x18]);             /* add bx, [bp-0x18] */
            ii(0x94f0, 2);    adc(cx, ax);                              /* adc cx, ax */
            ii(0x94f2, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x94f4, 3);    add(memw[es, bx], ax);                    /* add [es:bx], ax */
            ii(0x94f7, 4);    add(memw[ss, bp - 0x6], 0x4);             /* add word [bp-0x6], 0x4 */
        l_0x94fb:
            ii(0x94fb, 3);    dec(memw[ss, bp - 0x1a]);                 /* dec word [bp-0x1a] */
            ii(0x94fe, 2);    if(jns(0x94e0, -0x20)) goto l_0x94e0;     /* jns 0x94e0 */
            ii(0x9500, 5);    mov(memw[ss, bp - 0x20], 0x15e8);         /* mov word [bp-0x20], 0x15e8 */
            ii(0x9505, 3);    lea(ax, si + 0x68);                       /* lea ax, [si+0x68] */
            ii(0x9508, 3);    mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x950b, 2);    jmp(0x9518, 0xb); goto l_0x9518;          /* jmp 0x9518 */
        l_0x950d:
            ii(0x950d, 3);    mov(bx, memw[ss, bp - 0x20]);             /* mov bx, [bp-0x20] */
            ii(0x9510, 3);    inc(memw[ss, bp - 0x20]);                 /* inc word [bp-0x20] */
            ii(0x9513, 3);    cmp(memb[ds, bx], 0);                     /* cmp byte [bx], 0x0 */
            ii(0x9516, 2);    if(jnz(0x950d, -0xb)) goto l_0x950d;      /* jnz 0x950d */
        l_0x9518:
            ii(0x9518, 3);    mov(bx, memw[ss, bp - 0x20]);             /* mov bx, [bp-0x20] */
            ii(0x951b, 2);    mov(ax, memw[ds, bx]);                    /* mov ax, [bx] */
            ii(0x951d, 3);    mov(bx, memw[ss, bp - 0x22]);             /* mov bx, [bp-0x22] */
            ii(0x9520, 4);    add(memw[ss, bp - 0x22], 0x2);            /* add word [bp-0x22], 0x2 */
            ii(0x9524, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x9526, 4);    add(memw[ss, bp - 0x20], 0x2);            /* add word [bp-0x20], 0x2 */
            ii(0x952a, 3);    cmp(memw[ds, bx], -0x1 /* 0xff */);       /* cmp word [bx], 0xffff */
            ii(0x952d, 2);    if(jnz(0x950d, -0x22)) goto l_0x950d;     /* jnz 0x950d */
            ii(0x952f, 3);    lea(ax, bp - 0x1a);                       /* lea ax, [bp-0x1a] */
            ii(0x9532, 1);    push(ax);                                 /* push ax */
            ii(0x9533, 3);    lea(cx, si + 0x68);                       /* lea cx, [si+0x68] */
            ii(0x9536, 1);    push(cx);                                 /* push cx */
            ii(0x9537, 1);    push(si);                                 /* push si */
            ii(0x9538, 3);    push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x953b, 3);    call(0x9ef7, 0x9b9);                      /* call 0x9ef7 */
            ii(0x953e, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x9541, 3);    mov(memw[ss, bp - 0x6], ax);              /* mov [bp-0x6], ax */
            ii(0x9544, 3);    mov(memw[ss, bp - 0x4], dx);              /* mov [bp-0x4], dx */
            ii(0x9547, 3);    push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x954a, 3);    call(0x93a2, -0x1ab);                     /* call 0x93a2 */
            ii(0x954d, 1);    pop(bx);                                  /* pop bx */
            ii(0x954e, 3);    push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x9551, 3);    call(0x93a2, -0x1b2);                     /* call 0x93a2 */
            ii(0x9554, 1);    pop(bx);                                  /* pop bx */
            ii(0x9555, 4);    cmp(memw[ss, bp - 0x4], 0);               /* cmp word [bp-0x4], 0x0 */
            ii(0x9559, 2);    if(jz(0x9595, 0x3a)) goto l_0x9595;       /* jz 0x9595 */
            ii(0x955b, 3);    push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x955e, 5);    call_far_abs(0x1a2, 0xb12);               /* call word 0x1a2:0xb12 */
            ii(0x9563, 1);    pop(bx);                                  /* pop bx */
            ii(0x9564, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9566, 2);    if(jz(0x958e, 0x26)) goto l_0x958e;       /* jz 0x958e */
            ii(0x9568, 3);    push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x956b, 3);    mov(ax, 0x15e8);                          /* mov ax, 0x15e8 */
            ii(0x956e, 1);    push(ax);                                 /* push ax */
            ii(0x956f, 4);    push(memw[ds, 0x9b4]);                    /* push word [0x9b4] */
            ii(0x9573, 3);    push(memw[ss, bp - 0x6]);                 /* push word [bp-0x6] */
            ii(0x9576, 3);    push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x9579, 3);    call(0x96f2, 0x176);                      /* call 0x96f2 */
            ii(0x957c, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x957f, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x9582, 3);    add(ax, 0x15e8);                          /* add ax, 0x15e8 */
            ii(0x9585, 3);    mov(memw[ds, 0xf22], ax);                 /* mov [0xf22], ax */
            ii(0x9588, 1);    inc(ax);                                  /* inc ax */
            ii(0x9589, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x958b, 3);    mov(memw[ds, 0xcde], ax);                 /* mov [0xcde], ax */
        l_0x958e:
            ii(0x958e, 3);    push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x9591, 3);    call(0x93a2, -0x1f2);                     /* call 0x93a2 */
            ii(0x9594, 1);    pop(bx);                                  /* pop bx */
        l_0x9595:
            ii(0x9595, 1);    pop(si);                                  /* pop si */
            ii(0x9596, 1);    pop(di);                                  /* pop di */
            ii(0x9597, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9599, 1);    pop(bp);                                  /* pop bp */
            ii(0x959a, 1);    ret();                                    /* ret */
        }
    }
}
