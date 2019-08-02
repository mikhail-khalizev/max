using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("64b38caa-db8a-452d-b376-0f42ee108090")]
        public void Method_0013_8988()
        {
            ii(0x13_8988, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x13_898c, 1); pushw(ds);                                /* push ds */
            ii(0x13_898d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8990, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8992, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_8995, 4); mov(bx, memw_a16[ds, 0x4fba]);            /* mov bx, [0x4fba] */
            ii(0x13_8999, 3); mov(cx, 0x8);                             /* mov cx, 0x8 */
            ii(0x13_899c, 2); mov(es, cx);                              /* mov es, cx */
            ii(0x13_899e, 3); mov(memw_a16[ss, bp - 0x4], bx);          /* mov [bp-0x4], bx */
            ii(0x13_89a1, 3); mov(memw_a16[ss, bp - 0x2], es);          /* mov [bp-0x2], es */
            ii(0x13_89a4, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x13_89a8, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x13_89ab, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_89ae, 4); mov(memb_a16[es, bx + 0x4], al);          /* mov [es:bx+0x4], al */
            ii(0x13_89b2, 3); mov(al, memb_a16[ss, bp + 0x9]);          /* mov al, [bp+0x9] */
            ii(0x13_89b5, 4); mov(memb_a16[es, bx + 0x7], al);          /* mov [es:bx+0x7], al */
            ii(0x13_89b9, 1); popw(ds);                                 /* pop ds */
            ii(0x13_89ba, 1); leavew();                                 /* leave */
            ii(0x13_89bb, 1); retfw(); return;                          /* retf */
        }
    }
}
