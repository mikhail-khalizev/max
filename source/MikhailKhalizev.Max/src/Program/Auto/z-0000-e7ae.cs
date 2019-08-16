using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4e5722ae-f05e-45f2-8894-d7a262b31f4e")]
        public void Method_0000_e7ae()
        {
            ii(0xe7ae, 1);    cli();                                    /* cli */
            ii(0xe7af, 1);    pushw(di);                                /* push di */
            ii(0xe7b0, 4);    sub(di, 0x180);                           /* sub di, 0x180 */
            ii(0xe7b4, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xe7b6, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xe7b8, 1);    pushw(cx);                                /* push cx */
            ii(0xe7b9, 5);    pushw(memw_a16[es, 0xf52]);               /* push word [es:0xf52] */
            ii(0xe7be, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0xe7c0, 1);    cld();                                    /* cld */
            ii(0xe7c1, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xe7c4, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0xe7c6, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xe7c8, 4);    mov(memw_a16[ds, 0x99e], bx);             /* mov [0x99e], bx */
            ii(0xe7cc, 4);    mov(memw_a16[ds, 0x996], bx);             /* mov [0x996], bx */
            ii(0xe7d0, 3);    mov(memw_a16[ds, bx + 0x22], ss);         /* mov [bx+0x22], ss */
            ii(0xe7d3, 3);    mov(memw_a16[ds, bx + 0x26], bp);         /* mov [bx+0x26], bp */
            ii(0xe7d6, 2);    inc(ah);                                  /* inc ah */
            ii(0xe7d8, 3);    cmp(ah, 0x68);                            /* cmp ah, 0x68 */
            ii(0xe7db, 2);    if(jaw_func(0xe7ec, 0xf)) return;         /* ja 0xe7ec */
            ii(0xe7dd, 2);    xor(al, al);                              /* xor al, al */
            ii(0xe7df, 2);    xchg(ah, al);                             /* xchg ah, al */
            ii(0xe7e1, 3);    mov(memw_a16[ds, 0x97e], ax);             /* mov [0x97e], ax */
            ii(0xe7e4, 2);    shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0xe7e6, 1);    xchg(di, ax);                             /* xchg di, ax */
            ii(0xe7e7, 5);    if(jmpw_abs(memw_a16[cs, di + 0x66a])) return; /* jmp word [cs:di+0x66a] */
        }
    }
}
