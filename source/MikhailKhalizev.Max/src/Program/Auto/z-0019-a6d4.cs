using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a215a604-a73e-4aee-8566-b4c0d721cf0e")]
        public void Method_0019_a6d4()
        {
            ii(0x19_a6d4, 4); enterw(0xca, 0);                          /* enter 0xca, 0x0 */
            ii(0x19_a6d8, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_a6db, 3); callw(0x19_a14c, -0x592);                 /* call 0xa14c */
            ii(0x19_a6de, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_a6e0, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_a6e2, 3); mov(memw_a16[ss, bp - 0x6], bx);          /* mov [bp-0x6], bx */
            ii(0x19_a6e5, 3); mov(memw_a16[ss, bp - 0x4], es);          /* mov [bp-0x4], es */
            ii(0x19_a6e8, 6); mov(memw_a16[es, bx + 0x6c], 0xffff);     /* mov word [es:bx+0x6c], 0xffff */
            ii(0x19_a6ee, 7); mov(memw_a16[es, bx + 0x132], 0);         /* mov word [es:bx+0x132], 0x0 */
            ii(0x19_a6f5, 1); pushw(es);                                /* push es */
            ii(0x19_a6f6, 1); pushw(bx);                                /* push bx */
            ii(0x19_a6f7, 3); callw(0x19_b85e, 0x1164);                 /* call 0xb85e */
            ii(0x19_a6fa, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_a6fd, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a6ff, 2); if(jzw(0x19_a704, 0x3)) goto l_0x19_a704; /* jz 0xa704 */
            ii(0x19_a701, 3); jmpw(0x19_a7e1, 0xdd); goto l_0x19_a7e1;  /* jmp 0xa7e1 */
        l_0x19_a704:
            ii(0x19_a704, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x19_a707, 6); cmp(memb_a16[es, bx + 0xb2], 0x4c);       /* cmp byte [es:bx+0xb2], 0x4c */
            ii(0x19_a70d, 2); if(jzw(0x19_a712, 0x3)) goto l_0x19_a712; /* jz 0xa712 */
            ii(0x19_a70f, 3); jmpw(0x19_a7b0, 0x9e); goto l_0x19_a7b0;  /* jmp 0xa7b0 */
        l_0x19_a712:
            ii(0x19_a712, 5); mov(memw_a16[ss, bp - 0x2], 0x519);       /* mov word [bp-0x2], 0x519 */
            ii(0x19_a717, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x19_a71c, 4); pushw(memw_a16[es, bx + 0x70]);           /* push word [es:bx+0x70] */
            ii(0x19_a720, 4); pushw(memw_a16[es, bx + 0x6e]);           /* push word [es:bx+0x6e] */
            ii(0x19_a724, 4); lea(ax, bp - 0xca);                       /* lea ax, [bp-0xca] */
            ii(0x19_a728, 1); pushw(ss);                                /* push ss */
            ii(0x19_a729, 1); pushw(ax);                                /* push ax */
            ii(0x19_a72a, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x19_a72f, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a730, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a731, 1); pushw(dx);                                /* push dx */
            ii(0x19_a732, 1); pushw(ax);                                /* push ax */
            ii(0x19_a733, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_a735, 3); pushw(0xc4);                              /* push 0xc4 */
            ii(0x19_a738, 3); callw(0x19_c4e3, 0x1da8);                 /* call 0xc4e3 */
            ii(0x19_a73b, 3); cmp(ax, 0xc4);                            /* cmp ax, 0xc4 */
            ii(0x19_a73e, 2); if(jnzw(0x19_a744, 0x4)) goto l_0x19_a744; /* jnz 0xa744 */
            ii(0x19_a740, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x19_a742, 2); if(jzw(0x19_a746, 0x2)) goto l_0x19_a746; /* jz 0xa746 */
        l_0x19_a744:
            ii(0x19_a744, 2); jmpw(0x19_a7bd, 0x77); goto l_0x19_a7bd;  /* jmp 0xa7bd */
        l_0x19_a746:
            ii(0x19_a746, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a749, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a74c, 4); lea(ax, bp - 0xca);                       /* lea ax, [bp-0xca] */
            ii(0x19_a750, 1); pushw(ss);                                /* push ss */
            ii(0x19_a751, 1); pushw(ax);                                /* push ax */
            ii(0x19_a752, 3); callw(0x19_b2cb, 0xb76);                  /* call 0xb2cb */
            ii(0x19_a755, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_a758, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a75a, 2); if(jnzw(0x19_a768, 0xc)) goto l_0x19_a768; /* jnz 0xa768 */
            ii(0x19_a75c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a75f, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a762, 3); callw(0x19_b614, 0xeaf);                  /* call 0xb614 */
            ii(0x19_a765, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x19_a768:
            ii(0x19_a768, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a76a, 2); if(jnzw(0x19_a779, 0xd)) goto l_0x19_a779; /* jnz 0xa779 */
            ii(0x19_a76c, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a76f, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a772, 1); pushw(ax);                                /* push ax */
            ii(0x19_a773, 3); callw(0x19_aaf5, 0x37f);                  /* call 0xaaf5 */
            ii(0x19_a776, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x19_a779:
            ii(0x19_a779, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_a77b, 2); if(jnzw(0x19_a7a5, 0x28)) goto l_0x19_a7a5; /* jnz 0xa7a5 */
            ii(0x19_a77d, 4); test(memb_a16[ss, bp + 0x4], 0x2);        /* test byte [bp+0x4], 0x2 */
            ii(0x19_a781, 2); if(jnzw(0x19_a7a5, 0x22)) goto l_0x19_a7a5; /* jnz 0xa7a5 */
            ii(0x19_a783, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x19_a788, 2); if(jnzw(0x19_a795, 0xb)) goto l_0x19_a795; /* jnz 0xa795 */
            ii(0x19_a78a, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a78d, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a790, 3); callw(0x19_b95c, 0x11c9);                 /* call 0xb95c */
            ii(0x19_a793, 2); jmpw(0x19_a7a2, 0xd); goto l_0x19_a7a2;   /* jmp 0xa7a2 */
        l_0x19_a795:
            ii(0x19_a795, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a798, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a79b, 1); nop();                                    /* nop */
            ii(0x19_a79c, 1); pushw(cs);                                /* push cs */
            ii(0x19_a79d, 3); callw(0x19_c1f4, 0x1a54);                 /* call 0xc1f4 */
            ii(0x19_a7a0, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a7a1, 1); popw(bx);                                 /* pop bx */
        l_0x19_a7a2:
            ii(0x19_a7a2, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
        l_0x19_a7a5:
            ii(0x19_a7a5, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x19_a7a8, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x19_a7ab, 3); callw(0x19_9e60, -0x94e);                 /* call 0x9e60 */
            ii(0x19_a7ae, 2); jmpw(0x19_a7bd, 0xd); goto l_0x19_a7bd;   /* jmp 0xa7bd */
        l_0x19_a7b0:
            ii(0x19_a7b0, 6); cmp(memb_a16[es, bx + 0xb2], 0x4e);       /* cmp byte [es:bx+0xb2], 0x4e */
            ii(0x19_a7b6, 2); if(jnzw(0x19_a7bd, 0x5)) goto l_0x19_a7bd; /* jnz 0xa7bd */
            ii(0x19_a7b8, 5); mov(memw_a16[ss, bp - 0x2], 0x515);       /* mov word [bp-0x2], 0x515 */
        l_0x19_a7bd:
            ii(0x19_a7bd, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x19_a7c1, 2); if(jnzw(0x19_a7de, 0x1b)) goto l_0x19_a7de; /* jnz 0xa7de */
            ii(0x19_a7c3, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x19_a7c8, 2); if(jnzw(0x19_a7d5, 0xb)) goto l_0x19_a7d5; /* jnz 0xa7d5 */
            ii(0x19_a7ca, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x19_a7cd, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x19_a7d2, 3); callw(0x19_9e8b, -0x94a);                 /* call 0x9e8b */
        l_0x19_a7d5:
            ii(0x19_a7d5, 3); les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x19_a7d8, 6); mov(memw_a16[es, bx + 0x6c], 0);          /* mov word [es:bx+0x6c], 0x0 */
        l_0x19_a7de:
            ii(0x19_a7de, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
        l_0x19_a7e1:
            ii(0x19_a7e1, 1); leavew();                                 /* leave */
            ii(0x19_a7e2, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
