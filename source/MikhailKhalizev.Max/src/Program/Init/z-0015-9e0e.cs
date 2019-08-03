using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26ccc1db-e784-4566-9847-2d3afe0a2c58")]
        public void Method_0015_9e0e()
        {
            ii(0x15_9e0e, 4); enterw(0xa2, 0);                          /* enter 0xa2, 0x0 */
            ii(0x15_9e12, 3); mov(ax, memw_a16[ds, 0x3292]);            /* mov ax, [0x3292] */
            ii(0x15_9e15, 4); or(ax, memw_a16[ds, 0x3290]);             /* or ax, [0x3290] */
            ii(0x15_9e19, 2); if(jzw(0x15_9e22, 0x7)) goto l_0x15_9e22; /* jz 0x9e22 */
            ii(0x15_9e1b, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x15_9e20, 2); if(jzw(0x15_9e30, 0xe)) goto l_0x15_9e30; /* jz 0x9e30 */
        l_0x15_9e22:
            ii(0x15_9e22, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_9e25, 7); mov(memw_a16[es, bx + 0x12a], 0xffff);    /* mov word [es:bx+0x12a], 0xffff */
            ii(0x15_9e2c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_9e2e, 2); jmpw(0x15_9e5c, 0x2c); goto l_0x15_9e5c;  /* jmp 0x9e5c */
        l_0x15_9e30:
            ii(0x15_9e30, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9e33, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_9e36, 2); pushw(-0x6 /* 0xfa */);                   /* push 0xfffa */
            ii(0x15_9e38, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x15_9e3b, 1); pushw(ss);                                /* push ss */
            ii(0x15_9e3c, 1); pushw(ax);                                /* push ax */
            ii(0x15_9e3d, 3); callw(0x15_c5ce, 0x278e);                 /* call 0xc5ce */
            ii(0x15_9e40, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_9e42, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_9e45, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x15_9e48, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x15_9e4b, 1); pushw(dx);                                /* push dx */
            ii(0x15_9e4c, 1); pushw(ax);                                /* push ax */
            ii(0x15_9e4d, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x15_9e50, 1); pushw(ss);                                /* push ss */
            ii(0x15_9e51, 1); pushw(ax);                                /* push ax */
            ii(0x15_9e52, 3); callw(0x15_9bb6, -0x29f);                 /* call 0x9bb6 */
            ii(0x15_9e55, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x15_9e58, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x15_9e5a, 2); neg(ax);                                  /* neg ax */
        l_0x15_9e5c:
            ii(0x15_9e5c, 1); leavew();                                 /* leave */
            ii(0x15_9e5d, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}