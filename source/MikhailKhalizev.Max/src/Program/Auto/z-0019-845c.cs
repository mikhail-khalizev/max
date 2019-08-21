using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_845c-3a1f49ab")]
        public void Method_0019_845c()
        {
            ii(0x19_845c, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_8460, 1); pushw(di);                                /* push di */
            ii(0x19_8461, 1); pushw(si);                                /* push si */
            ii(0x19_8462, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x19_8464, 1); pushw(ds);                                /* push ds */
            ii(0x19_8465, 3); pushw(0x48a6);                            /* push 0x48a6 */
            ii(0x19_8468, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_846b, 4); pushw(memw_a16[es, bx + 0x36]);           /* push word [es:bx+0x36] */
            ii(0x19_846f, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_8472, 4); pushw(memw_a16[es, bx + 0x34]);           /* push word [es:bx+0x34] */
            ii(0x19_8476, 4); pushw(memw_a16[es, bx + 0x32]);           /* push word [es:bx+0x32] */
            ii(0x19_847a, 5); callw_far_abs(0x80, 0x1534);              /* call word 0x80:0x1534 */
            ii(0x19_847f, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_8482, 1); pushw(ds);                                /* push ds */
            ii(0x19_8483, 3); pushw(0x1733);                            /* push 0x1733 */
            ii(0x19_8486, 3); callw(0x19_105e, -0x742b);                /* call 0x105e */
            ii(0x19_8489, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_848c, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
            ii(0x19_8491, 3); jmpw(0x19_8497, 0x3); goto l_0x19_8497;   /* jmp 0x8497 */
        l_0x19_8494:
            ii(0x19_8494, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_8497:
            ii(0x19_8497, 4); cmp(memw_a16[ss, bp - 0x2], 0x10);        /* cmp word [bp-0x2], 0x10 */
            ii(0x19_849b, 2); if(jlw(0x19_84a0, 0x3)) goto l_0x19_84a0; /* jl 0x84a0 */
            ii(0x19_849d, 3); jmpw(0x19_84b7, 0x17); goto l_0x19_84b7;  /* jmp 0x84b7 */
        l_0x19_84a0:
            ii(0x19_84a0, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x19_84a3, 4); mov(al, memb_a16[ds, bx + 0x48a6]);       /* mov al, [bx+0x48a6] */
            ii(0x19_84a7, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x19_84a9, 1); pushw(ax);                                /* push ax */
            ii(0x19_84aa, 1); pushw(ds);                                /* push ds */
            ii(0x19_84ab, 3); pushw(0x1742);                            /* push 0x1742 */
            ii(0x19_84ae, 3); callw(0x19_105e, -0x7453);                /* call 0x105e */
            ii(0x19_84b1, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_84b4, 3); jmpw(0x19_8494, -0x23); goto l_0x19_8494; /* jmp 0x8494 */
        l_0x19_84b7:
            ii(0x19_84b7, 1); pushw(ds);                                /* push ds */
            ii(0x19_84b8, 3); pushw(0x1748);                            /* push 0x1748 */
            ii(0x19_84bb, 3); callw(0x19_105e, -0x7460);                /* call 0x105e */
            ii(0x19_84be, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_84c1, 1); popw(si);                                 /* pop si */
            ii(0x19_84c2, 1); popw(di);                                 /* pop di */
            ii(0x19_84c3, 1); leavew();                                 /* leave */
            ii(0x19_84c4, 1); retfw(); return;                          /* retf */
        }
    }
}
