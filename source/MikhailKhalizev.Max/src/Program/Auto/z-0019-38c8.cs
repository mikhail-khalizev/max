using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_38c8-fa4b108f")]
        public void Method_0019_38c8()
        {
            ii(0x19_38c8, 1); push(bp);                                 /* push bp */
            ii(0x19_38c9, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_38cb, 2); mov(dx, si);                              /* mov dx, si */
            ii(0x19_38cd, 1); push(ds);                                 /* push ds */
            ii(0x19_38ce, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x19_38d1, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_38d4, 2); mov(al, 0xff);                            /* mov al, 0xff */
        l_0x19_38d6:
            ii(0x19_38d6, 2); or(al, al);                               /* or al, al */
            ii(0x19_38d8, 2); if(jz(0x19_3907, 0x2d)) goto l_0x19_3907; /* jz 0x3907 */
            ii(0x19_38da, 1); lodsb();                                  /* lodsb */
            ii(0x19_38db, 3); mov(ah, memb[es, bx]);                    /* mov ah, [es:bx] */
            ii(0x19_38de, 1); inc(bx);                                  /* inc bx */
            ii(0x19_38df, 2); cmp(ah, al);                              /* cmp ah, al */
            ii(0x19_38e1, 2); if(jz(0x19_38d6, -0xd)) goto l_0x19_38d6; /* jz 0x38d6 */
            ii(0x19_38e3, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x19_38e5, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x19_38e7, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x19_38e9, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x19_38ec, 2); add(al, cl);                              /* add al, cl */
            ii(0x19_38ee, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x19_38f0, 2); xchg(al, ah);                             /* xchg al, ah */
            ii(0x19_38f2, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x19_38f4, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x19_38f6, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x19_38f8, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x19_38fb, 2); add(al, cl);                              /* add al, cl */
            ii(0x19_38fd, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x19_38ff, 2); cmp(al, ah);                              /* cmp al, ah */
            ii(0x19_3901, 2); if(jz(0x19_38d6, -0x2d)) goto l_0x19_38d6; /* jz 0x38d6 */
            ii(0x19_3903, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x19_3905, 2); sbb(al, -0x1 /* 0xff */);                 /* sbb al, 0xff */
        l_0x19_3907:
            ii(0x19_3907, 1); cbw();                                    /* cbw */
            ii(0x19_3908, 1); pop(ds);                                  /* pop ds */
            ii(0x19_3909, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x19_390b, 1); pop(bp);                                  /* pop bp */
            ii(0x19_390c, 1); retf();                                   /* retf */
        }
    }
}
