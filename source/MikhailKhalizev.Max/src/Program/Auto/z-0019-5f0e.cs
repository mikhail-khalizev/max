using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5f0e-3b458d5a")]
        public void Method_0019_5f0e()
        {
            ii(0x19_5f0e, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
            ii(0x19_5f11, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f14, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f17, 4); mov(ax, memw_a16[ds, bx + 0x11f2]);       /* mov ax, [bx+0x11f2] */
            ii(0x19_5f1b, 4); or(ax, memw_a16[ds, bx + 0x11f0]);        /* or ax, [bx+0x11f0] */
            ii(0x19_5f1f, 2); if(jnzw(0x19_5f24, 0x3)) goto l_0x19_5f24; /* jnz 0x5f24 */
            ii(0x19_5f21, 3); if(jmpw_func(0x19_5f69, 0x45)) return;    /* jmp 0x5f69 */
        l_0x19_5f24:
            ii(0x19_5f24, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f27, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f2a, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x19_5f2e, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x19_5f32, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f33, 3); pushw(0x11b0);                            /* push 0x11b0 */
            ii(0x19_5f36, 3); callw(0x18_fcad, -0x628c);                /* call 0xfcad */
            ii(0x19_5f39, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_5f3c, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_5f3f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5f41, 2); if(jnzw(0x19_5f46, 0x3)) goto l_0x19_5f46; /* jnz 0x5f46 */
            ii(0x19_5f43, 3); if(jmpw_func(0x19_5f66, 0x20)) return;    /* jmp 0x5f66 */
        l_0x19_5f46:
            ii(0x19_5f46, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x19_5f49, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_5f4c, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x19_5f50, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x19_5f54, 1); pushw(ds);                                /* push ds */
            ii(0x19_5f55, 3); pushw(0x11b7);                            /* push 0x11b7 */
            ii(0x19_5f58, 3); callw(0x19_1066, -0x4ef5);                /* call 0x1066 */
            ii(0x19_5f5b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5f5e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_5f60, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
        }
    }
}
