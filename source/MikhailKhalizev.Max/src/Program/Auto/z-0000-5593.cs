using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("facfe096-52a1-4d3f-955f-581144723e9b")]
        public void Method_0000_5593()
        {
            ii(0x5593, 1);    pushw(bp);                                /* push bp */
            ii(0x5594, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5596, 3);    mov(ax, 0xe18);                           /* mov ax, 0xe18 */
            ii(0x5599, 1);    pushw(ax);                                /* push ax */
            ii(0x559a, 3);    callw(0x4a87, -0x366);                    /* call 0x4a87 */
            ii(0x559d, 1);    popw(bx);                                 /* pop bx */
            ii(0x559e, 3);    mov(ax, 0xac4);                           /* mov ax, 0xac4 */
            ii(0x55a1, 1);    pushw(ax);                                /* push ax */
            ii(0x55a2, 3);    callw(0x4a87, -0x36e);                    /* call 0x4a87 */
            ii(0x55a5, 1);    popw(bx);                                 /* pop bx */
            ii(0x55a6, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x55a9, 3);    callw(0x4a87, -0x375);                    /* call 0x4a87 */
            ii(0x55ac, 1);    popw(bx);                                 /* pop bx */
            ii(0x55ad, 4);    cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x55b1, 2);    if(jzw(0x4e1a, 0x17)) goto l_0x4e1a;      /* jz 0x4e1a */
            ii(0x55b3, 3);    mov(ax, 0xacd);                           /* mov ax, 0xacd */
            ii(0x55b6, 1);    pushw(ax);                                /* push ax */
            ii(0x55b7, 3);    callw(0x4a87, -0x383);                    /* call 0x4a87 */
            ii(0x55ba, 1);    popw(bx);                                 /* pop bx */
            ii(0x55bb, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x55be, 3);    callw(0x4a87, -0x38a);                    /* call 0x4a87 */
            ii(0x55c1, 1);    popw(bx);                                 /* pop bx */
            ii(0x55c2, 3);    mov(ax, 0xad0);                           /* mov ax, 0xad0 */
            ii(0x55c5, 1);    pushw(ax);                                /* push ax */
            ii(0x55c6, 3);    callw(0x4a87, -0x392);                    /* call 0x4a87 */
            ii(0x55c9, 1);    popw(bx);                                 /* pop bx */
        l_0x4e1a:
            ii(0x55ca, 3);    callw(0x4dc8, -0x55);                     /* call 0x4dc8 */
            ii(0x55cd, 5);    cmp(memw_a16[ds, 0x11d4], 0);             /* cmp word [0x11d4], 0x0 */
            ii(0x55d2, 2);    if(jnzw(0x4e2a, 0x6)) goto l_0x4e2a;      /* jnz 0x4e2a */
            ii(0x55d4, 6);    mov(memw_a16[ds, 0x11d4], 0xffff);        /* mov word [0x11d4], 0xffff */
        l_0x4e2a:
            ii(0x55da, 4);    pushw(memw_a16[ds, 0x11d4]);              /* push word [0x11d4] */
            ii(0x55de, 4);    callw_abs(memw_a16[ds, 0xac2]);           /* call word [0xac2] */
            ii(0x55e2, 1);    popw(bx);                                 /* pop bx */
            ii(0x55e3, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x55e5, 1);    popw(bp);                                 /* pop bp */
            ii(0x55e6, 1);    retw(); return;                           /* ret */
        }
    }
}
