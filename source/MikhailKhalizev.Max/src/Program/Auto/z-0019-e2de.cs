using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e2de-e0b753b4")]
        public void Method_0019_e2de()
        {
            ii(0x19_e2de, 4); enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x19_e2e2, 1); pushw(ds);                                /* push ds */
            ii(0x19_e2e3, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_e2e6, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_e2e8, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x19_e2eb, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x19_e2ee, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_e2f1, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_e2f4, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x19_e2f6, 1); pushw(ax);                                /* push ax */
            ii(0x19_e2f7, 1); pushw(dx);                                /* push dx */
            ii(0x19_e2f8, 2); pushw(0x18);                              /* push 0x18 */
            ii(0x19_e2fa, 4); mov(es, memw_a16[ds, 0x3fc8]);            /* mov es, [0x3fc8] */
            ii(0x19_e2fe, 5); pushw(memw_a16[es, 0x3b7a]);              /* push word [es:0x3b7a] */
            ii(0x19_e303, 5); callw_far_abs(0x80, 0x3efa);              /* call word 0x80:0x3efa */
            ii(0x19_e308, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_e30b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_e30d, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x19_e310, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_e313, 5); mov(memw_a16[ss, bp - 0x12], 0x5100);     /* mov word [bp-0x12], 0x5100 */
            ii(0x19_e318, 3); lea(ax, bp - 0x1a);                       /* lea ax, [bp-0x1a] */
            ii(0x19_e31b, 1); pushw(ss);                                /* push ss */
            ii(0x19_e31c, 1); pushw(ax);                                /* push ax */
            ii(0x19_e31d, 3); lea(ax, bp - 0x12);                       /* lea ax, [bp-0x12] */
            ii(0x19_e320, 1); pushw(ss);                                /* push ss */
            ii(0x19_e321, 1); pushw(ax);                                /* push ax */
            ii(0x19_e322, 1); pushw(ss);                                /* push ss */
            ii(0x19_e323, 1); pushw(ax);                                /* push ax */
            ii(0x19_e324, 4); callw_a16_far_ind(ds, 0x1a0c);            /* call far word [0x1a0c] */
            ii(0x19_e328, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_e32b, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x19_e32e, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_e331, 4); mov(memw_a16[es, bx + 0x20], ax);         /* mov [es:bx+0x20], ax */
            ii(0x19_e335, 1); popw(ds);                                 /* pop ds */
            ii(0x19_e336, 1); leavew();                                 /* leave */
            ii(0x19_e337, 3); retw(0x4);                                /* ret 0x4 */
        }
    }
}
