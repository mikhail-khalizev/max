using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x866b-961f14ea")]
        public void Method_0000_866b()
        {
            ii(0x866b, 2);    mov(ss, bx);                              /* mov ss, bx */
            ii(0x866d, 5);    mov(ds, memw[cs, 0]);                     /* mov ds, [cs:0x0] */
            ii(0x8672, 4);    mov(gs, memw[ds, 0xd66]);                 /* mov gs, [0xd66] */
            ii(0x8676, 4);    mov(fs, memw[ds, 0xd64]);                 /* mov fs, [0xd64] */
            ii(0x867a, 5);    lidt(ds, 0xddc);                          /* lidt [0xddc] */
            ii(0x867f, 2);    popd(eax);                                /* pop eax */
            ii(0x8681, 6);    cmp(memw[ds, 0x35], 0x8000);              /* cmp word [0x35], 0x8000 */
            ii(0x8687, 2);    if(jnz(0x86ae, 0x25)) goto l_0x86ae;      /* jnz 0x86ae */
            ii(0x8689, 5);    cmp(memb[ds, 0x11f0], 0);                 /* cmp byte [0x11f0], 0x0 */
            ii(0x868e, 2);    if(jnz(0x86b8, 0x28)) goto l_0x86b8;      /* jnz 0x86b8 */
            ii(0x8690, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x8692, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x8694, 3);    mov(ax, memw[ds, 0xf56]);                 /* mov ax, [0xf56] */
            ii(0x8697, 4);    mov(memw[es, 0x467], ax);                 /* mov [es:0x467], ax */
            ii(0x869b, 3);    mov(ax, memw[ds, 0xf58]);                 /* mov ax, [0xf58] */
            ii(0x869e, 4);    mov(memw[es, 0x469], ax);                 /* mov [es:0x469], ax */
            ii(0x86a2, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x86a4, 5);    cmp(memb[ds, 0x2e], 0x2);                 /* cmp byte [0x2e], 0x2 */
            ii(0x86a9, 2);    if(jz(0x86b1, 0x6)) goto l_0x86b1;        /* jz 0x86b1 */
            ii(0x86ab, 3);    call(0x69ab, -0x1d03);                    /* call 0x69ab */
        l_0x86ae:
            ii(0x86ae, 1);    pop(bx);                                  /* pop bx */
            ii(0x86af, 1);    pop(ax);                                  /* pop ax */
            ii(0x86b0, 1);    ret(); return;                            /* ret */
        l_0x86b1:
            ii(0x86b1, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x86b3, 3);    call(0x6973, -0x1d43);                    /* call 0x6973 */
            ii(0x86b6, 2);    jmp(0x86ae, -0xa); goto l_0x86ae;         /* jmp 0x86ae */
        l_0x86b8:
            ii(0x86b8, 5);    cmp(memb[ds, 0x2e], 0x5);                 /* cmp byte [0x2e], 0x5 */
            ii(0x86bd, 2);    if(jz(0x86d7, 0x18)) goto l_0x86d7;       /* jz 0x86d7 */
            ii(0x86bf, 5);    cmp(memb[ds, 0x2e], 0xe);                 /* cmp byte [0x2e], 0xe */
            ii(0x86c4, 2);    if(jz(0x86df, 0x19)) goto l_0x86df;       /* jz 0x86df */
            ii(0x86c6, 5);    cmp(memb[ds, 0x2e], 0xf);                 /* cmp byte [0x2e], 0xf */
            ii(0x86cb, 2);    if(jz(0x86fa, 0x2d)) goto l_0x86fa;       /* jz 0x86fa */
            ii(0x86cd, 5);    cmp(memb[ds, 0x2e], 0x1);                 /* cmp byte [0x2e], 0x1 */
            ii(0x86d2, 2);    if(jz(0x8707, 0x33)) goto l_0x8707;       /* jz 0x8707 */
            ii(0x86d4, 1);    pop(bx);                                  /* pop bx */
            ii(0x86d5, 1);    pop(ax);                                  /* pop ax */
            ii(0x86d6, 1);    ret(); return;                            /* ret */
        l_0x86d7:
            ii(0x86d7, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x86d9, 2);    mov(al, 0x80);                            /* mov al, 0x80 */
            ii(0x86db, 2);    outb(0x20, al);                           /* out 0x20, al */
            ii(0x86dd, 2);    jmp(0x86ae, -0x31); goto l_0x86ae;        /* jmp 0x86ae */
        l_0x86df:
            ii(0x86df, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x86e1, 2);    outb(0xf2, al);                           /* out 0xf2, al */
            ii(0x86e3, 1);    pushfw();                                 /* pushfw */
            ii(0x86e4, 1);    cli();                                    /* cli */
            ii(0x86e5, 1);    push(dx);                                 /* push dx */
            ii(0x86e6, 3);    mov(dx, 0x140);                           /* mov dx, 0x140 */
            ii(0x86e9, 2);    mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x86eb, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x86ec, 2);    dec(al);                                  /* dec al */
            ii(0x86ee, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x86ef, 1);    pop(dx);                                  /* pop dx */
            ii(0x86f0, 1);    popfw();                                  /* popfw */
            ii(0x86f1, 1);    push(cx);                                 /* push cx */
            ii(0x86f2, 3);    mov(cx, 0xfa0);                           /* mov cx, 0xfa0 */
        l_0x86f5:
            ii(0x86f5, 2);    if(loop(0x86f5, -0x2)) goto l_0x86f5;     /* loop 0x86f5 */
            ii(0x86f7, 1);    pop(cx);                                  /* pop cx */
            ii(0x86f8, 2);    jmp(0x86ae, -0x4c); goto l_0x86ae;        /* jmp 0x86ae */
        l_0x86fa:
            ii(0x86fa, 1);    push(dx);                                 /* push dx */
            ii(0x86fb, 3);    mov(dx, 0x404);                           /* mov dx, 0x404 */
            ii(0x86fe, 1);    inb(al, dx);                              /* in al, dx */
            ii(0x86ff, 2);    and(al, 0xf9);                            /* and al, 0xf9 */
            ii(0x8701, 2);    jmp(0x8703, 0); goto l_0x8703;            /* jmp 0x8703 */
        l_0x8703:
            ii(0x8703, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x8704, 1);    pop(dx);                                  /* pop dx */
            ii(0x8705, 2);    jmp(0x86ae, -0x59); goto l_0x86ae;        /* jmp 0x86ae */
        l_0x8707:
            ii(0x8707, 2);    mov(al, 0x3);                             /* mov al, 0x3 */
            ii(0x8709, 2);    outb(0xf6, al);                           /* out 0xf6, al */
            ii(0x870b, 2);    jmp(0x86ae, -0x5f); goto l_0x86ae;        /* jmp 0x86ae */
        }
    }
}
