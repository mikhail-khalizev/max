using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fbdb-2988579c")]
        public void Method_0019_fbdb()
        {
            ii(0x19_fbdb, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x19_fbdf, 1); push(ds);                                 /* push ds */
            ii(0x19_fbe0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fbe3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fbe5, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_fbe8, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_fbeb, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_fbf0, 1); pop(bx);                                  /* pop bx */
            ii(0x19_fbf1, 1); pop(bx);                                  /* pop bx */
            ii(0x19_fbf2, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_fbf5, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x19_fbf8, 1); push(dx);                                 /* push dx */
            ii(0x19_fbf9, 1); push(ax);                                 /* push ax */
            ii(0x19_fbfa, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_fbfd, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_fc00, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_fc05, 1); pop(bx);                                  /* pop bx */
            ii(0x19_fc06, 1); pop(bx);                                  /* pop bx */
            ii(0x19_fc07, 3); sub(ax, memw[ss, bp - 4]);                /* sub ax, [bp-0x4] */
            ii(0x19_fc0a, 3); sbb(dx, memw[ss, bp - 2]);                /* sbb dx, [bp-0x2] */
            ii(0x19_fc0d, 1); push(dx);                                 /* push dx */
            ii(0x19_fc0e, 1); push(ax);                                 /* push ax */
            ii(0x19_fc0f, 3); call(0x19_fb9f, -0x73);                   /* call 0xfb9f */
            ii(0x19_fc12, 1); pop(ds);                                  /* pop ds */
            ii(0x19_fc13, 1); leave();                                  /* leave */
            ii(0x19_fc14, 3); ret(8);                                   /* ret 0x8 */
        }
    }
}
