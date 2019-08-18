using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x665b-961f14ea")]
        public void Method_0000_665b()
        {
            ii(0x665b, 2);    mov(ss, bx);                              /* mov ss, bx */
            ii(0x665d, 5);    mov(ds, memw_a16[cs, 0]);                 /* mov ds, [cs:0x0] */
            ii(0x6662, 4);    mov(gs, memw_a16[ds, 0xd66]);             /* mov gs, [0xd66] */
            ii(0x6666, 4);    mov(fs, memw_a16[ds, 0xd64]);             /* mov fs, [0xd64] */
            ii(0x666a, 5);    lidtw_a16(ds, 0xddc);                     /* lidt [0xddc] */
            ii(0x666f, 2);    popd(eax);                                /* pop eax */
            ii(0x6671, 6);    cmp(memw_a16[ds, 0x35], 0x8000);          /* cmp word [0x35], 0x8000 */
            ii(0x6677, 2);    if(jnzw(0x669e, 0x25)) goto l_0x669e;     /* jnz 0x669e */
            ii(0x6679, 5);    cmp(memb_a16[ds, 0x11f0], 0);             /* cmp byte [0x11f0], 0x0 */
            ii(0x667e, 2);    if(jnzw(0x66a8, 0x28)) goto l_0x66a8;     /* jnz 0x66a8 */
            ii(0x6680, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x6682, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x6684, 3);    mov(ax, memw_a16[ds, 0xf56]);             /* mov ax, [0xf56] */
            ii(0x6687, 4);    mov(memw_a16[es, 0x467], ax);             /* mov [es:0x467], ax */
            ii(0x668b, 3);    mov(ax, memw_a16[ds, 0xf58]);             /* mov ax, [0xf58] */
            ii(0x668e, 4);    mov(memw_a16[es, 0x469], ax);             /* mov [es:0x469], ax */
            ii(0x6692, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x6694, 5);    cmp(memb_a16[ds, 0x2e], 0x2);             /* cmp byte [0x2e], 0x2 */
            ii(0x6699, 2);    if(jzw(0x66a1, 0x6)) goto l_0x66a1;       /* jz 0x66a1 */
            ii(0x669b, 3);    callw(0x499b, -0x1d03);                   /* call 0x499b */
        l_0x669e:
            ii(0x669e, 1);    popw(bx);                                 /* pop bx */
            ii(0x669f, 1);    popw(ax);                                 /* pop ax */
            ii(0x66a0, 1);    retw(); return;                           /* ret */
        l_0x66a1:
            ii(0x66a1, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0x66a3, 3);    callw(0x4963, -0x1d43);                   /* call 0x4963 */
            ii(0x66a6, 2);    jmpw(0x669e, -0xa); goto l_0x669e;        /* jmp 0x669e */
        l_0x66a8:
            ii(0x66a8, 5);    cmp(memb_a16[ds, 0x2e], 0x5);             /* cmp byte [0x2e], 0x5 */
            ii(0x66ad, 2);    if(jzw(0x66c7, 0x18)) goto l_0x66c7;      /* jz 0x66c7 */
            ii(0x66af, 5);    cmp(memb_a16[ds, 0x2e], 0xe);             /* cmp byte [0x2e], 0xe */
            ii(0x66b4, 2);    if(jzw(0x66cf, 0x19)) goto l_0x66cf;      /* jz 0x66cf */
            ii(0x66b6, 5);    cmp(memb_a16[ds, 0x2e], 0xf);             /* cmp byte [0x2e], 0xf */
            ii(0x66bb, 2);    if(jzw(0x66ea, 0x2d)) goto l_0x66ea;      /* jz 0x66ea */
            ii(0x66bd, 5);    cmp(memb_a16[ds, 0x2e], 0x1);             /* cmp byte [0x2e], 0x1 */
            ii(0x66c2, 2);    if(jzw(0x66f7, 0x33)) goto l_0x66f7;      /* jz 0x66f7 */
            ii(0x66c4, 1);    popw(bx);                                 /* pop bx */
            ii(0x66c5, 1);    popw(ax);                                 /* pop ax */
            ii(0x66c6, 1);    retw(); return;                           /* ret */
        l_0x66c7:
            ii(0x66c7, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x66c9, 2);    mov(al, 0x80);                            /* mov al, 0x80 */
            ii(0x66cb, 2);    outb(0x20, al);                           /* out 0x20, al */
            ii(0x66cd, 2);    jmpw(0x669e, -0x31); goto l_0x669e;       /* jmp 0x669e */
        l_0x66cf:
            ii(0x66cf, 2);    mov(al, 0xff);                            /* mov al, 0xff */
            ii(0x66d1, 2);    outb(0xf2, al);                           /* out 0xf2, al */
            ii(0x66d3, 1);    pushfw();                                 /* pushfw */
            ii(0x66d4, 1);    cli();                                    /* cli */
            ii(0x66d5, 1);    pushw(dx);                                /* push dx */
            ii(0x66d6, 3);    mov(dx, 0x140);                           /* mov dx, 0x140 */
            ii(0x66d9, 2);    mov(al, 0x1);                             /* mov al, 0x1 */
            ii(0x66db, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x66dc, 2);    dec(al);                                  /* dec al */
            ii(0x66de, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x66df, 1);    popw(dx);                                 /* pop dx */
            ii(0x66e0, 1);    popfw();                                  /* popfw */
            ii(0x66e1, 1);    pushw(cx);                                /* push cx */
            ii(0x66e2, 3);    mov(cx, 0xfa0);                           /* mov cx, 0xfa0 */
        l_0x66e5:
            ii(0x66e5, 2);    if(loopw_a16(0x66e5, -0x2)) goto l_0x66e5; /* loop 0x66e5 */
            ii(0x66e7, 1);    popw(cx);                                 /* pop cx */
            ii(0x66e8, 2);    jmpw(0x669e, -0x4c); goto l_0x669e;       /* jmp 0x669e */
        l_0x66ea:
            ii(0x66ea, 1);    pushw(dx);                                /* push dx */
            ii(0x66eb, 3);    mov(dx, 0x404);                           /* mov dx, 0x404 */
            ii(0x66ee, 1);    inb(al, dx);                              /* in al, dx */
            ii(0x66ef, 2);    and(al, 0xf9);                            /* and al, 0xf9 */
            ii(0x66f1, 2);    jmpw(0x66f3, 0); goto l_0x66f3;           /* jmp 0x66f3 */
        l_0x66f3:
            ii(0x66f3, 1);    outb(dx, al);                             /* out dx, al */
            ii(0x66f4, 1);    popw(dx);                                 /* pop dx */
            ii(0x66f5, 2);    jmpw(0x669e, -0x59); goto l_0x669e;       /* jmp 0x669e */
        l_0x66f7:
            ii(0x66f7, 2);    mov(al, 0x3);                             /* mov al, 0x3 */
            ii(0x66f9, 2);    outb(0xf6, al);                           /* out 0xf6, al */
            ii(0x66fb, 2);    jmpw(0x669e, -0x5f); goto l_0x669e;       /* jmp 0x669e */
        }
    }
}
