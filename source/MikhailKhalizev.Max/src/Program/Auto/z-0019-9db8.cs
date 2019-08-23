using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9db8-13c80dd1")]
        public void Method_0019_9db8()
        {
            ii(0x19_9db8, 1); push(ds);                                 /* push ds */
            ii(0x19_9db9, 3); push(0x1f88);                             /* push 0x1f88 */
            ii(0x19_9dbc, 3); push(0x1364);                             /* push 0x1364 */
            ii(0x19_9dbf, 3); call(0x19_9c30, -0x192);                  /* call 0x9c30 */
            ii(0x19_9dc2, 3); mov(memw[ds, 0x1f1a], ax);                /* mov [0x1f1a], ax */
            ii(0x19_9dc5, 4); mov(memw[ds, 0x1f1c], dx);                /* mov [0x1f1c], dx */
            ii(0x19_9dc9, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9dcb, 4); or(ax, memw[ds, 0x1f1a]);                 /* or ax, [0x1f1a] */
            ii(0x19_9dcf, 2); if(jnz(0x19_9dd4, 0x3)) goto l_0x19_9dd4; /* jnz 0x9dd4 */
            ii(0x19_9dd1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9dd3, 1); ret(); return;                            /* ret */
        l_0x19_9dd4:
            ii(0x19_9dd4, 4); les(bx, memw[ds, 0x1f1a]);                /* les bx, [0x1f1a] */
            ii(0x19_9dd8, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x19_9ddc, 2); if(jnz(0x19_9e02, 0x24)) goto l_0x19_9e02; /* jnz 0x9e02 */
            ii(0x19_9dde, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9de0, 3); push(0x1364);                             /* push 0x1364 */
            ii(0x19_9de3, 1); push(es);                                 /* push es */
            ii(0x19_9de4, 1); push(bx);                                 /* push bx */
            ii(0x19_9de5, 1); nop();                                    /* nop */
            ii(0x19_9de6, 1); push(cs);                                 /* push cs */
            ii(0x19_9de7, 3); call(0x1a_0faf, 0x71c5);                  /* call 0xfaf */
            ii(0x19_9dea, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_9ded, 3); push(0xff);                               /* push 0xff */
            ii(0x19_9df0, 2); push(0x10);                               /* push 0x10 */
            ii(0x19_9df2, 4); push(memw[ds, 0x1f1c]);                   /* push word [0x1f1c] */
            ii(0x19_9df6, 4); push(memw[ds, 0x1f1a]);                   /* push word [0x1f1a] */
            ii(0x19_9dfa, 1); nop();                                    /* nop */
            ii(0x19_9dfb, 1); push(cs);                                 /* push cs */
            ii(0x19_9dfc, 3); call(0x1a_0faf, 0x71b0);                  /* call 0xfaf */
            ii(0x19_9dff, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x19_9e02:
            ii(0x19_9e02, 4); les(bx, memw[ds, 0x1f1a]);                /* les bx, [0x1f1a] */
            ii(0x19_9e06, 4); inc(memw[es, bx + 0x10]);                 /* inc word [es:bx+0x10] */
            ii(0x19_9e0a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_9e0d, 1); ret();                                    /* ret */
        }
    }
}
