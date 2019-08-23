using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xabc0-a1316ef")]
        public void Method_0000_abc0()
        {
            ii(0xabc0, 6);    mov(memd[cs, 0x6e14], esi);               /* mov [cs:0x6e14], esi */
            ii(0xabc6, 3);    xor(esi, esi);                            /* xor esi, esi */
            ii(0xabc9, 6);    mov(memd[cs, 0x6e18], edi);               /* mov [cs:0x6e18], edi */
            ii(0xabcf, 3);    xor(edi, edi);                            /* xor edi, edi */
            ii(0xabd2, 6);    mov(memd[cs, 0x6e1c], edx);               /* mov [cs:0x6e1c], edx */
            ii(0xabd8, 3);    xor(edx, edx);                            /* xor edx, edx */
            ii(0xabdb, 3);    mov(di, 0xc20);                           /* mov di, 0xc20 */
            ii(0xabde, 3);    mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0xabe1, 1);    push(ds);                                 /* push ds */
            ii(0xabe2, 1);    pop(es);                                  /* pop es */
            ii(0xabe3, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xabe5, 2);    rep(() => stosw());                       /* rep stosw */
            ii(0xabe7, 6);    mov(memw[ds, 0xc30], 0x40);               /* mov word [0xc30], 0x40 */
            ii(0xabed, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xabef, 3);    mov(bx, 0x200);                           /* mov bx, 0x200 */
            ii(0xabf2, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xabf4, 2);    if(jb(0xac0f, 0x19)) goto l_0xac0f;       /* jb 0xac0f */
            ii(0xabf6, 3);    mov(memw[ds, 0xc34], ax);                 /* mov [0xc34], ax */
            ii(0xabf9, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xabfb, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xabfd, 3);    mov(cx, 0x1000);                          /* mov cx, 0x1000 */
            ii(0xac00, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0xac02, 2);    rep(() => stosw());                       /* rep stosw */
            ii(0xac04, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xac06, 5);    mov(bx, memw[cs, 0x6d64]);                /* mov bx, [cs:0x6d64] */
            ii(0xac0b, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xac0d, 2);    if(jae(0xac12, 0x3)) goto l_0xac12;       /* jae 0xac12 */
        l_0xac0f:
            ii(0xac0f, 3);    jmp(0xaefb, 0x2e9); goto l_0xaefb;        /* jmp 0xaefb */
        l_0xac12:
            ii(0xac12, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xac14, 3);    call(0xb2c2, 0x6ab);                      /* call 0xb2c2 */
            ii(0xac17, 3);    mov(ax, memw[ds, 0xf50]);                 /* mov ax, [0xf50] */
            ii(0xac1a, 3);    add(ax, 0x2a);                            /* add ax, 0x2a */
            ii(0xac1d, 1);    push(cs);                                 /* push cs */
            ii(0xac1e, 1);    pop(ds);                                  /* pop ds */
            ii(0xac1f, 3);    mov(memw[ds, 0x17c2], ax);                /* mov [0x17c2], ax */
            ii(0xac22, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0xac25, 5);    call_far_abs(0x35f, 0x6dc2);              /* call word 0x35f:0x6dc2 */
            ii(0xac2a, 2);    if(jb_func(0xabad, -0x7f)) return;        /* jb 0xabad */
            ii(0xac2c, 1);    cld();                                    /* cld */
            ii(0xac2d, 7);    mov(memw[ss, 0xac2], 0x71fc);             /* mov word [ss:0xac2], 0x71fc */
            ii(0xac34, 5);    mov(memw[ss, 0xc32], ds);                 /* mov [ss:0xc32], ds */
            ii(0xac39, 4);    mov(memw[ds, 0x208e], ss);                /* mov [0x208e], ss */
            ii(0xac3d, 5);    mov(memw[ss, 0xc2a], es);                 /* mov [ss:0xc2a], es */
            ii(0xac42, 5);    mov(memw[ss, 0x9b2], es);                 /* mov [ss:0x9b2], es */
            ii(0xac47, 4);    mov(ax, memw[es, 0x2c]);                  /* mov ax, [es:0x2c] */
            ii(0xac4b, 4);    mov(memw[ss, 0xc2c], ax);                 /* mov [ss:0xc2c], ax */
            ii(0xac4f, 5);    mov(memw[ss, 0x8], ds);                   /* mov [ss:0x8], ds */
            ii(0xac54, 4);    mov(memw[ds, 0x17c0], cs);                /* mov [0x17c0], cs */
            ii(0xac58, 4);    mov(memw[ds, 0x17c4], ss);                /* mov [0x17c4], ss */
            ii(0xac5c, 3);    sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0xac5f, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0xac61, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xac63, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xac65, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xac68, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac6a, 5);    and(memb[es, di + 0x6], -0x41 /* 0xbf */); /* and byte [es:di+0x6], 0xbf */
            ii(0xac6f, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xac72, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac74, 2);    mov(bx, ds);                              /* mov bx, ds */
            ii(0xac76, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xac78, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xac7a, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xac7d, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac7f, 5);    and(memb[es, di + 0x6], -0x41 /* 0xbf */); /* and byte [es:di+0x6], 0xbf */
            ii(0xac84, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xac87, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac89, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xac8c, 3);    mov(si, 0x6d3d);                          /* mov si, 0x6d3d */
            ii(0xac8f, 3);    mov(ax, 0xa00);                           /* mov ax, 0xa00 */
            ii(0xac92, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac94, 3);    mov(ax, 0x305);                           /* mov ax, 0x305 */
            ii(0xac97, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xac99, 4);    mov(memw[ds, 0x6d4e], cx);                /* mov [0x6d4e], cx */
            ii(0xac9d, 4);    mov(memw[ds, 0x6d50], bx);                /* mov [0x6d50], bx */
            ii(0xaca1, 5);    mov(memd[ds, 0x6d54], edi);               /* mov [0x6d54], edi */
            ii(0xaca6, 4);    mov(memw[ds, 0x6d58], si);                /* mov [0x6d58], si */
            ii(0xacaa, 3);    mov(memw[ds, 0x6d52], ax);                /* mov [0x6d52], ax */
            ii(0xacad, 3);    mov(ax, 0x306);                           /* mov ax, 0x306 */
            ii(0xacb0, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xacb2, 2);    if(jae(0xacb7, 0x3)) goto l_0xacb7;       /* jae 0xacb7 */
            ii(0xacb4, 3);    jmp(0xaefb, 0x244); goto l_0xaefb;        /* jmp 0xaefb */
        l_0xacb7:
            ii(0xacb7, 4);    mov(memw[ds, 0x6d5a], cx);                /* mov [0x6d5a], cx */
            ii(0xacbb, 4);    mov(memw[ds, 0x6d5c], bx);                /* mov [0x6d5c], bx */
            ii(0xacbf, 5);    mov(memd[ds, 0x6d5e], edi);               /* mov [0x6d5e], edi */
            ii(0xacc4, 4);    mov(memw[ds, 0x6d62], si);                /* mov [0x6d62], si */
            ii(0xacc8, 2);    mov(bl, 0x21);                            /* mov bl, 0x21 */
            ii(0xacca, 3);    mov(ax, 0x204);                           /* mov ax, 0x204 */
            ii(0xaccd, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaccf, 5);    mov(memd[ds, 0x6d66], edx);               /* mov [0x6d66], edx */
            ii(0xacd4, 4);    mov(memw[ds, 0x6d6a], cx);                /* mov [0x6d6a], cx */
            ii(0xacd8, 5);    mov(memw[ss, 0xc42], cx);                 /* mov [ss:0xc42], cx */
            ii(0xacdd, 1);    push(ss);                                 /* push ss */
            ii(0xacde, 1);    pop(ds);                                  /* pop ds */
            ii(0xacdf, 1);    push(ds);                                 /* push ds */
            ii(0xace0, 1);    pop(es);                                  /* pop es */
            ii(0xace1, 3);    mov(di, 0xc0);                            /* mov di, 0xc0 */
            ii(0xace4, 1);    push(cs);                                 /* push cs */
            ii(0xace5, 3);    call(0xb3a6, 0x6be);                      /* call 0xb3a6 */
            ii(0xace8, 4);    mov(memw[ds, 0xc26], cs);                 /* mov [0xc26], cs */
            ii(0xacec, 4);    mov(memw[ds, 0xaf8], cs);                 /* mov [0xaf8], cs */
            ii(0xacf0, 4);    mov(memw[ds, 0xc28], ss);                 /* mov [0xc28], ss */
            ii(0xacf4, 1);    sti();                                    /* sti */
            ii(0xacf5, 4);    mov(memw[ds, 0x2c], ss);                  /* mov [0x2c], ss */
            ii(0xacf9, 4);    mov(memw[ds, 0x18], cs);                  /* mov [0x18], cs */
            ii(0xacfd, 4);    mov(memw[ds, 0x1c], cs);                  /* mov [0x1c], cs */
            ii(0xad01, 6);    mov(memw[ds, 0x22], 0x7364);              /* mov word [0x22], 0x7364 */
            ii(0xad07, 4);    mov(memw[ds, 0x24], cs);                  /* mov [0x24], cs */
            ii(0xad0b, 4);    mov(memw[ds, 0xc], ss);                   /* mov [0xc], ss */
            ii(0xad0f, 4);    mov(memw[ds, 0x3c], ss);                  /* mov [0x3c], ss */
            ii(0xad13, 4);    mov(memw[ds, 0x998], ss);                 /* mov [0x998], ss */
            ii(0xad17, 4);    mov(memw[ds, 0x44], ss);                  /* mov [0x44], ss */
            ii(0xad1b, 3);    mov(ax, 0x203);                           /* mov ax, 0x203 */
            ii(0xad1e, 2);    mov(bl, 0x11);                            /* mov bl, 0x11 */
            ii(0xad20, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xad22, 3);    mov(dx, 0x6d6c);                          /* mov dx, 0x6d6c */
        l_0xad25:
            ii(0xad25, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad27, 3);    add(dx, 0x4);                             /* add dx, 0x4 */
            ii(0xad2a, 2);    dec(bl);                                  /* dec bl */
            ii(0xad2c, 3);    cmp(bl, 0x6);                             /* cmp bl, 0x6 */
            ii(0xad2f, 2);    if(jae(0xad25, -0xc)) goto l_0xad25;      /* jae 0xad25 */
            ii(0xad31, 2);    mov(bl, 0xd);                             /* mov bl, 0xd */
            ii(0xad33, 3);    mov(dx, 0x6abb);                          /* mov dx, 0x6abb */
            ii(0xad36, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad38, 3);    mov(dx, 0x71f4);                          /* mov dx, 0x71f4 */
            ii(0xad3b, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xad3d, 2);    mov(bl, 0x3);                             /* mov bl, 0x3 */
            ii(0xad3f, 3);    mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0xad42, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad44, 3);    mov(dx, 0x732b);                          /* mov dx, 0x732b */
            ii(0xad47, 2);    mov(bl, 0x1);                             /* mov bl, 0x1 */
            ii(0xad49, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad4b, 3);    mov(dx, 0x71f8);                          /* mov dx, 0x71f8 */
            ii(0xad4e, 2);    mov(bl, 0);                               /* mov bl, 0x0 */
            ii(0xad50, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad52, 3);    mov(dx, 0x7584);                          /* mov dx, 0x7584 */
            ii(0xad55, 2);    mov(bl, 0x23);                            /* mov bl, 0x23 */
            ii(0xad57, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad59, 6);    cmp(memb[cs, 0x6d4b], 0);                 /* cmp byte [cs:0x6d4b], 0x0 */
            ii(0xad5f, 2);    if(jnz(0xad66, 0x5)) goto l_0xad66;       /* jnz 0xad66 */
            ii(0xad61, 3);    mov(ax, 0x1682);                          /* mov ax, 0x1682 */
            ii(0xad64, 2);    @int(0x2f);                               /* int 0x2f */
        l_0xad66:
            ii(0xad66, 3);    mov(ax, 0x3);                             /* mov ax, 0x3 */
            ii(0xad69, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad6b, 3);    mov(memw[ds, 0xc48], ax);                 /* mov [0xc48], ax */
            ii(0xad6e, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0xad70:
            ii(0xad70, 1);    inc(cx);                                  /* inc cx */
            ii(0xad71, 2);    shr(ax, 0x1);                             /* shr ax, 1 */
            ii(0xad73, 2);    if(jae(0xad70, -0x5)) goto l_0xad70;      /* jae 0xad70 */
            ii(0xad75, 4);    mov(memw[ds, 0xc46], cx);                 /* mov [0xc46], cx */
            ii(0xad79, 3);    mov(cx, 0x6);                             /* mov cx, 0x6 */
            ii(0xad7c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xad7e, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad80, 2);    if(jae(0xad85, 0x3)) goto l_0xad85;       /* jae 0xad85 */
        l_0xad82:
            ii(0xad82, 3);    jmp(0xaefb, 0x176); goto l_0xaefb;        /* jmp 0xaefb */
        l_0xad85:
            ii(0xad85, 3);    mov(memw[ds, 0xc2e], ax);                 /* mov [0xc2e], ax */
            ii(0xad88, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0xad89, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0xad8c, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0xad8f, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xad91, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xad93, 2);    if(jb(0xad82, -0x13)) goto l_0xad82;      /* jb 0xad82 */
            ii(0xad95, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xad99, 4);    mov(memw[ds, 0xc38], bx);                 /* mov [0xc38], bx */
            ii(0xad9d, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xad9f, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xada1, 2);    if(jb(0xad82, -0x21)) goto l_0xad82;      /* jb 0xad82 */
            ii(0xada3, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xada7, 4);    mov(memw[ds, 0xc3e], bx);                 /* mov [0xc3e], bx */
            ii(0xadab, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xadad, 2);    if(jb(0xad82, -0x2d)) goto l_0xad82;      /* jb 0xad82 */
            ii(0xadaf, 3);    sub(sp, 0x8);                             /* sub sp, 0x8 */
            ii(0xadb2, 1);    push(ss);                                 /* push ss */
            ii(0xadb3, 1);    pop(es);                                  /* pop es */
            ii(0xadb4, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xadb6, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xadba, 4);    mov(memw[ds, 0xc3c], bx);                 /* mov [0xc3c], bx */
            ii(0xadbe, 4);    mov(memw[ds, 0xaf4], bx);                 /* mov [0xaf4], bx */
            ii(0xadc2, 4);    mov(memw[ds, 0xa00], bx);                 /* mov [0xa00], bx */
            ii(0xadc6, 4);    mov(memw[ds, 0xa08], bx);                 /* mov [0xa08], bx */
            ii(0xadca, 3);    mov(ax, 0xb);                             /* mov ax, 0xb */
            ii(0xadcd, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xadcf, 3);    call(0x5cc4, -0x510e);                    /* call 0x5cc4 */
            ii(0xadd2, 1);    dec(ax);                                  /* dec ax */
            ii(0xadd3, 1);    stosw();                                  /* stosw */
            ii(0xadd4, 3);    mov(ax, memw[ds, 0xa10]);                 /* mov ax, [0xa10] */
            ii(0xadd7, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0xadda, 2);    mul(cx);                                  /* mul cx */
            ii(0xaddc, 1);    stosw();                                  /* stosw */
            ii(0xaddd, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xadde, 1);    stosb();                                  /* stosb */
            ii(0xaddf, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xade1, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xade4, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xade6, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xade8, 4);    mov(memw[ds, 0x5680], ss);                /* mov [0x5680], ss */
            ii(0xadec, 2);    mov(ax, cs);                              /* mov ax, cs */
            ii(0xadee, 3);    mov(memw[ds, 0x3ea8], ax);                /* mov [0x3ea8], ax */
            ii(0xadf1, 4);    mov(memw[ds, 0x403], bx);                 /* mov [0x403], bx */
            ii(0xadf5, 6);    mov(memw[ds, 0x401], 0x5692);             /* mov word [0x401], 0x5692 */
            ii(0xadfb, 5);    mov(memb[ds, 0x400], 0xea);               /* mov byte [0x400], 0xea */
            ii(0xae00, 3);    mov(si, 0x7a0);                           /* mov si, 0x7a0 */
        l_0xae03:
            ii(0xae03, 3);    mov(memw[ds, si + 0x2], bx);              /* mov [si+0x2], bx */
            ii(0xae06, 3);    mov(memw[ds, si + 0x6], bx);              /* mov [si+0x6], bx */
            ii(0xae09, 3);    add(si, 0x8);                             /* add si, 0x8 */
            ii(0xae0c, 3);    cmp(memw[ds, si], 0);                     /* cmp word [si], 0x0 */
            ii(0xae0f, 2);    if(jnz(0xae03, -0xe)) goto l_0xae03;      /* jnz 0xae03 */
            ii(0xae11, 3);    lar(cx, ax);                              /* lar cx, ax */
            ii(0xae14, 3);    shr(cx, 0x8);                             /* shr cx, 0x8 */
            ii(0xae17, 3);    mov(ax, 0x9);                             /* mov ax, 0x9 */
            ii(0xae1a, 1);    push(bx);                                 /* push bx */
            ii(0xae1b, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae1d, 2);    mov(cx, ds);                              /* mov cx, ds */
            ii(0xae1f, 3);    mov(bx, 0x10);                            /* mov bx, 0x10 */
            ii(0xae22, 3);    mov(ax, 0x205);                           /* mov ax, 0x205 */
        l_0xae25:
            ii(0xae25, 2);    mov(dx, bx);                              /* mov dx, bx */
            ii(0xae27, 3);    shl(dx, 0x2);                             /* shl dx, 0x2 */
            ii(0xae2a, 4);    add(dx, 0);                               /* add dx, 0x0 */
            ii(0xae2e, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae30, 2);    if(jae(0xae35, 0x3)) goto l_0xae35;       /* jae 0xae35 */
        l_0xae32:
            ii(0xae32, 3);    jmp(0xaefb, 0xc6); goto l_0xaefb;         /* jmp 0xaefb */
        l_0xae35:
            ii(0xae35, 2);    inc(bl);                                  /* inc bl */
            ii(0xae37, 3);    cmp(bl, 0x1b);                            /* cmp bl, 0x1b */
            ii(0xae3a, 2);    if(jz(0xae35, -0x7)) goto l_0xae35;       /* jz 0xae35 */
            ii(0xae3c, 3);    cmp(bl, 0x1c);                            /* cmp bl, 0x1c */
            ii(0xae3f, 2);    if(jz(0xae35, -0xc)) goto l_0xae35;       /* jz 0xae35 */
            ii(0xae41, 3);    cmp(bl, 0x23);                            /* cmp bl, 0x23 */
            ii(0xae44, 2);    if(jz(0xae35, -0x11)) goto l_0xae35;      /* jz 0xae35 */
            ii(0xae46, 3);    cmp(bl, 0x24);                            /* cmp bl, 0x24 */
            ii(0xae49, 2);    if(jz(0xae35, -0x16)) goto l_0xae35;      /* jz 0xae35 */
            ii(0xae4b, 3);    cmp(bl, 0x2f);                            /* cmp bl, 0x2f */
            ii(0xae4e, 2);    if(jz(0xae35, -0x1b)) goto l_0xae35;      /* jz 0xae35 */
            ii(0xae50, 3);    cmp(bl, 0x16);                            /* cmp bl, 0x16 */
            ii(0xae53, 2);    if(jz(0xae35, -0x20)) goto l_0xae35;      /* jz 0xae35 */
            ii(0xae55, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0xae58, 2);    if(jbe(0xae25, -0x35)) goto l_0xae25;     /* jbe 0xae25 */
            ii(0xae5a, 3);    mov(dx, 0xc9e);                           /* mov dx, 0xc9e */
            ii(0xae5d, 2);    mov(bl, 0x21);                            /* mov bl, 0x21 */
            ii(0xae5f, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae61, 2);    if(jb(0xae32, -0x31)) goto l_0xae32;      /* jb 0xae32 */
            ii(0xae63, 3);    mov(dx, 0x1a83);                          /* mov dx, 0x1a83 */
            ii(0xae66, 2);    mov(bl, 0x10);                            /* mov bl, 0x10 */
            ii(0xae68, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae6a, 3);    mov(dx, 0x556);                           /* mov dx, 0x556 */
            ii(0xae6d, 2);    mov(bl, 0x75);                            /* mov bl, 0x75 */
            ii(0xae6f, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae71, 1);    push(ss);                                 /* push ss */
            ii(0xae72, 1);    pop(ds);                                  /* pop ds */
            ii(0xae73, 3);    mov(ax, 0x1fff);                          /* mov ax, 0x1fff */
            ii(0xae76, 1);    stosw();                                  /* stosw */
            ii(0xae77, 3);    mov(ax, memw[ds, 0xc34]);                 /* mov ax, [0xc34] */
            ii(0xae7a, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0xae7d, 2);    mul(cx);                                  /* mul cx */
            ii(0xae7f, 1);    stosw();                                  /* stosw */
            ii(0xae80, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xae81, 1);    stosb();                                  /* stosb */
            ii(0xae82, 1);    pop(bx);                                  /* pop bx */
            ii(0xae83, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xae87, 4);    mov(memw[ds, 0xc34], bx);                 /* mov [0xc34], bx */
            ii(0xae8b, 4);    mov(memw[ds, 0xaa2], bx);                 /* mov [0xaa2], bx */
            ii(0xae8f, 2);    mov(di, sp);                              /* mov di, sp */
            ii(0xae91, 3);    mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0xae94, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xae96, 4);    add(bx, memw[ds, 0xc48]);                 /* add bx, [0xc48] */
            ii(0xae9a, 4);    mov(memw[ds, 0xa9c], bx);                 /* mov [0xa9c], bx */
            ii(0xae9e, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0xaea1, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0xaea3, 3);    mov(dx, 0xffff);                          /* mov dx, 0xffff */
            ii(0xaea6, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaea8, 1);    inc(ax);                                  /* inc ax */
            ii(0xaea9, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0xaeab, 3);    lar(cx, cx);                              /* lar cx, cx */
            ii(0xaeae, 3);    shr(cx, 0x8);                             /* shr cx, 0x8 */
            ii(0xaeb1, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaeb3, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xaeb6, 3);    call(0xb1b9, 0x300);                      /* call 0xb1b9 */
            ii(0xaeb9, 2);    mov(dl, 0);                               /* mov dl, 0x0 */
            ii(0xaebb, 4);    xchg(memb[ds, 0x980], dl);                /* xchg [0x980], dl */
            ii(0xaebf, 3);    mov(bx, 0x40);                            /* mov bx, 0x40 */
            ii(0xaec2, 2);    mov(ah, 0x48);                            /* mov ah, 0x48 */
            ii(0xaec4, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xaec6, 4);    if(jae(0xaecd, 0x3)) goto l_0xaecd;       /* jae 0xaecd */
            ii(0xaeca, 2);    jmp(0xaefb, 0x2f); goto l_0xaefb;         /* jmp 0xaefb */
        //  ii(0xaecc, 1);    nop();                                    /* nop */
        l_0xaecd:
            ii(0xaecd, 3);    mov(memw[ds, 0xc4c], ax);                 /* mov [0xc4c], ax */
            ii(0xaed0, 4);    mov(memb[ds, 0x980], dl);                 /* mov [0x980], dl */
            ii(0xaed4, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xaed6, 2);    xor(di, di);                              /* xor di, di */
            ii(0xaed8, 1);    push(cs);                                 /* push cs */
            ii(0xaed9, 3);    call(0xb331, 0x455);                      /* call 0xb331 */
            ii(0xaedc, 6);    mov(esi, memd[cs, 0x6e14]);               /* mov esi, [cs:0x6e14] */
            ii(0xaee2, 6);    mov(edi, memd[cs, 0x6e18]);               /* mov edi, [cs:0x6e18] */
            ii(0xaee8, 6);    mov(edx, memd[cs, 0x6e1c]);               /* mov edx, [cs:0x6e1c] */
            ii(0xaeee, 6);    mov(memw[ds, 0xaa4], 0x571d);             /* mov word [0xaa4], 0x571d */
            ii(0xaef4, 6);    mov(memw[ds, 0xaa6], 0x56f4);             /* mov word [0xaa6], 0x56f4 */
            ii(0xaefa, 1);    ret(); return;                            /* ret */
        l_0xaefb:
            ii(0xaefb, 2);    push(0x20);                               /* push 0x20 */
            ii(0xaefd, 3);    call(0x604d, -0x4eb3);                    /* call 0x604d */
            ii(0xaf00, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xaf02, 3);    mov(ax, memw[ds, bx + 0x2]);              /* mov ax, [bx+0x2] */
            ii(0xaf05, 4);    mov(es, memw[ds, 0xc34]);                 /* mov es, [0xc34] */
            ii(0xaf09, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xaf0b, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0xaf0e, 4);    or(memb[es, bx], -0x80 /* 0x80 */);       /* or byte [es:bx], 0x80 */
            ii(0xaf12, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0xaf13, 3);    mov(al, memb[ds, 0x980]);                 /* mov al, [0x980] */
            ii(0xaf16, 2);    cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0xaf18, 2);    if(jae(0xaf2e, 0x14)) goto l_0xaf2e;      /* jae 0xaf2e */
            ii(0xaf1a, 1);    push(ax);                                 /* push ax */
            ii(0xaf1b, 5);    mov(memb[ds, 0x980], 0x2);                /* mov byte [0x980], 0x2 */
            ii(0xaf20, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xaf22, 2);    mov(dh, 0x3);                             /* mov dh, 0x3 */
            ii(0xaf24, 2);    mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0xaf26, 1);    push(bx);                                 /* push bx */
            ii(0xaf27, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xaf29, 1);    pop(bx);                                  /* pop bx */
            ii(0xaf2a, 1);    pop(ax);                                  /* pop ax */
            ii(0xaf2b, 3);    mov(memb[ds, 0x980], al);                 /* mov [0x980], al */
        l_0xaf2e:
            ii(0xaf2e, 4);    cmp(bx, memw[ds, 0xc3c]);                 /* cmp bx, [0xc3c] */
            ii(0xaf32, 2);    if(jnz(0xaf3c, 0x8)) goto l_0xaf3c;       /* jnz 0xaf3c */
            ii(0xaf34, 3);    mov(ax, 0xa);                             /* mov ax, 0xa */
            ii(0xaf37, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaf39, 3);    mov(memw[ds, 0xc24], ax);                 /* mov [0xc24], ax */
        l_0xaf3c:
            ii(0xaf3c, 3);    mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0xaf3f, 2);    @int(0x31);                               /* int 0x31 */
            ii(0xaf41, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xaf42, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xaf44, 1);    ret();                                    /* ret */
        }
    }
}
