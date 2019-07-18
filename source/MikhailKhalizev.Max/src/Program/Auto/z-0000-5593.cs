using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("facfe096-52a1-4d3f-955f-581144723e9b")]
        public void Method_0000_5593()
        {
            ii(0x5593, 1969); pushw(bp);                                /* push bp */
            ii(0x5594, 1970); mov(bp, sp);                              /* mov bp, sp */
            ii(0x5596, 1971); mov(ax, 0xe18);                           /* mov ax, 0xe18 */
            ii(0x5599, 1969); pushw(ax);                                /* push ax */
            ii(0x559a, 1971); callw(0x4a87, -0x366);                    /* call 0x4a87 */
            ii(0x559d, 1969); popw(bx);                                 /* pop bx */
            ii(0x559e, 1971); mov(ax, 0xac4);                           /* mov ax, 0xac4 */
            ii(0x55a1, 1969); pushw(ax);                                /* push ax */
            ii(0x55a2, 1971); callw(0x4a87, -0x36e);                    /* call 0x4a87 */
            ii(0x55a5, 1969); popw(bx);                                 /* pop bx */
            ii(0x55a6, 1971); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x55a9, 1971); callw(0x4a87, -0x375);                    /* call 0x4a87 */
            ii(0x55ac, 1969); popw(bx);                                 /* pop bx */
            ii(0x55ad, 1972); cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x55b1, 1970); if(jzw(0x4e1a, 0x17)) goto l_0x4e1a;      /* jz 0x4e1a */
            ii(0x55b3, 1971); mov(ax, 0xacd);                           /* mov ax, 0xacd */
            ii(0x55b6, 1969); pushw(ax);                                /* push ax */
            ii(0x55b7, 1971); callw(0x4a87, -0x383);                    /* call 0x4a87 */
            ii(0x55ba, 1969); popw(bx);                                 /* pop bx */
            ii(0x55bb, 1971); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x55be, 1971); callw(0x4a87, -0x38a);                    /* call 0x4a87 */
            ii(0x55c1, 1969); popw(bx);                                 /* pop bx */
            ii(0x55c2, 1971); mov(ax, 0xad0);                           /* mov ax, 0xad0 */
            ii(0x55c5, 1969); pushw(ax);                                /* push ax */
            ii(0x55c6, 1971); callw(0x4a87, -0x392);                    /* call 0x4a87 */
            ii(0x55c9, 1969); popw(bx);                                 /* pop bx */
        l_0x4e1a:
            ii(0x55ca, 1971); callw(0x4dc8, -0x55);                     /* call 0x4dc8 */
            ii(0x55cd, 1973); cmp(memw_a16[ds, 0x11d4], 0);             /* cmp word [0x11d4], 0x0 */
            ii(0x55d2, 1970); if(jnzw(0x4e2a, 0x6)) goto l_0x4e2a;      /* jnz 0x4e2a */
            ii(0x55d4, 1974); mov(memw_a16[ds, 0x11d4], 0xffff);        /* mov word [0x11d4], 0xffff */
        l_0x4e2a:
            ii(0x55da, 1972); pushw(memw_a16[ds, 0x11d4]);              /* push word [0x11d4] */
            ii(0x55de, 1972); callw_abs(memw_a16[ds, 0xac2]);           /* call word [0xac2] */
            ii(0x55e2, 1969); popw(bx);                                 /* pop bx */
            ii(0x55e3, 1970); mov(sp, bp);                              /* mov sp, bp */
            ii(0x55e5, 1969); popw(bp);                                 /* pop bp */
            ii(0x55e6, 1969); retw(); return;                           /* ret */
        }
    }
}
