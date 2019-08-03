using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d6d2d246-333b-4212-bed7-3cd4fb1fc605")]
        public void Method_0015_fbdb()
        {
            ii(0x15_fbdb, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x15_fbdf, 1); pushw(ds);                                /* push ds */
            ii(0x15_fbe0, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fbe3, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fbe5, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_fbe8, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_fbeb, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_fbf0, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fbf1, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fbf2, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_fbf5, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_fbf8, 1); pushw(dx);                                /* push dx */
            ii(0x15_fbf9, 1); pushw(ax);                                /* push ax */
            ii(0x15_fbfa, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fbfd, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fc00, 5); callw_far_abs(0x80, 0x55dc);              /* call word 0x80:0x55dc */
            ii(0x15_fc05, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fc06, 1); popw(bx);                                 /* pop bx */
            ii(0x15_fc07, 3); sub(ax, memw_a16[ss, bp - 0x4]);          /* sub ax, [bp-0x4] */
            ii(0x15_fc0a, 3); sbb(dx, memw_a16[ss, bp - 0x2]);          /* sbb dx, [bp-0x2] */
            ii(0x15_fc0d, 1); pushw(dx);                                /* push dx */
            ii(0x15_fc0e, 1); pushw(ax);                                /* push ax */
            ii(0x15_fc0f, 3); callw(0x15_fb9f, -0x73);                  /* call 0xfb9f */
            ii(0x15_fc12, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fc13, 1); leavew();                                 /* leave */
            ii(0x15_fc14, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
