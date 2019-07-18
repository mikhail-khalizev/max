using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("65ad4157-71de-40d7-8e1f-b8d333ebb43d")]
        public void Method_0000_a0c7()
        {
            ii(0xa0c7, 1);    pushw(ax);                                /* push ax */
            ii(0xa0c8, 1);    pusha();                                  /* pusha */
            ii(0xa0c9, 1);    pushw(es);                                /* push es */
            ii(0xa0ca, 1);    pushw(ds);                                /* push ds */
            ii(0xa0cb, 1);    pushw(ss);                                /* push ss */
            ii(0xa0cc, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xa0ce, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xa0d0, 1);    pushw(ss);                                /* push ss */
            ii(0xa0d1, 1);    popw(ds);                                 /* pop ds */
            ii(0xa0d2, 3);    mov(bx, memw_a16[ds, si + 0x1a]);         /* mov bx, [si+0x1a] */
            ii(0xa0d5, 3);    mov(al, memb_a16[cs, bx]);                /* mov al, [cs:bx] */
            ii(0xa0d8, 2);    or(al, al);                               /* or al, al */
            ii(0xa0da, 2);    if(jsw(0xa0f3, 0x17)) goto l_0xa0f3;      /* js 0xa0f3 */
            ii(0xa0dc, 3);    and(ax, 0x1f);                            /* and ax, 0x1f */
            ii(0xa0df, 3);    mov(memw_a16[ds, si + 0x18], ax);         /* mov [si+0x18], ax */
            ii(0xa0e2, 3);    mov(ax, memw_a16[ds, si + 0x34]);         /* mov ax, [si+0x34] */
            ii(0xa0e5, 3);    mov(memw_a16[ds, si + 0xe], ax);          /* mov [si+0xe], ax */
            ii(0xa0e8, 3);    mov(ax, memw_a16[ds, si + 0x38]);         /* mov ax, [si+0x38] */
            ii(0xa0eb, 3);    mov(memw_a16[ds, si + 0x2], ax);          /* mov [si+0x2], ax */
            ii(0xa0ee, 3);    mov(bx, 0xa);                             /* mov bx, 0xa */
            ii(0xa0f1, 2);    jmpw(0xa0ff, 0xc); goto l_0xa0ff;         /* jmp 0xa0ff */
        l_0xa0f3:
            ii(0xa0f3, 3);    and(ax, 0x1f);                            /* and ax, 0x1f */
            ii(0xa0f6, 3);    mov(memw_a16[ds, si + 0x18], ax);         /* mov [si+0x18], ax */
            ii(0xa0f9, 4);    add(memw_a16[ds, si + 0xe], 0xa);         /* add word [si+0xe], 0xa */
            ii(0xa0fd, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0xa0ff:
            ii(0xa0ff, 5);    les(di, cs, 0x17c2);                      /* les di, [cs:0x17c2] */
            ii(0xa104, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0xa106, 1);    cld();                                    /* cld */
            ii(0xa107, 3);    mov(cx, 0xd);                             /* mov cx, 0xd */
            ii(0xa10a, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0xa10c, 2);    add(si, bx);                              /* add si, bx */
            ii(0xa10e, 2);    movsd_a16();                              /* movsd */
            ii(0xa110, 2);    movsd_a16();                              /* movsd */
            ii(0xa112, 2);    movsd_a16();                              /* movsd */
            ii(0xa114, 2);    movsd_a16();                              /* movsd */
            ii(0xa116, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0xa118, 2);    if(jzw(0xa13d, 0x23)) goto l_0xa13d;      /* jz 0xa13d */
            ii(0xa11a, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xa11c, 3);    mov(memw_a16[ds, si + 0x38], es);         /* mov [si+0x38], es */
            ii(0xa11f, 3);    mov(memw_a16[ds, si + 0x34], ax);         /* mov [si+0x34], ax */
            ii(0xa122, 3);    mov(memw_a16[ds, si + 0x2c], cs);         /* mov [si+0x2c], cs */
            ii(0xa125, 5);    mov(memw_a16[ds, si + 0x28], 0x6b51);     /* mov word [si+0x28], 0x6b51 */
            ii(0xa12a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xa12c, 3);    mov(memw_a16[ds, si + 0x36], ax);         /* mov [si+0x36], ax */
            ii(0xa12f, 3);    mov(memw_a16[ds, si + 0x2a], ax);         /* mov [si+0x2a], ax */
            ii(0xa132, 3);    add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0xa135, 1);    popw(ds);                                 /* pop ds */
            ii(0xa136, 1);    popw(es);                                 /* pop es */
            ii(0xa137, 1);    popa();                                   /* popa */
            ii(0xa138, 3);    add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0xa13b, 2);    retfd();                                  /* o32 retf */
        l_0xa13d:
            ii(0xa13d, 1);    pushw(es);                                /* push es */
            ii(0xa13e, 1);    popw(ss);                                 /* pop ss */
            ii(0xa13f, 2);    mov(sp, ax);                              /* mov sp, ax */
            ii(0xa141, 1);    sti();                                    /* sti */
            ii(0xa142, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xa144, 4);    cmp(memw_a16[ss, bp + 0x18], 0xd);        /* cmp word [bp+0x18], 0xd */
            ii(0xa148, 2);    jzw_func(0xa1bd, 0x73);                   /* jz 0xa1bd */
            ii(0xa14a, 5);    jmpw_a16_far_ind(cs, 0x17be); return;     /* jmp far word [cs:0x17be] */
        }
    }
}
