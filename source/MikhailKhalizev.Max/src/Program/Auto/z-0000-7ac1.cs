using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7ac1-166c90c8")]
        public void Method_0000_7ac1()
        {
            ii(0x7ac1, 4);    enter(0x56, 0);                           /* enter 0x56, 0x0 */
            ii(0x7ac5, 1);    push(si);                                 /* push si */
            ii(0x7ac6, 4);    cmp(memw[ss, bp + 4], 0);                 /* cmp word [bp+0x4], 0x0 */
            ii(0x7aca, 2);    if(jnz(0x7ad1, 5)) goto l_0x7ad1;         /* jnz 0x7ad1 */
            ii(0x7acc, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7ace, 1);    pop(si);                                  /* pop si */
            ii(0x7acf, 1);    leave();                                  /* leave */
            ii(0x7ad0, 1);    ret(); return;                            /* ret */
        l_0x7ad1:
            ii(0x7ad1, 2);    push(0x30);                               /* push 0x30 */
            ii(0x7ad3, 2);    push(0);                                  /* push 0x0 */
            ii(0x7ad5, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x7ad8, 1);    push(ax);                                 /* push ax */
            ii(0x7ad9, 3);    call(0x8526, 0xa4a);                      /* call 0x8526 */
            ii(0x7adc, 3);    add(sp, 6);                               /* add sp, 0x6 */
            ii(0x7adf, 3);    lea(ax, memw[ss, bp - 0x1e]);             /* lea ax, [bp-0x1e] */
            ii(0x7ae2, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x7ae5, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x7ae8, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x7aea, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x7aec, 2);    mov(cl, 4);                               /* mov cl, 0x4 */
            ii(0x7aee, 3);    call(0x8554, 0xa63);                      /* call 0x8554 */
            ii(0x7af1, 3);    add(ax, memw[ss, bp - 0x1a]);             /* add ax, [bp-0x1a] */
            ii(0x7af4, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x7af7, 3);    mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x7afa, 3);    mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x7afd, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0x7aff, 3);    mov(memw[ss, bp - 0x44], ax);             /* mov [bp-0x44], ax */
            ii(0x7b02, 3);    mov(memb[ss, bp - 0x42], bl);             /* mov [bp-0x42], bl */
            ii(0x7b05, 4);    mov(memb[ss, bp - 0x3a], 0xc0);           /* mov byte [bp-0x3a], 0xc0 */
            ii(0x7b09, 5);    mov(memw[ss, bp - 0x38], 0x8000);         /* mov word [bp-0x38], 0x8000 */
            ii(0x7b0e, 2);    mov(al, 0xf2);                            /* mov al, 0xf2 */
            ii(0x7b10, 3);    mov(memb[ss, bp - 0x39], al);             /* mov [bp-0x39], al */
            ii(0x7b13, 3);    mov(memb[ss, bp - 0x41], al);             /* mov [bp-0x41], al */
            ii(0x7b16, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x7b1a, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x7b1d, 3);    mov(memw[ss, bp - 0x46], ax);             /* mov [bp-0x46], ax */
            ii(0x7b20, 3);    mov(memw[ss, bp - 0x3e], ax);             /* mov [bp-0x3e], ax */
            ii(0x7b23, 3);    mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0x7b26, 3);    lea(ax, memw[ss, bp - 0x56]);             /* lea ax, [bp-0x56] */
            ii(0x7b29, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x7b2c, 3);    mov(memw[ss, bp - 0x18], ss);             /* mov [bp-0x18], ss */
            ii(0x7b2f, 3);    mov(memw[ss, bp - 0xa], ax);              /* mov [bp-0xa], ax */
            ii(0x7b32, 2);    mov(ax, ss);                              /* mov ax, ss */
            ii(0x7b34, 3);    mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x7b37, 5);    mov(memw[ss, bp - 0x1e], 0xfe);           /* mov word [bp-0x1e], 0xfe */
            ii(0x7b3c, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x7b3f, 1);    push(ax);                                 /* push ax */
            ii(0x7b40, 3);    lea(cx, memw[ss, bp - 0x12]);             /* lea cx, [bp-0x12] */
            ii(0x7b43, 1);    push(cx);                                 /* push cx */
            ii(0x7b44, 1);    push(cx);                                 /* push cx */
            ii(0x7b45, 2);    push(0x15);                               /* push 0x15 */
            ii(0x7b47, 3);    call(0x83ec, 0x8a2);                      /* call 0x83ec */
            ii(0x7b4a, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x7b4d, 3);    mov(ax, memw[ds, 0x11ec]);                /* mov ax, [0x11ec] */
            ii(0x7b50, 3);    mov(dx, 0xf000);                          /* mov dx, 0xf000 */
            ii(0x7b53, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x7b56, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0x7b59, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x7b5b, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0x7b5d, 3);    mov(cx, memw[ss, bp + 4]);                /* mov cx, [bp+0x4] */
            ii(0x7b60, 4);    sub(memw[es, bx + 4], cx);                /* sub [es:bx+0x4], cx */
            ii(0x7b64, 4);    mov(si, memw[es, bx + 6]);                /* mov si, [es:bx+0x6] */
            ii(0x7b68, 3);    mov(memw[ss, bp - 0x1c], si);             /* mov [bp-0x1c], si */
            ii(0x7b6b, 4);    sub(memw[es, bx + 6], cx);                /* sub [es:bx+0x6], cx */
            ii(0x7b6f, 5);    mov(memw[ss, bp - 0x1e], 0xfc);           /* mov word [bp-0x1e], 0xfc */
            ii(0x7b74, 4);    mov(memb[ss, bp - 0x11], 0x87);           /* mov byte [bp-0x11], 0x87 */
            ii(0x7b78, 5);    mov(memw[ss, bp - 0xe], 1);               /* mov word [bp-0xe], 0x1 */
            ii(0x7b7d, 3);    lea(ax, memw[ss, bp - 0x26]);             /* lea ax, [bp-0x26] */
            ii(0x7b80, 1);    push(ax);                                 /* push ax */
            ii(0x7b81, 3);    lea(ax, memw[ss, bp - 0x12]);             /* lea ax, [bp-0x12] */
            ii(0x7b84, 1);    push(ax);                                 /* push ax */
            ii(0x7b85, 1);    push(ax);                                 /* push ax */
            ii(0x7b86, 2);    push(0x15);                               /* push 0x15 */
            ii(0x7b88, 3);    call(0x83ec, 0x861);                      /* call 0x83ec */
            ii(0x7b8b, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x7b8e, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x7b91, 3);    les(bx, memw[ss, bp - 0x16]);             /* les bx, [bp-0x16] */
            ii(0x7b94, 4);    sub(ax, memw[es, bx + 6]);                /* sub ax, [es:bx+0x6] */
            ii(0x7b98, 3);    mov(memw[ss, bp + 4], ax);                /* mov [bp+0x4], ax */
            ii(0x7b9b, 4);    sub(memw[ds, 0x120a], ax);                /* sub [0x120a], ax */
            ii(0x7b9f, 3);    mov(ax, memw[ds, 0x120a]);                /* mov ax, [0x120a] */
            ii(0x7ba2, 1);    pop(si);                                  /* pop si */
            ii(0x7ba3, 1);    leave();                                  /* leave */
            ii(0x7ba4, 1);    ret();                                    /* ret */
        }
    }
}
