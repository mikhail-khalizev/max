using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("facfe096-52a1-4d3f-955f-581144723e9b")]
        public void Method_0000_5593()
        {
            ii(0x4de3, 1);    pushw(bp);                                /* push bp */
            ii(0x4de4, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4de6, 3);    mov(ax, 0xe18);                           /* mov ax, 0xe18 */
            ii(0x4de9, 1);    pushw(ax);                                /* push ax */
            ii(0x4dea, 3);    callw(0x4a87, -0x366);                    /* call 0x4a87 */
            ii(0x4ded, 1);    popw(bx);                                 /* pop bx */
            ii(0x4dee, 3);    mov(ax, 0xac4);                           /* mov ax, 0xac4 */
            ii(0x4df1, 1);    pushw(ax);                                /* push ax */
            ii(0x4df2, 3);    callw(0x4a87, -0x36e);                    /* call 0x4a87 */
            ii(0x4df5, 1);    popw(bx);                                 /* pop bx */
            ii(0x4df6, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x4df9, 3);    callw(0x4a87, -0x375);                    /* call 0x4a87 */
            ii(0x4dfc, 1);    popw(bx);                                 /* pop bx */
            ii(0x4dfd, 4);    cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0x4e01, 2);    if(jzw(0x4e1a, 0x17)) goto l_0x4e1a;      /* jz 0x4e1a */
            ii(0x4e03, 3);    mov(ax, 0xacd);                           /* mov ax, 0xacd */
            ii(0x4e06, 1);    pushw(ax);                                /* push ax */
            ii(0x4e07, 3);    callw(0x4a87, -0x383);                    /* call 0x4a87 */
            ii(0x4e0a, 1);    popw(bx);                                 /* pop bx */
            ii(0x4e0b, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x4e0e, 3);    callw(0x4a87, -0x38a);                    /* call 0x4a87 */
            ii(0x4e11, 1);    popw(bx);                                 /* pop bx */
            ii(0x4e12, 3);    mov(ax, 0xad0);                           /* mov ax, 0xad0 */
            ii(0x4e15, 1);    pushw(ax);                                /* push ax */
            ii(0x4e16, 3);    callw(0x4a87, -0x392);                    /* call 0x4a87 */
            ii(0x4e19, 1);    popw(bx);                                 /* pop bx */
        l_0x4e1a:
            ii(0x4e1a, 3);    callw(0x4dc8, -0x55);                     /* call 0x4dc8 */
            ii(0x4e1d, 5);    cmp(memw_a16[ds, 0x11d4], 0);             /* cmp word [0x11d4], 0x0 */
            ii(0x4e22, 2);    if(jnzw(0x4e2a, 0x6)) goto l_0x4e2a;      /* jnz 0x4e2a */
            ii(0x4e24, 6);    mov(memw_a16[ds, 0x11d4], 0xffff);        /* mov word [0x11d4], 0xffff */
        l_0x4e2a:
            ii(0x4e2a, 4);    pushw(memw_a16[ds, 0x11d4]);              /* push word [0x11d4] */
            ii(0x4e2e, 4);    callw_abs(memw_a16[ds, 0xac2]);           /* call word [0xac2] */
            ii(0x4e32, 1);    popw(bx);                                 /* pop bx */
            ii(0x4e33, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4e35, 1);    popw(bp);                                 /* pop bp */
            ii(0x4e36, 1);    retw(); return;                           /* ret */
        }
    }
}
