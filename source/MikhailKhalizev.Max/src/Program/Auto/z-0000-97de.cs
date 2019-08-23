using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x97de-41191e30")]
        public void Method_0000_97de()
        {
            ii(0x97de, 1);    push(bp);                                 /* push bp */
            ii(0x97df, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x97e1, 1);    push(di);                                 /* push di */
            ii(0x97e2, 1);    push(si);                                 /* push si */
            ii(0x97e3, 3);    mov(si, memw[ss, bp + 0x4]);              /* mov si, [bp+0x4] */
            ii(0x97e6, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x97e8, 1);    cwd();                                    /* cwd */
            ii(0x97e9, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0x97eb:
            ii(0x97eb, 1);    lodsb();                                  /* lodsb */
            ii(0x97ec, 2);    cmp(al, 0x20);                            /* cmp al, 0x20 */
            ii(0x97ee, 2);    if(jz(0x97eb, -0x5)) goto l_0x97eb;       /* jz 0x97eb */
            ii(0x97f0, 2);    cmp(al, 0x9);                             /* cmp al, 0x9 */
            ii(0x97f2, 2);    if(jz(0x97eb, -0x9)) goto l_0x97eb;       /* jz 0x97eb */
            ii(0x97f4, 1);    push(ax);                                 /* push ax */
            ii(0x97f5, 2);    cmp(al, 0x2d);                            /* cmp al, 0x2d */
            ii(0x97f7, 2);    if(jz(0x97fd, 0x4)) goto l_0x97fd;        /* jz 0x97fd */
            ii(0x97f9, 2);    cmp(al, 0x2b);                            /* cmp al, 0x2b */
            ii(0x97fb, 2);    if(jnz(0x97fe, 0x1)) goto l_0x97fe;       /* jnz 0x97fe */
        l_0x97fd:
            ii(0x97fd, 1);    lodsb();                                  /* lodsb */
        l_0x97fe:
            ii(0x97fe, 2);    cmp(al, 0x39);                            /* cmp al, 0x39 */
            ii(0x9800, 2);    if(ja(0x9821, 0x1f)) goto l_0x9821;       /* ja 0x9821 */
            ii(0x9802, 2);    sub(al, 0x30);                            /* sub al, 0x30 */
            ii(0x9804, 2);    if(jb(0x9821, 0x1b)) goto l_0x9821;       /* jb 0x9821 */
            ii(0x9806, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9808, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x980a, 2);    mov(cx, bx);                              /* mov cx, bx */
            ii(0x980c, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0x980e, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9810, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x9812, 2);    shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x9814, 2);    rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x9816, 2);    add(bx, cx);                              /* add bx, cx */
            ii(0x9818, 2);    adc(dx, di);                              /* adc dx, di */
            ii(0x981a, 2);    add(bx, ax);                              /* add bx, ax */
            ii(0x981c, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x981f, 2);    jmp(0x97fd, -0x24); goto l_0x97fd;        /* jmp 0x97fd */
        l_0x9821:
            ii(0x9821, 1);    pop(ax);                                  /* pop ax */
            ii(0x9822, 2);    cmp(al, 0x2d);                            /* cmp al, 0x2d */
            ii(0x9824, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0x9825, 2);    if(jnz(0x982e, 0x7)) goto l_0x982e;       /* jnz 0x982e */
            ii(0x9827, 2);    neg(ax);                                  /* neg ax */
            ii(0x9829, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x982c, 2);    neg(dx);                                  /* neg dx */
        l_0x982e:
            ii(0x982e, 1);    pop(si);                                  /* pop si */
            ii(0x982f, 1);    pop(di);                                  /* pop di */
            ii(0x9830, 1);    pop(bp);                                  /* pop bp */
            ii(0x9831, 1);    ret();                                    /* ret */
        }
    }
}
