using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("438562fa-2af7-4400-a097-efd638496ef9")]
        public void Method_0000_74c8()
        {
            ii(0x74c8, 1);    pushw(bp);                                /* push bp */
            ii(0x74c9, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x74cb, 4);    sub(sp, 0xec);                            /* sub sp, 0xec */
            ii(0x74cf, 1);    pushw(di);                                /* push di */
            ii(0x74d0, 1);    pushw(si);                                /* push si */
            ii(0x74d1, 2);    sub(al, al);                              /* sub al, al */
            ii(0x74d3, 4);    mov(memb_a16[ss, bp - 0xe8], al);         /* mov [bp-0xe8], al */
            ii(0x74d7, 3);    mov(memb_a16[ss, bp - 0x56], al);         /* mov [bp-0x56], al */
            ii(0x74da, 3);    mov(memb_a16[ss, bp - 0x5e], al);         /* mov [bp-0x5e], al */
            ii(0x74dd, 5);    mov(memw_a16[ss, bp - 0x5c], 0);          /* mov word [bp-0x5c], 0x0 */
            ii(0x74e2, 3);    callw(0x98e8, 0x2403);                    /* call 0x98e8 */
            ii(0x74e5, 6);    mov(memw_a16[ds, 0xac], 0);               /* mov word [0xac], 0x0 */
            ii(0x74eb, 6);    mov(memw_a16[ds, 0xae], 0x10);            /* mov word [0xae], 0x10 */
            ii(0x74f1, 6);    mov(memw_a16[ss, bp - 0xe6], 0xfffe);     /* mov word [bp-0xe6], 0xfffe */
            ii(0x74f7, 6);    mov(memw_a16[ss, bp - 0xe4], 0xf000);     /* mov word [bp-0xe4], 0xf000 */
            ii(0x74fd, 6);    mov(memw_a16[ds, 0x11d4], 0x2);           /* mov word [0x11d4], 0x2 */
            ii(0x7503, 3);    mov(bx, 0xf000);                          /* mov bx, 0xf000 */
            ii(0x7506, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x7508, 3);    mov(bx, 0xfffe);                          /* mov bx, 0xfffe */
            ii(0x750b, 3);    mov(si, memw_a16[es, bx]);                /* mov si, [es:bx] */
            ii(0x750e, 4);    and(si, 0xff);                            /* and si, 0xff */
            ii(0x7512, 4);    cmp(si, 0xfb);                            /* cmp si, 0xfb */
            ii(0x7516, 2);    if(jzw(0x751e, 0x6)) goto l_0x751e;       /* jz 0x751e */
            ii(0x7518, 4);    cmp(si, 0xfd);                            /* cmp si, 0xfd */
            ii(0x751c, 2);    if(jlw(0x7522, 0x4)) goto l_0x7522;       /* jl 0x7522 */
        l_0x751e:
            ii(0x751e, 4);    inc(memb_a16[ds, 0x11f0]);                /* inc byte [0x11f0] */
        l_0x7522:
            ii(0x7522, 3);    callw(0x9eb2, 0x298d);                    /* call 0x9eb2 */
            ii(0x7525, 3);    mov(memb_a16[ds, 0x3e], al);              /* mov [0x3e], al */
            ii(0x7528, 3);    callw(0x6330, -0x11fb);                   /* call 0x6330 */
            ii(0x752b, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x752d, 6);    mov(memw_a16[ds, 0x11d4], 0x3);           /* mov word [0x11d4], 0x3 */
            ii(0x7533, 2);    mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x7535, 3);    mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x7538, 3);    mov(memb_a16[ss, bp - 0x5e], al);         /* mov [bp-0x5e], al */
            ii(0x753b, 2);    or(si, si);                               /* or si, si */
            ii(0x753d, 2);    if(jzw(0x7542, 0x3)) goto l_0x7542;       /* jz 0x7542 */
            ii(0x753f, 3);    jmpw(0x7794, 0x252); goto l_0x7794;       /* jmp 0x7794 */
        l_0x7542:
            ii(0x7542, 3);    mov(si, 0xa);                             /* mov si, 0xa */
            ii(0x7545, 2);    sub(al, al);                              /* sub al, al */
            ii(0x7547, 3);    mov(memb_a16[ss, bp - 0x4], al);          /* mov [bp-0x4], al */
            ii(0x754a, 3);    mov(memb_a16[ss, bp - 0x5e], al);         /* mov [bp-0x5e], al */
            ii(0x754d, 4);    lea(ax, bp - 0xe2);                       /* lea ax, [bp-0xe2] */
            ii(0x7551, 1);    pushw(ax);                                /* push ax */
            ii(0x7552, 3);    mov(cx, 0xe84);                           /* mov cx, 0xe84 */
            ii(0x7555, 1);    pushw(cx);                                /* push cx */
            ii(0x7556, 3);    callw(0x7c55, 0x6fc);                     /* call 0x7c55 */
            ii(0x7559, 1);    popw(bx);                                 /* pop bx */
            ii(0x755a, 1);    popw(bx);                                 /* pop bx */
            ii(0x755b, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x755d, 2);    or(di, di);                               /* or di, di */
            ii(0x755f, 2);    if(jnzw(0x7578, 0x17)) goto l_0x7578;     /* jnz 0x7578 */
            ii(0x7561, 4);    lea(ax, bp - 0xe2);                       /* lea ax, [bp-0xe2] */
            ii(0x7565, 1);    pushw(ax);                                /* push ax */
            ii(0x7566, 3);    mov(ax, 0xe8c);                           /* mov ax, 0xe8c */
            ii(0x7569, 1);    pushw(ax);                                /* push ax */
            ii(0x756a, 3);    callw(0x7c55, 0x6e8);                     /* call 0x7c55 */
            ii(0x756d, 1);    popw(bx);                                 /* pop bx */
            ii(0x756e, 1);    popw(bx);                                 /* pop bx */
            ii(0x756f, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7571, 2);    or(di, di);                               /* or di, di */
            ii(0x7573, 2);    if(jnzw(0x7578, 0x3)) goto l_0x7578;      /* jnz 0x7578 */
            ii(0x7575, 3);    jmpw(0x7794, 0x21c); goto l_0x7794;       /* jmp 0x7794 */
        l_0x7578:
            ii(0x7578, 1);    pushw(di);                                /* push di */
            ii(0x7579, 3);    callw(0x7c35, 0x6b9);                     /* call 0x7c35 */
            ii(0x757c, 1);    popw(bx);                                 /* pop bx */
            ii(0x757d, 1);    pushw(ax);                                /* push ax */
            ii(0x757e, 1);    pushw(di);                                /* push di */
            ii(0x757f, 3);    callw(0x4ee1, -0x26a1);                   /* call 0x4ee1 */
            ii(0x7582, 1);    popw(bx);                                 /* pop bx */
            ii(0x7583, 1);    popw(bx);                                 /* pop bx */
            ii(0x7584, 3);    mov(memw_a16[ss, bp - 0x5c], di);         /* mov [bp-0x5c], di */
            ii(0x7587, 3);    mov(ax, 0xe94);                           /* mov ax, 0xe94 */
            ii(0x758a, 1);    pushw(ax);                                /* push ax */
            ii(0x758b, 1);    pushw(di);                                /* push di */
            ii(0x758c, 3);    callw(0x4f4d, -0x2642);                   /* call 0x4f4d */
            ii(0x758f, 1);    popw(bx);                                 /* pop bx */
            ii(0x7590, 1);    popw(bx);                                 /* pop bx */
            ii(0x7591, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7593, 2);    if(jzw(0x759f, 0xa)) goto l_0x759f;       /* jz 0x759f */
            ii(0x7595, 3);    mov(si, 0x3);                             /* mov si, 0x3 */
            ii(0x7598, 4);    inc(memb_a16[ds, 0x11f0]);                /* inc byte [0x11f0] */
            ii(0x759c, 3);    inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
        l_0x759f:
            ii(0x759f, 3);    mov(ax, 0xe9c);                           /* mov ax, 0xe9c */
            ii(0x75a2, 1);    pushw(ax);                                /* push ax */
            ii(0x75a3, 1);    pushw(di);                                /* push di */
            ii(0x75a4, 3);    callw(0x4f4d, -0x265a);                   /* call 0x4f4d */
            ii(0x75a7, 1);    popw(bx);                                 /* pop bx */
            ii(0x75a8, 1);    popw(bx);                                 /* pop bx */
            ii(0x75a9, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x75ab, 2);    if(jzw(0x75b0, 0x3)) goto l_0x75b0;       /* jz 0x75b0 */
            ii(0x75ad, 3);    inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
        l_0x75b0:
            ii(0x75b0, 3);    mov(ax, 0xea1);                           /* mov ax, 0xea1 */
            ii(0x75b3, 1);    pushw(ax);                                /* push ax */
            ii(0x75b4, 1);    pushw(di);                                /* push di */
            ii(0x75b5, 3);    callw(0x4f4d, -0x266b);                   /* call 0x4f4d */
            ii(0x75b8, 1);    popw(bx);                                 /* pop bx */
            ii(0x75b9, 1);    popw(bx);                                 /* pop bx */
            ii(0x75ba, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x75bc, 2);    if(jzw(0x75c4, 0x6)) goto l_0x75c4;       /* jz 0x75c4 */
            ii(0x75be, 3);    mov(si, 0xb);                             /* mov si, 0xb */
            ii(0x75c1, 3);    inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
        l_0x75c4:
            ii(0x75c4, 3);    mov(ax, 0xea6);                           /* mov ax, 0xea6 */
            ii(0x75c7, 1);    pushw(ax);                                /* push ax */
            ii(0x75c8, 1);    pushw(di);                                /* push di */
            ii(0x75c9, 3);    callw(0x4f4d, -0x267f);                   /* call 0x4f4d */
            ii(0x75cc, 1);    popw(bx);                                 /* pop bx */
            ii(0x75cd, 1);    popw(bx);                                 /* pop bx */
            ii(0x75ce, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x75d0, 2);    if(jzw(0x7602, 0x30)) goto l_0x7602;      /* jz 0x7602 */
            ii(0x75d2, 3);    mov(ax, 0x31);                            /* mov ax, 0x31 */
            ii(0x75d5, 1);    pushw(ax);                                /* push ax */
            ii(0x75d6, 4);    pushw(memw_a16[ds, 0x30]);                /* push word [0x30] */
            ii(0x75da, 3);    callw(0x9710, 0x2133);                    /* call 0x9710 */
            ii(0x75dd, 1);    popw(bx);                                 /* pop bx */
            ii(0x75de, 1);    popw(bx);                                 /* pop bx */
            ii(0x75df, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x75e2, 1);    pushw(ax);                                /* push ax */
            ii(0x75e3, 3);    callw(0x5c10, -0x19d6);                   /* call 0x5c10 */
            ii(0x75e6, 1);    popw(bx);                                 /* pop bx */
            ii(0x75e7, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x75ea, 2);    jmpw(0x75f7, 0xb); goto l_0x75f7;         /* jmp 0x75f7 */
        l_0x75ec:
            ii(0x75ec, 3);    mov(bx, memw_a16[ss, bp - 0x58]);         /* mov bx, [bp-0x58] */
            ii(0x75ef, 3);    add(bx, memw_a16[ss, bp - 0x2]);          /* add bx, [bp-0x2] */
            ii(0x75f2, 2);    mov(al, memb_a16[ds, bx]);                /* mov al, [bx] */
            ii(0x75f4, 3);    mov(memb_a16[ds, bx + 0x1], al);          /* mov [bx+0x1], al */
        l_0x75f7:
            ii(0x75f7, 3);    dec(memw_a16[ss, bp - 0x58]);             /* dec word [bp-0x58] */
            ii(0x75fa, 2);    if(jnsw(0x75ec, -0x10)) goto l_0x75ec;    /* jns 0x75ec */
            ii(0x75fc, 3);    mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x75ff, 3);    mov(memb_a16[ds, bx], 0x20);              /* mov byte [bx], 0x20 */
        l_0x7602:
            ii(0x7602, 3);    mov(ax, 0xeab);                           /* mov ax, 0xeab */
            ii(0x7605, 1);    pushw(ax);                                /* push ax */
            ii(0x7606, 1);    pushw(di);                                /* push di */
            ii(0x7607, 3);    callw(0x4f4d, -0x26bd);                   /* call 0x4f4d */
            ii(0x760a, 1);    popw(bx);                                 /* pop bx */
            ii(0x760b, 1);    popw(bx);                                 /* pop bx */
            ii(0x760c, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x760e, 2);    if(jnzw(0x761e, 0xe)) goto l_0x761e;      /* jnz 0x761e */
            ii(0x7610, 3);    mov(ax, 0xeaf);                           /* mov ax, 0xeaf */
            ii(0x7613, 1);    pushw(ax);                                /* push ax */
            ii(0x7614, 1);    pushw(di);                                /* push di */
            ii(0x7615, 3);    callw(0x4f4d, -0x26cb);                   /* call 0x4f4d */
            ii(0x7618, 1);    popw(bx);                                 /* pop bx */
            ii(0x7619, 1);    popw(bx);                                 /* pop bx */
            ii(0x761a, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x761c, 2);    if(jzw(0x7626, 0x8)) goto l_0x7626;       /* jz 0x7626 */
        l_0x761e:
            ii(0x761e, 3);    mov(si, 0x2);                             /* mov si, 0x2 */
            ii(0x7621, 3);    inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
            ii(0x7624, 2);    jmpw(0x7655, 0x2f); goto l_0x7655;        /* jmp 0x7655 */
        l_0x7626:
            ii(0x7626, 1);    pushw(di);                                /* push di */
            ii(0x7627, 3);    callw(0x9670, 0x2046);                    /* call 0x9670 */
            ii(0x762a, 1);    popw(bx);                                 /* pop bx */
            ii(0x762b, 3);    mov(memw_a16[ss, bp - 0x62], ax);         /* mov [bp-0x62], ax */
            ii(0x762e, 3);    mov(memw_a16[ss, bp - 0x60], dx);         /* mov [bp-0x60], dx */
            ii(0x7631, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x7633, 2);    if(jzw(0x7655, 0x20)) goto l_0x7655;      /* jz 0x7655 */
            ii(0x7635, 3);    inc(memb_a16[ss, bp - 0x4]);              /* inc byte [bp-0x4] */
            ii(0x7638, 4);    cmp(memw_a16[ss, bp - 0x60], 0x1);        /* cmp word [bp-0x60], 0x1 */
            ii(0x763c, 2);    if(jlw(0x7653, 0x15)) goto l_0x7653;      /* jl 0x7653 */
            ii(0x763e, 2);    if(jgw(0x7644, 0x4)) goto l_0x7644;       /* jg 0x7644 */
            ii(0x7640, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7642, 2);    if(jzw(0x7653, 0xf)) goto l_0x7653;       /* jz 0x7653 */
        l_0x7644:
            ii(0x7644, 3);    mov(dx, memw_a16[ss, bp - 0x60]);         /* mov dx, [bp-0x60] */
            ii(0x7647, 3);    sub(ax, 0x3880);                          /* sub ax, 0x3880 */
            ii(0x764a, 3);    sbb(dx, 0x1);                             /* sbb dx, 0x1 */
            ii(0x764d, 3);    mov(memw_a16[ss, bp - 0x62], ax);         /* mov [bp-0x62], ax */
            ii(0x7650, 3);    mov(memw_a16[ss, bp - 0x60], dx);         /* mov [bp-0x60], dx */
        l_0x7653:
            ii(0x7653, 2);    mov(si, ax);                              /* mov si, ax */
        l_0x7655:
            ii(0x7655, 3);    mov(ax, 0x2c);                            /* mov ax, 0x2c */
            ii(0x7658, 1);    pushw(ax);                                /* push ax */
            ii(0x7659, 3);    mov(memw_a16[ss, bp - 0x2], di);          /* mov [bp-0x2], di */
            ii(0x765c, 1);    pushw(di);                                /* push di */
            ii(0x765d, 3);    callw(0x9710, 0x20b0);                    /* call 0x9710 */
            ii(0x7660, 1);    popw(bx);                                 /* pop bx */
            ii(0x7661, 1);    popw(bx);                                 /* pop bx */
            ii(0x7662, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7664, 2);    or(di, di);                               /* or di, di */
            ii(0x7666, 2);    if(jzw(0x7682, 0x1a)) goto l_0x7682;      /* jz 0x7682 */
            ii(0x7668, 3);    lea(ax, di + 0x1);                        /* lea ax, [di+0x1] */
            ii(0x766b, 1);    pushw(ax);                                /* push ax */
            ii(0x766c, 3);    callw(0x966c, 0x1ffd);                    /* call 0x966c */
            ii(0x766f, 1);    popw(bx);                                 /* pop bx */
            ii(0x7670, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x7673, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7675, 2);    if(jlw(0x7682, 0xb)) goto l_0x7682;       /* jl 0x7682 */
            ii(0x7677, 1);    inc(ax);                                  /* inc ax */
            ii(0x7678, 3);    mov(memw_a16[ds, 0x12], ax);              /* mov [0x12], ax */
            ii(0x767b, 3);    mov(memw_a16[ds, 0x10], ax);              /* mov [0x10], ax */
            ii(0x767e, 4);    inc(memb_a16[ss, bp - 0xe8]);             /* inc byte [bp-0xe8] */
        l_0x7682:
            ii(0x7682, 3);    mov(ax, 0x40);                            /* mov ax, 0x40 */
            ii(0x7685, 1);    pushw(ax);                                /* push ax */
            ii(0x7686, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x7689, 3);    callw(0x9710, 0x2084);                    /* call 0x9710 */
            ii(0x768c, 1);    popw(bx);                                 /* pop bx */
            ii(0x768d, 1);    popw(bx);                                 /* pop bx */
            ii(0x768e, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7690, 2);    or(di, di);                               /* or di, di */
            ii(0x7692, 2);    if(jzw(0x76cf, 0x3b)) goto l_0x76cf;      /* jz 0x76cf */
            ii(0x7694, 1);    pushw(di);                                /* push di */
            ii(0x7695, 3);    callw(0x7bb3, 0x51b);                     /* call 0x7bb3 */
            ii(0x7698, 1);    popw(bx);                                 /* pop bx */
            ii(0x7699, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x769c, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x769e, 2);    if(jzw(0x76a8, 0x8)) goto l_0x76a8;       /* jz 0x76a8 */
            ii(0x76a0, 3);    mov(memw_a16[ds, 0xeca], ax);             /* mov [0xeca], ax */
            ii(0x76a3, 5);    or(memb_a16[ds, 0x11d2], 0x2);            /* or byte [0x11d2], 0x2 */
        l_0x76a8:
            ii(0x76a8, 3);    mov(ax, 0x2d);                            /* mov ax, 0x2d */
            ii(0x76ab, 1);    pushw(ax);                                /* push ax */
            ii(0x76ac, 1);    pushw(di);                                /* push di */
            ii(0x76ad, 3);    callw(0x9710, 0x2060);                    /* call 0x9710 */
            ii(0x76b0, 1);    popw(bx);                                 /* pop bx */
            ii(0x76b1, 1);    popw(bx);                                 /* pop bx */
            ii(0x76b2, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x76b4, 2);    or(di, di);                               /* or di, di */
            ii(0x76b6, 2);    if(jzw(0x76cf, 0x17)) goto l_0x76cf;      /* jz 0x76cf */
            ii(0x76b8, 1);    pushw(di);                                /* push di */
            ii(0x76b9, 3);    callw(0x7bb3, 0x4f7);                     /* call 0x7bb3 */
            ii(0x76bc, 1);    popw(bx);                                 /* pop bx */
            ii(0x76bd, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x76c0, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x76c2, 2);    if(jzw(0x76cf, 0xb)) goto l_0x76cf;       /* jz 0x76cf */
            ii(0x76c4, 3);    mov(memw_a16[ds, 0xece], ax);             /* mov [0xece], ax */
            ii(0x76c7, 3);    inc(memb_a16[ss, bp - 0x5e]);             /* inc byte [bp-0x5e] */
            ii(0x76ca, 5);    or(memb_a16[ds, 0x11d2], 0x4);            /* or byte [0x11d2], 0x4 */
        l_0x76cf:
            ii(0x76cf, 3);    mov(ax, 0x3a);                            /* mov ax, 0x3a */
            ii(0x76d2, 1);    pushw(ax);                                /* push ax */
            ii(0x76d3, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x76d6, 3);    callw(0x9710, 0x2037);                    /* call 0x9710 */
            ii(0x76d9, 1);    popw(bx);                                 /* pop bx */
            ii(0x76da, 1);    popw(bx);                                 /* pop bx */
            ii(0x76db, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x76dd, 2);    or(di, di);                               /* or di, di */
            ii(0x76df, 2);    if(jzw(0x76f1, 0x10)) goto l_0x76f1;      /* jz 0x76f1 */
            ii(0x76e1, 1);    pushw(di);                                /* push di */
            ii(0x76e2, 3);    callw(0x7bb3, 0x4ce);                     /* call 0x7bb3 */
            ii(0x76e5, 1);    popw(bx);                                 /* pop bx */
            ii(0x76e6, 3);    mov(memw_a16[ds, 0xecc], ax);             /* mov [0xecc], ax */
            ii(0x76e9, 3);    inc(memb_a16[ss, bp - 0x5e]);             /* inc byte [bp-0x5e] */
            ii(0x76ec, 5);    or(memb_a16[ds, 0x11d2], 0x1);            /* or byte [0x11d2], 0x1 */
        l_0x76f1:
            ii(0x76f1, 3);    mov(ax, 0x5e);                            /* mov ax, 0x5e */
            ii(0x76f4, 1);    pushw(ax);                                /* push ax */
            ii(0x76f5, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x76f8, 3);    callw(0x9710, 0x2015);                    /* call 0x9710 */
            ii(0x76fb, 1);    popw(bx);                                 /* pop bx */
            ii(0x76fc, 1);    popw(bx);                                 /* pop bx */
            ii(0x76fd, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x76ff, 2);    or(di, di);                               /* or di, di */
            ii(0x7701, 2);    if(jzw(0x770b, 0x8)) goto l_0x770b;       /* jz 0x770b */
            ii(0x7703, 1);    pushw(di);                                /* push di */
            ii(0x7704, 3);    callw(0x7bb3, 0x4ac);                     /* call 0x7bb3 */
            ii(0x7707, 1);    popw(bx);                                 /* pop bx */
            ii(0x7708, 3);    mov(memw_a16[ds, 0x14], ax);              /* mov [0x14], ax */
        l_0x770b:
            ii(0x770b, 3);    mov(ax, 0xeb4);                           /* mov ax, 0xeb4 */
            ii(0x770e, 1);    pushw(ax);                                /* push ax */
            ii(0x770f, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x7712, 3);    callw(0x973a, 0x2025);                    /* call 0x973a */
            ii(0x7715, 1);    popw(bx);                                 /* pop bx */
            ii(0x7716, 1);    popw(bx);                                 /* pop bx */
            ii(0x7717, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7719, 2);    if(jzw(0x771f, 0x4)) goto l_0x771f;       /* jz 0x771f */
            ii(0x771b, 4);    inc(memb_a16[ds, 0x11f1]);                /* inc byte [0x11f1] */
        l_0x771f:
            ii(0x771f, 3);    mov(ax, 0xeb9);                           /* mov ax, 0xeb9 */
            ii(0x7722, 1);    pushw(ax);                                /* push ax */
            ii(0x7723, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x7726, 3);    callw(0x973a, 0x2011);                    /* call 0x973a */
            ii(0x7729, 1);    popw(bx);                                 /* pop bx */
            ii(0x772a, 1);    popw(bx);                                 /* pop bx */
            ii(0x772b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x772d, 2);    if(jzw(0x7734, 0x5)) goto l_0x7734;       /* jz 0x7734 */
            ii(0x772f, 5);    mov(memb_a16[ds, 0x36], 0x80);            /* mov byte [0x36], 0x80 */
        l_0x7734:
            ii(0x7734, 3);    mov(ax, 0x2b);                            /* mov ax, 0x2b */
            ii(0x7737, 1);    pushw(ax);                                /* push ax */
            ii(0x7738, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x773b, 3);    callw(0x9710, 0x1fd2);                    /* call 0x9710 */
            ii(0x773e, 1);    popw(bx);                                 /* pop bx */
            ii(0x773f, 1);    popw(bx);                                 /* pop bx */
            ii(0x7740, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7742, 2);    if(jzw(0x7749, 0x5)) goto l_0x7749;       /* jz 0x7749 */
            ii(0x7744, 5);    or(memb_a16[ds, 0x47], 0x2);              /* or byte [0x47], 0x2 */
        l_0x7749:
            ii(0x7749, 3);    mov(ax, 0x56);                            /* mov ax, 0x56 */
            ii(0x774c, 1);    pushw(ax);                                /* push ax */
            ii(0x774d, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x7750, 3);    callw(0x9710, 0x1fbd);                    /* call 0x9710 */
            ii(0x7753, 1);    popw(bx);                                 /* pop bx */
            ii(0x7754, 1);    popw(bx);                                 /* pop bx */
            ii(0x7755, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x7757, 2);    or(di, di);                               /* or di, di */
            ii(0x7759, 2);    if(jzw(0x7770, 0x15)) goto l_0x7770;      /* jz 0x7770 */
            ii(0x775b, 4);    cmp(memb_a16[ds, di + 0x1], 0x43);        /* cmp byte [di+0x1], 0x43 */
            ii(0x775f, 2);    if(jzw(0x7770, 0xf)) goto l_0x7770;       /* jz 0x7770 */
            ii(0x7761, 1);    pushw(di);                                /* push di */
            ii(0x7762, 3);    callw(0x7bb3, 0x44e);                     /* call 0x7bb3 */
            ii(0x7765, 1);    popw(bx);                                 /* pop bx */
            ii(0x7766, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x7769, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x776b, 2);    if(jzw(0x7770, 0x3)) goto l_0x7770;       /* jz 0x7770 */
            ii(0x776d, 3);    mov(memb_a16[ds, 0x34], al);              /* mov [0x34], al */
        l_0x7770:
            ii(0x7770, 3);    mov(ax, 0xebd);                           /* mov ax, 0xebd */
            ii(0x7773, 1);    pushw(ax);                                /* push ax */
            ii(0x7774, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x7777, 3);    callw(0x973a, 0x1fc0);                    /* call 0x973a */
            ii(0x777a, 1);    popw(bx);                                 /* pop bx */
            ii(0x777b, 1);    popw(bx);                                 /* pop bx */
            ii(0x777c, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x777e, 2);    or(di, di);                               /* or di, di */
            ii(0x7780, 2);    if(jzw(0x7794, 0x12)) goto l_0x7794;      /* jz 0x7794 */
            ii(0x7782, 3);    lea(ax, di + 0x3);                        /* lea ax, [di+0x3] */
            ii(0x7785, 1);    pushw(ax);                                /* push ax */
            ii(0x7786, 3);    callw(0x7bb3, 0x42a);                     /* call 0x7bb3 */
            ii(0x7789, 1);    popw(bx);                                 /* pop bx */
            ii(0x778a, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x778d, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x778f, 2);    if(jzw(0x7794, 0x3)) goto l_0x7794;       /* jz 0x7794 */
            ii(0x7791, 3);    mov(memw_a16[ds, 0xd0e], ax);             /* mov [0xd0e], ax */
        l_0x7794:
            ii(0x7794, 1);    pushw(si);                                /* push si */
            ii(0x7795, 3);    callw(0x7b77, 0x3df);                     /* call 0x7b77 */
            ii(0x7798, 1);    popw(bx);                                 /* pop bx */
            ii(0x7799, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x779b, 2);    if(jzw(0x77a2, 0x5)) goto l_0x77a2;       /* jz 0x77a2 */
            ii(0x779d, 3);    callw(0x9985, 0x21e5);                    /* call 0x9985 */
            ii(0x77a0, 2);    jmpw(0x77a7, 0x5); goto l_0x77a7;         /* jmp 0x77a7 */
        l_0x77a2:
            ii(0x77a2, 5);    or(memb_a16[ds, 0x47], 0x1);              /* or byte [0x47], 0x1 */
        l_0x77a7:
            ii(0x77a7, 3);    callw(0x9f7b, 0x27d1);                    /* call 0x9f7b */
            ii(0x77aa, 2);    or(si, si);                               /* or si, si */
            ii(0x77ac, 2);    if(jgew(0x77c5, 0x17)) goto l_0x77c5;     /* jge 0x77c5 */
            ii(0x77ae, 3);    inc(memb_a16[ss, bp - 0x56]);             /* inc byte [bp-0x56] */
            ii(0x77b1, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x77b3, 2);    neg(ax);                                  /* neg ax */
            ii(0x77b5, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x77b7, 3);    cmp(si, 0xb);                             /* cmp si, 0xb */
            ii(0x77ba, 2);    if(jzw(0x77bf, 0x3)) goto l_0x77bf;       /* jz 0x77bf */
            ii(0x77bc, 3);    jmpw(0x78b7, 0xf8); goto l_0x78b7;        /* jmp 0x78b7 */
        l_0x77bf:
            ii(0x77bf, 3);    callw(0xaccb, 0x3509);                    /* call 0xaccb */
            ii(0x77c2, 3);    jmpw(0x78b7, 0xf2); goto l_0x78b7;        /* jmp 0x78b7 */
        l_0x77c5:
            ii(0x77c5, 3);    callw(0x9c92, 0x24ca);                    /* call 0x9c92 */
            ii(0x77c8, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x77ca, 2);    if(jzw(0x77cf, 0x3)) goto l_0x77cf;       /* jz 0x77cf */
            ii(0x77cc, 3);    mov(si, 0x10);                            /* mov si, 0x10 */
        l_0x77cf:
            ii(0x77cf, 3);    cmp(si, 0x2);                             /* cmp si, 0x2 */
            ii(0x77d2, 2);    if(jnzw(0x77d7, 0x3)) goto l_0x77d7;      /* jnz 0x77d7 */
            ii(0x77d4, 3);    callw(0x9c57, 0x2480);                    /* call 0x9c57 */
        l_0x77d7:
            ii(0x77d7, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x77dc, 2);    if(jlw(0x7847, 0x69)) goto l_0x7847;      /* jl 0x7847 */
            ii(0x77de, 6);    mov(memw_a16[ds, 0x9c2], 0x296d);         /* mov word [0x9c2], 0x296d */
            ii(0x77e4, 3);    callw(0x9c08, 0x2421);                    /* call 0x9c08 */
            ii(0x77e7, 3);    mov(memb_a16[ds, 0x2f], al);              /* mov [0x2f], al */
            ii(0x77ea, 3);    callw(0xa38c, 0x2b9f);                    /* call 0xa38c */
            ii(0x77ed, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x77f0, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x77f2, 2);    if(jzw(0x780d, 0x19)) goto l_0x780d;      /* jz 0x780d */
            ii(0x77f4, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x77f6, 3);    mov(memb_a16[ds, 0x46], al);              /* mov [0x46], al */
            ii(0x77f9, 3);    cmp(si, 0xb);                             /* cmp si, 0xb */
            ii(0x77fc, 2);    if(jnzw(0x7808, 0xa)) goto l_0x7808;      /* jnz 0x7808 */
            ii(0x77fe, 3);    callw(0xaccb, 0x34ca);                    /* call 0xaccb */
            ii(0x7801, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7803, 2);    if(jlew(0x7808, 0x3)) goto l_0x7808;      /* jle 0x7808 */
            ii(0x7805, 3);    jmpw(0x78b7, 0xaf); goto l_0x78b7;        /* jmp 0x78b7 */
        l_0x7808:
            ii(0x7808, 2);    sub(si, si);                              /* sub si, si */
            ii(0x780a, 3);    jmpw(0x7b38, 0x32b); goto l_0x7b38;       /* jmp 0x7b38 */
        l_0x780d:
            ii(0x780d, 3);    callw(0xaccb, 0x34bb);                    /* call 0xaccb */
            ii(0x7810, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x7813, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7815, 2);    if(jlew(0x7822, 0xb)) goto l_0x7822;      /* jle 0x7822 */
            ii(0x7817, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7819, 3);    mov(memb_a16[ds, 0x46], al);              /* mov [0x46], al */
            ii(0x781c, 3);    mov(si, 0xb);                             /* mov si, 0xb */
            ii(0x781f, 3);    jmpw(0x78b7, 0x95); goto l_0x78b7;        /* jmp 0x78b7 */
        l_0x7822:
            ii(0x7822, 6);    mov(memw_a16[ds, 0x11d4], 0x4);           /* mov word [0x11d4], 0x4 */
            ii(0x7828, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x782a, 2);    if(jgew(0x7834, 0x8)) goto l_0x7834;      /* jge 0x7834 */
            ii(0x782c, 3);    mov(ax, 0x11);                            /* mov ax, 0x11 */
            ii(0x782f, 1);    pushw(ax);                                /* push ax */
            ii(0x7830, 3);    callw(0x589d, -0x1f96);                   /* call 0x589d */
            ii(0x7833, 1);    popw(bx);                                 /* pop bx */
        l_0x7834:
            ii(0x7834, 1);    pushw(si);                                /* push si */
            ii(0x7835, 3);    callw(0x7b77, 0x33f);                     /* call 0x7b77 */
            ii(0x7838, 1);    popw(bx);                                 /* pop bx */
            ii(0x7839, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x783b, 2);    if(jnzw(0x7847, 0xa)) goto l_0x7847;      /* jnz 0x7847 */
            ii(0x783d, 3);    mov(si, 0x3);                             /* mov si, 0x3 */
            ii(0x7840, 3);    callw(0x9c62, 0x241f);                    /* call 0x9c62 */
            ii(0x7843, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7845, 2);    if(jzw(0x78b7, 0x70)) goto l_0x78b7;      /* jz 0x78b7 */
        l_0x7847:
            ii(0x7847, 1);    pushw(si);                                /* push si */
            ii(0x7848, 3);    callw(0x7b77, 0x32c);                     /* call 0x7b77 */
            ii(0x784b, 1);    popw(bx);                                 /* pop bx */
            ii(0x784c, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x784e, 2);    if(jnzw(0x785c, 0xc)) goto l_0x785c;      /* jnz 0x785c */
            ii(0x7850, 3);    callw(0x9c62, 0x240f);                    /* call 0x9c62 */
            ii(0x7853, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7855, 2);    if(jzw(0x785c, 0x5)) goto l_0x785c;       /* jz 0x785c */
            ii(0x7857, 3);    mov(si, 0x2);                             /* mov si, 0x2 */
            ii(0x785a, 2);    jmpw(0x78b7, 0x5b); goto l_0x78b7;        /* jmp 0x78b7 */
        l_0x785c:
            ii(0x785c, 4);    cmp(memb_a16[ss, bp - 0x4], 0);           /* cmp byte [bp-0x4], 0x0 */
            ii(0x7860, 2);    if(jnzw(0x78b7, 0x55)) goto l_0x78b7;     /* jnz 0x78b7 */
            ii(0x7862, 3);    callw(0x9e8e, 0x2629);                    /* call 0x9e8e */
            ii(0x7865, 1);    pushw(dx);                                /* push dx */
            ii(0x7866, 1);    pushw(ax);                                /* push ax */
            ii(0x7867, 3);    callw(0x9e59, 0x25ef);                    /* call 0x9e59 */
            ii(0x786a, 1);    popw(bx);                                 /* pop bx */
            ii(0x786b, 1);    popw(bx);                                 /* pop bx */
            ii(0x786c, 4);    mov(memw_a16[ss, bp - 0xec], ax);         /* mov [bp-0xec], ax */
            ii(0x7870, 4);    mov(memw_a16[ss, bp - 0xea], dx);         /* mov [bp-0xea], dx */
            ii(0x7874, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x7876, 2);    if(jnzw(0x789a, 0x22)) goto l_0x789a;     /* jnz 0x789a */
            ii(0x7878, 3);    callw(0x9ea9, 0x262e);                    /* call 0x9ea9 */
            ii(0x787b, 1);    pushw(dx);                                /* push dx */
            ii(0x787c, 1);    pushw(ax);                                /* push ax */
            ii(0x787d, 3);    callw(0x9e59, 0x25d9);                    /* call 0x9e59 */
            ii(0x7880, 1);    popw(bx);                                 /* pop bx */
            ii(0x7881, 1);    popw(bx);                                 /* pop bx */
            ii(0x7882, 4);    mov(memw_a16[ss, bp - 0xec], ax);         /* mov [bp-0xec], ax */
            ii(0x7886, 4);    mov(memw_a16[ss, bp - 0xea], dx);         /* mov [bp-0xea], dx */
            ii(0x788a, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x788c, 2);    if(jnzw(0x789a, 0xc)) goto l_0x789a;      /* jnz 0x789a */
            ii(0x788e, 6);    mov(memw_a16[ss, bp - 0xec], 0);          /* mov word [bp-0xec], 0x0 */
            ii(0x7894, 6);    mov(memw_a16[ss, bp - 0xea], 0x9);        /* mov word [bp-0xea], 0x9 */
        l_0x789a:
            ii(0x789a, 5);    cmp(memb_a16[ss, bp - 0xe8], 0);          /* cmp byte [bp-0xe8], 0x0 */
            ii(0x789f, 2);    if(jnzw(0x78b3, 0x12)) goto l_0x78b3;     /* jnz 0x78b3 */
            ii(0x78a1, 5);    cmp(memw_a16[ss, bp - 0xec], 0);          /* cmp word [bp-0xec], 0x0 */
            ii(0x78a6, 2);    if(jzw(0x78b3, 0xb)) goto l_0x78b3;       /* jz 0x78b3 */
            ii(0x78a8, 4);    mov(ax, memw_a16[ss, bp - 0xec]);         /* mov ax, [bp-0xec] */
            ii(0x78ac, 1);    inc(ax);                                  /* inc ax */
            ii(0x78ad, 3);    mov(memw_a16[ds, 0x12], ax);              /* mov [0x12], ax */
            ii(0x78b0, 3);    mov(memw_a16[ds, 0x10], ax);              /* mov [0x10], ax */
        l_0x78b3:
            ii(0x78b3, 4);    mov(si, memw_a16[ss, bp - 0xea]);         /* mov si, [bp-0xea] */
        l_0x78b7:
            ii(0x78b7, 3);    cmp(si, 0xb);                             /* cmp si, 0xb */
            ii(0x78ba, 2);    if(jzw(0x78c6, 0xa)) goto l_0x78c6;       /* jz 0x78c6 */
            ii(0x78bc, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x78c1, 2);    if(jzw(0x78c6, 0x3)) goto l_0x78c6;       /* jz 0x78c6 */
            ii(0x78c3, 3);    callw(0x9f9c, 0x26d6);                    /* call 0x9f9c */
        l_0x78c6:
            ii(0x78c6, 5);    mov(memb_a16[ds, 0x10ee], 0xff);          /* mov byte [0x10ee], 0xff */
            ii(0x78cb, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x78cd, 1);    dec(ax);                                  /* dec ax */
            ii(0x78ce, 2);    if(jnzw(0x78d3, 0x3)) goto l_0x78d3;      /* jnz 0x78d3 */
            ii(0x78d0, 3);    jmpw(0x795e, 0x8b); goto l_0x795e;        /* jmp 0x795e */
        l_0x78d3:
            ii(0x78d3, 1);    dec(ax);                                  /* dec ax */
            ii(0x78d4, 2);    if(jnzw(0x78d9, 0x3)) goto l_0x78d9;      /* jnz 0x78d9 */
            ii(0x78d6, 3);    jmpw(0x79dd, 0x104); goto l_0x79dd;       /* jmp 0x79dd */
        l_0x78d9:
            ii(0x78d9, 1);    dec(ax);                                  /* dec ax */
            ii(0x78da, 2);    if(jnzw(0x78df, 0x3)) goto l_0x78df;      /* jnz 0x78df */
            ii(0x78dc, 3);    jmpw(0x79fe, 0x11f); goto l_0x79fe;       /* jmp 0x79fe */
        l_0x78df:
            ii(0x78df, 1);    dec(ax);                                  /* dec ax */
            ii(0x78e0, 2);    if(jnzw(0x78e5, 0x3)) goto l_0x78e5;      /* jnz 0x78e5 */
            ii(0x78e2, 3);    jmpw(0x7a59, 0x174); goto l_0x7a59;       /* jmp 0x7a59 */
        l_0x78e5:
            ii(0x78e5, 1);    dec(ax);                                  /* dec ax */
            ii(0x78e6, 2);    if(jnzw(0x78eb, 0x3)) goto l_0x78eb;      /* jnz 0x78eb */
            ii(0x78e8, 3);    jmpw(0x7a13, 0x128); goto l_0x7a13;       /* jmp 0x7a13 */
        l_0x78eb:
            ii(0x78eb, 1);    dec(ax);                                  /* dec ax */
            ii(0x78ec, 2);    if(jnzw(0x78f1, 0x3)) goto l_0x78f1;      /* jnz 0x78f1 */
            ii(0x78ee, 3);    jmpw(0x7a4c, 0x15b); goto l_0x7a4c;       /* jmp 0x7a4c */
        l_0x78f1:
            ii(0x78f1, 1);    dec(ax);                                  /* dec ax */
            ii(0x78f2, 2);    if(jnzw(0x78f7, 0x3)) goto l_0x78f7;      /* jnz 0x78f7 */
            ii(0x78f4, 3);    jmpw(0x7a5c, 0x165); goto l_0x7a5c;       /* jmp 0x7a5c */
        l_0x78f7:
            ii(0x78f7, 1);    dec(ax);                                  /* dec ax */
            ii(0x78f8, 2);    if(jnzw(0x78fd, 0x3)) goto l_0x78fd;      /* jnz 0x78fd */
            ii(0x78fa, 3);    jmpw(0x7a76, 0x179); goto l_0x7a76;       /* jmp 0x7a76 */
        l_0x78fd:
            ii(0x78fd, 1);    dec(ax);                                  /* dec ax */
            ii(0x78fe, 2);    if(jnzw(0x7903, 0x3)) goto l_0x7903;      /* jnz 0x7903 */
            ii(0x7900, 3);    jmpw(0x7a5c, 0x159); goto l_0x7a5c;       /* jmp 0x7a5c */
        l_0x7903:
            ii(0x7903, 1);    dec(ax);                                  /* dec ax */
            ii(0x7904, 2);    if(jnzw(0x7909, 0x3)) goto l_0x7909;      /* jnz 0x7909 */
            ii(0x7906, 3);    jmpw(0x7a93, 0x18a); goto l_0x7a93;       /* jmp 0x7a93 */
        l_0x7909:
            ii(0x7909, 1);    dec(ax);                                  /* dec ax */
            ii(0x790a, 2);    if(jnzw(0x790f, 0x3)) goto l_0x790f;      /* jnz 0x790f */
            ii(0x790c, 3);    jmpw(0x7a9b, 0x18c); goto l_0x7a9b;       /* jmp 0x7a9b */
        l_0x790f:
            ii(0x790f, 1);    dec(ax);                                  /* dec ax */
            ii(0x7910, 2);    if(jnzw(0x7915, 0x3)) goto l_0x7915;      /* jnz 0x7915 */
            ii(0x7912, 3);    jmpw(0x7aa2, 0x18d); goto l_0x7aa2;       /* jmp 0x7aa2 */
        l_0x7915:
            ii(0x7915, 1);    dec(ax);                                  /* dec ax */
            ii(0x7916, 2);    if(jnzw(0x791b, 0x3)) goto l_0x791b;      /* jnz 0x791b */
            ii(0x7918, 3);    jmpw(0x7aa9, 0x18e); goto l_0x7aa9;       /* jmp 0x7aa9 */
        l_0x791b:
            ii(0x791b, 1);    dec(ax);                                  /* dec ax */
            ii(0x791c, 2);    if(jnzw(0x7921, 0x3)) goto l_0x7921;      /* jnz 0x7921 */
            ii(0x791e, 3);    jmpw(0x7ab6, 0x195); goto l_0x7ab6;       /* jmp 0x7ab6 */
        l_0x7921:
            ii(0x7921, 1);    dec(ax);                                  /* dec ax */
            ii(0x7922, 2);    if(jnzw(0x7927, 0x3)) goto l_0x7927;      /* jnz 0x7927 */
            ii(0x7924, 3);    jmpw(0x7abe, 0x197); goto l_0x7abe;       /* jmp 0x7abe */
        l_0x7927:
            ii(0x7927, 1);    dec(ax);                                  /* dec ax */
            ii(0x7928, 2);    if(jnzw(0x792d, 0x3)) goto l_0x792d;      /* jnz 0x792d */
            ii(0x792a, 3);    jmpw(0x7ad0, 0x1a3); goto l_0x7ad0;       /* jmp 0x7ad0 */
        l_0x792d:
            ii(0x792d, 3);    sub(ax, 0x3);                             /* sub ax, 0x3 */
            ii(0x7930, 2);    if(jnzw(0x7935, 0x3)) goto l_0x7935;      /* jnz 0x7935 */
            ii(0x7932, 3);    jmpw(0x7a54, 0x11f); goto l_0x7a54;       /* jmp 0x7a54 */
        l_0x7935:
            ii(0x7935, 1);    dec(ax);                                  /* dec ax */
            ii(0x7936, 2);    if(jnzw(0x793b, 0x3)) goto l_0x793b;      /* jnz 0x793b */
            ii(0x7938, 3);    jmpw(0x7a8b, 0x150); goto l_0x7a8b;       /* jmp 0x7a8b */
        l_0x793b:
            ii(0x793b, 3);    sub(ax, 0x10a);                           /* sub ax, 0x10a */
            ii(0x793e, 2);    if(jnzw(0x7943, 0x3)) goto l_0x7943;      /* jnz 0x7943 */
            ii(0x7940, 3);    jmpw(0x7a59, 0x116); goto l_0x7a59;       /* jmp 0x7a59 */
        l_0x7943:
            ii(0x7943, 3);    sub(ax, 0x64);                            /* sub ax, 0x64 */
            ii(0x7946, 2);    if(jnzw(0x794b, 0x3)) goto l_0x794b;      /* jnz 0x794b */
            ii(0x7948, 3);    jmpw(0x79fb, 0xb0); goto l_0x79fb;        /* jmp 0x79fb */
        l_0x794b:
            ii(0x794b, 3);    sub(ax, 0x171a);                          /* sub ax, 0x171a */
            ii(0x794e, 2);    if(jnzw(0x7953, 0x3)) goto l_0x7953;      /* jnz 0x7953 */
            ii(0x7950, 3);    jmpw(0x7a49, 0xf6); goto l_0x7a49;        /* jmp 0x7a49 */
        l_0x7953:
            ii(0x7953, 3);    sub(ax, 0xdad);                           /* sub ax, 0xdad */
            ii(0x7956, 2);    if(jzw(0x795b, 0x3)) goto l_0x795b;       /* jz 0x795b */
            ii(0x7958, 3);    jmpw(0x7ad7, 0x17c); goto l_0x7ad7;       /* jmp 0x7ad7 */
        l_0x795b:
            ii(0x795b, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
        l_0x795e:
            ii(0x795e, 5);    mov(memw_a16[ss, bp - 0x5a], 0x381);      /* mov word [bp-0x5a], 0x381 */
            ii(0x7963, 4);    cmp(memb_a16[ss, bp - 0x5e], 0);          /* cmp byte [bp-0x5e], 0x0 */
            ii(0x7967, 2);    if(jnzw(0x7976, 0xd)) goto l_0x7976;      /* jnz 0x7976 */
            ii(0x7969, 3);    callw(0xa264, 0x28f8);                    /* call 0xa264 */
            ii(0x796c, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x796e, 2);    if(jnzw(0x7976, 0x6)) goto l_0x7976;      /* jnz 0x7976 */
            ii(0x7970, 3);    callw(0x99f0, 0x207d);                    /* call 0x99f0 */
            ii(0x7973, 3);    mov(memb_a16[ss, bp - 0x5e], al);         /* mov [bp-0x5e], al */
        l_0x7976:
            ii(0x7976, 6);    mov(memw_a16[ds, 0x11fe], 0x146);         /* mov word [0x11fe], 0x146 */
            ii(0x797c, 6);    mov(memw_a16[ds, 0x1200], 0x40);          /* mov word [0x1200], 0x40 */
            ii(0x7982, 4);    les(bx, ds, 0x11fe);                      /* les bx, [0x11fe] */
            ii(0x7986, 4);    test(memb_a16[es, bx], 0x80);             /* test byte [es:bx], 0x80 */
            ii(0x798a, 2);    if(jzw(0x799a, 0xe)) goto l_0x799a;       /* jz 0x799a */
            ii(0x798c, 6);    cmp(memw_a16[ds, 0xeca], 0x500);          /* cmp word [0xeca], 0x500 */
            ii(0x7992, 2);    if(jaew(0x799a, 0x6)) goto l_0x799a;      /* jae 0x799a */
            ii(0x7994, 6);    mov(memw_a16[ds, 0xeca], 0x500);          /* mov word [0xeca], 0x500 */
        l_0x799a:
            ii(0x799a, 5);    or(memb_a16[ds, 0x14], 0x4);              /* or byte [0x14], 0x4 */
            ii(0x799f, 6);    mov(memw_a16[ds, 0x11d4], 0x5);           /* mov word [0x11d4], 0x5 */
            ii(0x79a5, 4);    cmp(memb_a16[ss, bp - 0x5e], 0);          /* cmp byte [bp-0x5e], 0x0 */
            ii(0x79a9, 2);    if(jnzw(0x79ba, 0xf)) goto l_0x79ba;      /* jnz 0x79ba */
            ii(0x79ab, 3);    callw(0xa264, 0x28b6);                    /* call 0xa264 */
            ii(0x79ae, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x79b0, 2);    if(jnzw(0x79ba, 0x8)) goto l_0x79ba;      /* jnz 0x79ba */
            ii(0x79b2, 3);    mov(ax, 0x12);                            /* mov ax, 0x12 */
            ii(0x79b5, 1);    pushw(ax);                                /* push ax */
            ii(0x79b6, 3);    callw(0x589d, -0x211c);                   /* call 0x589d */
            ii(0x79b9, 1);    popw(bx);                                 /* pop bx */
        l_0x79ba:
            ii(0x79ba, 3);    mov(ax, memw_a16[ds, 0xecc]);             /* mov ax, [0xecc] */
            ii(0x79bd, 4);    add(ax, memw_a16[ds, 0xeca]);             /* add ax, [0xeca] */
            ii(0x79c1, 3);    mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x79c4, 4);    cmp(ax, memw_a16[ds, 0xece]);             /* cmp ax, [0xece] */
            ii(0x79c8, 2);    if(jgew(0x79cd, 0x3)) goto l_0x79cd;      /* jge 0x79cd */
            ii(0x79ca, 3);    mov(memw_a16[ds, 0xece], ax);             /* mov [0xece], ax */
        l_0x79cd:
            ii(0x79cd, 3);    mov(ax, memw_a16[ds, 0xece]);             /* mov ax, [0xece] */
            ii(0x79d0, 3);    sub(ax, 0x400);                           /* sub ax, 0x400 */
            ii(0x79d3, 3);    mov(memw_a16[ds, 0xa8], ax);              /* mov [0xa8], ax */
            ii(0x79d6, 4);    inc(memb_a16[ds, 0x11f0]);                /* inc byte [0x11f0] */
            ii(0x79da, 3);    jmpw(0x7b0e, 0x131); goto l_0x7b0e;       /* jmp 0x7b0e */
        l_0x79dd:
            ii(0x79dd, 5);    mov(memw_a16[ss, bp - 0x5a], 0x8da);      /* mov word [bp-0x5a], 0x8da */
            ii(0x79e2, 3);    callw(0x9c62, 0x227d);                    /* call 0x9c62 */
            ii(0x79e5, 3);    mov(memb_a16[ds, 0x120c], al);            /* mov [0x120c], al */
            ii(0x79e8, 4);    cmp(memb_a16[ss, bp - 0x56], 0);          /* cmp byte [bp-0x56], 0x0 */
            ii(0x79ec, 2);    if(jzw(0x79f3, 0x5)) goto l_0x79f3;       /* jz 0x79f3 */
            ii(0x79ee, 5);    or(memb_a16[ds, 0x120c], 0x2);            /* or byte [0x120c], 0x2 */
        l_0x79f3:
            ii(0x79f3, 5);    mov(memb_a16[ds, 0x10ef], 0x1);           /* mov byte [0x10ef], 0x1 */
            ii(0x79f8, 3);    jmpw(0x7b0e, 0x113); goto l_0x7b0e;       /* jmp 0x7b0e */
        l_0x79fb:
            ii(0x79fb, 3);    mov(si, 0x3);                             /* mov si, 0x3 */
        l_0x79fe:
            ii(0x79fe, 5);    mov(memw_a16[ss, bp - 0x5a], 0x2824);     /* mov word [bp-0x5a], 0x2824 */
            ii(0x7a03, 5);    mov(memb_a16[ds, 0x10ee], 0x9);           /* mov byte [0x10ee], 0x9 */
        l_0x7a08:
            ii(0x7a08, 5);    mov(memb_a16[ds, 0x10ef], 0x1);           /* mov byte [0x10ef], 0x1 */
            ii(0x7a0d, 3);    callw(0x9fd0, 0x25c0);                    /* call 0x9fd0 */
            ii(0x7a10, 3);    jmpw(0x7b0e, 0xfb); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7a13:
            ii(0x7a13, 5);    mov(memw_a16[ss, bp - 0x5a], 0x3a7);      /* mov word [bp-0x5a], 0x3a7 */
            ii(0x7a18, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x7a1d, 2);    if(jlw(0x7a27, 0x8)) goto l_0x7a27;       /* jl 0x7a27 */
        l_0x7a1f:
            ii(0x7a1f, 5);    mov(memb_a16[ds, 0x36], 0x80);            /* mov byte [0x36], 0x80 */
            ii(0x7a24, 3);    jmpw(0x799a, -0x8d); goto l_0x799a;       /* jmp 0x799a */
        l_0x7a27:
            ii(0x7a27, 5);    cmp(memb_a16[ds, 0x3e], 0);               /* cmp byte [0x3e], 0x0 */
            ii(0x7a2c, 2);    if(jnzw(0x7a31, 0x3)) goto l_0x7a31;      /* jnz 0x7a31 */
            ii(0x7a2e, 3);    jmpw(0x799a, -0x97); goto l_0x799a;       /* jmp 0x799a */
        l_0x7a31:
            ii(0x7a31, 3);    mov(ax, 0x5e);                            /* mov ax, 0x5e */
            ii(0x7a34, 1);    pushw(ax);                                /* push ax */
            ii(0x7a35, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0x7a3a, 1);    popw(bx);                                 /* pop bx */
            ii(0x7a3b, 3);    mov(ax, 0x5e);                            /* mov ax, 0x5e */
            ii(0x7a3e, 1);    pushw(ax);                                /* push ax */
            ii(0x7a3f, 3);    callw(0x5a2e, -0x2014);                   /* call 0x5a2e */
            ii(0x7a42, 1);    popw(bx);                                 /* pop bx */
            ii(0x7a43, 3);    mov(memw_a16[ds, 0xf82], ax);             /* mov [0xf82], ax */
            ii(0x7a46, 3);    jmpw(0x799a, -0xaf); goto l_0x799a;       /* jmp 0x799a */
        l_0x7a49:
            ii(0x7a49, 3);    mov(si, 0x6);                             /* mov si, 0x6 */
        l_0x7a4c:
            ii(0x7a4c, 5);    mov(memw_a16[ss, bp - 0x5a], 0x71a);      /* mov word [bp-0x5a], 0x71a */
            ii(0x7a51, 3);    jmpw(0x7b0e, 0xba); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7a54:
            ii(0x7a54, 5);    mov(memb_a16[ds, 0xed0], 0);              /* mov byte [0xed0], 0x0 */
        l_0x7a59:
            ii(0x7a59, 3);    mov(si, 0x9);                             /* mov si, 0x9 */
        l_0x7a5c:
            ii(0x7a5c, 5);    mov(memw_a16[ss, bp - 0x5a], 0x8b2);      /* mov word [bp-0x5a], 0x8b2 */
            ii(0x7a61, 5);    cmp(memb_a16[ds, 0x11f0], 0);             /* cmp byte [0x11f0], 0x0 */
            ii(0x7a66, 2);    if(jzw(0x7a08, -0x60)) goto l_0x7a08;     /* jz 0x7a08 */
            ii(0x7a68, 5);    cmp(memb_a16[ds, 0x2f], 0x2);             /* cmp byte [0x2f], 0x2 */
            ii(0x7a6d, 2);    if(jnzw(0x7a08, -0x67)) goto l_0x7a08;    /* jnz 0x7a08 */
            ii(0x7a6f, 3);    callw(0x9ca9, 0x2237);                    /* call 0x9ca9 */
            ii(0x7a72, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7a74, 2);    if(jzw(0x7a86, 0x10)) goto l_0x7a86;      /* jz 0x7a86 */
        l_0x7a76:
            ii(0x7a76, 3);    mov(si, 0x8);                             /* mov si, 0x8 */
            ii(0x7a79, 5);    mov(memb_a16[ds, 0x10ee], 0xa);           /* mov byte [0x10ee], 0xa */
            ii(0x7a7e, 5);    mov(memw_a16[ss, bp - 0x5a], 0x749);      /* mov word [bp-0x5a], 0x749 */
            ii(0x7a83, 3);    jmpw(0x7b0e, 0x88); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7a86:
            ii(0x7a86, 3);    mov(ax, 0x13);                            /* mov ax, 0x13 */
            ii(0x7a89, 2);    jmpw(0x7b09, 0x7e); goto l_0x7b09;        /* jmp 0x7b09 */
        l_0x7a8b:
            ii(0x7a8b, 5);    mov(memb_a16[ds, 0xed0], 0);              /* mov byte [0xed0], 0x0 */
            ii(0x7a90, 3);    mov(si, 0xa);                             /* mov si, 0xa */
        l_0x7a93:
            ii(0x7a93, 5);    mov(memw_a16[ss, bp - 0x5a], 0x905);      /* mov word [bp-0x5a], 0x905 */
            ii(0x7a98, 3);    jmpw(0x7a08, -0x93); goto l_0x7a08;       /* jmp 0x7a08 */
        l_0x7a9b:
            ii(0x7a9b, 5);    mov(memw_a16[ss, bp - 0x5a], 0x29bc);     /* mov word [bp-0x5a], 0x29bc */
            ii(0x7aa0, 2);    jmpw(0x7b0e, 0x6c); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7aa2:
            ii(0x7aa2, 5);    mov(memw_a16[ss, bp - 0x5a], 0x679);      /* mov word [bp-0x5a], 0x679 */
            ii(0x7aa7, 2);    jmpw(0x7b0e, 0x65); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7aa9:
            ii(0x7aa9, 5);    mov(memw_a16[ss, bp - 0x5a], 0x8ac);      /* mov word [bp-0x5a], 0x8ac */
            ii(0x7aae, 5);    mov(memb_a16[ds, 0x10ee], 0x9);           /* mov byte [0x10ee], 0x9 */
            ii(0x7ab3, 3);    jmpw(0x79f3, -0xc3); goto l_0x79f3;       /* jmp 0x79f3 */
        l_0x7ab6:
            ii(0x7ab6, 5);    mov(memw_a16[ss, bp - 0x5a], 0x3d6);      /* mov word [bp-0x5a], 0x3d6 */
            ii(0x7abb, 3);    jmpw(0x799a, -0x124); goto l_0x799a;      /* jmp 0x799a */
        l_0x7abe:
            ii(0x7abe, 5);    mov(memw_a16[ss, bp - 0x5a], 0x462);      /* mov word [bp-0x5a], 0x462 */
            ii(0x7ac3, 5);    cmp(memb_a16[ds, 0x2f], 0x3);             /* cmp byte [0x2f], 0x3 */
            ii(0x7ac8, 2);    if(jgew(0x7acd, 0x3)) goto l_0x7acd;      /* jge 0x7acd */
            ii(0x7aca, 3);    jmpw(0x799a, -0x133); goto l_0x799a;      /* jmp 0x799a */
        l_0x7acd:
            ii(0x7acd, 3);    jmpw(0x7a1f, -0xb1); goto l_0x7a1f;       /* jmp 0x7a1f */
        l_0x7ad0:
            ii(0x7ad0, 5);    mov(memw_a16[ss, bp - 0x5a], 0x4f7);      /* mov word [bp-0x5a], 0x4f7 */
            ii(0x7ad5, 2);    jmpw(0x7b0e, 0x37); goto l_0x7b0e;        /* jmp 0x7b0e */
        l_0x7ad7:
            ii(0x7ad7, 3);    mov(di, 0x1190);                          /* mov di, 0x1190 */
            ii(0x7ada, 3);    mov(memb_a16[ds, di], 0);                 /* mov byte [di], 0x0 */
            ii(0x7add, 4);    cmp(memw_a16[ss, bp - 0x5c], 0);          /* cmp word [bp-0x5c], 0x0 */
            ii(0x7ae1, 2);    if(jzw(0x7b00, 0x1d)) goto l_0x7b00;      /* jz 0x7b00 */
            ii(0x7ae3, 3);    mov(ax, 0xec2);                           /* mov ax, 0xec2 */
            ii(0x7ae6, 1);    pushw(ax);                                /* push ax */
            ii(0x7ae7, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x7ae9, 1);    pushw(ax);                                /* push ax */
            ii(0x7aea, 3);    callw(0x5bde, -0x1f0f);                   /* call 0x5bde */
            ii(0x7aed, 1);    popw(bx);                                 /* pop bx */
            ii(0x7aee, 1);    popw(bx);                                 /* pop bx */
            ii(0x7aef, 3);    mov(ax, 0x14);                            /* mov ax, 0x14 */
            ii(0x7af2, 1);    pushw(ax);                                /* push ax */
            ii(0x7af3, 3);    pushw(memw_a16[ss, bp - 0x5c]);           /* push word [bp-0x5c] */
            ii(0x7af6, 3);    mov(ax, 0x1197);                          /* mov ax, 0x1197 */
            ii(0x7af9, 1);    pushw(ax);                                /* push ax */
            ii(0x7afa, 3);    callw(0x9644, 0x1b47);                    /* call 0x9644 */
            ii(0x7afd, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x7b00:
            ii(0x7b00, 6);    mov(memw_a16[ds, 0x11d4], 0x6);           /* mov word [0x11d4], 0x6 */
            ii(0x7b06, 3);    mov(ax, 0xffec);                          /* mov ax, 0xffec */
        l_0x7b09:
            ii(0x7b09, 1);    pushw(ax);                                /* push ax */
            ii(0x7b0a, 3);    callw(0x589d, -0x2270);                   /* call 0x589d */
            ii(0x7b0d, 1);    popw(bx);                                 /* pop bx */
        l_0x7b0e:
            ii(0x7b0e, 5);    cmp(memb_a16[ds, 0x10ee], -0x1 /* 0xff */); /* cmp byte [0x10ee], 0xff */
            ii(0x7b13, 2);    if(jnzw(0x7b1a, 0x5)) goto l_0x7b1a;      /* jnz 0x7b1a */
            ii(0x7b15, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7b17, 3);    mov(memb_a16[ds, 0x10ee], al);            /* mov [0x10ee], al */
        l_0x7b1a:
            ii(0x7b1a, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7b1c, 3);    mov(memb_a16[ds, 0x2e], al);              /* mov [0x2e], al */
            ii(0x7b1f, 3);    pushw(memw_a16[ss, bp - 0x5a]);           /* push word [bp-0x5a] */
            ii(0x7b22, 4);    mov(memw_a16[ss, bp - 0xec], ax);         /* mov [bp-0xec], ax */
            ii(0x7b26, 3);    callw(0x9840, 0x1d17);                    /* call 0x9840 */
            ii(0x7b29, 1);    popw(bx);                                 /* pop bx */
            ii(0x7b2a, 5);    cmp(memb_a16[ds, 0x46], 0);               /* cmp byte [0x46], 0x0 */
            ii(0x7b2f, 2);    if(jnzw(0x7b38, 0x7)) goto l_0x7b38;      /* jnz 0x7b38 */
            ii(0x7b31, 4);    mov(al, memb_a16[ss, bp - 0xec]);         /* mov al, [bp-0xec] */
            ii(0x7b35, 3);    mov(memb_a16[ds, 0x46], al);              /* mov [0x46], al */
        l_0x7b38:
            ii(0x7b38, 6);    mov(memw_a16[ds, 0x42], 0x9fa);           /* mov word [0x42], 0x9fa */
            ii(0x7b3e, 6);    mov(memw_a16[ds, 0x44], 0x20);            /* mov word [0x44], 0x20 */
            ii(0x7b44, 5);    and(memb_a16[ds, 0x47], -0x2 /* 0xfe */); /* and byte [0x47], 0xfe */
            ii(0x7b49, 3);    mov(al, memb_a16[ds, 0x46]);              /* mov al, [0x46] */
            ii(0x7b4c, 1);    cbw();                                    /* cbw */
            ii(0x7b4d, 1);    pushw(ax);                                /* push ax */
            ii(0x7b4e, 3);    callw(0x7b77, 0x26);                      /* call 0x7b77 */
            ii(0x7b51, 1);    popw(bx);                                 /* pop bx */
            ii(0x7b52, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7b54, 2);    if(jnzw(0x7b5b, 0x5)) goto l_0x7b5b;      /* jnz 0x7b5b */
            ii(0x7b56, 5);    or(memb_a16[ds, 0x47], 0x1);              /* or byte [0x47], 0x1 */
        l_0x7b5b:
            ii(0x7b5b, 2);    mov(ax, si);                              /* mov ax, si */
            ii(0x7b5d, 3);    mov(memb_a16[ds, 0x2e], al);              /* mov [0x2e], al */
            ii(0x7b60, 3);    cmp(si, 0xb);                             /* cmp si, 0xb */
            ii(0x7b63, 2);    if(jnzw(0x7b68, 0x3)) goto l_0x7b68;      /* jnz 0x7b68 */
            ii(0x7b65, 3);    callw(0xb252, 0x36ea);                    /* call 0xb252 */
        l_0x7b68:
            ii(0x7b68, 4);    cmp(memb_a16[ss, bp - 0x56], 0);          /* cmp byte [bp-0x56], 0x0 */
            ii(0x7b6c, 2);    if(jnzw(0x7b71, 0x3)) goto l_0x7b71;      /* jnz 0x7b71 */
            ii(0x7b6e, 3);    callw(0x66c8, -0x14a9);                   /* call 0x66c8 */
        l_0x7b71:
            ii(0x7b71, 1);    popw(si);                                 /* pop si */
            ii(0x7b72, 1);    popw(di);                                 /* pop di */
            ii(0x7b73, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7b75, 1);    popw(bp);                                 /* pop bp */
            ii(0x7b76, 1);    retw(); return;                           /* ret */
        }
    }
}
