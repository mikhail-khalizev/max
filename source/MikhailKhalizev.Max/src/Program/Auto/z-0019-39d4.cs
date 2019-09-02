using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_39d4-364fffdc")]
        public void Method_0019_39d4()
        {
            ii(0x19_39d4, 1); push(bp);                                 /* push bp */
            ii(0x19_39d5, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_39d7, 2); mov(dx, di);                              /* mov dx, di */
            ii(0x19_39d9, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x19_39db, 1); push(ds);                                 /* push ds */
            ii(0x19_39dc, 3); lds(si, memw[ss, bp + 10]);               /* lds si, [bp+0xa] */
            ii(0x19_39df, 2); mov(di, si);                              /* mov di, si */
            ii(0x19_39e1, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x19_39e3, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_39e5, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_39e7, 3); mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x19_39ea, 2); repne(() => scasb());                     /* repne scasb */
            ii(0x19_39ec, 2); not(cx);                                  /* not cx */
            ii(0x19_39ee, 3); les(di, memw[ss, bp + 6]);                /* les di, [bp+0x6] */
            ii(0x19_39f1, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x19_39f3, 2); test(al, 1);                              /* test al, 0x1 */
            ii(0x19_39f5, 2); if(jz(0x19_39f9, 2)) goto l_0x19_39f9;    /* jz 0x39f9 */
            ii(0x19_39f7, 1); movsb();                                  /* movsb */
            ii(0x19_39f8, 1); dec(cx);                                  /* dec cx */
        l_0x19_39f9:
            ii(0x19_39f9, 2); shr(cx, 1);                               /* shr cx, 1 */
            ii(0x19_39fb, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x19_39fd, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x19_39ff, 2); rep(() => movsb());                       /* rep movsb */
            ii(0x19_3a01, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_3a03, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_3a05, 1); pop(ds);                                  /* pop ds */
            ii(0x19_3a06, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_3a08, 1); pop(bp);                                  /* pop bp */
            ii(0x19_3a09, 1); retf();                                   /* retf */
        }
    }
}
