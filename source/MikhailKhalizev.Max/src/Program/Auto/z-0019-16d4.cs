using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_16d4-ac03e134")]
        public void Method_0019_16d4()
        {
            ii(0x19_16d4, 4); enter(6, 0);                              /* enter 0x6, 0x0 */
            ii(0x19_16d8, 3); lea(ax, memw[ss, bp + 10]);               /* lea ax, [bp+0xa] */
            ii(0x19_16db, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_16de, 3); mov(memw[ss, bp - 4], ss);                /* mov [bp-0x4], ss */
            ii(0x19_16e1, 3); lea(ax, memw[ss, bp - 6]);                /* lea ax, [bp-0x6] */
            ii(0x19_16e4, 1); push(ss);                                 /* push ss */
            ii(0x19_16e5, 1); push(ax);                                 /* push ax */
            ii(0x19_16e6, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_16e9, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_16ec, 2); push(0);                                  /* push 0x0 */
            ii(0x19_16ee, 2); push(0);                                  /* push 0x0 */
            ii(0x19_16f0, 4); push(memw[ds, 0x38c6]);                   /* push word [0x38c6] */
            ii(0x19_16f4, 4); push(memw[ds, 0x38c4]);                   /* push word [0x38c4] */
            ii(0x19_16f8, 1); push(cs);                                 /* push cs */
            ii(0x19_16f9, 3); call(0x19_15d2, -0x12a);                  /* call 0x15d2 */
            ii(0x19_16fc, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_16ff, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_1701, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_1704, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_1707, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_170a, 1); leave();                                  /* leave */
            ii(0x19_170b, 1); retf();                                   /* retf */
        }
    }
}
