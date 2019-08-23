using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5a50-f39c2584")]
        public void Method_0000_5a50()
        {
            ii(0x5a50, 4);    pop(memw[ds, 0xd10]);                     /* pop word [0xd10] */
            ii(0x5a54, 2);    mov(ah, 0x30);                            /* mov ah, 0x30 */
            ii(0x5a56, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x5a58, 3);    mov(memw[ds, 0xcee], ax);                 /* mov [0xcee], ax */
            ii(0x5a5b, 3);    mov(dx, 0x1);                             /* mov dx, 0x1 */
            ii(0x5a5e, 2);    cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x5a60, 2);    if(jz(0x5a8b, 0x29)) goto l_0x5a8b;       /* jz 0x5a8b */
            ii(0x5a62, 4);    mov(es, memw[ds, 0xcec]);                 /* mov es, [0xcec] */
            ii(0x5a66, 5);    mov(es, memw[es, 0x2c]);                  /* mov es, [es:0x2c] */
            ii(0x5a6b, 4);    mov(memw[ds, 0xcfa], es);                 /* mov [0xcfa], es */
            ii(0x5a6f, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5a71, 1);    cwd();                                    /* cwd */
            ii(0x5a72, 3);    mov(cx, 0x8000);                          /* mov cx, 0x8000 */
            ii(0x5a75, 2);    xor(di, di);                              /* xor di, di */
        l_0x5a77:
            ii(0x5a77, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x5a79, 1);    scasb();                                  /* scasb */
            ii(0x5a7a, 2);    if(jnz(0x5a77, -0x5)) goto l_0x5a77;      /* jnz 0x5a77 */
            ii(0x5a7c, 1);    inc(di);                                  /* inc di */
            ii(0x5a7d, 1);    inc(di);                                  /* inc di */
            ii(0x5a7e, 4);    mov(memw[ds, 0xcf8], di);                 /* mov [0xcf8], di */
            ii(0x5a82, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x5a85, 2);    repne(() => scasb());                     /* repne scasb */
            ii(0x5a87, 2);    not(cx);                                  /* not cx */
            ii(0x5a89, 2);    mov(dx, cx);                              /* mov dx, cx */
        l_0x5a8b:
            ii(0x5a8b, 3);    mov(di, 0x1);                             /* mov di, 0x1 */
            ii(0x5a8e, 3);    mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x5a91, 4);    mov(ds, memw[ds, 0xcec]);                 /* mov ds, [0xcec] */
        l_0x5a95:
            ii(0x5a95, 1);    lodsb();                                  /* lodsb */
            ii(0x5a96, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x5a98, 2);    if(jz(0x5a95, -0x5)) goto l_0x5a95;       /* jz 0x5a95 */
            ii(0x5a9a, 2);    cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x5a9c, 2);    if(jz(0x5a95, -0x9)) goto l_0x5a95;       /* jz 0x5a95 */
            ii(0x5a9e, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5aa0, 2);    if(jz(0x5b11, 0x6f)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5aa2, 2);    or(al, al);                               /* or al, al */
            ii(0x5aa4, 2);    if(jz(0x5b11, 0x6b)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5aa6, 1);    inc(di);                                  /* inc di */
        l_0x5aa7:
            ii(0x5aa7, 1);    dec(si);                                  /* dec si */
        l_0x5aa8:
            ii(0x5aa8, 1);    lodsb();                                  /* lodsb */
            ii(0x5aa9, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x5aab, 2);    if(jz(0x5a95, -0x18)) goto l_0x5a95;      /* jz 0x5a95 */
            ii(0x5aad, 2);    cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x5aaf, 2);    if(jz(0x5a95, -0x1c)) goto l_0x5a95;      /* jz 0x5a95 */
            ii(0x5ab1, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5ab3, 2);    if(jz(0x5b11, 0x5c)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5ab5, 2);    or(al, al);                               /* or al, al */
            ii(0x5ab7, 2);    if(jz(0x5b11, 0x58)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5ab9, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5abb, 2);    if(jz(0x5ae1, 0x24)) goto l_0x5ae1;       /* jz 0x5ae1 */
            ii(0x5abd, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5abf, 2);    if(jz(0x5ac4, 0x3)) goto l_0x5ac4;        /* jz 0x5ac4 */
            ii(0x5ac1, 1);    inc(dx);                                  /* inc dx */
            ii(0x5ac2, 2);    jmp(0x5aa8, -0x1c); goto l_0x5aa8;        /* jmp 0x5aa8 */
        l_0x5ac4:
            ii(0x5ac4, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0x5ac6:
            ii(0x5ac6, 1);    inc(cx);                                  /* inc cx */
            ii(0x5ac7, 1);    lodsb();                                  /* lodsb */
            ii(0x5ac8, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5aca, 2);    if(jz(0x5ac6, -0x6)) goto l_0x5ac6;       /* jz 0x5ac6 */
            ii(0x5acc, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5ace, 2);    if(jz(0x5ad4, 0x4)) goto l_0x5ad4;        /* jz 0x5ad4 */
            ii(0x5ad0, 2);    add(dx, cx);                              /* add dx, cx */
            ii(0x5ad2, 2);    jmp(0x5aa7, -0x2d); goto l_0x5aa7;        /* jmp 0x5aa7 */
        l_0x5ad4:
            ii(0x5ad4, 2);    mov(ax, cx);                              /* mov ax, cx */
            ii(0x5ad6, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5ad8, 2);    adc(dx, cx);                              /* adc dx, cx */
            ii(0x5ada, 2);    test(al, 0x1);                            /* test al, 0x1 */
            ii(0x5adc, 2);    if(jnz(0x5aa8, -0x36)) goto l_0x5aa8;     /* jnz 0x5aa8 */
            ii(0x5ade, 2);    jmp(0x5ae1, 0x1); goto l_0x5ae1;          /* jmp 0x5ae1 */
        l_0x5ae0:
            ii(0x5ae0, 1);    dec(si);                                  /* dec si */
        l_0x5ae1:
            ii(0x5ae1, 1);    lodsb();                                  /* lodsb */
            ii(0x5ae2, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5ae4, 2);    if(jz(0x5b11, 0x2b)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5ae6, 2);    or(al, al);                               /* or al, al */
            ii(0x5ae8, 2);    if(jz(0x5b11, 0x27)) goto l_0x5b11;       /* jz 0x5b11 */
            ii(0x5aea, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5aec, 2);    if(jz(0x5aa8, -0x46)) goto l_0x5aa8;      /* jz 0x5aa8 */
            ii(0x5aee, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5af0, 2);    if(jz(0x5af5, 0x3)) goto l_0x5af5;        /* jz 0x5af5 */
            ii(0x5af2, 1);    inc(dx);                                  /* inc dx */
            ii(0x5af3, 2);    jmp(0x5ae1, -0x14); goto l_0x5ae1;        /* jmp 0x5ae1 */
        l_0x5af5:
            ii(0x5af5, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0x5af7:
            ii(0x5af7, 1);    inc(cx);                                  /* inc cx */
            ii(0x5af8, 1);    lodsb();                                  /* lodsb */
            ii(0x5af9, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5afb, 2);    if(jz(0x5af7, -0x6)) goto l_0x5af7;       /* jz 0x5af7 */
            ii(0x5afd, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5aff, 2);    if(jz(0x5b05, 0x4)) goto l_0x5b05;        /* jz 0x5b05 */
            ii(0x5b01, 2);    add(dx, cx);                              /* add dx, cx */
            ii(0x5b03, 2);    jmp(0x5ae0, -0x25); goto l_0x5ae0;        /* jmp 0x5ae0 */
        l_0x5b05:
            ii(0x5b05, 2);    mov(ax, cx);                              /* mov ax, cx */
            ii(0x5b07, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5b09, 2);    adc(dx, cx);                              /* adc dx, cx */
            ii(0x5b0b, 2);    test(al, 0x1);                            /* test al, 0x1 */
            ii(0x5b0d, 2);    if(jnz(0x5ae1, -0x2e)) goto l_0x5ae1;     /* jnz 0x5ae1 */
            ii(0x5b0f, 2);    jmp(0x5aa8, -0x69); goto l_0x5aa8;        /* jmp 0x5aa8 */
        l_0x5b11:
            ii(0x5b11, 1);    push(ss);                                 /* push ss */
            ii(0x5b12, 1);    pop(ds);                                  /* pop ds */
            ii(0x5b13, 4);    mov(memw[ds, 0xcf2], di);                 /* mov [0xcf2], di */
            ii(0x5b17, 2);    add(dx, di);                              /* add dx, di */
            ii(0x5b19, 1);    inc(di);                                  /* inc di */
            ii(0x5b1a, 2);    shl(di, 0x1);                             /* shl di, 1 */
            ii(0x5b1c, 2);    add(dx, di);                              /* add dx, di */
            ii(0x5b1e, 1);    inc(dx);                                  /* inc dx */
            ii(0x5b1f, 3);    and(dl, 0xfe);                            /* and dl, 0xfe */
            ii(0x5b22, 2);    sub(sp, dx);                              /* sub sp, dx */
            ii(0x5b24, 2);    mov(ax, sp);                              /* mov ax, sp */
            ii(0x5b26, 3);    mov(memw[ds, 0xcf4], ax);                 /* mov [0xcf4], ax */
            ii(0x5b29, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x5b2b, 2);    add(di, bx);                              /* add di, bx */
            ii(0x5b2d, 1);    push(ss);                                 /* push ss */
            ii(0x5b2e, 1);    pop(es);                                  /* pop es */
            ii(0x5b2f, 3);    mov(memw[ss, bx], di);                    /* mov [ss:bx], di */
            ii(0x5b32, 1);    inc(bx);                                  /* inc bx */
            ii(0x5b33, 1);    inc(bx);                                  /* inc bx */
            ii(0x5b34, 4);    lds(si, memw[ds, 0xcf8]);                 /* lds si, [0xcf8] */
        l_0x5b38:
            ii(0x5b38, 1);    lodsb();                                  /* lodsb */
            ii(0x5b39, 1);    stosb();                                  /* stosb */
            ii(0x5b3a, 2);    or(al, al);                               /* or al, al */
            ii(0x5b3c, 2);    if(jnz(0x5b38, -0x6)) goto l_0x5b38;      /* jnz 0x5b38 */
            ii(0x5b3e, 5);    mov(ds, memw[ss, 0xcec]);                 /* mov ds, [ss:0xcec] */
            ii(0x5b43, 3);    mov(si, 0x81);                            /* mov si, 0x81 */
            ii(0x5b46, 2);    jmp(0x5b4b, 0x3); goto l_0x5b4b;          /* jmp 0x5b4b */
        l_0x5b48:
            ii(0x5b48, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5b4a, 1);    stosb();                                  /* stosb */
        l_0x5b4b:
            ii(0x5b4b, 1);    lodsb();                                  /* lodsb */
            ii(0x5b4c, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x5b4e, 2);    if(jz(0x5b4b, -0x5)) goto l_0x5b4b;       /* jz 0x5b4b */
            ii(0x5b50, 2);    cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x5b52, 2);    if(jz(0x5b4b, -0x9)) goto l_0x5b4b;       /* jz 0x5b4b */
            ii(0x5b54, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5b56, 2);    if(jz(0x5bd4, 0x7c)) goto l_0x5bd4;       /* jz 0x5bd4 */
            ii(0x5b58, 2);    or(al, al);                               /* or al, al */
            ii(0x5b5a, 2);    if(jz(0x5bd4, 0x78)) goto l_0x5bd4;       /* jz 0x5bd4 */
            ii(0x5b5c, 3);    mov(memw[ss, bx], di);                    /* mov [ss:bx], di */
            ii(0x5b5f, 1);    inc(bx);                                  /* inc bx */
            ii(0x5b60, 1);    inc(bx);                                  /* inc bx */
        l_0x5b61:
            ii(0x5b61, 1);    dec(si);                                  /* dec si */
        l_0x5b62:
            ii(0x5b62, 1);    lodsb();                                  /* lodsb */
            ii(0x5b63, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x5b65, 2);    if(jz(0x5b48, -0x1f)) goto l_0x5b48;      /* jz 0x5b48 */
            ii(0x5b67, 2);    cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x5b69, 2);    if(jz(0x5b48, -0x23)) goto l_0x5b48;      /* jz 0x5b48 */
            ii(0x5b6b, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5b6d, 2);    if(jz(0x5bd1, 0x62)) goto l_0x5bd1;       /* jz 0x5bd1 */
            ii(0x5b6f, 2);    or(al, al);                               /* or al, al */
            ii(0x5b71, 2);    if(jz(0x5bd1, 0x5e)) goto l_0x5bd1;       /* jz 0x5bd1 */
            ii(0x5b73, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5b75, 2);    if(jz(0x5b9e, 0x27)) goto l_0x5b9e;       /* jz 0x5b9e */
            ii(0x5b77, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5b79, 2);    if(jz(0x5b7e, 0x3)) goto l_0x5b7e;        /* jz 0x5b7e */
            ii(0x5b7b, 1);    stosb();                                  /* stosb */
            ii(0x5b7c, 2);    jmp(0x5b62, -0x1c); goto l_0x5b62;        /* jmp 0x5b62 */
        l_0x5b7e:
            ii(0x5b7e, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0x5b80:
            ii(0x5b80, 1);    inc(cx);                                  /* inc cx */
            ii(0x5b81, 1);    lodsb();                                  /* lodsb */
            ii(0x5b82, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5b84, 2);    if(jz(0x5b80, -0x6)) goto l_0x5b80;       /* jz 0x5b80 */
            ii(0x5b86, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5b88, 2);    if(jz(0x5b90, 0x6)) goto l_0x5b90;        /* jz 0x5b90 */
            ii(0x5b8a, 2);    mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x5b8c, 2);    rep(() => stosb());                       /* rep stosb */
            ii(0x5b8e, 2);    jmp(0x5b61, -0x2f); goto l_0x5b61;        /* jmp 0x5b61 */
        l_0x5b90:
            ii(0x5b90, 2);    mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x5b92, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5b94, 2);    rep(() => stosb());                       /* rep stosb */
            ii(0x5b96, 2);    if(jae(0x5b9e, 0x6)) goto l_0x5b9e;       /* jae 0x5b9e */
            ii(0x5b98, 2);    mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x5b9a, 1);    stosb();                                  /* stosb */
            ii(0x5b9b, 2);    jmp(0x5b62, -0x3b); goto l_0x5b62;        /* jmp 0x5b62 */
        l_0x5b9d:
            ii(0x5b9d, 1);    dec(si);                                  /* dec si */
        l_0x5b9e:
            ii(0x5b9e, 1);    lodsb();                                  /* lodsb */
            ii(0x5b9f, 2);    cmp(al, 0xd);                             /* cmp al, 0xd */
            ii(0x5ba1, 2);    if(jz(0x5bd1, 0x2e)) goto l_0x5bd1;       /* jz 0x5bd1 */
            ii(0x5ba3, 2);    or(al, al);                               /* or al, al */
            ii(0x5ba5, 2);    if(jz(0x5bd1, 0x2a)) goto l_0x5bd1;       /* jz 0x5bd1 */
            ii(0x5ba7, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5ba9, 2);    if(jz(0x5b62, -0x49)) goto l_0x5b62;      /* jz 0x5b62 */
            ii(0x5bab, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5bad, 2);    if(jz(0x5bb2, 0x3)) goto l_0x5bb2;        /* jz 0x5bb2 */
            ii(0x5baf, 1);    stosb();                                  /* stosb */
            ii(0x5bb0, 2);    jmp(0x5b9e, -0x14); goto l_0x5b9e;        /* jmp 0x5b9e */
        l_0x5bb2:
            ii(0x5bb2, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0x5bb4:
            ii(0x5bb4, 1);    inc(cx);                                  /* inc cx */
            ii(0x5bb5, 1);    lodsb();                                  /* lodsb */
            ii(0x5bb6, 2);    cmp(al, 0x5c);                            /* cmp al, 0x5c */
            ii(0x5bb8, 2);    if(jz(0x5bb4, -0x6)) goto l_0x5bb4;       /* jz 0x5bb4 */
            ii(0x5bba, 2);    cmp(al, 0x22);                            /* cmp al, 0x22 */
            ii(0x5bbc, 2);    if(jz(0x5bc4, 0x6)) goto l_0x5bc4;        /* jz 0x5bc4 */
            ii(0x5bbe, 2);    mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x5bc0, 2);    rep(() => stosb());                       /* rep stosb */
            ii(0x5bc2, 2);    jmp(0x5b9d, -0x27); goto l_0x5b9d;        /* jmp 0x5b9d */
        l_0x5bc4:
            ii(0x5bc4, 2);    mov(al, 0x5c);                            /* mov al, 0x5c */
            ii(0x5bc6, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x5bc8, 2);    rep(() => stosb());                       /* rep stosb */
            ii(0x5bca, 2);    if(jae(0x5b62, -0x6a)) goto l_0x5b62;     /* jae 0x5b62 */
            ii(0x5bcc, 2);    mov(al, 0x22);                            /* mov al, 0x22 */
            ii(0x5bce, 1);    stosb();                                  /* stosb */
            ii(0x5bcf, 2);    jmp(0x5b9e, -0x33); goto l_0x5b9e;        /* jmp 0x5b9e */
        l_0x5bd1:
            ii(0x5bd1, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5bd3, 1);    stosb();                                  /* stosb */
        l_0x5bd4:
            ii(0x5bd4, 1);    push(ss);                                 /* push ss */
            ii(0x5bd5, 1);    pop(ds);                                  /* pop ds */
            ii(0x5bd6, 4);    mov(memw[ds, bx], 0);                     /* mov word [bx], 0x0 */
            ii(0x5bda, 4);    jmp_abs(memw[ds, 0xd10]);                 /* jmp word [0xd10] */
        }
    }
}
