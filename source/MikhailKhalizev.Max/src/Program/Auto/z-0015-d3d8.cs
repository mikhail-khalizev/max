using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("66bd60c9-e679-424b-8f84-2ae1c6e1a30a")]
        public void Method_0015_d3d8()
        {
            ii(0x15_d3d8, 4); enterw(0x42, 0);                          /* enter 0x42, 0x0 */
            ii(0x15_d3dc, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d3df, 5); mov(memw_a16[es, bx], 0);                 /* mov word [es:bx], 0x0 */
            ii(0x15_d3e4, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_d3e6, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x15_d3ea, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_d3ee, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_d3f1, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x15_d3f4, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_d3f7, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_d3fa, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d3fd, 1); pushw(ss);                                /* push ss */
            ii(0x15_d3fe, 1); pushw(ax);                                /* push ax */
            ii(0x15_d3ff, 3); callw(0x15_cde9, -0x619);                 /* call 0xcde9 */
            ii(0x15_d402, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d405, 1); pushw(ss);                                /* push ss */
            ii(0x15_d406, 1); pushw(ax);                                /* push ax */
            ii(0x15_d407, 3); callw(0x15_a16e, -0x329c);                /* call 0xa16e */
            ii(0x15_d40a, 3); mov(memw_a16[ss, bp - 0x42], ax);         /* mov [bp-0x42], ax */
            ii(0x15_d40d, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x15_d410, 2); if(jnzw(0x15_d41d, 0xb)) goto l_0x15_d41d; /* jnz 0xd41d */
            ii(0x15_d412, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d415, 1); pushw(ss);                                /* push ss */
            ii(0x15_d416, 1); pushw(ax);                                /* push ax */
            ii(0x15_d417, 3); callw(0x15_d6d6, 0x2bc);                  /* call 0xd6d6 */
            ii(0x15_d41a, 3); mov(memw_a16[ss, bp - 0x42], ax);         /* mov [bp-0x42], ax */
        l_0x15_d41d:
            ii(0x15_d41d, 3); pushw(memw_a16[ss, bp + 0x14]);           /* push word [bp+0x14] */
            ii(0x15_d420, 3); pushw(memw_a16[ss, bp + 0x12]);           /* push word [bp+0x12] */
            ii(0x15_d423, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d426, 1); pushw(ss);                                /* push ss */
            ii(0x15_d427, 1); pushw(ax);                                /* push ax */
            ii(0x15_d428, 3); callw(0x15_d270, -0x1bb);                 /* call 0xd270 */
            ii(0x15_d42b, 4); cmp(memw_a16[ss, bp - 0x42], -0x1 /* 0xff */); /* cmp word [bp-0x42], 0xffff */
            ii(0x15_d42f, 2); if(jzw(0x15_d440, 0xf)) goto l_0x15_d440; /* jz 0xd440 */
            ii(0x15_d431, 3); pushw(memw_a16[ss, bp - 0x42]);           /* push word [bp-0x42] */
            ii(0x15_d434, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_d437, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_d43a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_d43d, 3); callw(0x15_cff8, -0x448);                 /* call 0xcff8 */
        l_0x15_d440:
            ii(0x15_d440, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d443, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_d447, 4); or(ax, memw_a16[es, bx + 0x2]);           /* or ax, [es:bx+0x2] */
            ii(0x15_d44b, 2); if(jnzw(0x15_d461, 0x14)) goto l_0x15_d461; /* jnz 0xd461 */
            ii(0x15_d44d, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d450, 1); pushw(ss);                                /* push ss */
            ii(0x15_d451, 1); pushw(ax);                                /* push ax */
            ii(0x15_d452, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_d455, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_d458, 1); pushw(es);                                /* push es */
            ii(0x15_d459, 1); pushw(bx);                                /* push bx */
            ii(0x15_d45a, 3); mov(al, memb_a16[ss, bp + 0x4]);          /* mov al, [bp+0x4] */
            ii(0x15_d45d, 1); pushw(ax);                                /* push ax */
            ii(0x15_d45e, 3); callw(0x15_d1ad, -0x2b4);                 /* call 0xd1ad */
        l_0x15_d461:
            ii(0x15_d461, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d464, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_d468, 4); or(ax, memw_a16[es, bx + 0x2]);           /* or ax, [es:bx+0x2] */
            ii(0x15_d46c, 2); if(jnzw(0x15_d487, 0x19)) goto l_0x15_d487; /* jnz 0xd487 */
            ii(0x15_d46e, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d471, 1); pushw(ss);                                /* push ss */
            ii(0x15_d472, 1); pushw(ax);                                /* push ax */
            ii(0x15_d473, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_d476, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_d479, 3); mov(ax, memw_a16[ss, bp + 0x12]);         /* mov ax, [bp+0x12] */
            ii(0x15_d47c, 3); mov(dx, memw_a16[ss, bp + 0x14]);         /* mov dx, [bp+0x14] */
            ii(0x15_d47f, 3); add(ax, 0xea);                            /* add ax, 0xea */
            ii(0x15_d482, 1); pushw(dx);                                /* push dx */
            ii(0x15_d483, 1); pushw(ax);                                /* push ax */
            ii(0x15_d484, 3); callw(0x15_cd9f, -0x6e8);                 /* call 0xcd9f */
        l_0x15_d487:
            ii(0x15_d487, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d48a, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_d48d, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_d491, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_d495, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_d498, 3); lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x15_d49b, 1); pushw(ss);                                /* push ss */
            ii(0x15_d49c, 1); pushw(ax);                                /* push ax */
            ii(0x15_d49d, 1); pushw(ds);                                /* push ds */
            ii(0x15_d49e, 3); pushw(0x29f0);                            /* push 0x29f0 */
            ii(0x15_d4a1, 5); callw_far_abs(0x80, 0x2289);              /* call word 0x80:0x2289 */
            ii(0x15_d4a6, 1); leavew();                                 /* leave */
            ii(0x15_d4a7, 3); retw(0x12); return;                       /* ret 0x12 */
        }
    }
}
