using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("78197613-7f4b-4018-8bea-188c72f8c58d")]
        public void Method_0013_e020()
        {
            ii(0x13_e020, 1); pushw(bp);                                /* push bp */
            ii(0x13_e021, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_e023, 2); mov(dx, si);                              /* mov dx, si */
            ii(0x13_e025, 1); pushw(ds);                                /* push ds */
            ii(0x13_e026, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x13_e029, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_e02c, 2); mov(al, 0xff);                            /* mov al, 0xff */
        l_0x13_e02e:
            ii(0x13_e02e, 2); or(al, al);                               /* or al, al */
            ii(0x13_e030, 2); if(jzw(0x13_e05f, 0x2d)) goto l_0x13_e05f; /* jz 0xe05f */
            ii(0x13_e032, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_e033, 3); mov(ah, memb_a16[es, bx]);                /* mov ah, [es:bx] */
            ii(0x13_e036, 1); inc(bx);                                  /* inc bx */
            ii(0x13_e037, 2); cmp(ah, al);                              /* cmp ah, al */
            ii(0x13_e039, 2); if(jzw(0x13_e02e, -0xd)) goto l_0x13_e02e; /* jz 0xe02e */
            ii(0x13_e03b, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x13_e03d, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x13_e03f, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x13_e041, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x13_e044, 2); add(al, cl);                              /* add al, cl */
            ii(0x13_e046, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x13_e048, 2); xchg(al, ah);                             /* xchg al, ah */
            ii(0x13_e04a, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x13_e04c, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x13_e04e, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x13_e050, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x13_e053, 2); add(al, cl);                              /* add al, cl */
            ii(0x13_e055, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x13_e057, 2); cmp(al, ah);                              /* cmp al, ah */
            ii(0x13_e059, 2); if(jzw(0x13_e02e, -0x2d)) goto l_0x13_e02e; /* jz 0xe02e */
            ii(0x13_e05b, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x13_e05d, 2); sbb(al, -0x1 /* 0xff */);                 /* sbb al, 0xff */
        l_0x13_e05f:
            ii(0x13_e05f, 1); cbw();                                    /* cbw */
            ii(0x13_e060, 1); popw(ds);                                 /* pop ds */
            ii(0x13_e061, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x13_e063, 1); popw(bp);                                 /* pop bp */
            ii(0x13_e064, 1); retfw(); return;                          /* retf */
        }
    }
}
