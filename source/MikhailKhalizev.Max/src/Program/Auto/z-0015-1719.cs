using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e20a96dc-30e7-40a7-94e4-320c16af3f33")]
        public void Method_0015_1719()
        {
            ii(0x15_1719, 4); enterw(0x6, 0);                           /* enter 0x6, 0x0 */
            ii(0x15_171d, 1); pushw(ds);                                /* push ds */
            ii(0x15_171e, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_1721, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_1723, 5); test(memb_a16[ds, 0x36f6], 0x1);          /* test byte [0x36f6], 0x1 */
            ii(0x15_1728, 2); if(jnzw(0x15_172f, 0x5)) goto l_0x15_172f; /* jnz 0x172f */
            ii(0x15_172a, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_172c, 1); popw(ds);                                 /* pop ds */
            ii(0x15_172d, 1); leavew();                                 /* leave */
            ii(0x15_172e, 1); retfw(); return;                          /* retf */
        l_0x15_172f:
            ii(0x15_172f, 3); lea(ax, bp + 0xa);                        /* lea ax, [bp+0xa] */
            ii(0x15_1732, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_1735, 3); mov(memw_a16[ss, bp - 0x4], ss);          /* mov [bp-0x4], ss */
            ii(0x15_1738, 3); lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x15_173b, 1); pushw(ss);                                /* push ss */
            ii(0x15_173c, 1); pushw(ax);                                /* push ax */
            ii(0x15_173d, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_1740, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_1743, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_1745, 2); pushw(-0x1 /* 0xff */);                   /* push 0xffff */
            ii(0x15_1747, 4); pushw(memw_a16[ds, 0x38c6]);              /* push word [0x38c6] */
            ii(0x15_174b, 4); pushw(memw_a16[ds, 0x38c4]);              /* push word [0x38c4] */
            ii(0x15_174f, 1); pushw(cs);                                /* push cs */
            ii(0x15_1750, 3); callw(0x15_15d2, -0x181);                 /* call 0x15d2 */
            ii(0x15_1753, 3); add(sp, 0x10);                            /* add sp, 0x10 */
            ii(0x15_1756, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_1759, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_175b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_175e, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x15_1761, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_1764, 1); popw(ds);                                 /* pop ds */
            ii(0x15_1765, 1); leavew();                                 /* leave */
            ii(0x15_1766, 1); retfw(); return;                          /* retf */
        }
    }
}
