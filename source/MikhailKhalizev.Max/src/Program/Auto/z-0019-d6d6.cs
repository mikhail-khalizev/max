using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("956afdaf-ea90-4372-b42a-eed357104413")]
        public void Method_0019_d6d6()
        {
            ii(0x19_d6d6, 4); enterw(0x5c, 0);                          /* enter 0x5c, 0x0 */
            ii(0x19_d6da, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_d6dc, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
            ii(0x19_d6df, 3); mov(memw_a16[ss, bp - 0x5a], ax);         /* mov [bp-0x5a], ax */
            ii(0x19_d6e2, 5); mov(memw_a16[ss, bp - 0x50], 0xffff);     /* mov word [bp-0x50], 0xffff */
            ii(0x19_d6e7, 3); mov(memw_a16[ss, bp - 0x52], ax);         /* mov [bp-0x52], ax */
            ii(0x19_d6ea, 5); mov(memw_a16[ss, bp - 0x54], 0xffff);     /* mov word [bp-0x54], 0xffff */
            ii(0x19_d6ef, 4); mov(memb_a16[ss, bp - 0x5c], 0);          /* mov byte [bp-0x5c], 0x0 */
            ii(0x19_d6f3, 1); pushw(ds);                                /* push ds */
            ii(0x19_d6f4, 3); pushw(0x2aff);                            /* push 0x2aff */
            ii(0x19_d6f7, 1); pushw(ds);                                /* push ds */
            ii(0x19_d6f8, 3); pushw(0x2afa);                            /* push 0x2afa */
            ii(0x19_d6fb, 3); callw(0x19_fcad, 0x25af);                 /* call 0xfcad */
            ii(0x19_d6fe, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_d701, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_d704, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_d706, 2); if(jzw(0x19_d731, 0x29)) goto l_0x19_d731; /* jz 0xd731 */
            ii(0x19_d708, 2); pushw(0x7);                               /* push 0x7 */
            ii(0x19_d70a, 1); pushw(ds);                                /* push ds */
            ii(0x19_d70b, 3); pushw(0x2b0a);                            /* push 0x2b0a */
            ii(0x19_d70e, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x19_d711, 1); pushw(dx);                                /* push dx */
            ii(0x19_d712, 1); pushw(ax);                                /* push ax */
            ii(0x19_d713, 5); callw_far_abs(0x80, 0x3f6c);              /* call word 0x80:0x3f6c */
            ii(0x19_d718, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_d71b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d71d, 2); if(jnzw(0x19_d731, 0x12)) goto l_0x19_d731; /* jnz 0xd731 */
            ii(0x19_d71f, 1); pushw(ds);                                /* push ds */
            ii(0x19_d720, 3); pushw(0x2b12);                            /* push 0x2b12 */
            ii(0x19_d723, 3); pushw(0x8fe);                             /* push 0x8fe */
            ii(0x19_d726, 5); callw_far_abs(0x80, 0x21d2);              /* call word 0x80:0x21d2 */
            ii(0x19_d72b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_d72e, 3); jmpw(0x19_d8f3, 0x1c2); goto l_0x19_d8f3; /* jmp 0xd8f3 */
        l_0x19_d731:
            ii(0x19_d731, 1); pushw(ds);                                /* push ds */
            ii(0x19_d732, 3); pushw(0x2b2d);                            /* push 0x2b2d */
            ii(0x19_d735, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d738, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d73b, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x19_d740, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_d743, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d745, 2); if(jnzw(0x19_d74d, 0x6)) goto l_0x19_d74d; /* jnz 0xd74d */
            ii(0x19_d747, 3); mov(ax, 0x29a);                           /* mov ax, 0x29a */
            ii(0x19_d74a, 3); jmpw(0x19_d8f6, 0x1a9); goto l_0x19_d8f6; /* jmp 0xd8f6 */
        l_0x19_d74d:
            ii(0x19_d74d, 1); pushw(ds);                                /* push ds */
            ii(0x19_d74e, 3); pushw(0x2b36);                            /* push 0x2b36 */
            ii(0x19_d751, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d754, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d757, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x19_d75c, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_d75f, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d761, 2); if(jzw(0x19_d779, 0x16)) goto l_0x19_d779; /* jz 0xd779 */
            ii(0x19_d763, 1); pushw(ds);                                /* push ds */
            ii(0x19_d764, 3); pushw(0x2b3f);                            /* push 0x2b3f */
            ii(0x19_d767, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d76a, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d76d, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x19_d772, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_d775, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d777, 2); if(jnzw(0x19_d77c, 0x3)) goto l_0x19_d77c; /* jnz 0xd77c */
        l_0x19_d779:
            ii(0x19_d779, 3); jmpw(0x19_d8ee, 0x172); goto l_0x19_d8ee; /* jmp 0xd8ee */
        l_0x19_d77c:
            ii(0x19_d77c, 3); lea(ax, bp - 0x4a);                       /* lea ax, [bp-0x4a] */
            ii(0x19_d77f, 1); pushw(ss);                                /* push ss */
            ii(0x19_d780, 1); pushw(ax);                                /* push ax */
            ii(0x19_d781, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d784, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d787, 3); callw(0x19_ff6c, 0x27e2);                 /* call 0xff6c */
            ii(0x19_d78a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d78d, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d790, 3); callw(0x19_a16e, -0x3625);                /* call 0xa16e */
            ii(0x19_d793, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x19_d796, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_d799, 2); if(jnzw(0x19_d7b1, 0x16)) goto l_0x19_d7b1; /* jnz 0xd7b1 */
            ii(0x19_d79b, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d79e, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d7a1, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d7a3, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d7a5, 3); lea(ax, bp - 0x4a);                       /* lea ax, [bp-0x4a] */
            ii(0x19_d7a8, 1); pushw(ss);                                /* push ss */
            ii(0x19_d7a9, 1); pushw(ax);                                /* push ax */
            ii(0x19_d7aa, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x19_d7ac, 1); nop();                                    /* nop */
            ii(0x19_d7ad, 1); pushw(cs);                                /* push cs */
            ii(0x19_d7ae, 3); callw(0x1a_0a45, 0x3294);                 /* call 0xa45 */
        l_0x19_d7b1:
            ii(0x19_d7b1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_d7b3, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x19_d7b6, 3); mov(memw_a16[ss, bp - 0x4e], ax);         /* mov [bp-0x4e], ax */
            ii(0x19_d7b9, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x19_d7bc, 3); lea(ax, bp - 0x4a);                       /* lea ax, [bp-0x4a] */
            ii(0x19_d7bf, 1); pushw(ss);                                /* push ss */
            ii(0x19_d7c0, 1); pushw(ax);                                /* push ax */
            ii(0x19_d7c1, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d7c4, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d7c7, 1); pushw(ds);                                /* push ds */
            ii(0x19_d7c8, 3); pushw(0x2b5f);                            /* push 0x2b5f */
            ii(0x19_d7cb, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x19_d7d0, 3); add(sp, 0xe);                             /* add sp, 0xe */
            ii(0x19_d7d3, 4); cmp(memw_a16[ss, bp - 0x50], -0x1 /* 0xff */); /* cmp word [bp-0x50], 0xffff */
            ii(0x19_d7d7, 2); if(jnzw(0x19_d7f9, 0x20)) goto l_0x19_d7f9; /* jnz 0xd7f9 */
            ii(0x19_d7d9, 4); cmp(memw_a16[ss, bp - 0x48], 0);          /* cmp word [bp-0x48], 0x0 */
            ii(0x19_d7dd, 2); if(jnzw(0x19_d7e7, 0x8)) goto l_0x19_d7e7; /* jnz 0xd7e7 */
            ii(0x19_d7df, 3); mov(ax, memw_a16[ss, bp - 0x4a]);         /* mov ax, [bp-0x4a] */
            ii(0x19_d7e2, 3); mov(memw_a16[ss, bp - 0x54], ax);         /* mov [bp-0x54], ax */
            ii(0x19_d7e5, 2); jmpw(0x19_d7f9, 0x12); goto l_0x19_d7f9;  /* jmp 0xd7f9 */
        l_0x19_d7e7:
            ii(0x19_d7e7, 3); lea(ax, bp - 0x4a);                       /* lea ax, [bp-0x4a] */
            ii(0x19_d7ea, 1); pushw(ss);                                /* push ss */
            ii(0x19_d7eb, 1); pushw(ax);                                /* push ax */
            ii(0x19_d7ec, 3); callw(0x19_c4ae, -0x1341);                /* call 0xc4ae */
            ii(0x19_d7ef, 3); mov(memw_a16[ss, bp - 0x54], ax);         /* mov [bp-0x54], ax */
            ii(0x19_d7f2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d7f4, 2); if(jgew(0x19_d7f9, 0x3)) goto l_0x19_d7f9; /* jge 0xd7f9 */
            ii(0x19_d7f6, 3); jmpw(0x19_d8ee, 0xf5); goto l_0x19_d8ee;  /* jmp 0xd8ee */
        l_0x19_d7f9:
            ii(0x19_d7f9, 4); cmp(memw_a16[ss, bp - 0x50], -0x1 /* 0xff */); /* cmp word [bp-0x50], 0xffff */
            ii(0x19_d7fd, 2); if(jzw(0x19_d82e, 0x2f)) goto l_0x19_d82e; /* jz 0xd82e */
            ii(0x19_d7ff, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x19_d802, 3); pushw(memw_a16[ss, bp - 0x54]);           /* push word [bp-0x54] */
            ii(0x19_d805, 3); callw(0x19_9ed2, -0x3936);                /* call 0x9ed2 */
            ii(0x19_d808, 3); mov(memw_a16[ss, bp - 0x56], ax);         /* mov [bp-0x56], ax */
            ii(0x19_d80b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d80d, 2); if(jnzw(0x19_d812, 0x3)) goto l_0x19_d812; /* jnz 0xd812 */
            ii(0x19_d80f, 3); jmpw(0x19_d8f3, 0xe1); goto l_0x19_d8f3;  /* jmp 0xd8f3 */
        l_0x19_d812:
            ii(0x19_d812, 3); cmp(ax, 0x2);                             /* cmp ax, 0x2 */
            ii(0x19_d815, 2); if(jzw(0x19_d81a, 0x3)) goto l_0x19_d81a; /* jz 0xd81a */
            ii(0x19_d817, 3); inc(memb_a16[ss, bp - 0x5c]);             /* inc byte [bp-0x5c] */
        l_0x19_d81a:
            ii(0x19_d81a, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x19_d81d, 3); callw(0x19_a14c, -0x36d4);                /* call 0xa14c */
            ii(0x19_d820, 3); mov(memw_a16[ss, bp - 0x5a], ax);         /* mov [bp-0x5a], ax */
            ii(0x19_d823, 3); mov(memw_a16[ss, bp - 0x58], dx);         /* mov [bp-0x58], dx */
            ii(0x19_d826, 1); pushw(dx);                                /* push dx */
            ii(0x19_d827, 1); pushw(ax);                                /* push ax */
            ii(0x19_d828, 3); callw(0x19_b95c, -0x1ecf);                /* call 0xb95c */
            ii(0x19_d82b, 3); jmpw(0x19_d8cc, 0x9e); goto l_0x19_d8cc;  /* jmp 0xd8cc */
        l_0x19_d82e:
            ii(0x19_d82e, 5); cmp(memb_a16[ds, 0x2bf2], 0);             /* cmp byte [0x2bf2], 0x0 */
            ii(0x19_d833, 2); if(jnzw(0x19_d89a, 0x65)) goto l_0x19_d89a; /* jnz 0xd89a */
            ii(0x19_d835, 3); lea(ax, bp - 0x4a);                       /* lea ax, [bp-0x4a] */
            ii(0x19_d838, 1); pushw(ss);                                /* push ss */
            ii(0x19_d839, 1); pushw(ax);                                /* push ax */
            ii(0x19_d83a, 3); lea(ax, bp - 0x5a);                       /* lea ax, [bp-0x5a] */
            ii(0x19_d83d, 1); pushw(ss);                                /* push ss */
            ii(0x19_d83e, 1); pushw(ax);                                /* push ax */
            ii(0x19_d83f, 3); callw(0x19_a06c, -0x37d6);                /* call 0xa06c */
            ii(0x19_d842, 3); mov(memw_a16[ss, bp - 0x50], ax);         /* mov [bp-0x50], ax */
            ii(0x19_d845, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_d848, 2); if(jzw(0x19_d89a, 0x50)) goto l_0x19_d89a; /* jz 0xd89a */
            ii(0x19_d84a, 3); mov(ax, memw_a16[ss, bp - 0x54]);         /* mov ax, [bp-0x54] */
            ii(0x19_d84d, 3); les(bx, ss, bp - 0x5a);                   /* les bx, [bp-0x5a] */
            ii(0x19_d850, 5); mov(memw_a16[es, bx + 0xb4], ax);         /* mov [es:bx+0xb4], ax */
            ii(0x19_d855, 3); mov(ax, memw_a16[ss, bp - 0x4e]);         /* mov ax, [bp-0x4e] */
            ii(0x19_d858, 3); mov(dx, memw_a16[ss, bp - 0x4c]);         /* mov dx, [bp-0x4c] */
            ii(0x19_d85b, 3); les(bx, ss, bp - 0x5a);                   /* les bx, [bp-0x5a] */
            ii(0x19_d85e, 5); mov(memw_a16[es, bx + 0xb6], ax);         /* mov [es:bx+0xb6], ax */
            ii(0x19_d863, 5); mov(memw_a16[es, bx + 0xb8], dx);         /* mov [es:bx+0xb8], dx */
            ii(0x19_d868, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x19_d86d, 2); if(jnzw(0x19_d883, 0x14)) goto l_0x19_d883; /* jnz 0xd883 */
            ii(0x19_d86f, 3); mov(ax, memw_a16[ds, 0x19fe]);            /* mov ax, [0x19fe] */
            ii(0x19_d872, 4); mov(dx, memw_a16[ds, 0x1a00]);            /* mov dx, [0x1a00] */
            ii(0x19_d876, 3); les(bx, ss, bp - 0x5a);                   /* les bx, [bp-0x5a] */
            ii(0x19_d879, 5); mov(memw_a16[es, bx + 0xc4], ax);         /* mov [es:bx+0xc4], ax */
            ii(0x19_d87e, 5); mov(memw_a16[es, bx + 0xc6], dx);         /* mov [es:bx+0xc6], dx */
        l_0x19_d883:
            ii(0x19_d883, 4); inc(memb_a16[ds, 0x28ba]);                /* inc byte [0x28ba] */
            ii(0x19_d887, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x19_d88a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_d88c, 3); callw(0x19_a6d4, -0x31bb);                /* call 0xa6d4 */
            ii(0x19_d88f, 3); mov(memw_a16[ss, bp - 0x52], ax);         /* mov [bp-0x52], ax */
            ii(0x19_d892, 4); dec(memb_a16[ds, 0x28ba]);                /* dec byte [0x28ba] */
            ii(0x19_d896, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d898, 2); if(jzw(0x19_d8c9, 0x2f)) goto l_0x19_d8c9; /* jz 0xd8c9 */
        l_0x19_d89a:
            ii(0x19_d89a, 4); cmp(memw_a16[ss, bp - 0x48], 0);          /* cmp word [bp-0x48], 0x0 */
            ii(0x19_d89e, 2); if(jzw(0x19_d8bb, 0x1b)) goto l_0x19_d8bb; /* jz 0xd8bb */
            ii(0x19_d8a0, 3); pushw(memw_a16[ss, bp - 0x54]);           /* push word [bp-0x54] */
            ii(0x19_d8a3, 3); callw(0x19_febc, 0x2616);                 /* call 0xfebc */
            ii(0x19_d8a6, 3); mov(memw_a16[ss, bp - 0x52], ax);         /* mov [bp-0x52], ax */
            ii(0x19_d8a9, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x19_d8ac, 3); or(ax, memw_a16[ss, bp - 0x5a]);          /* or ax, [bp-0x5a] */
            ii(0x19_d8af, 2); if(jzw(0x19_d8bb, 0xa)) goto l_0x19_d8bb; /* jz 0xd8bb */
            ii(0x19_d8b1, 3); les(bx, ss, bp - 0x5a);                   /* les bx, [bp-0x5a] */
            ii(0x19_d8b4, 7); mov(memw_a16[es, bx + 0xb4], 0xffff);     /* mov word [es:bx+0xb4], 0xffff */
        l_0x19_d8bb:
            ii(0x19_d8bb, 4); cmp(memw_a16[ss, bp - 0x50], -0x1 /* 0xff */); /* cmp word [bp-0x50], 0xffff */
            ii(0x19_d8bf, 2); if(jzw(0x19_d8f3, 0x32)) goto l_0x19_d8f3; /* jz 0xd8f3 */
            ii(0x19_d8c1, 3); pushw(memw_a16[ss, bp - 0x50]);           /* push word [bp-0x50] */
            ii(0x19_d8c4, 3); callw(0x19_a1f7, -0x36d0);                /* call 0xa1f7 */
            ii(0x19_d8c7, 2); jmpw(0x19_d8f3, 0x2a); goto l_0x19_d8f3;  /* jmp 0xd8f3 */
        l_0x19_d8c9:
            ii(0x19_d8c9, 3); inc(memb_a16[ss, bp - 0x5c]);             /* inc byte [bp-0x5c] */
        l_0x19_d8cc:
            ii(0x19_d8cc, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x19_d8cf, 3); pushw(memw_a16[ss, bp - 0x5a]);           /* push word [bp-0x5a] */
            ii(0x19_d8d2, 3); callw(0x19_d518, -0x3bd);                 /* call 0xd518 */
            ii(0x19_d8d5, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d8d7, 2); if(jzw(0x19_d8e8, 0xf)) goto l_0x19_d8e8; /* jz 0xd8e8 */
            ii(0x19_d8d9, 4); cmp(memb_a16[ss, bp - 0x5c], 0);          /* cmp byte [bp-0x5c], 0x0 */
            ii(0x19_d8dd, 2); if(jzw(0x19_d8e8, 0x9)) goto l_0x19_d8e8; /* jz 0xd8e8 */
            ii(0x19_d8df, 3); pushw(memw_a16[ss, bp - 0x58]);           /* push word [bp-0x58] */
            ii(0x19_d8e2, 3); pushw(memw_a16[ss, bp - 0x5a]);           /* push word [bp-0x5a] */
            ii(0x19_d8e5, 3); callw(0x19_d5b5, -0x333);                 /* call 0xd5b5 */
        l_0x19_d8e8:
            ii(0x19_d8e8, 4); cmp(memw_a16[ss, bp - 0x52], 0);          /* cmp word [bp-0x52], 0x0 */
            ii(0x19_d8ec, 2); if(jnzw(0x19_d8f3, 0x5)) goto l_0x19_d8f3; /* jnz 0xd8f3 */
        l_0x19_d8ee:
            ii(0x19_d8ee, 3); mov(ax, memw_a16[ss, bp - 0x50]);         /* mov ax, [bp-0x50] */
            ii(0x19_d8f1, 2); jmpw(0x19_d8f6, 0x3); goto l_0x19_d8f6;   /* jmp 0xd8f6 */
        l_0x19_d8f3:
            ii(0x19_d8f3, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x19_d8f6:
            ii(0x19_d8f6, 1); leavew();                                 /* leave */
            ii(0x19_d8f7, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}
