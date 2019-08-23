using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_5622-b7f58a04")]
        public void Method_0017_5622()
        {
            ii(0x17_5622, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_5626, 1); push(ds);                                 /* push ds */
            ii(0x17_5627, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_562a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_562c, 5); mov(memw[ss, bp - 0x2], 0x8);             /* mov word [bp-0x2], 0x8 */
            ii(0x17_5631, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_5634, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_5637, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_563a, 4); mov(al, memb[es, bx + 0x5]);              /* mov al, [es:bx+0x5] */
            ii(0x17_563e, 2); and(al, 0xf3);                            /* and al, 0xf3 */
            ii(0x17_5640, 2); or(al, 0x13);                             /* or al, 0x13 */
            ii(0x17_5642, 4); mov(memb[es, bx + 0x5], al);              /* mov [es:bx+0x5], al */
            ii(0x17_5646, 1); pop(ds);                                  /* pop ds */
            ii(0x17_5647, 1); leave();                                  /* leave */
            ii(0x17_5648, 1); retf();                                   /* retf */
        }
    }
}
