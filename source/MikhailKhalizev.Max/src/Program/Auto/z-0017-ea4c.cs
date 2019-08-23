using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ea4c-737a92eb")]
        public void Method_0017_ea4c()
        {
            ii(0x17_ea4c, 4); enter(0x8, 0);                            /* enter 0x8, 0x0 */
            ii(0x17_ea50, 1); push(ds);                                 /* push ds */
            ii(0x17_ea51, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_ea54, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_ea56, 3); mov(ax, memw[ds, 0x1414]);                /* mov ax, [0x1414] */
            ii(0x17_ea59, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_ea5c, 5); mov(memw[ss, bp - 0x4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x17_ea61, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea64, 7); mov(memw[es, bx + 0x7f2], 0);             /* mov word [es:bx+0x7f2], 0x0 */
            ii(0x17_ea6b, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x17_ea6e, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_ea71, 3); mov(memw[ss, bp - 0x6], ss);              /* mov [bp-0x6], ss */
            ii(0x17_ea74, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea77, 5); mov(memw[es, bx + 0x7e8], ax);            /* mov [es:bx+0x7e8], ax */
            ii(0x17_ea7c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea7f, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x17_ea82, 5); mov(memw[es, bx + 0x7ea], ax);            /* mov [es:bx+0x7ea], ax */
            ii(0x17_ea87, 3); mov(ax, 0x140e);                          /* mov ax, 0x140e */
            ii(0x17_ea8a, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_ea8d, 3); mov(memw[ss, bp - 0x6], ds);              /* mov [bp-0x6], ds */
            ii(0x17_ea90, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_ea93, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x17_ea95, 5); mov(memw[es, bx + 0x7ee], ax);            /* mov [es:bx+0x7ee], ax */
            ii(0x17_ea9a, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x17_ea9d, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x17_eaa0, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_eaa3, 3); mov(memw[ss, bp - 0x6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_eaa6, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_eaa9, 5); mov(memw[es, bx + 0x7f0], ax);            /* mov [es:bx+0x7f0], ax */
            ii(0x17_eaae, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x17_eab1, 3); mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0x17_eab4, 5); mov(memw[es, bx + 0x7f2], ax);            /* mov [es:bx+0x7f2], ax */
            ii(0x17_eab9, 1); pop(ds);                                  /* pop ds */
            ii(0x17_eaba, 1); leave();                                  /* leave */
            ii(0x17_eabb, 1); retf();                                   /* retf */
        }
    }
}
