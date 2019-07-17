using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("95a2b7eb-6814-48c4-9a08-6c1f90693bc4")]
        public void Method_0000_a880()
        {
            ii(0xa880, 3);    sub(sp, 0x54);                            /* sub sp, 0x54 */
            ii(0xa883, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xa885, 4);    mov(memw_a16[ds, 0xf50], sp);             /* mov [0xf50], sp */
            ii(0xa889, 4);    sub(sp, 0x80);                            /* sub sp, 0x80 */
            ii(0xa88d, 3);    callw(0x6342, -0x454e);                   /* call 0x6342 */
            ii(0xa890, 3);    callw(0x6f76, -0x391d);                   /* call 0x6f76 */
            ii(0xa893, 3);    pushw(0x810);                             /* push 0x810 */
            ii(0xa896, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0xa89b, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0xa89c, 2);    if(jcxzw(0xa90d, 0x6f)) goto l_0xa90d;    /* jcxz 0xa90d */
            ii(0xa89e, 3);    callw(0x5a2e, -0x4e73);                   /* call 0x5a2e */
            ii(0xa8a1, 3);    add(ax, 0x800);                           /* add ax, 0x800 */
            ii(0xa8a4, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0xa8a6, 3);    mov(memw_a16[ds, 0xc4a], ax);             /* mov [0xc4a], ax */
            ii(0xa8a9, 5);    cmp(memb_a16[ds, 0xc44], 0);              /* cmp byte [0xc44], 0x0 */
            ii(0xa8ae, 2);    if(jnzw(0xa8be, 0xe)) goto l_0xa8be;      /* jnz 0xa8be */
            ii(0xa8b0, 3);    mov(ax, 0xbf02);                          /* mov ax, 0xbf02 */
            ii(0xa8b3, 2);    xor(si, si);                              /* xor si, si */
            ii(0xa8b5, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xa8b7, 3);    callw(0x44e4, -0x63d6);                   /* call 0x44e4 */
            ii(0xa8ba, 2);    or(si, dx);                               /* or si, dx */
            ii(0xa8bc, 2);    jnzw_func(0xa87b, -0x43);                 /* jnz 0xa87b */
        l_0xa8be:
            ii(0xa8be, 2);    mov(ah, 0x35);                            /* mov ah, 0x35 */
            ii(0xa8c0, 3);    mov(al, memb_a16[ds, 0x34]);              /* mov al, [0x34] */
            ii(0xa8c3, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa8c5, 1);    pushw(cs);                                /* push cs */
            ii(0xa8c6, 1);    popw(ds);                                 /* pop ds */
            ii(0xa8c7, 4);    mov(memw_a16[ds, 0x12c4], bx);            /* mov [0x12c4], bx */
            ii(0xa8cb, 4);    mov(memw_a16[ds, 0x12c6], es);            /* mov [0x12c6], es */
            ii(0xa8cf, 3);    mov(dx, 0x7273);                          /* mov dx, 0x7273 */
            ii(0xa8d2, 2);    mov(ah, 0x25);                            /* mov ah, 0x25 */
            ii(0xa8d4, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa8d6, 1);    pushw(ss);                                /* push ss */
            ii(0xa8d7, 1);    popw(ds);                                 /* pop ds */
            ii(0xa8d8, 6);    mov(memw_a16[ds, 0xac2], 0x7322);         /* mov word [0xac2], 0x7322 */
            ii(0xa8de, 3);    callw(0xa410, -0x4d1);                    /* call 0xa410 */
            ii(0xa8e1, 1);    pushw(bp);                                /* push bp */
            ii(0xa8e2, 3);    callw(0x8127, -0x27be);                   /* call 0x8127 */
            ii(0xa8e5, 3);    callw(0x637b, -0x456d);                   /* call 0x637b */
            ii(0xa8e8, 3);    mov(es, memw_a16[ss, bp + 0x2]);          /* mov es, [bp+0x2] */
            ii(0xa8eb, 3);    mov(di, memw_a16[ss, bp + 0xe]);          /* mov di, [bp+0xe] */
            ii(0xa8ee, 3);    mov(ax, memw_a16[ss, bp + 0x1e]);         /* mov ax, [bp+0x1e] */
            ii(0xa8f1, 1);    stosw_a16();                              /* stosw */
            ii(0xa8f2, 3);    mov(ax, memw_a16[ss, bp + 0x22]);         /* mov ax, [bp+0x22] */
            ii(0xa8f5, 1);    stosw_a16();                              /* stosw */
            ii(0xa8f6, 3);    mov(ax, memw_a16[ss, bp + 0x26]);         /* mov ax, [bp+0x26] */
            ii(0xa8f9, 1);    stosw_a16();                              /* stosw */
            ii(0xa8fa, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0xa8fd, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0xa8ff, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0xa901, 3);    lea(sp, di - 0x6);                        /* lea sp, [di-0x6] */
            ii(0xa904, 4);    mov(memw_a16[ds, 0xf50], bp);             /* mov [0xf50], bp */
            ii(0xa908, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xa90a, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xa90c, 1);    iretw();                                  /* iretw */
        l_0xa90d:
            ii(0xa90d, 2);    pushw(0xd);                               /* push 0xd */
            ii(0xa90f, 3);    callw(0x589d, -0x5075);                   /* call 0x589d */
            ii(0xa912, 3);    callw(0x499d, -0x5f78);                   /* call 0x499d */
            ii(0xa915, 1);    popw(cx);                                 /* pop cx */
            ii(0xa916, 1);    popw(ax);                                 /* pop ax */
            ii(0xa917, 2);    mov(ah, 0x4c);                            /* mov ah, 0x4c */
            ii(0xa919, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa91b, 3);    callw(0xa0c7, -0x857);                    /* call 0xa0c7 */
            ii(0xa91e, 6);    adc(memw_a16[ds, bx + si + 0], 0);        /* adc word [bx+si], 0x0 */
            ii(0xa924, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa926, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa928, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa92a, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa92c, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa92e, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa930, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa932, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa934, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa936, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa938, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa93a, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa93c, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa93e, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa940, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa942, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa944, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa946, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa948, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa94a, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa94c, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa94e, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa950, 2);    add(memb_a16[ds, bx + si], al);           /* add [bx+si], al */
            ii(0xa952, 2);    xchg(bx, bx);                             /* xchg bx, bx */
            ii(0xa954, 1);    pushw(bp);                                /* push bp */
            ii(0xa955, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xa957, 1);    pushw(si);                                /* push si */
            ii(0xa958, 2);    pushd(edi);                               /* push edi */
            ii(0xa95a, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xa95d, 1);    pushw(ds);                                /* push ds */
            ii(0xa95e, 1);    pushw(es);                                /* push es */
            ii(0xa95f, 1);    pushfw();                                 /* pushfw */
            ii(0xa960, 1);    cli();                                    /* cli */
            ii(0xa961, 5);    mov(es, memw_a16[cs, 0x208e]);            /* mov es, [cs:0x208e] */
            ii(0xa966, 5);    mov(di, memw_a16[es, 0xc4a]);             /* mov di, [es:0xc4a] */
            ii(0xa96b, 7);    sub(memw_a16[es, 0xc4a], 0x200);          /* sub word [es:0xc4a], 0x200 */
            ii(0xa972, 3);    sub(di, 0x32);                            /* sub di, 0x32 */
            ii(0xa975, 1);    pushw(di);                                /* push di */
            ii(0xa976, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa978, 1);    cld();                                    /* cld */
            ii(0xa979, 3);    lds(si, ss, bp + 0x8);                    /* lds si, [bp+0x8] */
            ii(0xa97c, 1);    pushw(si);                                /* push si */
            ii(0xa97d, 3);    add(si, 0x4);                             /* add si, 0x4 */
            ii(0xa980, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
        l_0xa983:
            ii(0xa983, 1);    movsw_a16();                              /* movsw */
            ii(0xa984, 1);    stosw_a16();                              /* stosw */
            ii(0xa985, 2);    if(loopw_a16(0xa983, -0x4)) goto l_0xa983; /* loop 0xa983 */
            ii(0xa987, 1);    stosw_a16();                              /* stosw */
            ii(0xa988, 1);    popw(si);                                 /* pop si */
            ii(0xa989, 1);    lodsw_a16();                              /* lodsw */
            ii(0xa98a, 1);    movsw_a16();                              /* movsw */
            ii(0xa98b, 1);    stosw_a16();                              /* stosw */
            ii(0xa98c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa98e, 1);    stosw_a16();                              /* stosw */
            ii(0xa98f, 1);    stosw_a16();                              /* stosw */
            ii(0xa990, 5);    mov(ds, memw_a16[cs, 0x208e]);            /* mov ds, [cs:0x208e] */
            ii(0xa995, 3);    mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0xa998, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0xa99a, 3);    shl(si, 0x2);                             /* shl si, 0x2 */
            ii(0xa99d, 4);    mov(dx, memw_a16[ds, 0xc2e]);             /* mov dx, [0xc2e] */
            ii(0xa9a1, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0xa9a4, 3);    cmp(ax, 0x26);                            /* cmp ax, 0x26 */
            ii(0xa9a7, 2);    if(jaw(0xa9b8, 0xf)) goto l_0xa9b8;       /* ja 0xa9b8 */
            ii(0xa9a9, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xa9ab, 5);    cmp(memb_a16[ds, bx + 0x10c6], 0);        /* cmp byte [bx+0x10c6], 0x0 */
            ii(0xa9b0, 2);    if(jzw(0xa9b8, 0x6)) goto l_0xa9b8;       /* jz 0xa9b8 */
            ii(0xa9b2, 4);    add(si, 0xf6a);                           /* add si, 0xf6a */
            ii(0xa9b6, 2);    mov(dx, ds);                              /* mov dx, ds */
        l_0xa9b8:
            ii(0xa9b8, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xa9ba, 1);    movsw_a16();                              /* movsw */
            ii(0xa9bb, 1);    movsw_a16();                              /* movsw */
            ii(0xa9bc, 1);    popw(ax);                                 /* pop ax */
            ii(0xa9bd, 1);    stosw_a16();                              /* stosw */
            ii(0xa9be, 3);    mov(ax, 0x1a2);                           /* mov ax, 0x1a2 */
            ii(0xa9c1, 1);    stosw_a16();                              /* stosw */
            ii(0xa9c2, 3);    sub(di, 0x32);                            /* sub di, 0x32 */
            ii(0xa9c5, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0xa9c7, 3);    mov(ax, 0x302);                           /* mov ax, 0x302 */
            ii(0xa9ca, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xa9cc, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0xa9cf, 2);    if(jbw(0xa9f4, 0x23)) goto l_0xa9f4;      /* jb 0xa9f4 */
            ii(0xa9d1, 5);    mov(ds, memw_a16[cs, 0x208e]);            /* mov ds, [cs:0x208e] */
            ii(0xa9d6, 4);    mov(si, memw_a16[ds, 0xc4a]);             /* mov si, [0xc4a] */
            ii(0xa9da, 4);    add(si, 0x1ce);                           /* add si, 0x1ce */
            ii(0xa9de, 3);    les(di, ss, bp + 0xc);                    /* les di, [bp+0xc] */
            ii(0xa9e1, 3);    mov(ax, memw_a16[ds, si + 0x24]);         /* mov ax, [si+0x24] */
            ii(0xa9e4, 1);    stosw_a16();                              /* stosw */
            ii(0xa9e5, 3);    mov(ax, memw_a16[ds, si + 0x22]);         /* mov ax, [si+0x22] */
            ii(0xa9e8, 1);    stosw_a16();                              /* stosw */
            ii(0xa9e9, 3);    mov(ax, memw_a16[ds, si + 0x20]);         /* mov ax, [si+0x20] */
            ii(0xa9ec, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
        l_0xa9ef:
            ii(0xa9ef, 1);    movsw_a16();                              /* movsw */
            ii(0xa9f0, 1);    inc(si);                                  /* inc si */
            ii(0xa9f1, 1);    inc(si);                                  /* inc si */
            ii(0xa9f2, 2);    if(loopw_a16(0xa9ef, -0x5)) goto l_0xa9ef; /* loop 0xa9ef */
        l_0xa9f4:
            ii(0xa9f4, 6);    add(memw_a16[ds, 0xc4a], 0x200);          /* add word [0xc4a], 0x200 */
            ii(0xa9fa, 1);    popw(cx);                                 /* pop cx */
            ii(0xa9fb, 4);    and(cx, 0x200);                           /* and cx, 0x200 */
            ii(0xa9ff, 2);    if(jcxzw(0xaa02, 0x1)) goto l_0xaa02;     /* jcxz 0xaa02 */
            ii(0xaa01, 1);    sti();                                    /* sti */
        l_0xaa02:
            ii(0xaa02, 1);    popw(es);                                 /* pop es */
            ii(0xaa03, 1);    popw(ds);                                 /* pop ds */
            ii(0xaa04, 2);    popd(edi);                                /* pop edi */
            ii(0xaa06, 1);    popw(si);                                 /* pop si */
            ii(0xaa07, 1);    popw(bp);                                 /* pop bp */
            ii(0xaa08, 1);    retfw();                                  /* retf */
        }
    }
}
