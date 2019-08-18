using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7857bb69-87c9-40f4-af8c-e7ba0eb240d9")]
        public void Method_0000_8d9d()
        {
            ii(0x8d9d, 4);    enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x8da1, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0x8da3, 3);    lea(ax, bp + 0x4);                        /* lea ax, [bp+0x4] */
            ii(0x8da6, 1);    pushw(ax);                                /* push ax */
            ii(0x8da7, 3);    callw(0x9f4a, 0x11a0);                    /* call 0x9f4a */
            ii(0x8daa, 3);    cmp(dx, 0x10);                            /* cmp dx, 0x10 */
            ii(0x8dad, 2);    if(jgw(0x8db1, 0x2)) goto l_0x8db1;       /* jg 0x8db1 */
            ii(0x8daf, 2);    if(jlw(0x8dea, 0x39)) goto l_0x8dea;      /* jl 0x8dea */
        l_0x8db1:
            ii(0x8db1, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0x8db3, 3);    pushw(0xf08);                             /* push 0xf08 */
            ii(0x8db6, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x8db9, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x8dbc, 3);    callw(0x4fc2, -0x3dfd);                   /* call 0x4fc2 */
            ii(0x8dbf, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8dc2, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0x8dc4, 3);    lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x8dc7, 1);    pushw(ax);                                /* push ax */
            ii(0x8dc8, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x8dcb, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x8dce, 3);    callw(0x4f8d, -0x3e44);                   /* call 0x4f8d */
            ii(0x8dd1, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x8dd4, 3);    mov(ax, memw_a16[ds, 0xf08]);             /* mov ax, [0xf08] */
            ii(0x8dd7, 4);    mov(dx, memw_a16[ds, 0xf0a]);             /* mov dx, [0xf0a] */
            ii(0x8ddb, 3);    cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0x8dde, 2);    if(jnzw(0x8dea, 0xa)) goto l_0x8dea;      /* jnz 0x8dea */
            ii(0x8de0, 3);    cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0x8de3, 2);    if(jnzw(0x8dea, 0x5)) goto l_0x8dea;      /* jnz 0x8dea */
            ii(0x8de5, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x8de8, 1);    leavew();                                 /* leave */
            ii(0x8de9, 1);    retw(); return;                           /* ret */
        l_0x8dea:
            ii(0x8dea, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8dec, 1);    leavew();                                 /* leave */
            ii(0x8ded, 1);    retw(); return;                           /* ret */
        }
    }
}
