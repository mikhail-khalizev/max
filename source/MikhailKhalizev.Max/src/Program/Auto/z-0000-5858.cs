using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66e2b37f-44f9-4663-9316-662d2626ef97")]
        public void Method_0000_5858()
        {
            ii(0x5858, 4);    enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x585c, 3);    les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x585f, 5);    test(memb_a16[es, bx + 0x5], 0x10);       /* test byte [es:bx+0x5], 0x10 */
            ii(0x5864, 2);    if(jzw(0x58a8, 0x42)) goto l_0x58a8;      /* jz 0x58a8 */
            ii(0x5866, 4);    mov(al, memb_a16[es, bx + 0x7]);          /* mov al, [es:bx+0x7] */
            ii(0x586a, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x586c, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x586f, 5);    test(memb_a16[es, bx + 0x4], 0xf0);       /* test byte [es:bx+0x4], 0xf0 */
            ii(0x5874, 2);    if(jnzw(0x587a, 0x4)) goto l_0x587a;      /* jnz 0x587a */
            ii(0x5876, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x5878, 2);    if(jzw(0x58a8, 0x2e)) goto l_0x58a8;      /* jz 0x58a8 */
        l_0x587a:
            ii(0x587a, 3);    pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x587d, 3);    callw(0x4f7d, -0x903);                    /* call 0x4f7d */
            ii(0x5880, 1);    popw(bx);                                 /* pop bx */
            ii(0x5881, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x5883, 1);    pushw(ax);                                /* push ax */
            ii(0x5884, 3);    les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x5887, 4);    mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x588b, 4);    mov(dx, memw_a16[es, bx + 0x4]);          /* mov dx, [es:bx+0x4] */
            ii(0x588f, 2);    and(al, 0xf0);                            /* and al, 0xf0 */
            ii(0x5891, 2);    sub(dh, dh);                              /* sub dh, dh */
            ii(0x5893, 3);    mov(ch, memb_a16[ss, bp - 0x2]);          /* mov ch, [bp-0x2] */
            ii(0x5896, 2);    sub(cl, cl);                              /* sub cl, cl */
            ii(0x5898, 2);    sub(bx, bx);                              /* sub bx, bx */
            ii(0x589a, 2);    add(ax, bx);                              /* add ax, bx */
            ii(0x589c, 2);    adc(dx, cx);                              /* adc dx, cx */
            ii(0x589e, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x58a0, 3);    callw(0x6550, 0xcad);                     /* call 0x6550 */
            ii(0x58a3, 1);    pushw(dx);                                /* push dx */
            ii(0x58a4, 1);    pushw(ax);                                /* push ax */
            ii(0x58a5, 3);    callw(0x5c0d, 0x365);                     /* call 0x5c0d */
        l_0x58a8:
            ii(0x58a8, 1);    leavew();                                 /* leave */
            ii(0x58a9, 1);    retw(); return;                           /* ret */
        }
    }
}
