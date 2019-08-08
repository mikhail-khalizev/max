using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7e3d79ca-8867-4392-9be8-0b61c9b5e3e1")]
        public void Method_0000_700c()
        {
            ii(0x700c, 4);    enterw(0x40, 0);                          /* enter 0x40, 0x0 */
            ii(0x7010, 3);    mov(ax, memw_a16[ds, 0x11da]);            /* mov ax, [0x11da] */
            ii(0x7013, 4);    mov(dx, memw_a16[ds, 0x11dc]);            /* mov dx, [0x11dc] */
            ii(0x7017, 3);    add(ax, 0x40);                            /* add ax, 0x40 */
            ii(0x701a, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x701d, 1);    pushw(dx);                                /* push dx */
            ii(0x701e, 1);    pushw(ax);                                /* push ax */
            ii(0x701f, 3);    callw(0x9d6a, 0x2d48);                    /* call 0x9d6a */
            ii(0x7022, 1);    popw(bx);                                 /* pop bx */
            ii(0x7023, 1);    popw(bx);                                 /* pop bx */
            ii(0x7024, 2);    pushw(0x40);                              /* push 0x40 */
            ii(0x7026, 3);    lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x7029, 1);    pushw(ax);                                /* push ax */
            ii(0x702a, 3);    callw(0x9d82, 0x2d55);                    /* call 0x9d82 */
            ii(0x702d, 1);    popw(bx);                                 /* pop bx */
            ii(0x702e, 1);    popw(bx);                                 /* pop bx */
            ii(0x702f, 3);    pushw(0xe73);                             /* push 0xe73 */
            ii(0x7032, 3);    lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x7035, 1);    pushw(ax);                                /* push ax */
            ii(0x7036, 3);    callw(0x9eea, 0x2eb1);                    /* call 0x9eea */
            ii(0x7039, 1);    popw(bx);                                 /* pop bx */
            ii(0x703a, 1);    popw(bx);                                 /* pop bx */
            ii(0x703b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x703d, 2);    if(jnzw(0x704f, 0x10)) goto l_0x704f;     /* jnz 0x704f */
            ii(0x703f, 3);    pushw(0xe7b);                             /* push 0xe7b */
            ii(0x7042, 3);    lea(ax, bp - 0x40);                       /* lea ax, [bp-0x40] */
            ii(0x7045, 1);    pushw(ax);                                /* push ax */
            ii(0x7046, 3);    callw(0x9eea, 0x2ea1);                    /* call 0x9eea */
            ii(0x7049, 1);    popw(bx);                                 /* pop bx */
            ii(0x704a, 1);    popw(bx);                                 /* pop bx */
            ii(0x704b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x704d, 2);    if(jzw(0x7062, 0x13)) goto l_0x7062;      /* jz 0x7062 */
        l_0x704f:
            ii(0x704f, 3);    mov(ax, memw_a16[ds, 0x11f4]);            /* mov ax, [0x11f4] */
            ii(0x7052, 4);    mov(dx, memw_a16[ds, 0x11f6]);            /* mov dx, [0x11f6] */
            ii(0x7056, 3);    mov(memw_a16[ds, 0x11da], ax);            /* mov [0x11da], ax */
            ii(0x7059, 4);    mov(memw_a16[ds, 0x11dc], dx);            /* mov [0x11dc], dx */
            ii(0x705d, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x7060, 1);    leavew();                                 /* leave */
            ii(0x7061, 1);    retw(); return;                           /* ret */
        l_0x7062:
            ii(0x7062, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x7064, 1);    leavew();                                 /* leave */
            ii(0x7065, 1);    retw(); return;                           /* ret */
        }
    }
}
