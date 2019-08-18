using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("50c839a7-e9f3-4aea-b34b-b305c5c6034c")]
        public void Method_0019_d099()
        {
            ii(0x19_d099, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_d09d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_d0a0, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_d0a3, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_d0a6, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_d0a9, 3); callw(0x19_a14c, -0x2f60);                /* call 0xa14c */
            ii(0x19_d0ac, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_d0ae, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_d0b0, 3); mov(memw_a16[ss, bp - 0x4], bx);          /* mov [bp-0x4], bx */
            ii(0x19_d0b3, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x19_d0b6, 4); pushw(memw_a16[es, bx + 0x22]);           /* push word [es:bx+0x22] */
            ii(0x19_d0ba, 4); pushw(memw_a16[es, bx + 0x20]);           /* push word [es:bx+0x20] */
            ii(0x19_d0be, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d0c1, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d0c4, 3); callw(0x19_d013, -0xb4);                  /* call 0xd013 */
            ii(0x19_d0c7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d0c9, 2); if(jnzw(0x19_d0e8, 0x1d)) goto l_0x19_d0e8; /* jnz 0xd0e8 */
            ii(0x19_d0cb, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_d0ce, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_d0d1, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_d0d4, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_d0d7, 4); pushw(memw_a16[es, bx + 0x26]);           /* push word [es:bx+0x26] */
            ii(0x19_d0db, 4); pushw(memw_a16[es, bx + 0x24]);           /* push word [es:bx+0x24] */
            ii(0x19_d0df, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_d0e2, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_d0e5, 3); callw(0x19_d013, -0xd5);                  /* call 0xd013 */
        l_0x19_d0e8:
            ii(0x19_d0e8, 1); leavew();                                 /* leave */
            ii(0x19_d0e9, 3); retw(0xa); return;                        /* ret 0xa */
        }
    }
}
