using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2f127753-a358-400e-af70-9ed5aa2226a3")]
        public void Method_0000_ad46()
        {
            ii(0xad46, 3);    mov(ax, 0xde00);                          /* mov ax, 0xde00 */
            ii(0xad49, 3);    callw(0xac9b, -0xb1);                     /* call 0xac9b */
            ii(0xad4c, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad4e, 2);    jnzw_func(0xad30, -0x20);                 /* jnz 0xad30 */
            ii(0xad50, 3);    mov(ax, 0xde0a);                          /* mov ax, 0xde0a */
            ii(0xad53, 2);    int_n(0x67);                              /* int 0x67 */
            ii(0xad55, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad57, 2);    jnzw_func(0xad30, -0x29);                 /* jnz 0xad30 */
            ii(0xad59, 4);    mov(memb_a16[ds, 0x50], bl);              /* mov [0x50], bl */
            ii(0xad5d, 4);    mov(memb_a16[ds, 0x51], cl);              /* mov [0x51], cl */
            ii(0xad61, 5);    mov(memb_a16[ds, 0x2e], 0xb);             /* mov byte [0x2e], 0xb */
            ii(0xad66, 3);    callw(0x66c8, -0x46a1);                   /* call 0x66c8 */
            ii(0xad69, 3);    callw(0x6e34, -0x3f38);                   /* call 0x6e34 */
            ii(0xad6c, 6);    cmp(memw_a16[ds, 0xdec], 0x602);          /* cmp word [0xdec], 0x602 */
            ii(0xad72, 2);    if(jbw(0xad86, 0x12)) goto l_0xad86;      /* jb 0xad86 */
            ii(0xad74, 6);    mov(memw_a16[ds, 0xdee], 0x4);            /* mov word [0xdee], 0x4 */
            ii(0xad7a, 6);    mov(memw_a16[ds, 0xdf0], 0xfc00);         /* mov word [0xdf0], 0xfc00 */
            ii(0xad80, 6);    mov(memw_a16[ds, 0xdf2], 0x801);          /* mov word [0xdf2], 0x801 */
        l_0xad86:
            ii(0xad86, 3);    mov(al, memb_a16[ds, 0x47]);              /* mov al, [0x47] */
            ii(0xad89, 2);    and(al, 0x80);                            /* and al, 0x80 */
            ii(0xad8b, 4);    or(al, memb_a16[ds, 0xa16]);              /* or al, [0xa16] */
            ii(0xad8f, 4);    mov(ah, memb_a16[ds, 0x15]);              /* mov ah, [0x15] */
            ii(0xad93, 3);    and(ah, 0x20);                            /* and ah, 0x20 */
            ii(0xad96, 2);    or(al, ah);                               /* or al, ah */
            ii(0xad98, 4);    mov(memb_a16[cs, 0x76aa], al);            /* mov [cs:0x76aa], al */
            ii(0xad9c, 2);    xor(si, si);                              /* xor si, si */
            ii(0xad9e, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xada0, 3);    mov(ax, 0xbf02);                          /* mov ax, 0xbf02 */
            ii(0xada3, 5);    test(memb_a16[ds, 0x14], 0x10);           /* test byte [0x14], 0x10 */
            ii(0xada8, 2);    if(jzw(0xadac, 0x2)) goto l_0xadac;       /* jz 0xadac */
            ii(0xadaa, 2);    mov(al, 0xdc);                            /* mov al, 0xdc */
        l_0xadac:
            ii(0xadac, 3);    callw(0x44e4, -0x68cb);                   /* call 0x44e4 */
            ii(0xadaf, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0xadb1, 2);    if(jzw(0xae16, 0x63)) goto l_0xae16;      /* jz 0xae16 */
            ii(0xadb3, 1);    pushw(ds);                                /* push ds */
            ii(0xadb4, 1);    popw(es);                                 /* pop es */
            ii(0xadb5, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xadb7, 6);    cmp(memw_a16[ds, 0], 0x1f4);              /* cmp word [0x0], 0x1f4 */
            ii(0xadbd, 4);    if(jbw(0xadc5, 0x4)) goto l_0xadc5;       /* jb 0xadc5 */
            ii(0xadc1, 2);    cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0xadc3, 2);    if(jnzw(0xae16, 0x51)) goto l_0xae16;     /* jnz 0xae16 */
        l_0xadc5:
            ii(0xadc5, 6);    test(memb_a16[ss, 0x14], 0x10);           /* test byte [ss:0x14], 0x10 */
            ii(0xadcb, 2);    if(jnzw(0xadd5, 0x8)) goto l_0xadd5;      /* jnz 0xadd5 */
            ii(0xadcd, 6);    cmp(memb_a16[ss, 0xa16], 0);              /* cmp byte [ss:0xa16], 0x0 */
            ii(0xadd3, 2);    if(jnzw(0xae16, 0x41)) goto l_0xae16;     /* jnz 0xae16 */
        l_0xadd5:
            ii(0xadd5, 3);    mov(di, 0x98);                            /* mov di, 0x98 */
            ii(0xadd8, 7);    cmp(memd_a16[ds, si], 0x4_0000);          /* cmp dword [si], 0x40000 */
            ii(0xaddf, 6);    seta(memb_a16[ss, 0xdff]);                /* seta byte [ss:0xdff] */
            ii(0xade5, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xade8, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0xadea, 1);    pushw(es);                                /* push es */
            ii(0xadeb, 1);    popw(ds);                                 /* pop ds */
            ii(0xadec, 4);    mov(eax, memd_a16[ds, 0x98]);             /* mov eax, [0x98] */
            ii(0xadf0, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xadf4, 3);    mov(memw_a16[ds, 0xeca], ax);             /* mov [0xeca], ax */
            ii(0xadf7, 4);    mov(eax, memd_a16[ds, 0x9c]);             /* mov eax, [0x9c] */
            ii(0xadfb, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xadff, 4);    sub(ax, memw_a16[ds, 0xeca]);             /* sub ax, [0xeca] */
            ii(0xae03, 3);    mov(memw_a16[ds, 0xece], ax);             /* mov [0xece], ax */
            ii(0xae06, 4);    cmp(dx, memw_a16[ds, 0xa2]);              /* cmp dx, [0xa2] */
            ii(0xae0a, 2);    if(jnzw(0xae13, 0x7)) goto l_0xae13;      /* jnz 0xae13 */
            ii(0xae0c, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0xae11, 2);    if(jnzw(0xae62, 0x4f)) goto l_0xae62;     /* jnz 0xae62 */
        l_0xae13:
            ii(0xae13, 3);    jmpw_func(0xaec1, 0xab);                  /* jmp 0xaec1 */
        l_0xae16:
            ii(0xae16, 1);    pushw(ss);                                /* push ss */
            ii(0xae17, 1);    popw(ds);                                 /* pop ds */
            ii(0xae18, 3);    callw(0xb124, 0x309);                     /* call 0xb124 */
            ii(0xae1b, 2);    mov(dx, bx);                              /* mov dx, bx */
            ii(0xae1d, 3);    cmp(dx, 0x4);                             /* cmp dx, 0x4 */
            ii(0xae20, 2);    if(jbw(0xae2d, 0xb)) goto l_0xae2d;       /* jb 0xae2d */
            ii(0xae22, 4);    mov(al, memb_a16[cs, 0x76aa]);            /* mov al, [cs:0x76aa] */
            ii(0xae26, 3);    mov(memb_a16[ds, 0xdff], al);             /* mov [0xdff], al */
            ii(0xae29, 2);    or(al, al);                               /* or al, al */
            ii(0xae2b, 2);    if(jnzw(0xae44, 0x17)) goto l_0xae44;     /* jnz 0xae44 */
        l_0xae2d:
            ii(0xae2d, 3);    mov(ax, 0x3000);                          /* mov ax, 0x3000 */
            ii(0xae30, 4);    cmp(memw_a16[ds, 0xecc], ax);             /* cmp [0xecc], ax */
            ii(0xae34, 2);    if(jbw(0xae39, 0x3)) goto l_0xae39;       /* jb 0xae39 */
            ii(0xae36, 3);    mov(memw_a16[ds, 0xecc], ax);             /* mov [0xecc], ax */
        l_0xae39:
            ii(0xae39, 4);    cmp(dx, 0x300);                           /* cmp dx, 0x300 */
            ii(0xae3d, 2);    if(jbew(0xae44, 0x5)) goto l_0xae44;      /* jbe 0xae44 */
            ii(0xae3f, 3);    mov(dx, 0x3000);                          /* mov dx, 0x3000 */
            ii(0xae42, 2);    goto l_0xae4a;                            /* jmp 0xae4a */
        l_0xae44:
            ii(0xae44, 3);    shl(dx, 0x4);                             /* shl dx, 0x4 */
            ii(0xae47, 3);    callw(0xb140, 0x2f6);                     /* call 0xb140 */
        l_0xae4a:
            ii(0xae4a, 4);    mov(memw_a16[ds, 0xece], dx);             /* mov [0xece], dx */
            ii(0xae4e, 4);    add(dx, 0x2fff);                          /* add dx, 0x2fff */
            ii(0xae52, 2);    if(jaew(0xae5b, 0x7)) goto l_0xae5b;      /* jae 0xae5b */
            ii(0xae54, 3);    mov(dx, 0xef00);                          /* mov dx, 0xef00 */
            ii(0xae57, 4);    mov(memw_a16[ds, 0xece], dx);             /* mov [0xece], dx */
        l_0xae5b:
            ii(0xae5b, 5);    cmp(memb_a16[ds, 0xdff], 0);              /* cmp byte [0xdff], 0x0 */
            ii(0xae60, 2);    if(jzw(0xae6a, 0x8)) goto l_0xae6a;       /* jz 0xae6a */
        l_0xae62:
            ii(0xae62, 3);    mov(dx, 0x2000);                          /* mov dx, 0x2000 */
            ii(0xae65, 5);    mov(memb_a16[ds, 0xdff], 0x1);            /* mov byte [0xdff], 0x1 */
        l_0xae6a:
            ii(0xae6a, 4);    and(dx, 0xf000);                          /* and dx, 0xf000 */
            ii(0xae6e, 4);    mov(memb_a16[ds, 0xe00], dh);             /* mov [0xe00], dh */
            ii(0xae72, 1);    pushw(dx);                                /* push dx */
            ii(0xae73, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0xae75, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0xae78, 4);    add(ax, memw_a16[ds, 0xcde]);             /* add ax, [0xcde] */
            ii(0xae7c, 3);    and(ah, 0xf);                             /* and ah, 0xf */
            ii(0xae7f, 2);    neg(ax);                                  /* neg ax */
            ii(0xae81, 3);    add(ah, 0x10);                            /* add ah, 0x10 */
            ii(0xae84, 1);    pushw(ax);                                /* push ax */
            ii(0xae85, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0xae87, 1);    pushw(ax);                                /* push ax */
            ii(0xae88, 5);    callw_far_abs(0x1a2, 0xb12);              /* call word 0x1a2:0xb12 */
            ii(0xae8d, 3);    callw(0x9bb3, -0x12dd);                   /* call 0x9bb3 */
            ii(0xae90, 1);    popw(cx);                                 /* pop cx */
            ii(0xae91, 3);    cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0xae94, 2);    jnzw_func(0xae9b, 0x5);                   /* jnz 0xae9b */
            ii(0xae96, 0);    jmpd_func(0xae96, 0);                     /* Принудительное завершение функции. */
        }
    }
}
