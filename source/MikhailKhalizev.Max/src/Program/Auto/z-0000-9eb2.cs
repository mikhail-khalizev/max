using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9eb2-46d6f1b8")]
        public void Method_0000_9eb2()
        {
            ii(0x9eb2, 1);    push(bp);                                 /* push bp */
            ii(0x9eb3, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9eb5, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x9eb7, 2);    push(-0x1 /* 0xff */);                    /* push 0xffff */
            ii(0x9eb9, 3);    smsw(ax);                                 /* smsw ax */
            ii(0x9ebc, 2);    test(al, 0x4);                            /* test al, 0x4 */
            ii(0x9ebe, 2);    if(jnz(0x9ed9, 0x19)) goto l_0x9ed9;      /* jnz 0x9ed9 */
            ii(0x9ec0, 2);    fninit();                                 /* fninit */
            ii(0x9ec2, 3);    fnstsw(memw[ss, bp - 0x2]);               /* fnstsw word [bp-0x2] */
            ii(0x9ec5, 3);    cmp(memb[ss, bp - 0x2], cl);              /* cmp [bp-0x2], cl */
            ii(0x9ec8, 2);    if(jnz(0x9ed9, 0xf)) goto l_0x9ed9;       /* jnz 0x9ed9 */
            ii(0x9eca, 3);    fnstcw(memw[ss, bp - 0x2]);               /* fnstcw word [bp-0x2] */
            ii(0x9ecd, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x9ed0, 3);    and(ax, 0x103f);                          /* and ax, 0x103f */
            ii(0x9ed3, 3);    cmp(ax, 0x3f);                            /* cmp ax, 0x3f */
            ii(0x9ed6, 2);    if(jnz(0x9ed9, 0x1)) goto l_0x9ed9;       /* jnz 0x9ed9 */
            ii(0x9ed8, 1);    inc(cx);                                  /* inc cx */
        l_0x9ed9:
            ii(0x9ed9, 1);    leave();                                  /* leave */
            ii(0x9eda, 1);    xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x9edb, 1);    ret();                                    /* ret */
        }
    }
}
