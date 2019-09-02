using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5ab1-166c90c8")]
        public void Method_0000_5ab1()
        {
            ii(0x5ab1, 4);    enter(0x56, 0);                           /* enter 0x56, 0x0 */
            ii(0x5ab5, 1);    push(si);                                 /* push si */
            ii(0x5ab6, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x5aba, 2);    if(jnz(0x5ac1, 5)) goto l_0x5ac1;         /* jnz 0x5ac1 */
            ii(0x5abc, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x5abe, 1);    pop(si);                                  /* pop si */
            ii(0x5abf, 1);    leave();                                  /* leave */
            ii(0x5ac0, 1);    ret(); return;                            /* ret */
        l_0x5ac1:
            ii(0x5ac1, 2);    push(0x30);                               /* push 0x30 */
            ii(0x5ac3, 2);    push(0);                                  /* push 0x0 */
            ii(0x5ac5, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x5ac8, 1);    push(ax);                                 /* push ax */
            ii(0x5ac9, 3);    call(0x6516, 0xa4a);                      /* call 0x6516 */
            ii(0x5acc, 3);    add(sp, 6);                               /* add sp, 0x6 */
            ii(0x5acf, 3);    lea(ax, memw[ss, bp - 0x1e]);             /* lea ax, [bp-0x1e] */
            ii(0x5ad2, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x5ad5, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x5ad8, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x5ada, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x5adc, 2);    mov(cl, 4);                               /* mov cl, 0x4 */
            ii(0x5ade, 3);    call(0x6544, 0xa63);                      /* call 0x6544 */
            ii(0x5ae1, 3);    add(ax, memw[ss, bp - 0x1a]);             /* add ax, [bp-0x1a] */
            ii(0x5ae4, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x5ae7, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x5aea, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x5aed, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x5aef, 3);    mov(memw[ss, bp - 0x44], ax);             /* mov [bp-0x44], ax */
            ii(0x5af2, 3);    mov(memb[ss, bp - 0x42], bl);             /* mov [bp-0x42], bl */
            ii(0x5af5, 4);    mov(memb[ss, bp - 0x3a], 0xc0);           /* mov byte [bp-0x3a], 0xc0 */
            ii(0x5af9, 5);    mov(memw[ss, bp - 0x38], 0x8000);         /* mov word [bp-0x38], 0x8000 */
            ii(0x5afe, 2);    mov(al, 0xf2);                            /* mov al, 0xf2 */
            ii(0x5b00, 3);    mov(memb[ss, bp - 0x39], al);             /* mov [bp-0x39], al */
            ii(0x5b03, 3);    mov(memb[ss, bp - 0x41], al);             /* mov [bp-0x41], al */
            ii(0x5b06, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x5b0a, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x5b0d, 3);    mov(memw[ss, bp - 0x46], ax);             /* mov [bp-0x46], ax */
            ii(0x5b10, 3);    mov(memw[ss, bp - 0x3e], ax);             /* mov [bp-0x3e], ax */
            ii(0x5b13, 3);    mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x5b16, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x5b19, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x5b1c, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x5b1f, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x5b22, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x5b24, 3);    mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x5b27, 5);    mov(memw[ss, bp - 0x1e], 0xfe);           /* mov word [bp-0x1e], 0xfe */
            ii(0x5b2c, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x5b2f, 1);    push(ax);                                 /* push ax */
            ii(0x5b30, 3);    lea(cx, memw[ss, bp - 0x12]);             /* lea cx, [bp-0x12] */
            ii(0x5b33, 1);    push(cx);                                 /* push cx */
            ii(0x5b34, 1);    push(cx);                                 /* push cx */
            ii(0x5b35, 2);    push(0x15);                               /* push 0x15 */
            ii(0x5b37, 3);    call(0x63dc, 0x8a2);                      /* call 0x63dc */
            ii(0x5b3a, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x5b3d, 3);    mov(ax, memw[ds, 0x11ec]);                /* mov ax, [0x11ec] */
            ii(0x5b40, 3);    mov(dx, 0xf000);                          /* mov dx, 0xf000 */
            ii(0x5b43, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x5b46, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x5b49, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x5b4b, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x5b4d, 3);    mov(cx, memw[ss, bp + 4]);                /* mov cx, [bp+0x4] */
            ii(0x5b50, 4);    sub(memw[es, bx + 4], cx);                /* sub [es:bx+0x4], cx */
            ii(0x5b54, 4);    mov(si, memw[es, bx + 6]);                /* mov si, [es:bx+0x6] */
            ii(0x5b58, 3);    mov(memw[ss, bp - 0x1c], si);             /* mov [bp-0x1c], si */
            ii(0x5b5b, 4);    sub(memw[es, bx + 6], cx);                /* sub [es:bx+0x6], cx */
            ii(0x5b5f, 5);    mov(memw[ss, bp - 0x1e], 0xfc);           /* mov word [bp-0x1e], 0xfc */
            ii(0x5b64, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x5b68, 5);    mov(memw[ss, bp - 0xe], 1);               /* mov word [bp-0xe], 0x1 */
            ii(0x5b6d, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x5b70, 1);    push(ax);                                 /* push ax */
            ii(0x5b71, 3);    lea(ax, memw[ss, bp - 0x12]);             /* lea ax, [bp-0x12] */
            ii(0x5b74, 1);    push(ax);                                 /* push ax */
            ii(0x5b75, 1);    push(ax);                                 /* push ax */
            ii(0x5b76, 2);    push(0x15);                               /* push 0x15 */
            ii(0x5b78, 3);    call(0x63dc, 0x861);                      /* call 0x63dc */
            ii(0x5b7b, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x5b7e, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x5b81, 3);    les(bx, memw[ss, bp - 0x16]);             /* les bx, [bp-0x16] */
            ii(0x5b84, 4);    sub(ax, memw[es, bx + 6]);                /* sub ax, [es:bx+0x6] */
            ii(0x5b88, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x5b8b, 4);    sub(memw[ds, 0x120a], ax);                /* sub [0x120a], ax */
            ii(0x5b8f, 3);    mov(ax, memw[ds, 0x120a]);                /* mov ax, [0x120a] */
            ii(0x5b92, 1);    pop(si);                                  /* pop si */
            ii(0x5b93, 1);    leave();                                  /* leave */
            ii(0x5b94, 1);    ret();                                    /* ret */
        }
    }
}
