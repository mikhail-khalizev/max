using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9ee2f1a4-0f6c-4724-91c3-0dc73f0e2e43")]
        public void Method_0015_16d4()
        {
            ii(0x15_16d4, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_16d8, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x15_16db, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_16de, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x15_16e1, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x15_16e4, 1); pushw(ss);                                /* push ss */
            ii(0x15_16e5, 1); pushw(ax);                                /* push ax */
            ii(0x15_16e6, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_16e9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_16ec, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_16ee, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_16f0, 4); pushw(memw_a16[ds, 0x38c6]);              /* push word [0x38c6] */
            ii(0x15_16f4, 4); pushw(memw_a16[ds, 0x38c4]);              /* push word [0x38c4] */
            ii(0x15_16f8, 1); pushw(cs);                                /* push cs */
            ii(0x15_16f9, 3); callw(0x15_15d2, -0x12a);                 /* call 0x15d2 */
            ii(0x15_16fc, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_16ff, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_1701, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_1704, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_1707, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_170a, 1); leavew();                                 /* leave */
            ii(0x15_170b, 1); retfw(); return;                          /* retf */
        }
    }
}