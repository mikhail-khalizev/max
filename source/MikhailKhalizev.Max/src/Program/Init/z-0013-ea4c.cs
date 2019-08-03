using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8d5341b9-d3e5-4ab5-803b-26d0339c030f")]
        public void Method_0013_ea4c()
        {
            ii(0x13_ea4c, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x13_ea50, 1); pushw(ds);                                /* push ds */
            ii(0x13_ea51, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_ea54, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_ea56, 3); mov(ax, memw_a16[ds, 0x1414]);            /* mov ax, [0x1414] */
            ii(0x13_ea59, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_ea5c, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x13_ea61, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ea64, 7); mov(memw_a16[es, bx + 0x7f2], 0);         /* mov word [es:bx+0x7f2], 0x0 */
            ii(0x13_ea6b, 3); lea(ax, bp + 0x6);                        /* lea ax, [bp+0x6] */
            ii(0x13_ea6e, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_ea71, 3); mov(memw_a16[ss, bp - 0x6], ss);          /* mov [bp-0x6], ss */
            ii(0x13_ea74, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ea77, 5); mov(memw_a16[es, bx + 0x7e8], ax);        /* mov [es:bx+0x7e8], ax */
            ii(0x13_ea7c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ea7f, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_ea82, 5); mov(memw_a16[es, bx + 0x7ea], ax);        /* mov [es:bx+0x7ea], ax */
            ii(0x13_ea87, 3); mov(ax, 0x140e);                          /* mov ax, 0x140e */
            ii(0x13_ea8a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_ea8d, 3); mov(memw_a16[ss, bp - 0x6], ds);          /* mov [bp-0x6], ds */
            ii(0x13_ea90, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_ea93, 2); mov(ax, ds);                              /* mov ax, ds */
            ii(0x13_ea95, 5); mov(memw_a16[es, bx + 0x7ee], ax);        /* mov [es:bx+0x7ee], ax */
            ii(0x13_ea9a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_ea9d, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_eaa0, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_eaa3, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_eaa6, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_eaa9, 5); mov(memw_a16[es, bx + 0x7f0], ax);        /* mov [es:bx+0x7f0], ax */
            ii(0x13_eaae, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_eab1, 3); mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x13_eab4, 5); mov(memw_a16[es, bx + 0x7f2], ax);        /* mov [es:bx+0x7f2], ax */
            ii(0x13_eab9, 1); popw(ds);                                 /* pop ds */
            ii(0x13_eaba, 1); leavew();                                 /* leave */
            ii(0x13_eabb, 1); retfw(); return;                          /* retf */
        }
    }
}
