using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("39df339d-8165-46a1-8553-9e0c4d9a917a")]
        public void Method_0015_15fe()
        {
            ii(0x15_15fe, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_1602, 3); lea(ax, bp + 0xc);                        /* lea ax, [bp+0xc] */
            ii(0x15_1605, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_1608, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x15_160b, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x15_160e, 1); pushw(ss);                                /* push ss */
            ii(0x15_160f, 1); pushw(ax);                                /* push ax */
            ii(0x15_1610, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_1613, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_1616, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_1619, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_161b, 4); pushw(memw_a16[ds, 0x38c6]);              /* push word [0x38c6] */
            ii(0x15_161f, 4); pushw(memw_a16[ds, 0x38c4]);              /* push word [0x38c4] */
            ii(0x15_1623, 1); pushw(cs);                                /* push cs */
            ii(0x15_1624, 3); callw(0x15_15d2, -0x55);                  /* call 0x15d2 */
            ii(0x15_1627, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x15_162a, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_162d, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_162f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_1632, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_1635, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_1638, 1); nop();                                    /* nop */
            ii(0x15_1639, 1); pushw(cs);                                /* push cs */
            ii(0x15_163a, 3); callw(0x15_292f, 0x12f2);                 /* call 0x292f */
            ii(0x15_163d, 1); popw(bx);                                 /* pop bx */
            ii(0x15_163e, 1); leavew();                                 /* leave */
            ii(0x15_163f, 1); retfw(); return;                          /* retf */
        }
    }
}
