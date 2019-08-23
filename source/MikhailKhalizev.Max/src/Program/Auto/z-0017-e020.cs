using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e020-fa4b108f")]
        public void Method_0017_e020()
        {
            ii(0x17_e020, 1); push(bp);                                 /* push bp */
            ii(0x17_e021, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_e023, 2); mov(dx, si);                              /* mov dx, si */
            ii(0x17_e025, 1); push(ds);                                 /* push ds */
            ii(0x17_e026, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x17_e029, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x17_e02c, 2); mov(al, 0xff);                            /* mov al, 0xff */
        l_0x17_e02e:
            ii(0x17_e02e, 2); or(al, al);                               /* or al, al */
            ii(0x17_e030, 2); if(jz(0x17_e05f, 0x2d)) goto l_0x17_e05f; /* jz 0xe05f */
            ii(0x17_e032, 1); lodsb();                                  /* lodsb */
            ii(0x17_e033, 3); mov(ah, memb[es, bx]);                    /* mov ah, [es:bx] */
            ii(0x17_e036, 1); inc(bx);                                  /* inc bx */
            ii(0x17_e037, 2); cmp(ah, al);                              /* cmp ah, al */
            ii(0x17_e039, 2); if(jz(0x17_e02e, -0xd)) goto l_0x17_e02e; /* jz 0xe02e */
            ii(0x17_e03b, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x17_e03d, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x17_e03f, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x17_e041, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x17_e044, 2); add(al, cl);                              /* add al, cl */
            ii(0x17_e046, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x17_e048, 2); xchg(al, ah);                             /* xchg al, ah */
            ii(0x17_e04a, 2); sub(al, 0x41);                            /* sub al, 0x41 */
            ii(0x17_e04c, 2); cmp(al, 0x1a);                            /* cmp al, 0x1a */
            ii(0x17_e04e, 2); sbb(cl, cl);                              /* sbb cl, cl */
            ii(0x17_e050, 3); and(cl, 0x20);                            /* and cl, 0x20 */
            ii(0x17_e053, 2); add(al, cl);                              /* add al, cl */
            ii(0x17_e055, 2); add(al, 0x41);                            /* add al, 0x41 */
            ii(0x17_e057, 2); cmp(al, ah);                              /* cmp al, ah */
            ii(0x17_e059, 2); if(jz(0x17_e02e, -0x2d)) goto l_0x17_e02e; /* jz 0xe02e */
            ii(0x17_e05b, 2); sbb(al, al);                              /* sbb al, al */
            ii(0x17_e05d, 2); sbb(al, -0x1 /* 0xff */);                 /* sbb al, 0xff */
        l_0x17_e05f:
            ii(0x17_e05f, 1); cbw();                                    /* cbw */
            ii(0x17_e060, 1); pop(ds);                                  /* pop ds */
            ii(0x17_e061, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_e063, 1); pop(bp);                                  /* pop bp */
            ii(0x17_e064, 1); retf();                                   /* retf */
        }
    }
}
