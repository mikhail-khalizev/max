using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9db8-13c80dd1")]
        public void Method_0019_9db8()
        {
            ii(0x19_9db8, 1); pushw(ds);                                /* push ds */
            ii(0x19_9db9, 3); pushw(0x1f88);                            /* push 0x1f88 */
            ii(0x19_9dbc, 3); pushw(0x1364);                            /* push 0x1364 */
            ii(0x19_9dbf, 3); callw(0x19_9c30, -0x192);                 /* call 0x9c30 */
            ii(0x19_9dc2, 3); mov(memw_a16[ds, 0x1f1a], ax);            /* mov [0x1f1a], ax */
            ii(0x19_9dc5, 4); mov(memw_a16[ds, 0x1f1c], dx);            /* mov [0x1f1c], dx */
            ii(0x19_9dc9, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_9dcb, 4); or(ax, memw_a16[ds, 0x1f1a]);             /* or ax, [0x1f1a] */
            ii(0x19_9dcf, 2); if(jnzw(0x19_9dd4, 0x3)) goto l_0x19_9dd4; /* jnz 0x9dd4 */
            ii(0x19_9dd1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9dd3, 1); retw(); return;                           /* ret */
        l_0x19_9dd4:
            ii(0x19_9dd4, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_9dd8, 4); cmp(memb_a16[es, bx], 0);                 /* cmp byte [es:bx], 0x0 */
            ii(0x19_9ddc, 2); if(jnzw(0x19_9e02, 0x24)) goto l_0x19_9e02; /* jnz 0x9e02 */
            ii(0x19_9dde, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_9de0, 3); pushw(0x1364);                            /* push 0x1364 */
            ii(0x19_9de3, 1); pushw(es);                                /* push es */
            ii(0x19_9de4, 1); pushw(bx);                                /* push bx */
            ii(0x19_9de5, 1); nop();                                    /* nop */
            ii(0x19_9de6, 1); pushw(cs);                                /* push cs */
            ii(0x19_9de7, 3); callw(0x1a_0faf, 0x71c5);                 /* call 0xfaf */
            ii(0x19_9dea, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_9ded, 3); pushw(0xff);                              /* push 0xff */
            ii(0x19_9df0, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x19_9df2, 4); pushw(memw_a16[ds, 0x1f1c]);              /* push word [0x1f1c] */
            ii(0x19_9df6, 4); pushw(memw_a16[ds, 0x1f1a]);              /* push word [0x1f1a] */
            ii(0x19_9dfa, 1); nop();                                    /* nop */
            ii(0x19_9dfb, 1); pushw(cs);                                /* push cs */
            ii(0x19_9dfc, 3); callw(0x1a_0faf, 0x71b0);                 /* call 0xfaf */
            ii(0x19_9dff, 3); add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x19_9e02:
            ii(0x19_9e02, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_9e06, 4); inc(memw_a16[es, bx + 0x10]);             /* inc word [es:bx+0x10] */
            ii(0x19_9e0a, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_9e0d, 1); retw(); return;                           /* ret */
        }
    }
}
