using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb030-22e06c12")]
        public void Method_0000_b030()
        {
            ii(0xb030, 3);    sub(sp, 0x54);                            /* sub sp, 0x54 */
            ii(0xb033, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xb035, 4);    mov(memw[ds, 0xf50], sp);                 /* mov [0xf50], sp */
            ii(0xb039, 4);    sub(sp, 0x80);                            /* sub sp, 0x80 */
            ii(0xb03d, 3);    call(0x6af2, -0x454e);                    /* call 0x6af2 */
            ii(0xb040, 3);    call(0x7726, -0x391d);                    /* call 0x7726 */
            ii(0xb043, 3);    push(0x810);                              /* push 0x810 */
            ii(0xb046, 5);    call_far_abs(0x1a2, 0xb12);               /* call word 0x1a2:0xb12 */
            ii(0xb04b, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xb04c, 2);    if(jcxz(0xb0bd, 0x6f)) goto l_0xb0bd;     /* jcxz 0xb0bd */
            ii(0xb04e, 3);    call(0x61de, -0x4e73);                    /* call 0x61de */
            ii(0xb051, 3);    add(ax, 0x800);                           /* add ax, 0x800 */
            ii(0xb054, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0xb056, 3);    mov(memw[ds, 0xc4a], ax);                 /* mov [0xc4a], ax */
            ii(0xb059, 5);    cmp(memb[ds, 0xc44], 0);                  /* cmp byte [0xc44], 0x0 */
            ii(0xb05e, 2);    if(jnz(0xb06e, 0xe)) goto l_0xb06e;       /* jnz 0xb06e */
            ii(0xb060, 3);    mov(ax, 0xbf02);                          /* mov ax, 0xbf02 */
            ii(0xb063, 2);    xor(si, si);                              /* xor si, si */
            ii(0xb065, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xb067, 3);    call(0x4c94, -0x63d6);                    /* call 0x4c94 */
            ii(0xb06a, 2);    or(si, dx);                               /* or si, dx */
            ii(0xb06c, 2);    if(jnz_func(0xb02b, -0x43)) return;       /* jnz 0xb02b */
        l_0xb06e:
            ii(0xb06e, 2);    mov(ah, 0x35);                            /* mov ah, 0x35 */
            ii(0xb070, 3);    mov(al, memb[ds, 0x34]);                  /* mov al, [0x34] */
            ii(0xb073, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xb075, 1);    push(cs);                                 /* push cs */
            ii(0xb076, 1);    pop(ds);                                  /* pop ds */
            ii(0xb077, 4);    mov(memw[ds, 0x12c4], bx);                /* mov [0x12c4], bx */
            ii(0xb07b, 4);    mov(memw[ds, 0x12c6], es);                /* mov [0x12c6], es */
            ii(0xb07f, 3);    mov(dx, 0x7273);                          /* mov dx, 0x7273 */
            ii(0xb082, 2);    mov(ah, 0x25);                            /* mov ah, 0x25 */
            ii(0xb084, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xb086, 1);    push(ss);                                 /* push ss */
            ii(0xb087, 1);    pop(ds);                                  /* pop ds */
            ii(0xb088, 6);    mov(memw[ds, 0xac2], 0x7322);             /* mov word [0xac2], 0x7322 */
            ii(0xb08e, 3);    call(0xabc0, -0x4d1);                     /* call 0xabc0 */
            ii(0xb091, 1);    push(bp);                                 /* push bp */
            ii(0xb092, 3);    call(0x88d7, -0x27be);                    /* call 0x88d7 */
            ii(0xb095, 3);    call(0x6b2b, -0x456d);                    /* call 0x6b2b */
            ii(0xb098, 3);    mov(es, memw[ss, bp + 2]);                /* mov es, [bp+0x2] */
            ii(0xb09b, 3);    mov(di, memw[ss, bp + 14]);               /* mov di, [bp+0xe] */
            ii(0xb09e, 3);    mov(ax, memw[ss, bp + 30]);               /* mov ax, [bp+0x1e] */
            ii(0xb0a1, 1);    stosw();                                  /* stosw */
            ii(0xb0a2, 3);    mov(ax, memw[ss, bp + 34]);               /* mov ax, [bp+0x22] */
            ii(0xb0a5, 1);    stosw();                                  /* stosw */
            ii(0xb0a6, 3);    mov(ax, memw[ss, bp + 38]);               /* mov ax, [bp+0x26] */
            ii(0xb0a9, 1);    stosw();                                  /* stosw */
            ii(0xb0aa, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0xb0ad, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0xb0af, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0xb0b1, 3);    lea(sp, memw[ds, di - 6]);                /* lea sp, [di-0x6] */
            ii(0xb0b4, 4);    mov(memw[ds, 0xf50], bp);                 /* mov [0xf50], bp */
            ii(0xb0b8, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xb0ba, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xb0bc, 1);    iretw(); return;                          /* iretw */
        l_0xb0bd:
            ii(0xb0bd, 2);    push(0xd);                                /* push 0xd */
            ii(0xb0bf, 3);    call(0x604d, -0x5075);                    /* call 0x604d */
            ii(0xb0c2, 3);    call(0x514d, -0x5f78);                    /* call 0x514d */
            ii(0xb0c5, 1);    pop(cx);                                  /* pop cx */
            ii(0xb0c6, 1);    pop(ax);                                  /* pop ax */
            ii(0xb0c7, 2);    mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0xb0c9, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xb0cb, 3);    call(0xa877, -0x857);                     /* call 0xa877 */
            ii(0xb0ce, 6);    adc(memw[ds, bx + si], 0);                /* adc word [bx+si], 0x0 */
            ii(0xb0d4, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0d6, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0d8, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0da, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0dc, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0de, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0e0, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0e2, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0e4, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0e6, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0e8, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0ea, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0ec, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0ee, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0f0, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0f2, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0f4, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0f6, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0f8, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0fa, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0fc, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb0fe, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb100, 2);    add(memb[ds, bx + si], al);               /* add [bx+si], al */
            ii(0xb102, 2);    xchg(bx, bx);                             /* xchg bx, bx */
            ii(0xb104, 1);    push(bp);                                 /* push bp */
            ii(0xb105, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xb107, 1);    push(si);                                 /* push si */
            ii(0xb108, 2);    push(edi);                                /* push edi */
            ii(0xb10a, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xb10d, 1);    push(ds);                                 /* push ds */
            ii(0xb10e, 1);    push(es);                                 /* push es */
            ii(0xb10f, 1);    pushfw();                                 /* pushfw */
            ii(0xb110, 1);    cli();                                    /* cli */
            ii(0xb111, 5);    mov(es, memw[cs, 0x208e]);                /* mov es, [cs:0x208e] */
            ii(0xb116, 5);    mov(di, memw[es, 0xc4a]);                 /* mov di, [es:0xc4a] */
            ii(0xb11b, 7);    sub(memw[es, 0xc4a], 0x200);              /* sub word [es:0xc4a], 0x200 */
            ii(0xb122, 3);    sub(di, 0x32);                            /* sub di, 0x32 */
            ii(0xb125, 1);    push(di);                                 /* push di */
            ii(0xb126, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xb128, 1);    cld();                                    /* cld */
            ii(0xb129, 3);    lds(si, memw[ss, bp + 8]);                /* lds si, [bp+0x8] */
            ii(0xb12c, 1);    push(si);                                 /* push si */
            ii(0xb12d, 3);    add(si, 4);                               /* add si, 0x4 */
            ii(0xb130, 3);    mov(cx, 8);                               /* mov cx, 0x8 */
        l_0xb133:
            ii(0xb133, 1);    movsw();                                  /* movsw */
            ii(0xb134, 1);    stosw();                                  /* stosw */
            ii(0xb135, 2);    if(loop(0xb133, -4)) goto l_0xb133;       /* loop 0xb133 */
            ii(0xb137, 1);    stosw();                                  /* stosw */
            ii(0xb138, 1);    pop(si);                                  /* pop si */
            ii(0xb139, 1);    lodsw();                                  /* lodsw */
            ii(0xb13a, 1);    movsw();                                  /* movsw */
            ii(0xb13b, 1);    stosw();                                  /* stosw */
            ii(0xb13c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xb13e, 1);    stosw();                                  /* stosw */
            ii(0xb13f, 1);    stosw();                                  /* stosw */
            ii(0xb140, 5);    mov(ds, memw[cs, 0x208e]);                /* mov ds, [cs:0x208e] */
            ii(0xb145, 3);    mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0xb148, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0xb14a, 3);    shl(si, 2);                               /* shl si, 0x2 */
            ii(0xb14d, 4);    mov(dx, memw[ds, 0xc2e]);                 /* mov dx, [0xc2e] */
            ii(0xb151, 3);    sub(ax, 8);                               /* sub ax, 0x8 */
            ii(0xb154, 3);    cmp(ax, 0x26);                            /* cmp ax, 0x26 */
            ii(0xb157, 2);    if(ja(0xb168, 0xf)) goto l_0xb168;        /* ja 0xb168 */
            ii(0xb159, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xb15b, 5);    cmp(memb[ds, bx + 0x10c6], 0);            /* cmp byte [bx+0x10c6], 0x0 */
            ii(0xb160, 2);    if(jz(0xb168, 6)) goto l_0xb168;          /* jz 0xb168 */
            ii(0xb162, 4);    add(si, 0xf6a);                           /* add si, 0xf6a */
            ii(0xb166, 2);    mov(dx, ds);                              /* mov dx, ds */
        l_0xb168:
            ii(0xb168, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xb16a, 1);    movsw();                                  /* movsw */
            ii(0xb16b, 1);    movsw();                                  /* movsw */
            ii(0xb16c, 1);    pop(ax);                                  /* pop ax */
            ii(0xb16d, 1);    stosw();                                  /* stosw */
            ii(0xb16e, 3);    mov(ax, 0x1a2);                           /* mov ax, 0x1a2 */
            ii(0xb171, 1);    stosw();                                  /* stosw */
            ii(0xb172, 3);    sub(di, 0x32);                            /* sub di, 0x32 */
            ii(0xb175, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0xb177, 3);    mov(ax, 0x302);                           /* mov ax, 0x302 */
            ii(0xb17a, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xb17c, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xb17f, 2);    if(jb(0xb1a4, 0x23)) goto l_0xb1a4;       /* jb 0xb1a4 */
            ii(0xb181, 5);    mov(ds, memw[cs, 0x208e]);                /* mov ds, [cs:0x208e] */
            ii(0xb186, 4);    mov(si, memw[ds, 0xc4a]);                 /* mov si, [0xc4a] */
            ii(0xb18a, 4);    add(si, 0x1ce);                           /* add si, 0x1ce */
            ii(0xb18e, 3);    les(di, memw[ss, bp + 12]);               /* les di, [bp+0xc] */
            ii(0xb191, 3);    mov(ax, memw[ds, si + 36]);               /* mov ax, [si+0x24] */
            ii(0xb194, 1);    stosw();                                  /* stosw */
            ii(0xb195, 3);    mov(ax, memw[ds, si + 34]);               /* mov ax, [si+0x22] */
            ii(0xb198, 1);    stosw();                                  /* stosw */
            ii(0xb199, 3);    mov(ax, memw[ds, si + 32]);               /* mov ax, [si+0x20] */
            ii(0xb19c, 3);    mov(cx, 8);                               /* mov cx, 0x8 */
        l_0xb19f:
            ii(0xb19f, 1);    movsw();                                  /* movsw */
            ii(0xb1a0, 1);    inc(si);                                  /* inc si */
            ii(0xb1a1, 1);    inc(si);                                  /* inc si */
            ii(0xb1a2, 2);    if(loop(0xb19f, -5)) goto l_0xb19f;       /* loop 0xb19f */
        l_0xb1a4:
            ii(0xb1a4, 6);    add(memw[ds, 0xc4a], 0x200);              /* add word [0xc4a], 0x200 */
            ii(0xb1aa, 1);    pop(cx);                                  /* pop cx */
            ii(0xb1ab, 4);    and(cx, 0x200);                           /* and cx, 0x200 */
            ii(0xb1af, 2);    if(jcxz(0xb1b2, 1)) goto l_0xb1b2;        /* jcxz 0xb1b2 */
            ii(0xb1b1, 1);    sti();                                    /* sti */
        l_0xb1b2:
            ii(0xb1b2, 1);    pop(es);                                  /* pop es */
            ii(0xb1b3, 1);    pop(ds);                                  /* pop ds */
            ii(0xb1b4, 2);    pop(edi);                                 /* pop edi */
            ii(0xb1b6, 1);    pop(si);                                  /* pop si */
            ii(0xb1b7, 1);    pop(bp);                                  /* pop bp */
            ii(0xb1b8, 1);    retf();                                   /* retf */
        }
    }
}
