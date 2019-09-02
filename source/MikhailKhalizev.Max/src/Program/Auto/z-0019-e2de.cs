using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_e2de-e0b753b4")]
        public void Method_0019_e2de()
        {
            ii(0x19_e2de, 4); enter(0x1a, 0);                           /* enter 0x1a, 0x0 */
            ii(0x19_e2e2, 1); push(ds);                                 /* push ds */
            ii(0x19_e2e3, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_e2e6, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_e2e8, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_e2eb, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x19_e2ee, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_e2f1, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_e2f4, 2); push(0x20);                               /* push 0x20 */
            ii(0x19_e2f6, 1); push(ax);                                 /* push ax */
            ii(0x19_e2f7, 1); push(dx);                                 /* push dx */
            ii(0x19_e2f8, 2); push(0x18);                               /* push 0x18 */
            ii(0x19_e2fa, 4); mov(es, memw[ds, 0x3fc8]);                /* mov es, [0x3fc8] */
            ii(0x19_e2fe, 5); push(memw[es, 0x3b7a]);                   /* push word [es:0x3b7a] */
            ii(0x19_e303, 5); call_far_abs(0x80, 0x3efa);               /* call word 0x80:0x3efa */
            ii(0x19_e308, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_e30b, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_e30d, 3); mov(memw[ss, bp - 20], ax);               /* mov [bp-0x14], ax */
            ii(0x19_e310, 3); mov(memw[ss, bp - 26], ax);               /* mov [bp-0x1a], ax */
            ii(0x19_e313, 5); mov(memw[ss, bp - 18], 0x5100);           /* mov word [bp-0x12], 0x5100 */
            ii(0x19_e318, 3); lea(ax, memw[ss, bp - 26]);               /* lea ax, [bp-0x1a] */
            ii(0x19_e31b, 1); push(ss);                                 /* push ss */
            ii(0x19_e31c, 1); push(ax);                                 /* push ax */
            ii(0x19_e31d, 3); lea(ax, memw[ss, bp - 18]);               /* lea ax, [bp-0x12] */
            ii(0x19_e320, 1); push(ss);                                 /* push ss */
            ii(0x19_e321, 1); push(ax);                                 /* push ax */
            ii(0x19_e322, 1); push(ss);                                 /* push ss */
            ii(0x19_e323, 1); push(ax);                                 /* push ax */
            ii(0x19_e324, 4); call_far_ind(memw[ds, 0x1a0c]);           /* call far word [0x1a0c] */
            ii(0x19_e328, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_e32b, 3); mov(ax, memw[ss, bp - 16]);               /* mov ax, [bp-0x10] */
            ii(0x19_e32e, 3); les(bx, memw[ss, bp + 4]);                /* les bx, [bp+0x4] */
            ii(0x19_e331, 4); mov(memw[es, bx + 32], ax);               /* mov [es:bx+0x20], ax */
            ii(0x19_e335, 1); pop(ds);                                  /* pop ds */
            ii(0x19_e336, 1); leave();                                  /* leave */
            ii(0x19_e337, 3); ret(4);                                   /* ret 0x4 */
        }
    }
}
