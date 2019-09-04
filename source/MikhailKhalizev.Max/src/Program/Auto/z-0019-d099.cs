using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d099-69f3bb02")]
        public void Method_0019_d099()
        {
            ii(0x19_d099, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_d09d, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_d0a0, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_d0a3, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_d0a6, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_d0a9, 3); call(0x19_a14c, -0x2f60);                 /* call 0xa14c */
            ii(0x19_d0ac, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_d0ae, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_d0b0, 3); mov(memw[ss, bp - 4], bx);                /* mov [bp-0x4], bx */
            ii(0x19_d0b3, 3); mov(memw[ss, bp - 2], es);                /* mov [bp-0x2], es */
            ii(0x19_d0b6, 4); push(memw[es, bx + 34]);                  /* push word [es:bx+0x22] */
            ii(0x19_d0ba, 4); push(memw[es, bx + 32]);                  /* push word [es:bx+0x20] */
            ii(0x19_d0be, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_d0c1, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_d0c4, 3); call(0x19_d013, -0xb4);                   /* call 0xd013 */
            ii(0x19_d0c7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d0c9, 2); if(jnz(0x19_d0e8, 0x1d)) goto l_0x19_d0e8; /* jnz 0xd0e8 */
            ii(0x19_d0cb, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_d0ce, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_d0d1, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_d0d4, 3); les(bx, memw[ss, bp - 4]);                /* les bx, [bp-0x4] */
            ii(0x19_d0d7, 4); push(memw[es, bx + 38]);                  /* push word [es:bx+0x26] */
            ii(0x19_d0db, 4); push(memw[es, bx + 36]);                  /* push word [es:bx+0x24] */
            ii(0x19_d0df, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_d0e2, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_d0e5, 3); call(0x19_d013, -0xd5);                   /* call 0xd013 */
        l_0x19_d0e8:
            ii(0x19_d0e8, 1); leave();                                  /* leave */
            ii(0x19_d0e9, 3); ret(0xa);                                 /* ret 0xa */
        }
    }
}
