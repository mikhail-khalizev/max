using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6993-c07dc156")]
        public void Method_0000_6993()
        {
            ii(0x6993, 2);    pushad();                                 /* pushad */
            ii(0x6995, 3);    call(0x687b, -0x11d);                     /* call 0x687b */
            ii(0x6998, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x699a, 4);    xchg(memb[ds, 0xe00], cl);                /* xchg [0xe00], cl */
            ii(0x699e, 2);    if(jcxz(0x69e9, 0x49)) goto l_0x69e9;     /* jcxz 0x69e9 */
            ii(0x69a0, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x69a5, 2);    if(jz(0x69c1, 0x1a)) goto l_0x69c1;       /* jz 0x69c1 */
            ii(0x69a7, 4);    les(bx, memw[ds, 0xa0]);                  /* les bx, [0xa0] */
            ii(0x69ab, 5);    mov(eax, memd[es, bx + 0x14]);            /* mov eax, [es:bx+0x14] */
            ii(0x69b0, 4);    mov(memd[ds, 0xac], eax);                 /* mov [0xac], eax */
            ii(0x69b4, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x69b7, 3);    mov(bx, 0xa);                             /* mov bx, 0xa */
            ii(0x69ba, 3);    call(0x4c94, -0x1d29);                    /* call 0x4c94 */
            ii(0x69bd, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x69bf, 2);    if(jge(0x69e9, 0x28)) goto l_0x69e9;      /* jge 0x69e9 */
        l_0x69c1:
            ii(0x69c1, 6);    mov(memw[ds, 0xeca], 0x1000);             /* mov word [0xeca], 0x1000 */
            ii(0x69c7, 1);    sti();                                    /* sti */
            ii(0x69c8, 3);    push(0xf7ff);                             /* push 0xf7ff */
            ii(0x69cb, 5);    push(memd[ds, 0x9c]);                     /* push dword [0x9c] */
            ii(0x69d0, 6);    movzx(eax, memw[ds, 0xeca]);              /* movzx eax, word [0xeca] */
            ii(0x69d6, 4);    shl(eax, 0x6);                            /* shl eax, 0x6 */
            ii(0x69da, 2);    push(eax);                                /* push eax */
            ii(0x69dc, 3);    call(0x4030, -0x29af);                    /* call 0x4030 */
            ii(0x69df, 1);    push(cs);                                 /* push cs */
            ii(0x69e0, 3);    call(0x68e7, -0xfc);                      /* call 0x68e7 */
            ii(0x69e3, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x69e6, 3);    call(0x46cc, -0x231d);                    /* call 0x46cc */
        l_0x69e9:
            ii(0x69e9, 2);    popad();                                  /* popad */
            ii(0x69eb, 1);    ret();                                    /* ret */
        }
    }
}
