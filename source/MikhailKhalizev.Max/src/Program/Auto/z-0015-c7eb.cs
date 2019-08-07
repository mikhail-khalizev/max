using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8f72f3d4-355b-4fe0-a3b5-1f163abae8f4")]
        public void Method_0015_c7eb()
        {
            ii(0x15_c7eb, 4); enterw(0x2e, 0);                          /* enter 0x2e, 0x0 */
            ii(0x15_c7ef, 1); pushw(di);                                /* push di */
            ii(0x15_c7f0, 1); pushw(si);                                /* push si */
            ii(0x15_c7f1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_c7f3, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x15_c7f6, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_c7f9, 4); mov(es, memw_a16[ds, 0x3fc2]);            /* mov es, [0x3fc2] */
            ii(0x15_c7fd, 4); mov(ax, memw_a16[es, 0x3b84]);            /* mov ax, [es:0x3b84] */
            ii(0x15_c801, 5); mov(memw_a16[ss, bp - 0x1e], 0);          /* mov word [bp-0x1e], 0x0 */
            ii(0x15_c806, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_c809, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x15_c80b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_c80e, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_c811, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_c814, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x15_c816, 1); pushw(dx);                                /* push dx */
            ii(0x15_c817, 1); pushw(ax);                                /* push ax */
            ii(0x15_c818, 3); lea(cx, bp - 0x22);                       /* lea cx, [bp-0x22] */
            ii(0x15_c81b, 1); pushw(ss);                                /* push ss */
            ii(0x15_c81c, 1); pushw(cx);                                /* push cx */
            ii(0x15_c81d, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_c81f, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_c821, 3); callw(0x15_c684, -0x1a0);                 /* call 0xc684 */
            ii(0x15_c824, 3); mov(memw_a16[ss, bp - 0x26], ax);         /* mov [bp-0x26], ax */
            ii(0x15_c827, 3); mov(memw_a16[ss, bp - 0x24], dx);         /* mov [bp-0x24], dx */
            ii(0x15_c82a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_c82c, 2); if(jzw(0x15_c854, 0x26)) goto l_0x15_c854; /* jz 0xc854 */
            ii(0x15_c82e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c830, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_c832, 3); pushw(memw_a16[ss, bp - 0x24]);           /* push word [bp-0x24] */
            ii(0x15_c835, 1); pushw(ax);                                /* push ax */
            ii(0x15_c836, 1); pushw(di);                                /* push di */
            ii(0x15_c837, 1); pushw(si);                                /* push si */
            ii(0x15_c838, 3); callw(0x15_de46, 0x160b);                 /* call 0xde46 */
            ii(0x15_c83b, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_c83e, 3); mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x15_c841, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_c843, 3); or(ax, memw_a16[ss, bp - 0x1a]);          /* or ax, [bp-0x1a] */
            ii(0x15_c846, 2); if(jzw(0x15_c854, 0xc)) goto l_0x15_c854; /* jz 0xc854 */
            ii(0x15_c848, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x15_c84a, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x15_c84d, 3); les(si, ss, bp - 0x1e);                   /* les si, [bp-0x1e] */
            ii(0x15_c850, 4); or(memb_a16[es, bx + si], 0x1);           /* or byte [es:bx+si], 0x1 */
        l_0x15_c854:
            ii(0x15_c854, 3); mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x15_c857, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x15_c85a, 1); popw(si);                                 /* pop si */
            ii(0x15_c85b, 1); popw(di);                                 /* pop di */
            ii(0x15_c85c, 1); leavew();                                 /* leave */
            ii(0x15_c85d, 3); retw(0x6); return;                        /* ret 0x6 */
        }
    }
}
