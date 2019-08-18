using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4f0d-4a5fb6e3")]
        public void Method_0000_4f0d()
        {
            ii(0x4f0d, 1);    pushw(bp);                                /* push bp */
            ii(0x4f0e, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4f10, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x4f13, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x4f16, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x4f19, 1);    pushw(ax);                                /* push ax */
            ii(0x4f1a, 3);    callw(0x4ee1, -0x3c);                     /* call 0x4ee1 */
            ii(0x4f1d, 1);    popw(bx);                                 /* pop bx */
            ii(0x4f1e, 1);    popw(bx);                                 /* pop bx */
            ii(0x4f1f, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x4f22, 1);    pushw(ax);                                /* push ax */
            ii(0x4f23, 3);    callw(0x5c10, 0xcea);                     /* call 0x5c10 */
            ii(0x4f26, 1);    popw(bx);                                 /* pop bx */
            ii(0x4f27, 3);    mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x4f2a, 3);    mov(memw_a16[ds, 0x11f8], ax);            /* mov [0x11f8], ax */
            ii(0x4f2d, 2);    jmpw(0x4f44, 0x15); goto l_0x4f44;        /* jmp 0x4f44 */
        l_0x4f2f:
            ii(0x4f2f, 3);    mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x4f32, 5);    cmp(memb_a16[ds, bx + 0x1190], 0x5c);     /* cmp byte [bx+0x1190], 0x5c */
            ii(0x4f37, 2);    if(jzw(0x4f49, 0x10)) goto l_0x4f49;      /* jz 0x4f49 */
            ii(0x4f39, 5);    cmp(memb_a16[ds, bx + 0x1190], 0x2e);     /* cmp byte [bx+0x1190], 0x2e */
            ii(0x4f3e, 2);    if(jnzw(0x4f44, 0x4)) goto l_0x4f44;      /* jnz 0x4f44 */
            ii(0x4f40, 4);    mov(memw_a16[ds, 0x11f8], bx);            /* mov [0x11f8], bx */
        l_0x4f44:
            ii(0x4f44, 3);    dec(memw_a16[ss, bp - 0x2]);              /* dec word [bp-0x2] */
            ii(0x4f47, 2);    if(jnsw(0x4f2f, -0x1a)) goto l_0x4f2f;    /* jns 0x4f2f */
        l_0x4f49:
            ii(0x4f49, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4f4b, 1);    popw(bp);                                 /* pop bp */
            ii(0x4f4c, 1);    retw(); return;                           /* ret */
        }
    }
}
