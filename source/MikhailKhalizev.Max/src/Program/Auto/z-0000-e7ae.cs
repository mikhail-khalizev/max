using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe7ae-5f28ab9f")]
        public void Method_0000_e7ae()
        {
            ii(0xe7ae, 1);    cli();                                    /* cli */
            ii(0xe7af, 1);    push(di);                                 /* push di */
            ii(0xe7b0, 4);    sub(di, 0x180);                           /* sub di, 0x180 */
            ii(0xe7b4, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe7b6, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xe7b8, 1);    push(cx);                                 /* push cx */
            ii(0xe7b9, 5);    push(memw[es, 0xf52]);                    /* push word [es:0xf52] */
            ii(0xe7be, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0xe7c0, 1);    cld();                                    /* cld */
            ii(0xe7c1, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xe7c4, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0xe7c6, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xe7c8, 4);    mov(memw[ds, 0x99e], bx);                 /* mov [0x99e], bx */
            ii(0xe7cc, 4);    mov(memw[ds, 0x996], bx);                 /* mov [0x996], bx */
            ii(0xe7d0, 3);    mov(memw[ds, bx + 0x22], ss);             /* mov [bx+0x22], ss */
            ii(0xe7d3, 3);    mov(memw[ds, bx + 0x26], bp);             /* mov [bx+0x26], bp */
            ii(0xe7d6, 2);    inc(ah);                                  /* inc ah */
            ii(0xe7d8, 3);    cmp(ah, 0x68);                            /* cmp ah, 0x68 */
            ii(0xe7db, 2);    if(ja(0xe7ec, 0xf)) goto l_0xe7ec;        /* ja 0xe7ec */
            ii(0xe7dd, 2);    xor(al, al);                              /* xor al, al */
            ii(0xe7df, 2);    xchg(ah, al);                             /* xchg ah, al */
            ii(0xe7e1, 3);    mov(memw[ds, 0x97e], ax);                 /* mov [0x97e], ax */
            ii(0xe7e4, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xe7e6, 1);    xchg(di, ax);                             /* xchg di, ax */
            ii(0xe7e7, 5);    if(jmp_abs(memw[cs, di + 0x66a])) return; /* jmp word [cs:di+0x66a] */
        l_0xe7ec:
            ii(0xe7ec, 3);    call(0xe863, 0x74);                       /* call 0xe863 */
            ii(0xe7ef, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0xe7f1, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0xe7f3, 1);    cld();                                    /* cld */
            ii(0xe7f4, 3);    lea(di, bp + 0x8);                        /* lea di, [bp+0x8] */
            ii(0xe7f7, 3);    lea(si, bx + 0x8);                        /* lea si, [bx+0x8] */
            ii(0xe7fa, 3);    mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0xe7fd, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0xe7ff, 3);    mov(ax, memw[ds, bx + 0x26]);             /* mov ax, [bx+0x26] */
            ii(0xe802, 3);    and(ah, 0xe);                             /* and ah, 0xe */
            ii(0xe805, 3);    mov(memw[ss, bp + 0x26], ax);             /* mov [bp+0x26], ax */
            ii(0xe808, 5);    test(memw[ss, bp + 0x26], 0x200);         /* test word [bp+0x26], 0x200 */
            ii(0xe80d, 2);    if(jz(0xe810, 0x1)) goto l_0xe810;        /* jz 0xe810 */
            ii(0xe80f, 1);    sti();                                    /* sti */
        l_0xe810:
            ii(0xe810, 3);    lea(sp, bp - 0x4);                        /* lea sp, [bp-0x4] */
            ii(0xe813, 4);    pop(memw[ds, 0xf52]);                     /* pop word [0xf52] */
            ii(0xe817, 4);    pop(memw[ds, 0x99e]);                     /* pop word [0x99e] */
            ii(0xe81b, 4);    pop(memw[ds, 0x996]);                     /* pop word [0x996] */
            ii(0xe81f, 1);    inc(sp);                                  /* inc sp */
            ii(0xe820, 1);    inc(sp);                                  /* inc sp */
            ii(0xe821, 1);    pop(ds);                                  /* pop ds */
            ii(0xe822, 1);    pop(es);                                  /* pop es */
            ii(0xe823, 1);    popa();                                   /* popa */
            ii(0xe824, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe827, 2);    iretd();                                  /* iretd */
        }
    }
}
