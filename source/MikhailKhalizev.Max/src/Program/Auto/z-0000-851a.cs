using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x851a-3ea09302")]
        public void Method_0000_851a()
        {
            ii(0x851a, 4);    enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x851e, 2);    push(0x12);                               /* push 0x12 */
            ii(0x8520, 3);    lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x8523, 1);    push(ax);                                 /* push ax */
            ii(0x8524, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8526, 2);    push(0);                                  /* push 0x0 */
            ii(0x8528, 3);    call(0x47dd, -0x3d4e);                    /* call 0x47dd */
            ii(0x852b, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x852e, 3);    push(0xef4);                              /* push 0xef4 */
            ii(0x8531, 3);    lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x8534, 1);    push(ax);                                 /* push ax */
            ii(0x8535, 3);    call(0x4f4d, -0x35eb);                    /* call 0x4f4d */
            ii(0x8538, 1);    pop(bx);                                  /* pop bx */
            ii(0x8539, 1);    pop(bx);                                  /* pop bx */
            ii(0x853a, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x853c, 2);    if(jz(0x856f, 0x31)) goto l_0x856f;       /* jz 0x856f */
            ii(0x853e, 2);    push(0x4);                                /* push 0x4 */
            ii(0x8540, 3);    lea(ax, memw[ss, bp - 0x4]);              /* lea ax, [bp-0x4] */
            ii(0x8543, 1);    push(ax);                                 /* push ax */
            ii(0x8544, 2);    push(0x10);                               /* push 0x10 */
            ii(0x8546, 2);    push(0x32);                               /* push 0x32 */
            ii(0x8548, 3);    call(0x47dd, -0x3d6e);                    /* call 0x47dd */
            ii(0x854b, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x854e, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8551, 3);    sub(ax, memw[ss, bp - 0x2]);              /* sub ax, [bp-0x2] */
            ii(0x8554, 3);    add(ah, 0x4);                             /* add ah, 0x4 */
            ii(0x8557, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x8559, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x855c, 2);    adc(dx, dx);                              /* adc dx, dx */
            ii(0x855e, 2);    mov(cl, 0x6);                             /* mov cl, 0x6 */
            ii(0x8560, 3);    call(0x5d94, -0x27cf);                    /* call 0x5d94 */
            ii(0x8563, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0x8566, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
            ii(0x856a, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x856d, 1);    leave();                                  /* leave */
            ii(0x856e, 1);    ret(); return;                            /* ret */
        l_0x856f:
            ii(0x856f, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x8571, 1);    leave();                                  /* leave */
            ii(0x8572, 1);    ret();                                    /* ret */
        }
    }
}
