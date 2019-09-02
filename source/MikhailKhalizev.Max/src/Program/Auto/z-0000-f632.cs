using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xf632-2f65ab06")]
        public void Method_0000_f632()
        {
            ii(0xf632, 4);    enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0xf636, 5);    cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0xf63b, 2);    if(jz(0xf678, 0x3b)) goto l_0xf678;       /* jz 0xf678 */
            ii(0xf63d, 5);    cmp(memb[ds, 0xa16], 0);                  /* cmp byte [0xa16], 0x0 */
            ii(0xf642, 2);    if(jnz(0xf678, 0x34)) goto l_0xf678;      /* jnz 0xf678 */
            ii(0xf644, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xf647, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xf64b, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0xf64e, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0xf651, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xf656, 2);    if(jnz(0xf661, 9)) goto l_0xf661;         /* jnz 0xf661 */
        l_0xf658:
            ii(0xf658, 3);    mov(ax, memw[ds, 0xaa8]);                 /* mov ax, [0xaa8] */
            ii(0xf65b, 4);    mov(dx, memw[ds, 0xaaa]);                 /* mov dx, [0xaaa] */
            ii(0xf65f, 1);    leave();                                  /* leave */
            ii(0xf660, 1);    ret(); return;                            /* ret */
        l_0xf661:
            ii(0xf661, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0xf664, 3);    mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0xf667, 4);    sub(ax, memw[ds, 0x98]);                  /* sub ax, [0x98] */
            ii(0xf66b, 4);    sbb(dx, memw[ds, 0x9a]);                  /* sbb dx, [0x9a] */
            ii(0xf66f, 1);    push(dx);                                 /* push dx */
            ii(0xf670, 1);    push(ax);                                 /* push ax */
            ii(0xf671, 3);    call(0xfb97, 0x523);                      /* call 0xfb97 */
            ii(0xf674, 1);    pop(bx);                                  /* pop bx */
            ii(0xf675, 1);    pop(bx);                                  /* pop bx */
            ii(0xf676, 1);    leave();                                  /* leave */
            ii(0xf677, 1);    ret(); return;                            /* ret */
        l_0xf678:
            ii(0xf678, 5);    mov(memw[ss, bp - 0x14], 3);              /* mov word [bp-0x14], 0x3 */
        l_0xf67d:
            ii(0xf67d, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0xf680, 3);    mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0xf683, 4);    sub(ax, memw[ds, 0xaa8]);                 /* sub ax, [0xaa8] */
            ii(0xf687, 4);    sbb(dx, memw[ds, 0xaaa]);                 /* sbb dx, [0xaaa] */
            ii(0xf68b, 3);    add(ax, 0xfff);                           /* add ax, 0xfff */
            ii(0xf68e, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xf691, 3);    and(ax, 0xf000);                          /* and ax, 0xf000 */
            ii(0xf694, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0xf697, 3);    mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0xf69a, 5);    mov(memw[ss, bp - 0xe], 3);               /* mov word [bp-0xe], 0x3 */
        l_0xf69f:
            ii(0xf69f, 4);    call_abs(memw[ds, 0xaa4]);                /* call word [0xaa4] */
            ii(0xf6a3, 3);    mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0xf6a6, 3);    mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0xf6a9, 3);    cmp(dx, memw[ss, bp - 0xa]);              /* cmp dx, [bp-0xa] */
            ii(0xf6ac, 2);    if(jg(0xf6c1, 0x13)) goto l_0xf6c1;       /* jg 0xf6c1 */
            ii(0xf6ae, 2);    if(jl(0xf6b5, 5)) goto l_0xf6b5;          /* jl 0xf6b5 */
            ii(0xf6b0, 3);    cmp(ax, memw[ss, bp - 0xc]);              /* cmp ax, [bp-0xc] */
            ii(0xf6b3, 2);    if(jae(0xf6c1, 0xc)) goto l_0xf6c1;       /* jae 0xf6c1 */
        l_0xf6b5:
            ii(0xf6b5, 4);    cmp(memw[ss, bp + 8], 0);                 /* cmp word [bp+0x8], 0x0 */
            ii(0xf6b9, 2);    if(jnz(0xf658, -0x63)) goto l_0xf658;     /* jnz 0xf658 */
            ii(0xf6bb, 3);    mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0xf6be, 3);    mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
        l_0xf6c1:
            ii(0xf6c1, 4);    cmp(memw[ss, bp - 0xa], 0);               /* cmp word [bp-0xa], 0x0 */
            ii(0xf6c5, 2);    if(jg(0xf6cf, 8)) goto l_0xf6cf;          /* jg 0xf6cf */
            ii(0xf6c7, 2);    if(jl(0xf658, -0x71)) goto l_0xf658;      /* jl 0xf658 */
            ii(0xf6c9, 4);    cmp(memw[ss, bp - 0xc], 0);               /* cmp word [bp-0xc], 0x0 */
            ii(0xf6cd, 2);    if(jz(0xf658, -0x77)) goto l_0xf658;      /* jz 0xf658 */
        l_0xf6cf:
            ii(0xf6cf, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0xf6d2, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0xf6d5, 4);    call_abs(memw[ds, 0xaa6]);                /* call word [0xaa6] */
            ii(0xf6d9, 1);    pop(bx);                                  /* pop bx */
            ii(0xf6da, 1);    pop(bx);                                  /* pop bx */
            ii(0xf6db, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0xf6de, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0xf6e1, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xf6e3, 2);    if(jnz(0xf6fb, 0x16)) goto l_0xf6fb;      /* jnz 0xf6fb */
            ii(0xf6e5, 4);    cmp(memw[ss, bp + 8], 0);                 /* cmp word [bp+0x8], 0x0 */
            ii(0xf6e9, 2);    if(jz(0xf6f3, 8)) goto l_0xf6f3;          /* jz 0xf6f3 */
            ii(0xf6eb, 3);    dec(memw[ss, bp - 0xe]);                  /* dec word [bp-0xe] */
            ii(0xf6ee, 2);    if(jns(0xf6f3, 3)) goto l_0xf6f3;         /* jns 0xf6f3 */
            ii(0xf6f0, 3);    jmp(0xf658, -0x9b); goto l_0xf658;        /* jmp 0xf658 */
        l_0xf6f3:
            ii(0xf6f3, 3);    sar(memw[ss, bp - 0xa], 1);               /* sar word [bp-0xa], 1 */
            ii(0xf6f6, 3);    rcr(memw[ss, bp - 0xc], 1);               /* rcr word [bp-0xc], 1 */
            ii(0xf6f9, 2);    jmp(0xf69f, -0x5c); goto l_0xf69f;        /* jmp 0xf69f */
        l_0xf6fb:
            ii(0xf6fb, 3);    push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0xf6fe, 1);    push(ax);                                 /* push ax */
            ii(0xf6ff, 3);    call(0xfb7c, 0x47a);                      /* call 0xfb7c */
            ii(0xf702, 1);    pop(bx);                                  /* pop bx */
            ii(0xf703, 1);    pop(bx);                                  /* pop bx */
            ii(0xf704, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0xf707, 3);    mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0xf70a, 1);    cli();                                    /* cli */
            ii(0xf70b, 3);    mov(ax, memw[ss, bp - 0x12]);             /* mov ax, [bp-0x12] */
            ii(0xf70e, 3);    mov(dx, memw[ss, bp - 0x10]);             /* mov dx, [bp-0x10] */
            ii(0xf711, 4);    cmp(memw[ds, 0x9a], dx);                  /* cmp [0x9a], dx */
            ii(0xf715, 2);    if(ja(0xf728, 0x11)) goto l_0xf728;       /* ja 0xf728 */
            ii(0xf717, 2);    if(jb(0xf71f, 6)) goto l_0xf71f;          /* jb 0xf71f */
            ii(0xf719, 4);    cmp(memw[ds, 0x98], ax);                  /* cmp [0x98], ax */
            ii(0xf71d, 2);    if(ja(0xf728, 9)) goto l_0xf728;          /* ja 0xf728 */
        l_0xf71f:
            ii(0xf71f, 3);    mov(ax, memw[ds, 0x9a]);                  /* mov ax, [0x9a] */
            ii(0xf722, 4);    or(ax, memw[ds, 0x98]);                   /* or ax, [0x98] */
            ii(0xf726, 2);    if(jnz(0xf774, 0x4c)) goto l_0xf774;      /* jnz 0xf774 */
        l_0xf728:
            ii(0xf728, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xf72b, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xf72f, 3);    mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0xf732, 3);    mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0xf735, 3);    mov(ax, memw[ss, bp - 0x12]);             /* mov ax, [bp-0x12] */
            ii(0xf738, 3);    mov(dx, memw[ss, bp - 0x10]);             /* mov dx, [bp-0x10] */
            ii(0xf73b, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0xf73e, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
            ii(0xf742, 3);    push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0xf745, 3);    push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0xf748, 2);    push(0);                                  /* push 0x0 */
            ii(0xf74a, 1);    push(dx);                                 /* push dx */
            ii(0xf74b, 1);    push(ax);                                 /* push ax */
            ii(0xf74c, 3);    call(0xfb27, 0x3d8);                      /* call 0xfb27 */
            ii(0xf74f, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xf752, 2);    push(0);                                  /* push 0x0 */
            ii(0xf754, 2);    push(0);                                  /* push 0x0 */
            ii(0xf756, 2);    push(4);                                  /* push 0x4 */
            ii(0xf758, 3);    push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0xf75b, 3);    push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0xf75e, 3);    call(0xfb27, 0x3c6);                      /* call 0xfb27 */
            ii(0xf761, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xf764, 4);    add(memw[ss, bp - 0x12], 1);              /* add word [bp-0x12], 0x1 */
            ii(0xf768, 4);    adc(memw[ss, bp - 0x10], 0);              /* adc word [bp-0x10], 0x0 */
            ii(0xf76c, 4);    sub(memw[ss, bp - 0xc], 0x10);            /* sub word [bp-0xc], 0x10 */
            ii(0xf770, 4);    sbb(memw[ss, bp - 0xa], 0);               /* sbb word [bp-0xa], 0x0 */
        l_0xf774:
            ii(0xf774, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0xf777, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0xf77a, 3);    call(0xfb7c, 0x3ff);                      /* call 0xfb7c */
            ii(0xf77d, 1);    pop(bx);                                  /* pop bx */
            ii(0xf77e, 1);    pop(bx);                                  /* pop bx */
            ii(0xf77f, 3);    add(ax, memw[ss, bp - 0x12]);             /* add ax, [bp-0x12] */
            ii(0xf782, 3);    adc(dx, memw[ss, bp - 0x10]);             /* adc dx, [bp-0x10] */
            ii(0xf785, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0xf788, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0xf78b, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0xf78f, 2);    if(ja(0xf7a0, 0xf)) goto l_0xf7a0;        /* ja 0xf7a0 */
            ii(0xf791, 2);    if(jb(0xf799, 6)) goto l_0xf799;          /* jb 0xf799 */
            ii(0xf793, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0xf797, 2);    if(jae(0xf7a0, 7)) goto l_0xf7a0;         /* jae 0xf7a0 */
        l_0xf799:
            ii(0xf799, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0xf79c, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0xf7a0:
            ii(0xf7a0, 3);    push(memw[ss, bp - 0xa]);                 /* push word [bp-0xa] */
            ii(0xf7a3, 3);    push(memw[ss, bp - 0xc]);                 /* push word [bp-0xc] */
            ii(0xf7a6, 3);    call(0xfb7c, 0x3d3);                      /* call 0xfb7c */
            ii(0xf7a9, 1);    pop(bx);                                  /* pop bx */
            ii(0xf7aa, 1);    pop(bx);                                  /* pop bx */
            ii(0xf7ab, 1);    push(dx);                                 /* push dx */
            ii(0xf7ac, 1);    push(ax);                                 /* push ax */
            ii(0xf7ad, 3);    push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0xf7b0, 3);    push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0xf7b3, 3);    call(0xdfd0, -0x17e6);                    /* call 0xdfd0 */
            ii(0xf7b6, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0xf7b9, 5);    cmp(memb[ds, 0x2e], 0);                   /* cmp byte [0x2e], 0x0 */
            ii(0xf7be, 2);    if(jnz(0xf7d1, 0x11)) goto l_0xf7d1;      /* jnz 0xf7d1 */
            ii(0xf7c0, 4);    push(memw[ds, 0x1204]);                   /* push word [0x1204] */
            ii(0xf7c4, 4);    push(memw[ds, 0x1202]);                   /* push word [0x1202] */
            ii(0xf7c8, 3);    push(memw[ss, bp - 0x10]);                /* push word [bp-0x10] */
            ii(0xf7cb, 3);    push(memw[ss, bp - 0x12]);                /* push word [bp-0x12] */
            ii(0xf7ce, 3);    call(0xe3f6, -0x13db);                    /* call 0xe3f6 */
        l_0xf7d1:
            ii(0xf7d1, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xf7d6, 2);    if(jz(0xf7e6, 0xe)) goto l_0xf7e6;        /* jz 0xf7e6 */
            ii(0xf7d8, 3);    mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0xf7db, 3);    mov(dx, memw[ss, bp - 0xa]);              /* mov dx, [bp-0xa] */
            ii(0xf7de, 4);    add(memw[ds, 0xaa8], ax);                 /* add [0xaa8], ax */
            ii(0xf7e2, 4);    adc(memw[ds, 0xaaa], dx);                 /* adc [0xaaa], dx */
        l_0xf7e6:
            ii(0xf7e6, 3);    dec(memw[ss, bp - 0x14]);                 /* dec word [bp-0x14] */
            ii(0xf7e9, 4);    cmp(memw[ss, bp - 0x14], 0);              /* cmp word [bp-0x14], 0x0 */
            ii(0xf7ed, 2);    if(jg(0xf7f2, 3)) goto l_0xf7f2;          /* jg 0xf7f2 */
            ii(0xf7ef, 3);    jmp(0xf658, -0x19a); goto l_0xf658;       /* jmp 0xf658 */
        l_0xf7f2:
            ii(0xf7f2, 3);    jmp(0xf67d, -0x178); goto l_0xf67d;       /* jmp 0xf67d */
        }
    }
}
