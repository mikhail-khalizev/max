using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ed1a-4b150229")]
        public void Method_0017_ed1a()
        {
            ii(0x17_ed1a, 1); push(bp);                                 /* push bp */
            ii(0x17_ed1b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_ed1d, 1); push(ds);                                 /* push ds */
            ii(0x17_ed1e, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ed21, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ed23, 4); mov(es, memw[ds, 0x1dce]);                /* mov es, [0x1dce] */
            ii(0x17_ed27, 4); mov(ax, memw[es, 0x1418]);                /* mov ax, [es:0x1418] */
            ii(0x17_ed2b, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x17_ed2d, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_ed2f, 4); mov(ax, memw[es, bx + 66]);               /* mov ax, [es:bx+0x42] */
            ii(0x17_ed33, 4); mov(dx, memw[es, bx + 68]);               /* mov dx, [es:bx+0x44] */
            ii(0x17_ed37, 3); les(bx, memw[ss, bp + 6]);                /* les bx, [bp+0x6] */
            ii(0x17_ed3a, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x17_ed3d, 4); mov(memw[es, bx + 2], dx);                /* mov [es:bx+0x2], dx */
            ii(0x17_ed41, 4); mov(es, memw[ds, 0x1dce]);                /* mov es, [0x1dce] */
            ii(0x17_ed45, 4); mov(ax, memw[es, 0x1418]);                /* mov ax, [es:0x1418] */
            ii(0x17_ed49, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x17_ed4b, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x17_ed4d, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_ed50, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_ed53, 4); mov(memw[es, bx + 66], ax);               /* mov [es:bx+0x42], ax */
            ii(0x17_ed57, 4); mov(memw[es, bx + 68], dx);               /* mov [es:bx+0x44], dx */
            ii(0x17_ed5b, 1); pop(ds);                                  /* pop ds */
            ii(0x17_ed5c, 1); leave();                                  /* leave */
            ii(0x17_ed5d, 1); retf();                                   /* retf */
        }
    }
}
