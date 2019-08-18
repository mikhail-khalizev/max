using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8c79-2252553f")]
        public void Method_0000_8c79()
        {
            ii(0x8c79, 1);    pushw(bp);                                /* push bp */
            ii(0x8c7a, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8c7c, 3);    sub(sp, 0x18);                            /* sub sp, 0x18 */
            ii(0x8c7f, 4);    mov(memb_a16[ss, bp - 0xd], 0x1a);        /* mov byte [bp-0xd], 0x1a */
            ii(0x8c83, 5);    mov(memw_a16[ss, bp - 0x8], 0x80);        /* mov word [bp-0x8], 0x80 */
            ii(0x8c88, 3);    mov(ax, memw_a16[ds, 0xcec]);             /* mov ax, [0xcec] */
            ii(0x8c8b, 3);    mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x8c8e, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x8c91, 1);    pushw(ax);                                /* push ax */
            ii(0x8c92, 3);    lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x8c95, 1);    pushw(ax);                                /* push ax */
            ii(0x8c96, 1);    pushw(ax);                                /* push ax */
            ii(0x8c97, 3);    callw(0x84c8, -0x7d2);                    /* call 0x84c8 */
            ii(0x8c9a, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x8c9d, 5);    cmp(memb_a16[ds, 0xe6a], 0);              /* cmp byte [0xe6a], 0x0 */
            ii(0x8ca2, 2);    if(jnzw(0x8cf8, 0x54)) goto l_0x8cf8;     /* jnz 0x8cf8 */
            ii(0x8ca4, 5);    cmp(memb_a16[ds, 0x980], 0x1);            /* cmp byte [0x980], 0x1 */
            ii(0x8ca9, 2);    if(jzw(0x8cb5, 0xa)) goto l_0x8cb5;       /* jz 0x8cb5 */
            ii(0x8cab, 5);    cmp(memb_a16[ds, 0x980], 0x3);            /* cmp byte [0x980], 0x3 */
            ii(0x8cb0, 2);    if(jzw(0x8cb5, 0x3)) goto l_0x8cb5;       /* jz 0x8cb5 */
            ii(0x8cb2, 3);    callw(0xb696, 0x29e1);                    /* call 0xb696 */
        l_0x8cb5:
            ii(0x8cb5, 5);    mov(memw_a16[ss, bp - 0x18], 0x2d40);     /* mov word [bp-0x18], 0x2d40 */
            ii(0x8cba, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x8cbf, 2);    if(jzw(0x8ccd, 0xc)) goto l_0x8ccd;       /* jz 0x8ccd */
            ii(0x8cc1, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x8cc6, 2);    if(jnzw(0x8ccd, 0x5)) goto l_0x8ccd;      /* jnz 0x8ccd */
            ii(0x8cc8, 5);    mov(memw_a16[ss, bp - 0x18], 0x29bc);     /* mov word [bp-0x18], 0x29bc */
        l_0x8ccd:
            ii(0x8ccd, 5);    test(memb_a16[ds, 0x14], 0x8);            /* test byte [0x14], 0x8 */
            ii(0x8cd2, 2);    if(jzw(0x8cd9, 0x5)) goto l_0x8cd9;       /* jz 0x8cd9 */
            ii(0x8cd4, 5);    mov(memw_a16[ss, bp - 0x18], 0x627f);     /* mov word [bp-0x18], 0x627f */
        l_0x8cd9:
            ii(0x8cd9, 5);    cmp(memw_a16[ds, 0xe6e], 0);              /* cmp word [0xe6e], 0x0 */
            ii(0x8cde, 2);    if(jzw(0x8ce9, 0x9)) goto l_0x8ce9;       /* jz 0x8ce9 */
            ii(0x8ce0, 3);    mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x8ce3, 4);    cmp(memw_a16[ds, 0xe6e], ax);             /* cmp [0xe6e], ax */
            ii(0x8ce7, 2);    if(jbew(0x8cf8, 0xf)) goto l_0x8cf8;      /* jbe 0x8cf8 */
        l_0x8ce9:
            ii(0x8ce9, 3);    mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x8cec, 3);    mov(memw_a16[ds, 0xe6e], ax);             /* mov [0xe6e], ax */
            ii(0x8cef, 1);    pushw(ax);                                /* push ax */
            ii(0x8cf0, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x8cf3, 3);    callw(0x7c4f, -0x10a7);                   /* call 0x7c4f */
            ii(0x8cf6, 1);    popw(bx);                                 /* pop bx */
            ii(0x8cf7, 1);    popw(bx);                                 /* pop bx */
        l_0x8cf8:
            ii(0x8cf8, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x8cfa, 1);    popw(bp);                                 /* pop bp */
            ii(0x8cfb, 1);    retw(); return;                           /* ret */
        }
    }
}
