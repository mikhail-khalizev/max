using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xaccb-5d5fe4d")]
        public void Method_0000_accb()
        {
            ii(0xaccb, 1);    push(si);                                 /* push si */
            ii(0xaccc, 1);    push(di);                                 /* push di */
            ii(0xaccd, 3);    call(0x9f7b, -0xd55);                     /* call 0x9f7b */
            ii(0xacd0, 3);    mov(ax, 0x3567);                          /* mov ax, 0x3567 */
            ii(0xacd3, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xacd5, 2);    mov(cx, es);                              /* mov cx, es */
            ii(0xacd7, 4);    cmp(cx, memw[ds, 0x58]);                  /* cmp cx, [0x58] */
            ii(0xacdb, 2);    if(jz(0xad46, 0x69)) goto l_0xad46;       /* jz 0xad46 */
            ii(0xacdd, 7);    cmp(memw[es, 0xb], 0x4d4d);               /* cmp word [es:0xb], 0x4d4d */
            ii(0xace4, 2);    if(jnz(0xad46, 0x60)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xace6, 7);    cmp(memw[es, 0xe], 0x5858);               /* cmp word [es:0xe], 0x5858 */
            ii(0xaced, 2);    if(jnz(0xad46, 0x57)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xacef, 6);    cmp(memb[es, 0xa], 0x45);                 /* cmp byte [es:0xa], 0x45 */
            ii(0xacf5, 2);    if(jnz(0xad46, 0x4f)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xacf7, 6);    cmp(memb[es, 0xd], 0x58);                 /* cmp byte [es:0xd], 0x58 */
            ii(0xacfd, 2);    if(jnz(0xad46, 0x47)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xacff, 6);    cmp(memb[es, 0x11], 0x30);                /* cmp byte [es:0x11], 0x30 */
            ii(0xad05, 2);    if(jnz(0xad46, 0x3f)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xad07, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0xad0c, 2);    if(jnz(0xad41, 0x33)) goto l_0xad41;      /* jnz 0xad41 */
            ii(0xad0e, 5);    test(memb[ds, 0x14], 0x2);                /* test byte [0x14], 0x2 */
            ii(0xad13, 2);    if(jnz(0xad41, 0x2c)) goto l_0xad41;      /* jnz 0xad41 */
            ii(0xad15, 3);    mov(ax, 0xde00);                          /* mov ax, 0xde00 */
            ii(0xad18, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xad1a, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad1c, 2);    if(jz(0xad41, 0x23)) goto l_0xad41;       /* jz 0xad41 */
            ii(0xad1e, 2);    mov(ah, 0x43);                            /* mov ah, 0x43 */
            ii(0xad20, 3);    mov(bx, 0x1);                             /* mov bx, 0x1 */
            ii(0xad23, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xad25, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad27, 2);    if(jnz(0xad46, 0x1d)) goto l_0xad46;      /* jnz 0xad46 */
            ii(0xad29, 5);    mov(memw[cs, 0x2ad9], dx);                /* mov [cs:0x2ad9], dx */
            ii(0xad2e, 2);    jmp(0xad46, 0x16); goto l_0xad46;         /* jmp 0xad46 */
        l_0xad30:
            ii(0xad30, 3);    call(0x9cc4, -0x106f);                    /* call 0x9cc4 */
            ii(0xad33, 1);    push(ax);                                 /* push ax */
            ii(0xad34, 3);    call(0x60cb, -0x4c6c);                    /* call 0x60cb */
            ii(0xad37, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xad39, 1);    pop(cx);                                  /* pop cx */
            ii(0xad3a, 2);    if(jcxz(0xad3d, 0x1)) goto l_0xad3d;      /* jcxz 0xad3d */
            ii(0xad3c, 1);    dec(ax);                                  /* dec ax */
        l_0xad3d:
            ii(0xad3d, 1);    pop(di);                                  /* pop di */
            ii(0xad3e, 1);    pop(si);                                  /* pop si */
            ii(0xad3f, 1);    ret(); return;                            /* ret */
        //  ii(0xad40, 1);    Недостижимый код.
        l_0xad41:
            ii(0xad41, 3);    call(0x9cc4, -0x1080);                    /* call 0x9cc4 */
            ii(0xad44, 2);    if(jz(0xad30, -0x16)) goto l_0xad30;      /* jz 0xad30 */
        l_0xad46:
            ii(0xad46, 3);    mov(ax, 0xde00);                          /* mov ax, 0xde00 */
            ii(0xad49, 3);    call(0xac9b, -0xb1);                      /* call 0xac9b */
            ii(0xad4c, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad4e, 2);    if(jnz(0xad30, -0x20)) goto l_0xad30;     /* jnz 0xad30 */
            ii(0xad50, 3);    mov(ax, 0xde0a);                          /* mov ax, 0xde0a */
            ii(0xad53, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xad55, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad57, 2);    if(jnz(0xad30, -0x29)) goto l_0xad30;     /* jnz 0xad30 */
            ii(0xad59, 4);    mov(memb[ds, 0x50], bl);                  /* mov [0x50], bl */
            ii(0xad5d, 4);    mov(memb[ds, 0x51], cl);                  /* mov [0x51], cl */
            ii(0xad61, 5);    mov(memb[ds, 0x2e], 0xb);                 /* mov byte [0x2e], 0xb */
            ii(0xad66, 3);    call(0x66c8, -0x46a1);                    /* call 0x66c8 */
            ii(0xad69, 3);    call(0x6e34, -0x3f38);                    /* call 0x6e34 */
            ii(0xad6c, 6);    cmp(memw[ds, 0xdec], 0x602);              /* cmp word [0xdec], 0x602 */
            ii(0xad72, 2);    if(jb(0xad86, 0x12)) goto l_0xad86;       /* jb 0xad86 */
            ii(0xad74, 6);    mov(memw[ds, 0xdee], 0x4);                /* mov word [0xdee], 0x4 */
            ii(0xad7a, 6);    mov(memw[ds, 0xdf0], 0xfc00);             /* mov word [0xdf0], 0xfc00 */
            ii(0xad80, 6);    mov(memw[ds, 0xdf2], 0x801);              /* mov word [0xdf2], 0x801 */
        l_0xad86:
            ii(0xad86, 3);    mov(al, memb[ds, 0x47]);                  /* mov al, [0x47] */
            ii(0xad89, 2);    and(al, 0x80);                            /* and al, 0x80 */
            ii(0xad8b, 4);    or(al, memb[ds, 0xa16]);                  /* or al, [0xa16] */
            ii(0xad8f, 4);    mov(ah, memb[ds, 0x15]);                  /* mov ah, [0x15] */
            ii(0xad93, 3);    and(ah, 0x20);                            /* and ah, 0x20 */
            ii(0xad96, 2);    or(al, ah);                               /* or al, ah */
            ii(0xad98, 4);    mov(memb[cs, 0x76aa], al);                /* mov [cs:0x76aa], al */
            ii(0xad9c, 2);    xor(si, si);                              /* xor si, si */
            ii(0xad9e, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xada0, 3);    mov(ax, 0xbf02);                          /* mov ax, 0xbf02 */
            ii(0xada3, 5);    test(memb[ds, 0x14], 0x10);               /* test byte [0x14], 0x10 */
            ii(0xada8, 2);    if(jz(0xadac, 0x2)) goto l_0xadac;        /* jz 0xadac */
            ii(0xadaa, 2);    mov(al, 0xdc);                            /* mov al, 0xdc */
        l_0xadac:
            ii(0xadac, 3);    call(0x44e4, -0x68cb);                    /* call 0x44e4 */
            ii(0xadaf, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0xadb1, 2);    if(jz(0xae16, 0x63)) goto l_0xae16;       /* jz 0xae16 */
            ii(0xadb3, 1);    push(ds);                                 /* push ds */
            ii(0xadb4, 1);    pop(es);                                  /* pop es */
            ii(0xadb5, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xadb7, 6);    cmp(memw[ds, 0], 0x1f4);                  /* cmp word [0x0], 0x1f4 */
            ii(0xadbd, 4);    if(jb(0xadc5, 0x4)) goto l_0xadc5;        /* jb 0xadc5 */
            ii(0xadc1, 2);    cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0xadc3, 2);    if(jnz(0xae16, 0x51)) goto l_0xae16;      /* jnz 0xae16 */
        l_0xadc5:
            ii(0xadc5, 6);    test(memb[ss, 0x14], 0x10);               /* test byte [ss:0x14], 0x10 */
            ii(0xadcb, 2);    if(jnz(0xadd5, 0x8)) goto l_0xadd5;       /* jnz 0xadd5 */
            ii(0xadcd, 6);    cmp(memb[ss, 0xa16], 0);                  /* cmp byte [ss:0xa16], 0x0 */
            ii(0xadd3, 2);    if(jnz(0xae16, 0x41)) goto l_0xae16;      /* jnz 0xae16 */
        l_0xadd5:
            ii(0xadd5, 3);    mov(di, 0x98);                            /* mov di, 0x98 */
            ii(0xadd8, 7);    cmp(memd[ds, si], 0x4_0000);              /* cmp dword [si], 0x40000 */
            ii(0xaddf, 6);    seta(memb[ss, 0xdff]);                    /* seta byte [ss:0xdff] */
            ii(0xade5, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xade8, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0xadea, 1);    push(es);                                 /* push es */
            ii(0xadeb, 1);    pop(ds);                                  /* pop ds */
            ii(0xadec, 4);    mov(eax, memd[ds, 0x98]);                 /* mov eax, [0x98] */
            ii(0xadf0, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xadf4, 3);    mov(memw[ds, 0xeca], ax);                 /* mov [0xeca], ax */
            ii(0xadf7, 4);    mov(eax, memd[ds, 0x9c]);                 /* mov eax, [0x9c] */
            ii(0xadfb, 4);    shr(eax, 0x6);                            /* shr eax, 0x6 */
            ii(0xadff, 4);    sub(ax, memw[ds, 0xeca]);                 /* sub ax, [0xeca] */
            ii(0xae03, 3);    mov(memw[ds, 0xece], ax);                 /* mov [0xece], ax */
            ii(0xae06, 4);    cmp(dx, memw[ds, 0xa2]);                  /* cmp dx, [0xa2] */
            ii(0xae0a, 2);    if(jnz(0xae13, 0x7)) goto l_0xae13;       /* jnz 0xae13 */
            ii(0xae0c, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0xae11, 2);    if(jnz(0xae62, 0x4f)) goto l_0xae62;      /* jnz 0xae62 */
        l_0xae13:
            ii(0xae13, 3);    if(jmp_func(0xaec1, 0xab)) return;        /* jmp 0xaec1 */
        l_0xae16:
            ii(0xae16, 1);    push(ss);                                 /* push ss */
            ii(0xae17, 1);    pop(ds);                                  /* pop ds */
            ii(0xae18, 3);    call(0xb124, 0x309);                      /* call 0xb124 */
            ii(0xae1b, 2);    mov(dx, bx);                              /* mov dx, bx */
            ii(0xae1d, 3);    cmp(dx, 0x4);                             /* cmp dx, 0x4 */
            ii(0xae20, 2);    if(jb(0xae2d, 0xb)) goto l_0xae2d;        /* jb 0xae2d */
            ii(0xae22, 4);    mov(al, memb[cs, 0x76aa]);                /* mov al, [cs:0x76aa] */
            ii(0xae26, 3);    mov(memb[ds, 0xdff], al);                 /* mov [0xdff], al */
            ii(0xae29, 2);    or(al, al);                               /* or al, al */
            ii(0xae2b, 2);    if(jnz(0xae44, 0x17)) goto l_0xae44;      /* jnz 0xae44 */
        l_0xae2d:
            ii(0xae2d, 3);    mov(ax, 0x3000);                          /* mov ax, 0x3000 */
            ii(0xae30, 4);    cmp(memw[ds, 0xecc], ax);                 /* cmp [0xecc], ax */
            ii(0xae34, 2);    if(jb(0xae39, 0x3)) goto l_0xae39;        /* jb 0xae39 */
            ii(0xae36, 3);    mov(memw[ds, 0xecc], ax);                 /* mov [0xecc], ax */
        l_0xae39:
            ii(0xae39, 4);    cmp(dx, 0x300);                           /* cmp dx, 0x300 */
            ii(0xae3d, 2);    if(jbe(0xae44, 0x5)) goto l_0xae44;       /* jbe 0xae44 */
            ii(0xae3f, 3);    mov(dx, 0x3000);                          /* mov dx, 0x3000 */
            ii(0xae42, 2);    jmp(0xae4a, 0x6); goto l_0xae4a;          /* jmp 0xae4a */
        l_0xae44:
            ii(0xae44, 3);    shl(dx, 0x4);                             /* shl dx, 0x4 */
            ii(0xae47, 3);    call(0xb140, 0x2f6);                      /* call 0xb140 */
        l_0xae4a:
            ii(0xae4a, 4);    mov(memw[ds, 0xece], dx);                 /* mov [0xece], dx */
            ii(0xae4e, 4);    add(dx, 0x2fff);                          /* add dx, 0x2fff */
            ii(0xae52, 2);    if(jae(0xae5b, 0x7)) goto l_0xae5b;       /* jae 0xae5b */
            ii(0xae54, 3);    mov(dx, 0xef00);                          /* mov dx, 0xef00 */
            ii(0xae57, 4);    mov(memw[ds, 0xece], dx);                 /* mov [0xece], dx */
        l_0xae5b:
            ii(0xae5b, 5);    cmp(memb[ds, 0xdff], 0);                  /* cmp byte [0xdff], 0x0 */
            ii(0xae60, 2);    if(jz(0xae6a, 0x8)) goto l_0xae6a;        /* jz 0xae6a */
        l_0xae62:
            ii(0xae62, 3);    mov(dx, 0x2000);                          /* mov dx, 0x2000 */
            ii(0xae65, 5);    mov(memb[ds, 0xdff], 0x1);                /* mov byte [0xdff], 0x1 */
        l_0xae6a:
            ii(0xae6a, 4);    and(dx, 0xf000);                          /* and dx, 0xf000 */
            ii(0xae6e, 4);    mov(memb[ds, 0xe00], dh);                 /* mov [0xe00], dh */
            ii(0xae72, 1);    push(dx);                                 /* push dx */
            ii(0xae73, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0xae75, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0xae78, 4);    add(ax, memw[ds, 0xcde]);                 /* add ax, [0xcde] */
            ii(0xae7c, 3);    and(ah, 0xf);                             /* and ah, 0xf */
            ii(0xae7f, 2);    neg(ax);                                  /* neg ax */
            ii(0xae81, 3);    add(ah, 0x10);                            /* add ah, 0x10 */
            ii(0xae84, 1);    push(ax);                                 /* push ax */
            ii(0xae85, 2);    add(ax, dx);                              /* add ax, dx */
            ii(0xae87, 1);    push(ax);                                 /* push ax */
            ii(0xae88, 5);    call_far_abs(0x1a2, 0xb12);               /* call word 0x1a2:0xb12 */
            ii(0xae8d, 3);    call(0x9bb3, -0x12dd);                    /* call 0x9bb3 */
            ii(0xae90, 1);    pop(cx);                                  /* pop cx */
            ii(0xae91, 3);    cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0xae94, 2);    if(jnz_func(0xae9b, 0x5)) return;         /* jnz 0xae9b */
        }
    }
}
