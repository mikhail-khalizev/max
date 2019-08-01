using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c53df2ae-b846-49ea-83f9-b045927cd6f5")]
        public void Method_0015_36a0()
        {
            ii(0x15_36a0, 1); pushw(bp);                                /* push bp */
            ii(0x15_36a1, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_36a3, 1); pushw(ds);                                /* push ds */
            ii(0x15_36a4, 1); pushw(bx);                                /* push bx */
            ii(0x15_36a5, 3); lds(bx, ss, bp + 0x6);                    /* lds bx, [bp+0x6] */
            ii(0x15_36a8, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_36ab, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_36ae, 3); pushw(memw_a16[ds, bx + 0x2]);            /* push word [bx+0x2] */
            ii(0x15_36b1, 2); pushw(memw_a16[ds, bx]);                  /* push word [bx] */
            ii(0x15_36b3, 1); pushw(cs);                                /* push cs */
            ii(0x15_36b4, 3); callw(0x15_36e2, 0x2b);                   /* call 0x36e2 */
            ii(0x15_36b7, 2); mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x15_36b9, 3); mov(memw_a16[ds, bx + 0x2], dx);          /* mov [bx+0x2], dx */
            ii(0x15_36bc, 1); popw(bx);                                 /* pop bx */
            ii(0x15_36bd, 1); popw(ds);                                 /* pop ds */
            ii(0x15_36be, 1); popw(bp);                                 /* pop bp */
            ii(0x15_36bf, 3); retfw(0x8); return;                       /* retf 0x8 */
        }
    }
}
