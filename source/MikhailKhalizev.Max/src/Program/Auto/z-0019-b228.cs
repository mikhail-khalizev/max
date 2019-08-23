using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_b228-88886ff9")]
        public void Method_0019_b228()
        {
            ii(0x19_b228, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_b22c, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_b22f, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_b232, 2); push(-0x2 /* 0xfe */);                    /* push 0xfffe */
            ii(0x19_b234, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b236, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_b239, 4); push(memw[es, bx + 0x60]);                /* push word [es:bx+0x60] */
            ii(0x19_b23d, 4); push(memw[es, bx + 0x5e]);                /* push word [es:bx+0x5e] */
            ii(0x19_b241, 3); call(0x19_c975, 0x1731);                  /* call 0xc975 */
            ii(0x19_b244, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_b247, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_b249, 2); if(jnz(0x19_b250, 0x5)) goto l_0x19_b250; /* jnz 0xb250 */
        l_0x19_b24b:
            ii(0x19_b24b, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x19_b24e, 2); jmp(0x19_b27e, 0x2e); goto l_0x19_b27e;   /* jmp 0xb27e */
        l_0x19_b250:
            ii(0x19_b250, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_b253, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_b256, 2); push(-0x7 /* 0xf9 */);                    /* push 0xfff9 */
            ii(0x19_b258, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_b25a, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b25c, 2); push(0x28);                               /* push 0x28 */
            ii(0x19_b25e, 3); call(0x19_c975, 0x1714);                  /* call 0xc975 */
            ii(0x19_b261, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_b264, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_b266, 2); if(jz(0x19_b24b, -0x1d)) goto l_0x19_b24b; /* jz 0xb24b */
            ii(0x19_b268, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_b26b, 1); push(ax);                                 /* push ax */
            ii(0x19_b26c, 2); push(0);                                  /* push 0x0 */
            ii(0x19_b26e, 2); push(0x28);                               /* push 0x28 */
            ii(0x19_b270, 3); call(0x19_fb9f, 0x492c);                  /* call 0xfb9f */
            ii(0x19_b273, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_b275, 2); if(jnz(0x19_b27c, 0x5)) goto l_0x19_b27c; /* jnz 0xb27c */
            ii(0x19_b277, 3); mov(ax, 0x522);                           /* mov ax, 0x522 */
            ii(0x19_b27a, 2); jmp(0x19_b27e, 0x2); goto l_0x19_b27e;    /* jmp 0xb27e */
        l_0x19_b27c:
            ii(0x19_b27c, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_b27e:
            ii(0x19_b27e, 1); leave();                                  /* leave */
            ii(0x19_b27f, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}
