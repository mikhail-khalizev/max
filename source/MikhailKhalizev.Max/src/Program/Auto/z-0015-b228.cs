using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c8b288c-b788-447d-82fd-5197d19eb27f")]
        public void Method_0015_b228()
        {
            ii(0x15_b228, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_b22c, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_b22f, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_b232, 2); pushw(-0x2 /* 0xfe */);                   /* push 0xfffe */
            ii(0x15_b234, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_b236, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_b239, 4); pushw(memw_a16[es, bx + 0x60]);           /* push word [es:bx+0x60] */
            ii(0x15_b23d, 4); pushw(memw_a16[es, bx + 0x5e]);           /* push word [es:bx+0x5e] */
            ii(0x15_b241, 3); callw(0x15_c975, 0x1731);                 /* call 0xc975 */
            ii(0x15_b244, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_b247, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_b249, 2); if(jnzw(0x15_b250, 0x5)) goto l_0x15_b250; /* jnz 0xb250 */
        l_0x15_b24b:
            ii(0x15_b24b, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x15_b24e, 2); jmpw(0x15_b27e, 0x2e); goto l_0x15_b27e;  /* jmp 0xb27e */
        l_0x15_b250:
            ii(0x15_b250, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_b253, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_b256, 2); pushw(-0x7 /* 0xf9 */);                   /* push 0xfff9 */
            ii(0x15_b258, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_b25a, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b25c, 2); pushw(0x28);                              /* push 0x28 */
            ii(0x15_b25e, 3); callw(0x15_c975, 0x1714);                 /* call 0xc975 */
            ii(0x15_b261, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_b264, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_b266, 2); if(jzw(0x15_b24b, -0x1d)) goto l_0x15_b24b; /* jz 0xb24b */
            ii(0x15_b268, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_b26b, 1); pushw(ax);                                /* push ax */
            ii(0x15_b26c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b26e, 2); pushw(0x28);                              /* push 0x28 */
            ii(0x15_b270, 3); callw(0x15_fb9f, 0x492c);                 /* call 0xfb9f */
            ii(0x15_b273, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_b275, 2); if(jnzw(0x15_b27c, 0x5)) goto l_0x15_b27c; /* jnz 0xb27c */
            ii(0x15_b277, 3); mov(ax, 0x522);                           /* mov ax, 0x522 */
            ii(0x15_b27a, 2); jmpw(0x15_b27e, 0x2); goto l_0x15_b27e;   /* jmp 0xb27e */
        l_0x15_b27c:
            ii(0x15_b27c, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_b27e:
            ii(0x15_b27e, 1); leavew();                                 /* leave */
            ii(0x15_b27f, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}