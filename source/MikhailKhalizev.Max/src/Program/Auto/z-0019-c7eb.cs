using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c7eb-946273ba")]
        public void Method_0019_c7eb()
        {
            ii(0x19_c7eb, 4); enter(0x2e, 0);                           /* enter 0x2e, 0x0 */
            ii(0x19_c7ef, 1); push(di);                                 /* push di */
            ii(0x19_c7f0, 1); push(si);                                 /* push si */
            ii(0x19_c7f1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c7f3, 3); mov(memw[ss, bp - 24], ax);               /* mov [bp-0x18], ax */
            ii(0x19_c7f6, 3); mov(memw[ss, bp - 26], ax);               /* mov [bp-0x1a], ax */
            ii(0x19_c7f9, 4); mov(es, memw[ds, 0x3fc2]);                /* mov es, [0x3fc2] */
            ii(0x19_c7fd, 4); mov(ax, memw[es, 0x3b84]);                /* mov ax, [es:0x3b84] */
            ii(0x19_c801, 5); mov(memw[ss, bp - 30], 0);                /* mov word [bp-0x1e], 0x0 */
            ii(0x19_c806, 3); mov(memw[ss, bp - 28], ax);               /* mov [bp-0x1c], ax */
            ii(0x19_c809, 2); push(2);                                  /* push 0x2 */
            ii(0x19_c80b, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_c80e, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_c811, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_c814, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_c816, 1); push(dx);                                 /* push dx */
            ii(0x19_c817, 1); push(ax);                                 /* push ax */
            ii(0x19_c818, 3); lea(cx, memw[ss, bp - 34]);               /* lea cx, [bp-0x22] */
            ii(0x19_c81b, 1); push(ss);                                 /* push ss */
            ii(0x19_c81c, 1); push(cx);                                 /* push cx */
            ii(0x19_c81d, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_c81f, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_c821, 3); call(0x19_c684, -0x1a0);                  /* call 0xc684 */
            ii(0x19_c824, 3); mov(memw[ss, bp - 38], ax);               /* mov [bp-0x26], ax */
            ii(0x19_c827, 3); mov(memw[ss, bp - 36], dx);               /* mov [bp-0x24], dx */
            ii(0x19_c82a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_c82c, 2); if(jz(0x19_c854, 0x26)) goto l_0x19_c854; /* jz 0xc854 */
            ii(0x19_c82e, 2); push(0);                                  /* push 0x0 */
            ii(0x19_c830, 2); push(0);                                  /* push 0x0 */
            ii(0x19_c832, 3); push(memw[ss, bp - 36]);                  /* push word [bp-0x24] */
            ii(0x19_c835, 1); push(ax);                                 /* push ax */
            ii(0x19_c836, 1); push(di);                                 /* push di */
            ii(0x19_c837, 1); push(si);                                 /* push si */
            ii(0x19_c838, 3); call(0x19_de46, 0x160b);                  /* call 0xde46 */
            ii(0x19_c83b, 3); mov(memw[ss, bp - 26], ax);               /* mov [bp-0x1a], ax */
            ii(0x19_c83e, 3); mov(memw[ss, bp - 24], dx);               /* mov [bp-0x18], dx */
            ii(0x19_c841, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_c843, 3); or(ax, memw[ss, bp - 26]);                /* or ax, [bp-0x1a] */
            ii(0x19_c846, 2); if(jz(0x19_c854, 0xc)) goto l_0x19_c854;  /* jz 0xc854 */
            ii(0x19_c848, 2); mov(bx, dx);                              /* mov bx, dx */
            ii(0x19_c84a, 3); shr(bx, 3);                               /* shr bx, 0x3 */
            ii(0x19_c84d, 3); les(si, memw[ss, bp - 30]);               /* les si, [bp-0x1e] */
            ii(0x19_c850, 4); or(memb[es, bx + si], 1);                 /* or byte [es:bx+si], 0x1 */
        l_0x19_c854:
            ii(0x19_c854, 3); mov(ax, memw[ss, bp - 26]);               /* mov ax, [bp-0x1a] */
            ii(0x19_c857, 3); mov(dx, memw[ss, bp - 24]);               /* mov dx, [bp-0x18] */
            ii(0x19_c85a, 1); pop(si);                                  /* pop si */
            ii(0x19_c85b, 1); pop(di);                                  /* pop di */
            ii(0x19_c85c, 1); leave();                                  /* leave */
            ii(0x19_c85d, 3); ret(6);                                   /* ret 0x6 */
        }
    }
}
