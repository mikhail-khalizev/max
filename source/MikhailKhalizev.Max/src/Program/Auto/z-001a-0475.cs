using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0475-432bfca8")]
        public void Method_001a_0475()
        {
            ii(0x1a_0475, 1); push(bp);                                 /* push bp */
            ii(0x1a_0476, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x1a_0478, 1); push(ds);                                 /* push ds */
            ii(0x1a_0479, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_047c, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_047e, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_0481, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0484, 1); push(ds);                                 /* push ds */
            ii(0x1a_0485, 3); push(0x3720);                             /* push 0x3720 */
            ii(0x1a_0488, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_048a, 1); push(cs);                                 /* push cs */
            ii(0x1a_048b, 3); call(0x1a_053f, 0xb1);                    /* call 0x53f */
            ii(0x1a_048e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0490, 2); if(jnz(0x1a_04a6, 0x14)) goto l_0x1a_04a6; /* jnz 0x4a6 */
            ii(0x1a_0492, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_0495, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0498, 1); push(ds);                                 /* push ds */
            ii(0x1a_0499, 3); push(0x3728);                             /* push 0x3728 */
            ii(0x1a_049c, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_049e, 1); push(cs);                                 /* push cs */
            ii(0x1a_049f, 3); call(0x1a_053f, 0x9d);                    /* call 0x53f */
            ii(0x1a_04a2, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_04a4, 2); if(jz(0x1a_04ad, 7)) goto l_0x1a_04ad;    /* jz 0x4ad */
        l_0x1a_04a6:
            ii(0x1a_04a6, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_04a9, 4); or(memb[es, bx], 1);                      /* or byte [es:bx], 0x1 */
        l_0x1a_04ad:
            ii(0x1a_04ad, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_04b0, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_04b3, 1); push(ds);                                 /* push ds */
            ii(0x1a_04b4, 3); push(0x372d);                             /* push 0x372d */
            ii(0x1a_04b7, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_04b9, 1); push(cs);                                 /* push cs */
            ii(0x1a_04ba, 3); call(0x1a_053f, 0x82);                    /* call 0x53f */
            ii(0x1a_04bd, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_04bf, 2); if(jz(0x1a_04c8, 7)) goto l_0x1a_04c8;    /* jz 0x4c8 */
            ii(0x1a_04c1, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_04c4, 4); or(memb[es, bx], 0x10);                   /* or byte [es:bx], 0x10 */
        l_0x1a_04c8:
            ii(0x1a_04c8, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_04cb, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_04ce, 1); push(ds);                                 /* push ds */
            ii(0x1a_04cf, 3); push(0x3736);                             /* push 0x3736 */
            ii(0x1a_04d2, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_04d4, 1); push(cs);                                 /* push cs */
            ii(0x1a_04d5, 3); call(0x1a_053f, 0x67);                    /* call 0x53f */
            ii(0x1a_04d8, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_04da, 2); if(jz(0x1a_04e3, 7)) goto l_0x1a_04e3;    /* jz 0x4e3 */
            ii(0x1a_04dc, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_04df, 4); or(memb[es, bx], 0x20);                   /* or byte [es:bx], 0x20 */
        l_0x1a_04e3:
            ii(0x1a_04e3, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_04e6, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_04e9, 1); push(ds);                                 /* push ds */
            ii(0x1a_04ea, 3); push(0x373e);                             /* push 0x373e */
            ii(0x1a_04ed, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_04ef, 1); push(cs);                                 /* push cs */
            ii(0x1a_04f0, 3); call(0x1a_053f, 0x4c);                    /* call 0x53f */
            ii(0x1a_04f3, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_04f5, 2); if(jz(0x1a_04fe, 7)) goto l_0x1a_04fe;    /* jz 0x4fe */
            ii(0x1a_04f7, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_04fa, 4); or(memb[es, bx], -0x80 /* 0x80 */);       /* or byte [es:bx], 0x80 */
        l_0x1a_04fe:
            ii(0x1a_04fe, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_0501, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0504, 1); push(ds);                                 /* push ds */
            ii(0x1a_0505, 3); push(0x3746);                             /* push 0x3746 */
            ii(0x1a_0508, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_050a, 1); push(cs);                                 /* push cs */
            ii(0x1a_050b, 3); call(0x1a_053f, 0x31);                    /* call 0x53f */
            ii(0x1a_050e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_0510, 2); if(jz(0x1a_051a, 8)) goto l_0x1a_051a;    /* jz 0x51a */
            ii(0x1a_0512, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0515, 5); or(memb[es, bx + 1], 1);                  /* or byte [es:bx+0x1], 0x1 */
        l_0x1a_051a:
            ii(0x1a_051a, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x1a_051d, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0520, 1); push(ds);                                 /* push ds */
            ii(0x1a_0521, 3); push(0x374f);                             /* push 0x374f */
            ii(0x1a_0524, 2); push(0);                                  /* push 0x0 */
            ii(0x1a_0526, 1); push(cs);                                 /* push cs */
            ii(0x1a_0527, 3); call(0x1a_053f, 0x15);                    /* call 0x53f */
            ii(0x1a_052a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x1a_052c, 2); if(jz(0x1a_0535, 7)) goto l_0x1a_0535;    /* jz 0x535 */
            ii(0x1a_052e, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x1a_0531, 4); or(memb[es, bx], 0x40);                   /* or byte [es:bx], 0x40 */
        l_0x1a_0535:
            ii(0x1a_0535, 3); mov(ax, 0x3755);                          /* mov ax, 0x3755 */
            ii(0x1a_0538, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x1a_053a, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_053b, 1); leave();                                  /* leave */
            ii(0x1a_053c, 3); retf(8);                                  /* retf 0x8 */
        }
    }
}
