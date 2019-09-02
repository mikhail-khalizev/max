using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c860-5727951d")]
        public void Method_0019_c860()
        {
            ii(0x19_c860, 4); enter(0xb6, 0);                           /* enter 0xb6, 0x0 */
            ii(0x19_c864, 1); push(si);                                 /* push si */
            ii(0x19_c865, 6); mov(memw[ss, bp - 0xb2], 0);              /* mov word [bp-0xb2], 0x0 */
            ii(0x19_c86b, 3); mov(ax, memw[ss, bp + 8]);                /* mov ax, [bp+0x8] */
            ii(0x19_c86e, 3); mov(dx, memw[ss, bp + 0xa]);              /* mov dx, [bp+0xa] */
            ii(0x19_c871, 4); mov(memw[ss, bp - 0x9c], ax);             /* mov [bp-0x9c], ax */
            ii(0x19_c875, 4); mov(memw[ss, bp - 0x9a], dx);             /* mov [bp-0x9a], dx */
            ii(0x19_c879, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_c87c, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_c87f, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_c882, 3); lea(ax, memw[ss, bp - 0x80]);             /* lea ax, [bp-0x80] */
            ii(0x19_c885, 1); push(ss);                                 /* push ss */
            ii(0x19_c886, 1); push(ax);                                 /* push ax */
            ii(0x19_c887, 3); call(0x19_c5ce, -0x2bc);                  /* call 0xc5ce */
            ii(0x19_c88a, 4); cmp(memw[ss, bp + 0xc], -7 /* 0xf9 */);   /* cmp word [bp+0xc], 0xfff9 */
            ii(0x19_c88e, 2); if(jnz(0x19_c898, 8)) goto l_0x19_c898;   /* jnz 0xc898 */
            ii(0x19_c890, 6); mov(memw[ss, bp - 0xb2], 0);              /* mov word [bp-0xb2], 0x0 */
            ii(0x19_c896, 2); jmp(0x19_c8de, 0x46); goto l_0x19_c8de;   /* jmp 0xc8de */
        l_0x19_c898:
            ii(0x19_c898, 4); cmp(memw[ss, bp + 0xc], 0);               /* cmp word [bp+0xc], 0x0 */
            ii(0x19_c89c, 2); if(jl(0x19_c8da, 0x3c)) goto l_0x19_c8da; /* jl 0xc8da */
            ii(0x19_c89e, 3); mov(ax, memw[ss, bp + 0x10]);             /* mov ax, [bp+0x10] */
            ii(0x19_c8a1, 3); or(ax, memw[ss, bp + 0xe]);               /* or ax, [bp+0xe] */
            ii(0x19_c8a4, 2); if(jz(0x19_c8bc, 0x16)) goto l_0x19_c8bc; /* jz 0xc8bc */
            ii(0x19_c8a6, 4); imul(bx, memw[ss, bp + 0xc], 0x18);       /* imul bx, [bp+0xc], 0x18 */
            ii(0x19_c8aa, 3); les(si, memw[ss, bp + 0xe]);              /* les si, [bp+0xe] */
            ii(0x19_c8ad, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_c8af, 4); les(bx, memw[es, si + 0x3c]);             /* les bx, [es:si+0x3c] */
            ii(0x19_c8b3, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_c8b5, 5); test(memb[es, bx + si + 8], 0x20);        /* test byte [es:bx+si+0x8], 0x20 */
            ii(0x19_c8ba, 2); if(jnz(0x19_c8da, 0x1e)) goto l_0x19_c8da; /* jnz 0xc8da */
        l_0x19_c8bc:
            ii(0x19_c8bc, 3); mov(ax, memw[ss, bp + 0x10]);             /* mov ax, [bp+0x10] */
            ii(0x19_c8bf, 3); or(ax, memw[ss, bp + 0xe]);               /* or ax, [bp+0xe] */
            ii(0x19_c8c2, 2); if(jz(0x19_c8de, 0x1a)) goto l_0x19_c8de; /* jz 0xc8de */
            ii(0x19_c8c4, 4); imul(bx, memw[ss, bp + 0xc], 0x18);       /* imul bx, [bp+0xc], 0x18 */
            ii(0x19_c8c8, 3); les(si, memw[ss, bp + 0xe]);              /* les si, [bp+0xe] */
            ii(0x19_c8cb, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_c8cd, 4); les(bx, memw[es, si + 0x3c]);             /* les bx, [es:si+0x3c] */
            ii(0x19_c8d1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_c8d3, 5); test(memb[es, bx + si + 8], 4);           /* test byte [es:bx+si+0x8], 0x4 */
            ii(0x19_c8d8, 2); if(jz(0x19_c8de, 4)) goto l_0x19_c8de;    /* jz 0xc8de */
        l_0x19_c8da:
            ii(0x19_c8da, 4); inc(memw[ss, bp - 0xb2]);                 /* inc word [bp-0xb2] */
        l_0x19_c8de:
            ii(0x19_c8de, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x19_c8e1, 5); cmp(memw[es, bx + 0x5c], 0);              /* cmp word [es:bx+0x5c], 0x0 */
            ii(0x19_c8e6, 2); if(jz(0x19_c8ec, 4)) goto l_0x19_c8ec;    /* jz 0xc8ec */
            ii(0x19_c8e8, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c8ea, 2); jmp(0x19_c8f8, 0xc); goto l_0x19_c8f8;    /* jmp 0xc8f8 */
        l_0x19_c8ec:
            ii(0x19_c8ec, 5); cmp(memw[ss, bp - 0xb2], 1);              /* cmp word [bp-0xb2], 0x1 */
            ii(0x19_c8f1, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_c8f3, 3); and(ax, 2);                               /* and ax, 0x2 */
            ii(0x19_c8f6, 1); inc(ax);                                  /* inc ax */
            ii(0x19_c8f7, 1); inc(ax);                                  /* inc ax */
        l_0x19_c8f8:
            ii(0x19_c8f8, 4); mov(memw[ss, bp - 0xb2], ax);             /* mov [bp-0xb2], ax */
            ii(0x19_c8fc, 1); push(ax);                                 /* push ax */
            ii(0x19_c8fd, 3); lea(ax, memw[ss, bp - 0x80]);             /* lea ax, [bp-0x80] */
            ii(0x19_c900, 1); push(ss);                                 /* push ss */
            ii(0x19_c901, 1); push(ax);                                 /* push ax */
            ii(0x19_c902, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_c905, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_c908, 4); lea(ax, memw[ss, bp - 0x94]);             /* lea ax, [bp-0x94] */
            ii(0x19_c90c, 1); push(ss);                                 /* push ss */
            ii(0x19_c90d, 1); push(ax);                                 /* push ax */
            ii(0x19_c90e, 3); call(0x19_c684, -0x28d);                  /* call 0xc684 */
            ii(0x19_c911, 4); mov(memw[ss, bp - 0x90], ax);             /* mov [bp-0x90], ax */
            ii(0x19_c915, 4); mov(memw[ss, bp - 0x8e], dx);             /* mov [bp-0x8e], dx */
            ii(0x19_c919, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_c91b, 4); or(ax, memw[ss, bp - 0x90]);              /* or ax, [bp-0x90] */
            ii(0x19_c91f, 2); if(jz(0x19_c945, 0x24)) goto l_0x19_c945; /* jz 0xc945 */
            ii(0x19_c921, 4); mov(ax, memw[ss, bp - 0x94]);             /* mov ax, [bp-0x94] */
            ii(0x19_c925, 4); mov(dx, memw[ss, bp - 0x92]);             /* mov dx, [bp-0x92] */
            ii(0x19_c929, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_c92c, 4); mov(memw[es, bx + 8], ax);                /* mov [es:bx+0x8], ax */
            ii(0x19_c930, 4); mov(memw[es, bx + 0xa], dx);              /* mov [es:bx+0xa], dx */
            ii(0x19_c934, 4); mov(ax, memw[ss, bp - 0x90]);             /* mov ax, [bp-0x90] */
            ii(0x19_c938, 4); mov(dx, memw[ss, bp - 0x8e]);             /* mov dx, [bp-0x8e] */
            ii(0x19_c93c, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_c93f, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x19_c943, 2); jmp(0x19_c948, 3); goto l_0x19_c948;      /* jmp 0xc948 */
        l_0x19_c945:
            ii(0x19_c945, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c947, 1); cwd();                                    /* cwd */
        l_0x19_c948:
            ii(0x19_c948, 1); pop(si);                                  /* pop si */
            ii(0x19_c949, 1); leave();                                  /* leave */
            ii(0x19_c94a, 3); ret(0xe);                                 /* ret 0xe */
        }
    }
}
