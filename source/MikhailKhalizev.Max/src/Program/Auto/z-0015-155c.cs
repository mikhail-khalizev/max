using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("83e1b1b5-597c-4bda-9372-92b9ad50e9a4")]
        public void Method_0015_155c()
        {
            ii(0x15_155c, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_1560, 1); pushw(ds);                                /* push ds */
            ii(0x15_1561, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_1564, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_1566, 1); pushw(ds);                                /* push ds */
            ii(0x15_1567, 3); pushw(0x38c8);                            /* push 0x38c8 */
            ii(0x15_156a, 1); nop();                                    /* nop */
            ii(0x15_156b, 1); pushw(cs);                                /* push cs */
            ii(0x15_156c, 3); callw(0x15_5030, 0x3ac1);                 /* call 0x5030 */
            ii(0x15_156f, 1); popw(bx);                                 /* pop bx */
            ii(0x15_1570, 1); popw(bx);                                 /* pop bx */
            ii(0x15_1571, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_1574, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_1577, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_1579, 2); if(jzw(0x15_159a, 0x1f)) goto l_0x15_159a; /* jz 0x159a */
            ii(0x15_157b, 1); pushw(ds);                                /* push ds */
            ii(0x15_157c, 3); pushw(0x38cf);                            /* push 0x38cf */
            ii(0x15_157f, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_1582, 1); pushw(ax);                                /* push ax */
            ii(0x15_1583, 1); nop();                                    /* nop */
            ii(0x15_1584, 1); pushw(cs);                                /* push cs */
            ii(0x15_1585, 3); callw(0x15_4eb0, 0x3928);                 /* call 0x4eb0 */
            ii(0x15_1588, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_158b, 3); mov(memw_a16[ds, 0x38bc], ax);            /* mov [0x38bc], ax */
            ii(0x15_158e, 4); mov(memw_a16[ds, 0x38be], dx);            /* mov [0x38be], dx */
            ii(0x15_1592, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x15_1594, 4); or(ax, memw_a16[ds, 0x38bc]);             /* or ax, [0x38bc] */
            ii(0x15_1598, 2); if(jnzw(0x15_15a3, 0x9)) goto l_0x15_15a3; /* jnz 0x15a3 */
        l_0x15_159a:
            ii(0x15_159a, 3); pushw(0xee);                              /* push 0xee */
            ii(0x15_159d, 1); nop();                                    /* nop */
            ii(0x15_159e, 1); pushw(cs);                                /* push cs */
            ii(0x15_159f, 3); callw(0x15_292f, 0x138d);                 /* call 0x292f */
            ii(0x15_15a2, 1); popw(bx);                                 /* pop bx */
        l_0x15_15a3:
            ii(0x15_15a3, 1); pushw(ds);                                /* push ds */
            ii(0x15_15a4, 3); pushw(0x38d8);                            /* push 0x38d8 */
            ii(0x15_15a7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_15aa, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_15ad, 1); nop();                                    /* nop */
            ii(0x15_15ae, 1); pushw(cs);                                /* push cs */
            ii(0x15_15af, 3); callw(0x15_4eb0, 0x38fe);                 /* call 0x4eb0 */
            ii(0x15_15b2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_15b5, 3); mov(memw_a16[ds, 0x38c0], ax);            /* mov [0x38c0], ax */
            ii(0x15_15b8, 4); mov(memw_a16[ds, 0x38c2], dx);            /* mov [0x38c2], dx */
            ii(0x15_15bc, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_15bf, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_15c2, 3); mov(memw_a16[ds, 0x38c4], ax);            /* mov [0x38c4], ax */
            ii(0x15_15c5, 4); mov(memw_a16[ds, 0x38c6], dx);            /* mov [0x38c6], dx */
            ii(0x15_15c9, 1); pushw(cs);                                /* push cs */
            ii(0x15_15ca, 3); callw(0x15_153a, -0x93);                  /* call 0x153a */
            ii(0x15_15cd, 1); popw(ds);                                 /* pop ds */
            ii(0x15_15ce, 1); leavew();                                 /* leave */
            ii(0x15_15cf, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
