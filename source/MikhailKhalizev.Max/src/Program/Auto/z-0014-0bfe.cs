using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d51f4557-1575-4acb-b7f0-a9ddeb20490f")]
        public void Method_0014_0bfe()
        {
            ii(0x14_0bfe, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x14_0c02, 1); pushw(ds);                                /* push ds */
            ii(0x14_0c03, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0c06, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0c08, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x14_0c0b, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x14_0c0e, 1); nop();                                    /* nop */
            ii(0x14_0c0f, 1); pushw(cs);                                /* push cs */
            ii(0x14_0c10, 3); callw(0x13_e91a, -0x22f9);                /* call 0xe91a */
            ii(0x14_0c13, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0c14, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0c15, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x14_0c18, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x14_0c1b, 1); pushw(dx);                                /* push dx */
            ii(0x14_0c1c, 1); pushw(ax);                                /* push ax */
            ii(0x14_0c1d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x14_0c20, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x14_0c23, 1); nop();                                    /* nop */
            ii(0x14_0c24, 1); pushw(cs);                                /* push cs */
            ii(0x14_0c25, 3); callw(0x13_e91a, -0x230e);                /* call 0xe91a */
            ii(0x14_0c28, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0c29, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0c2a, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x14_0c2d, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x14_0c30, 1); pushw(dx);                                /* push dx */
            ii(0x14_0c31, 1); pushw(ax);                                /* push ax */
            ii(0x14_0c32, 3); callw(0x14_0bc2, -0x73);                  /* call 0xbc2 */
            ii(0x14_0c35, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0c36, 1); leavew();                                 /* leave */
            ii(0x14_0c37, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
