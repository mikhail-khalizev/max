using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9e0e-6bdcdf25")]
        public void Method_0019_9e0e()
        {
            ii(0x19_9e0e, 4); enter(0xa2, 0);                           /* enter 0xa2, 0x0 */
            ii(0x19_9e12, 3); mov(ax, memw[ds, 0x3292]);                /* mov ax, [0x3292] */
            ii(0x19_9e15, 4); or(ax, memw[ds, 0x3290]);                 /* or ax, [0x3290] */
            ii(0x19_9e19, 2); if(jz(0x19_9e22, 0x7)) goto l_0x19_9e22;  /* jz 0x9e22 */
            ii(0x19_9e1b, 5); cmp(memb[ds, 0x19f4], 0x1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_9e20, 2); if(jz(0x19_9e30, 0xe)) goto l_0x19_9e30;  /* jz 0x9e30 */
        l_0x19_9e22:
            ii(0x19_9e22, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_9e25, 7); mov(memw[es, bx + 0x12a], 0xffff);        /* mov word [es:bx+0x12a], 0xffff */
            ii(0x19_9e2c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9e2e, 2); jmp(0x19_9e5c, 0x2c); goto l_0x19_9e5c;   /* jmp 0x9e5c */
        l_0x19_9e30:
            ii(0x19_9e30, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_9e33, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_9e36, 2); push(-0x6 /* 0xfa */);                    /* push 0xfffa */
            ii(0x19_9e38, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_9e3b, 1); push(ss);                                 /* push ss */
            ii(0x19_9e3c, 1); push(ax);                                 /* push ax */
            ii(0x19_9e3d, 3); call(0x19_c5ce, 0x278e);                  /* call 0xc5ce */
            ii(0x19_9e40, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_9e42, 3); mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x19_9e45, 3); mov(dx, memw[ss, bp + 0x6]);              /* mov dx, [bp+0x6] */
            ii(0x19_9e48, 3); add(ax, 0x12a);                           /* add ax, 0x12a */
            ii(0x19_9e4b, 1); push(dx);                                 /* push dx */
            ii(0x19_9e4c, 1); push(ax);                                 /* push ax */
            ii(0x19_9e4d, 3); lea(ax, bp - 0x80);                       /* lea ax, [bp-0x80] */
            ii(0x19_9e50, 1); push(ss);                                 /* push ss */
            ii(0x19_9e51, 1); push(ax);                                 /* push ax */
            ii(0x19_9e52, 3); call(0x19_9bb6, -0x29f);                  /* call 0x9bb6 */
            ii(0x19_9e55, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x19_9e58, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_9e5a, 2); neg(ax);                                  /* neg ax */
        l_0x19_9e5c:
            ii(0x19_9e5c, 1); leave();                                  /* leave */
            ii(0x19_9e5d, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
