using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7868-25cf79fd")]
        public void Method_0000_7868()
        {
            ii(0x7868, 4);    enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x786c, 3);    les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x786f, 5);    test(memb[es, bx + 5], 0x10);             /* test byte [es:bx+0x5], 0x10 */
            ii(0x7874, 2);    if(jz(0x78b8, 0x42)) goto l_0x78b8;       /* jz 0x78b8 */
            ii(0x7876, 4);    mov(al, memb[es, bx + 7]);                /* mov al, [es:bx+0x7] */
            ii(0x787a, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x787c, 3);    mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x787f, 5);    test(memb[es, bx + 4], 0xf0);             /* test byte [es:bx+0x4], 0xf0 */
            ii(0x7884, 2);    if(jnz(0x788a, 4)) goto l_0x788a;         /* jnz 0x788a */
            ii(0x7886, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x7888, 2);    if(jz(0x78b8, 0x2e)) goto l_0x78b8;       /* jz 0x78b8 */
        l_0x788a:
            ii(0x788a, 3);    push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x788d, 3);    call(0x6f8d, -0x903);                     /* call 0x6f8d */
            ii(0x7890, 1);    pop(bx);                                  /* pop bx */
            ii(0x7891, 2);    push(0);                                  /* push 0x0 */
            ii(0x7893, 1);    push(ax);                                 /* push ax */
            ii(0x7894, 3);    les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x7897, 4);    mov(ax, memw[es, bx + 2]);                /* mov ax, [es:bx+0x2] */
            ii(0x789b, 4);    mov(dx, memw[es, bx + 4]);                /* mov dx, [es:bx+0x4] */
            ii(0x789f, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x78a1, 2);    sub(dh, dh);                              /* sub dh, dh */
            ii(0x78a3, 3);    mov(ch, memb[ss, bp - 2]);                /* mov ch, [bp-0x2] */
            ii(0x78a6, 2);    sub(cl, cl);                              /* sub cl, cl */
            ii(0x78a8, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x78aa, 2);    add(ax, bx);                              /* add ax, bx */
            ii(0x78ac, 2);    adc(dx, cx);                              /* adc dx, cx */
            ii(0x78ae, 2);    mov(cl, 4);                               /* mov cl, 0x4 */
            ii(0x78b0, 3);    call(0x8560, 0xcad);                      /* call 0x8560 */
            ii(0x78b3, 1);    push(dx);                                 /* push dx */
            ii(0x78b4, 1);    push(ax);                                 /* push ax */
            ii(0x78b5, 3);    call(0x7c1d, 0x365);                      /* call 0x7c1d */
        l_0x78b8:
            ii(0x78b8, 1);    leave();                                  /* leave */
            ii(0x78b9, 1);    ret();                                    /* ret */
        }
    }
}
