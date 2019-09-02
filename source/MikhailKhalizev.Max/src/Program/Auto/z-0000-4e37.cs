using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x4e37-98ca9f15")]
        public void Method_0000_4e37()
        {
            ii(0x4e37, 1);    push(bp);                                 /* push bp */
            ii(0x4e38, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4e3a, 3);    sub(sp, 6);                               /* sub sp, 0x6 */
            ii(0x4e3d, 1);    push(si);                                 /* push si */
            ii(0x4e3e, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x4e42, 2);    if(jz(0x4e53, 0xf)) goto l_0x4e53;        /* jz 0x4e53 */
            ii(0x4e44, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x4e47, 3);    call(0x4a87, -0x3c3);                     /* call 0x4a87 */
            ii(0x4e4a, 1);    pop(bx);                                  /* pop bx */
            ii(0x4e4b, 3);    mov(ax, 0xad2);                           /* mov ax, 0xad2 */
            ii(0x4e4e, 1);    push(ax);                                 /* push ax */
            ii(0x4e4f, 3);    call(0x4a87, -0x3cb);                     /* call 0x4a87 */
            ii(0x4e52, 1);    pop(bx);                                  /* pop bx */
        l_0x4e53:
            ii(0x4e53, 3);    mov(si, 5);                               /* mov si, 0x5 */
            ii(0x4e56, 2);    jmp(0x4e72, 0x1a); goto l_0x4e72;         /* jmp 0x4e72 */
        l_0x4e58:
            ii(0x4e58, 3);    lea(cx, memw[ds, si - 1]);                /* lea cx, [si-0x1] */
            ii(0x4e5b, 2);    shl(cl, 1);                               /* shl cl, 1 */
            ii(0x4e5d, 2);    shl(cl, 1);                               /* shl cl, 1 */
            ii(0x4e5f, 3);    mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x4e62, 2);    shr(bx, cl);                              /* shr bx, cl */
            ii(0x4e64, 3);    and(bx, 0xf);                             /* and bx, 0xf */
            ii(0x4e67, 4);    mov(al, memb[ds, bx + 0xab0]);            /* mov al, [bx+0xab0] */
            ii(0x4e6b, 3);    lea(bx, memw[ss, bp - 2]);                /* lea bx, [bp-0x2] */
            ii(0x4e6e, 2);    sub(bx, si);                              /* sub bx, si */
            ii(0x4e70, 2);    mov(memb[ds, bx], al);                    /* mov [bx], al */
        l_0x4e72:
            ii(0x4e72, 1);    dec(si);                                  /* dec si */
            ii(0x4e73, 2);    if(jns(0x4e58, -0x1d)) goto l_0x4e58;     /* jns 0x4e58 */
            ii(0x4e75, 4);    mov(memb[ss, bp - 2], 0);                 /* mov byte [bp-0x2], 0x0 */
            ii(0x4e79, 3);    lea(ax, memw[ss, bp - 6]);                /* lea ax, [bp-0x6] */
            ii(0x4e7c, 1);    push(ax);                                 /* push ax */
            ii(0x4e7d, 3);    call(0x4a87, -0x3f9);                     /* call 0x4a87 */
            ii(0x4e80, 1);    pop(bx);                                  /* pop bx */
            ii(0x4e81, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x4e85, 2);    if(jz(0x4e8f, 8)) goto l_0x4e8f;          /* jz 0x4e8f */
            ii(0x4e87, 3);    mov(ax, 0xad4);                           /* mov ax, 0xad4 */
            ii(0x4e8a, 1);    push(ax);                                 /* push ax */
            ii(0x4e8b, 3);    call(0x4a87, -0x407);                     /* call 0x4a87 */
            ii(0x4e8e, 1);    pop(bx);                                  /* pop bx */
        l_0x4e8f:
            ii(0x4e8f, 1);    pop(si);                                  /* pop si */
            ii(0x4e90, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4e92, 1);    pop(bp);                                  /* pop bp */
            ii(0x4e93, 1);    ret();                                    /* ret */
        }
    }
}
