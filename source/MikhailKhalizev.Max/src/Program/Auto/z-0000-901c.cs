using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x901c-f62f58b4")]
        public void Method_0000_901c()
        {
            ii(0x901c, 4);    enter(0x40, 0);                           /* enter 0x40, 0x0 */
            ii(0x9020, 3);    mov(ax, memw[ds, 0x11da]);                /* mov ax, [0x11da] */
            ii(0x9023, 4);    mov(dx, memw[ds, 0x11dc]);                /* mov dx, [0x11dc] */
            ii(0x9027, 3);    add(ax, 0x40);                            /* add ax, 0x40 */
            ii(0x902a, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x902d, 1);    push(dx);                                 /* push dx */
            ii(0x902e, 1);    push(ax);                                 /* push ax */
            ii(0x902f, 3);    call(0xbd7a, 0x2d48);                     /* call 0xbd7a */
            ii(0x9032, 1);    pop(bx);                                  /* pop bx */
            ii(0x9033, 1);    pop(bx);                                  /* pop bx */
            ii(0x9034, 2);    push(0x40);                               /* push 0x40 */
            ii(0x9036, 3);    lea(ax, memw[ss, bp - 0x40]);             /* lea ax, [bp-0x40] */
            ii(0x9039, 1);    push(ax);                                 /* push ax */
            ii(0x903a, 3);    call(0xbd92, 0x2d55);                     /* call 0xbd92 */
            ii(0x903d, 1);    pop(bx);                                  /* pop bx */
            ii(0x903e, 1);    pop(bx);                                  /* pop bx */
            ii(0x903f, 3);    push(0xe73);                              /* push 0xe73 */
            ii(0x9042, 3);    lea(ax, memw[ss, bp - 0x40]);             /* lea ax, [bp-0x40] */
            ii(0x9045, 1);    push(ax);                                 /* push ax */
            ii(0x9046, 3);    call(0xbefa, 0x2eb1);                     /* call 0xbefa */
            ii(0x9049, 1);    pop(bx);                                  /* pop bx */
            ii(0x904a, 1);    pop(bx);                                  /* pop bx */
            ii(0x904b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x904d, 2);    if(jnz(0x905f, 0x10)) goto l_0x905f;      /* jnz 0x905f */
            ii(0x904f, 3);    push(0xe7b);                              /* push 0xe7b */
            ii(0x9052, 3);    lea(ax, memw[ss, bp - 0x40]);             /* lea ax, [bp-0x40] */
            ii(0x9055, 1);    push(ax);                                 /* push ax */
            ii(0x9056, 3);    call(0xbefa, 0x2ea1);                     /* call 0xbefa */
            ii(0x9059, 1);    pop(bx);                                  /* pop bx */
            ii(0x905a, 1);    pop(bx);                                  /* pop bx */
            ii(0x905b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x905d, 2);    if(jz(0x9072, 0x13)) goto l_0x9072;       /* jz 0x9072 */
        l_0x905f:
            ii(0x905f, 3);    mov(ax, memw[ds, 0x11f4]);                /* mov ax, [0x11f4] */
            ii(0x9062, 4);    mov(dx, memw[ds, 0x11f6]);                /* mov dx, [0x11f6] */
            ii(0x9066, 3);    mov(memw[ds, 0x11da], ax);                /* mov [0x11da], ax */
            ii(0x9069, 4);    mov(memw[ds, 0x11dc], dx);                /* mov [0x11dc], dx */
            ii(0x906d, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x9070, 1);    leave();                                  /* leave */
            ii(0x9071, 1);    ret(); return;                            /* ret */
        l_0x9072:
            ii(0x9072, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x9074, 1);    leave();                                  /* leave */
            ii(0x9075, 1);    ret();                                    /* ret */
        }
    }
}
