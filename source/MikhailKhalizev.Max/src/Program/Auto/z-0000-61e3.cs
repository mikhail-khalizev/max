using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x61e3-c07dc156")]
        public void Method_0000_61e3()
        {
            ii(0x61e3, 2);    pushad();                                 /* pushad */
            ii(0x61e5, 3);    call(0x60cb, -0x11d);                     /* call 0x60cb */
            ii(0x61e8, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x61ea, 4);    xchg(memb[ds, 0xe00], cl);                /* xchg [0xe00], cl */
            ii(0x61ee, 2);    if(jcxz(0x6239, 0x49)) goto l_0x6239;     /* jcxz 0x6239 */
            ii(0x61f0, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0x61f5, 2);    if(jz(0x6211, 0x1a)) goto l_0x6211;       /* jz 0x6211 */
            ii(0x61f7, 4);    les(bx, ds, 0xa0);                        /* les bx, [0xa0] */
            ii(0x61fb, 5);    mov(eax, memd[es, bx + 0x14]);            /* mov eax, [es:bx+0x14] */
            ii(0x6200, 4);    mov(memd[ds, 0xac], eax);                 /* mov [0xac], eax */
            ii(0x6204, 3);    mov(ax, 0xbfde);                          /* mov ax, 0xbfde */
            ii(0x6207, 3);    mov(bx, 0xa);                             /* mov bx, 0xa */
            ii(0x620a, 3);    call(0x44e4, -0x1d29);                    /* call 0x44e4 */
            ii(0x620d, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x620f, 2);    if(jge(0x6239, 0x28)) goto l_0x6239;      /* jge 0x6239 */
        l_0x6211:
            ii(0x6211, 6);    mov(memw[ds, 0xeca], 0x1000);             /* mov word [0xeca], 0x1000 */
            ii(0x6217, 1);    sti();                                    /* sti */
            ii(0x6218, 3);    push(0xf7ff);                             /* push 0xf7ff */
            ii(0x621b, 5);    pushd(memd[ds, 0x9c]);                    /* push dword [0x9c] */
            ii(0x6220, 6);    movzx(eax, memw[ds, 0xeca]);              /* movzx eax, word [0xeca] */
            ii(0x6226, 4);    shl(eax, 0x6);                            /* shl eax, 0x6 */
            ii(0x622a, 2);    pushd(eax);                               /* push eax */
            ii(0x622c, 3);    call(0x3880, -0x29af);                    /* call 0x3880 */
            ii(0x622f, 1);    push(cs);                                 /* push cs */
            ii(0x6230, 3);    call(0x6137, -0xfc);                      /* call 0x6137 */
            ii(0x6233, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x6236, 3);    call(0x3f1c, -0x231d);                    /* call 0x3f1c */
        l_0x6239:
            ii(0x6239, 2);    popad();                                  /* popad */
            ii(0x623b, 1);    ret();                                    /* ret */
        }
    }
}
