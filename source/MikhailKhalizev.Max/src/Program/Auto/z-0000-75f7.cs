using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6f5c4bd0-f823-4b36-a1ff-0f25b81f5d80")]
        public void Method_0000_75f7()
        {
            ii(0x75f7, 1);    pushw(bp);                                /* push bp */
            ii(0x75f8, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x75fa, 3);    sub(sp, 0x6);                             /* sub sp, 0x6 */
            ii(0x75fd, 1);    pushw(si);                                /* push si */
            ii(0x75fe, 4);    cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x7602, 2);    if(jzw(0x7613, 0xf)) goto l_0x7613;       /* jz 0x7613 */
            ii(0x7604, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x7607, 3);    callw(0x7247, -0x3c3);                    /* call 0x7247 */
            ii(0x760a, 1);    popw(bx);                                 /* pop bx */
            ii(0x760b, 3);    mov(ax, 0xad2);                           /* mov ax, 0xad2 */
            ii(0x760e, 1);    pushw(ax);                                /* push ax */
            ii(0x760f, 3);    callw(0x7247, -0x3cb);                    /* call 0x7247 */
            ii(0x7612, 1);    popw(bx);                                 /* pop bx */
        l_0x7613:
            ii(0x7613, 3);    mov(si, 0x5);                             /* mov si, 0x5 */
            ii(0x7616, 2);    jmpw(0x7632, 0x1a); goto l_0x7632;        /* jmp 0x7632 */
        l_0x7618:
            ii(0x7618, 3);    lea(cx, si - 0x1);                        /* lea cx, [si-0x1] */
            ii(0x761b, 2);    shl(cl, 0x1);                             /* shl cl, 1 */
            ii(0x761d, 2);    shl(cl, 0x1);                             /* shl cl, 1 */
            ii(0x761f, 3);    mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x7622, 2);    shr(bx, cl);                              /* shr bx, cl */
            ii(0x7624, 3);    and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x7627, 4);    mov(al, memb_a16[ds, bx + 0xab0]);        /* mov al, [bx+0xab0] */
            ii(0x762b, 3);    lea(bx, bp - 0x2);                        /* lea bx, [bp-0x2] */
            ii(0x762e, 2);    sub(bx, si);                              /* sub bx, si */
            ii(0x7630, 2);    mov(memb_a16[ds, bx], al);                /* mov [bx], al */
        l_0x7632:
            ii(0x7632, 1);    dec(si);                                  /* dec si */
            ii(0x7633, 2);    if(jnsw(0x7618, -0x1d)) goto l_0x7618;    /* jns 0x7618 */
            ii(0x7635, 4);    mov(memb_a16[ss, bp - 0x2], 0);           /* mov byte [bp-0x2], 0x0 */
            ii(0x7639, 3);    lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x763c, 1);    pushw(ax);                                /* push ax */
            ii(0x763d, 3);    callw(0x7247, -0x3f9);                    /* call 0x7247 */
            ii(0x7640, 1);    popw(bx);                                 /* pop bx */
            ii(0x7641, 4);    cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0x7645, 2);    if(jzw(0x764f, 0x8)) goto l_0x764f;       /* jz 0x764f */
            ii(0x7647, 3);    mov(ax, 0xad4);                           /* mov ax, 0xad4 */
            ii(0x764a, 1);    pushw(ax);                                /* push ax */
            ii(0x764b, 3);    callw(0x7247, -0x407);                    /* call 0x7247 */
            ii(0x764e, 1);    popw(bx);                                 /* pop bx */
        l_0x764f:
            ii(0x764f, 1);    popw(si);                                 /* pop si */
            ii(0x7650, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x7652, 1);    popw(bp);                                 /* pop bp */
            ii(0x7653, 1);    retw(); return;                           /* ret */
        }
    }
}
