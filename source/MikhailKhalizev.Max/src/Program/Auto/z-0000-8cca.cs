using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8cca-3ea09302")]
        public void Method_0000_8cca()
        {
            ii(0x8cca, 4);    enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x8cce, 2);    push(0x12);                               /* push 0x12 */
            ii(0x8cd0, 3);    lea(ax, memw[ss, bp - 22]);               /* lea ax, [bp-0x16] */
            ii(0x8cd3, 1);    push(ax);                                 /* push ax */
            ii(0x8cd4, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8cd6, 2);    push(0);                                  /* push 0x0 */
            ii(0x8cd8, 3);    call(0x4f8d, -0x3d4e);                    /* call 0x4f8d */
            ii(0x8cdb, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x8cde, 3);    push(0xef4);                              /* push 0xef4 */
            ii(0x8ce1, 3);    lea(ax, memw[ss, bp - 22]);               /* lea ax, [bp-0x16] */
            ii(0x8ce4, 1);    push(ax);                                 /* push ax */
            ii(0x8ce5, 3);    call(0x56fd, -0x35eb);                    /* call 0x56fd */
            ii(0x8ce8, 1);    pop(bx);                                  /* pop bx */
            ii(0x8ce9, 1);    pop(bx);                                  /* pop bx */
            ii(0x8cea, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8cec, 2);    if(jz(0x8d1f, 0x31)) goto l_0x8d1f;       /* jz 0x8d1f */
            ii(0x8cee, 2);    push(4);                                  /* push 0x4 */
            ii(0x8cf0, 3);    lea(ax, memw[ss, bp - 4]);                /* lea ax, [bp-0x4] */
            ii(0x8cf3, 1);    push(ax);                                 /* push ax */
            ii(0x8cf4, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8cf6, 2);    push(0x32);                               /* push 0x32 */
            ii(0x8cf8, 3);    call(0x4f8d, -0x3d6e);                    /* call 0x4f8d */
            ii(0x8cfb, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0x8cfe, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x8d01, 3);    sub(ax, memw[ss, bp - 2]);                /* sub ax, [bp-0x2] */
            ii(0x8d04, 3);    add(ah, 4);                               /* add ah, 0x4 */
            ii(0x8d07, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x8d09, 3);    add(ax, 1);                               /* add ax, 0x1 */
            ii(0x8d0c, 2);    adc(dx, dx);                              /* adc dx, dx */
            ii(0x8d0e, 2);    mov(cl, 6);                               /* mov cl, 0x6 */
            ii(0x8d10, 3);    call(0x6544, -0x27cf);                    /* call 0x6544 */
            ii(0x8d13, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0x8d16, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
            ii(0x8d1a, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x8d1d, 1);    leave();                                  /* leave */
            ii(0x8d1e, 1);    ret(); return;                            /* ret */
        l_0x8d1f:
            ii(0x8d1f, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8d21, 1);    leave();                                  /* leave */
            ii(0x8d22, 1);    ret();                                    /* ret */
        }
    }
}
