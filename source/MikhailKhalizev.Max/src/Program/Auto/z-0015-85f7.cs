using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5f80062-a4df-4cc2-accb-94e52ec512de")]
        public void Method_0015_85f7()
        {
            ii(0x15_85f7, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x15_85fb, 1); pushw(di);                                /* push di */
            ii(0x15_85fc, 1); pushw(si);                                /* push si */
            ii(0x15_85fd, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_8600, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_8603, 1); nop();                                    /* nop */
            ii(0x15_8604, 1); pushw(cs);                                /* push cs */
            ii(0x15_8605, 3); callw(0x15_f8ec, 0x72e4);                 /* call 0xf8ec */
            ii(0x15_8608, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_860b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_860e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_8611, 1); nop();                                    /* nop */
            ii(0x15_8612, 1); pushw(cs);                                /* push cs */
            ii(0x15_8613, 3); callw(0x15_8309, -0x30d);                 /* call 0x8309 */
            ii(0x15_8616, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_8619, 1); nop();                                    /* nop */
            ii(0x15_861a, 1); pushw(cs);                                /* push cs */
            ii(0x15_861b, 3); callw(0x15_8399, -0x285);                 /* call 0x8399 */
            ii(0x15_861e, 3); mov(ax, memw_a16[ds, 0x17bc]);            /* mov ax, [0x17bc] */
            ii(0x15_8621, 4); or(ax, memw_a16[ds, 0x17ba]);             /* or ax, [0x17ba] */
            ii(0x15_8625, 2); if(jnzw(0x15_862a, 0x3)) goto l_0x15_862a; /* jnz 0x862a */
            ii(0x15_8627, 3); jmpw(0x15_8688, 0x5e); goto l_0x15_8688;  /* jmp 0x8688 */
        l_0x15_862a:
            ii(0x15_862a, 4); les(bx, ds, 0x17ba);                      /* les bx, [0x17ba] */
            ii(0x15_862e, 4); mov(ax, memw_a16[es, bx + 0x12]);         /* mov ax, [es:bx+0x12] */
            ii(0x15_8632, 4); or(ax, memw_a16[es, bx + 0x10]);          /* or ax, [es:bx+0x10] */
            ii(0x15_8636, 2); if(jnzw(0x15_863b, 0x3)) goto l_0x15_863b; /* jnz 0x863b */
            ii(0x15_8638, 3); jmpw(0x15_8688, 0x4d); goto l_0x15_8688;  /* jmp 0x8688 */
        l_0x15_863b:
            ii(0x15_863b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_863e, 4); mov(ax, memw_a16[es, bx + 0x36]);         /* mov ax, [es:bx+0x36] */
            ii(0x15_8642, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_8645, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8648, 4); mov(ax, memw_a16[es, bx + 0x32]);         /* mov ax, [es:bx+0x32] */
            ii(0x15_864c, 4); mov(dx, memw_a16[es, bx + 0x34]);         /* mov dx, [es:bx+0x34] */
            ii(0x15_8650, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x15_8653, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x15_8656, 4); pushw(memw_a16[ds, 0x17c0]);              /* push word [0x17c0] */
            ii(0x15_865a, 4); pushw(memw_a16[ds, 0x17be]);              /* push word [0x17be] */
            ii(0x15_865e, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x15_8661, 1); pushw(ss);                                /* push ss */
            ii(0x15_8662, 1); pushw(ax);                                /* push ax */
            ii(0x15_8663, 4); les(bx, ds, 0x17ba);                      /* les bx, [0x17ba] */
            ii(0x15_8667, 4); callw_a16_far_ind(es, bx + 0x10);         /* call far word [es:bx+0x10] */
            ii(0x15_866b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_866e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_8670, 2); if(jzw(0x15_8675, 0x3)) goto l_0x15_8675; /* jz 0x8675 */
            ii(0x15_8672, 3); jmpw(0x15_8688, 0x13); goto l_0x15_8688;  /* jmp 0x8688 */
        l_0x15_8675:
            ii(0x15_8675, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x15_8678, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x15_867b, 3); pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0x15_867e, 1); pushw(ds);                                /* push ds */
            ii(0x15_867f, 3); pushw(0x1784);                            /* push 0x1784 */
            ii(0x15_8682, 3); callw(0x15_105e, -0x7627);                /* call 0x105e */
            ii(0x15_8685, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x15_8688:
            ii(0x15_8688, 4); mov(es, memw_a16[ds, 0x3fb0]);            /* mov es, [0x3fb0] */
            ii(0x15_868c, 6); cmp(memb_a16[es, 0xd84], 0);              /* cmp byte [es:0xd84], 0x0 */
            ii(0x15_8692, 2); if(jnzw(0x15_8697, 0x3)) goto l_0x15_8697; /* jnz 0x8697 */
            ii(0x15_8694, 3); jmpw(0x15_873a, 0xa3); goto l_0x15_873a;  /* jmp 0x873a */
        l_0x15_8697:
            ii(0x15_8697, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_869a, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_869d, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_86a0, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x15_86a3:
            ii(0x15_86a3, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_86a6, 4); cmp(memw_a16[es, bx], 0);                 /* cmp word [es:bx], 0x0 */
            ii(0x15_86aa, 2); if(jnzw(0x15_86af, 0x3)) goto l_0x15_86af; /* jnz 0x86af */
            ii(0x15_86ac, 3); jmpw(0x15_870a, 0x5b); goto l_0x15_870a;  /* jmp 0x870a */
        l_0x15_86af:
            ii(0x15_86af, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_86b2, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x15_86b5, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_86b8, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_86bb, 5); cmp(memw_a16[es, bx + 0x36], 0);          /* cmp word [es:bx+0x36], 0x0 */
            ii(0x15_86c0, 2); if(jzw(0x15_86c5, 0x3)) goto l_0x15_86c5; /* jz 0x86c5 */
            ii(0x15_86c2, 3); jmpw(0x15_86d8, 0x13); goto l_0x15_86d8;  /* jmp 0x86d8 */
        l_0x15_86c5:
            ii(0x15_86c5, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_86c8, 4); mov(ax, memw_a16[es, bx + 0x34]);         /* mov ax, [es:bx+0x34] */
            ii(0x15_86cc, 4); or(ax, memw_a16[es, bx + 0x32]);          /* or ax, [es:bx+0x32] */
            ii(0x15_86d0, 2); if(jzw(0x15_86d5, 0x3)) goto l_0x15_86d5; /* jz 0x86d5 */
            ii(0x15_86d2, 3); jmpw(0x15_86d8, 0x3); goto l_0x15_86d8;   /* jmp 0x86d8 */
        l_0x15_86d5:
            ii(0x15_86d5, 3); jmpw(0x15_86a3, -0x35); goto l_0x15_86a3; /* jmp 0x86a3 */
        l_0x15_86d8:
            ii(0x15_86d8, 1); pushw(ds);                                /* push ds */
            ii(0x15_86d9, 3); pushw(0x17ac);                            /* push 0x17ac */
            ii(0x15_86dc, 3); callw(0x15_105e, -0x7681);                /* call 0x105e */
            ii(0x15_86df, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_86e2, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_86e5, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_86e8, 1); nop();                                    /* nop */
            ii(0x15_86e9, 1); pushw(cs);                                /* push cs */
            ii(0x15_86ea, 3); callw(0x15_f8ec, 0x71ff);                 /* call 0xf8ec */
            ii(0x15_86ed, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_86f0, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x15_86f4, 2); if(jnzw(0x15_86f9, 0x3)) goto l_0x15_86f9; /* jnz 0x86f9 */
            ii(0x15_86f6, 3); jmpw(0x15_8707, 0xe); goto l_0x15_8707;   /* jmp 0x8707 */
        l_0x15_86f9:
            ii(0x15_86f9, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_86fc, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_86ff, 1); nop();                                    /* nop */
            ii(0x15_8700, 1); pushw(cs);                                /* push cs */
            ii(0x15_8701, 3); callw(0x15_8309, -0x3fb);                 /* call 0x8309 */
            ii(0x15_8704, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x15_8707:
            ii(0x15_8707, 3); jmpw(0x15_86a3, -0x67); goto l_0x15_86a3; /* jmp 0x86a3 */
        l_0x15_870a:
            ii(0x15_870a, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_870d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_8710, 1); nop();                                    /* nop */
            ii(0x15_8711, 1); pushw(cs);                                /* push cs */
            ii(0x15_8712, 3); callw(0x15_845c, -0x2b9);                 /* call 0x845c */
            ii(0x15_8715, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_8718, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_871b, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_871e, 4); pushw(memw_a16[es, bx + 0x1a]);           /* push word [es:bx+0x1a] */
            ii(0x15_8722, 4); pushw(memw_a16[es, bx + 0x18]);           /* push word [es:bx+0x18] */
            ii(0x15_8726, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_8729, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_872d, 1); nop();                                    /* nop */
            ii(0x15_872e, 1); pushw(cs);                                /* push cs */
            ii(0x15_872f, 3); callw(0x15_84c5, -0x26d);                 /* call 0x84c5 */
            ii(0x15_8732, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_8735, 1); nop();                                    /* nop */
            ii(0x15_8736, 1); pushw(cs);                                /* push cs */
            ii(0x15_8737, 3); callw(0x15_8560, -0x1da);                 /* call 0x8560 */
        l_0x15_873a:
            ii(0x15_873a, 5); cmp(memb_a16[ds, 0xd7f], 0);              /* cmp byte [0xd7f], 0x0 */
            ii(0x15_873f, 2); if(jnzw(0x15_8744, 0x3)) goto l_0x15_8744; /* jnz 0x8744 */
            ii(0x15_8741, 3); if(jmpw_func(0x15_8749, 0x5)) return;     /* jmp 0x8749 */
        l_0x15_8744:
            ii(0x15_8744, 1); int3();                                   /* int3 */
            ii(0x15_8745, 2); outb(0x99, al);                           /* out 0x99, al */
            ii(0x15_8747, 1); cli();                                    /* cli */
        }
    }
}
