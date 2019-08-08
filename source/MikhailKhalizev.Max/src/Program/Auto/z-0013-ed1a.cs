using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0be6a889-3f33-4a46-a5ba-10f6b669b655")]
        public void Method_0013_ed1a()
        {
            ii(0x13_ed1a, 1); pushw(bp);                                /* push bp */
            ii(0x13_ed1b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_ed1d, 1); pushw(ds);                                /* push ds */
            ii(0x13_ed1e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ed21, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ed23, 4); mov(es, memw_a16[ds, 0x1dce]);            /* mov es, [0x1dce] */
            ii(0x13_ed27, 4); mov(ax, memw_a16[es, 0x1418]);            /* mov ax, [es:0x1418] */
            ii(0x13_ed2b, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x13_ed2d, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_ed2f, 4); mov(ax, memw_a16[es, bx + 0x42]);         /* mov ax, [es:bx+0x42] */
            ii(0x13_ed33, 4); mov(dx, memw_a16[es, bx + 0x44]);         /* mov dx, [es:bx+0x44] */
            ii(0x13_ed37, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_ed3a, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_ed3d, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x13_ed41, 4); mov(es, memw_a16[ds, 0x1dce]);            /* mov es, [0x1dce] */
            ii(0x13_ed45, 4); mov(ax, memw_a16[es, 0x1418]);            /* mov ax, [es:0x1418] */
            ii(0x13_ed49, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x13_ed4b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x13_ed4d, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_ed50, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_ed53, 4); mov(memw_a16[es, bx + 0x42], ax);         /* mov [es:bx+0x42], ax */
            ii(0x13_ed57, 4); mov(memw_a16[es, bx + 0x44], dx);         /* mov [es:bx+0x44], dx */
            ii(0x13_ed5b, 1); popw(ds);                                 /* pop ds */
            ii(0x13_ed5c, 1); leavew();                                 /* leave */
            ii(0x13_ed5d, 1); retfw(); return;                          /* retf */
        }
    }
}