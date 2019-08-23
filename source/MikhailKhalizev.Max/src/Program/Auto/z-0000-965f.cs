using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x965f-1fe8ff0f")]
        public void Method_0000_965f()
        {
            ii(0x965f, 4);    enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x9663, 5);    cmp(memb[ds, 0x980], 0x1);                /* cmp byte [0x980], 0x1 */
            ii(0x9668, 2);    if(jnz(0x9683, 0x19)) goto l_0x9683;      /* jnz 0x9683 */
            ii(0x966a, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x966d, 3);    call(0x970c, 0x9c);                       /* call 0x970c */
            ii(0x9670, 1);    pop(bx);                                  /* pop bx */
            ii(0x9671, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x9674, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x9677, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x9679, 2);    if(jz(0x9683, 0x8)) goto l_0x9683;        /* jz 0x9683 */
        l_0x967b:
            ii(0x967b, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x967e, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x9681, 1);    leave();                                  /* leave */
            ii(0x9682, 1);    ret(); return;                            /* ret */
        l_0x9683:
            ii(0x9683, 5);    cmp(memb[ds, 0x980], 0x3);                /* cmp byte [0x980], 0x3 */
            ii(0x9688, 2);    if(jge(0x96a8, 0x1e)) goto l_0x96a8;      /* jge 0x96a8 */
            ii(0x968a, 3);    call(0x773a, -0x1f53);                    /* call 0x773a */
            ii(0x968d, 2);    push(0);                                  /* push 0x0 */
            ii(0x968f, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x9692, 3);    call(0x7c18, -0x1a7d);                    /* call 0x7c18 */
            ii(0x9695, 1);    pop(bx);                                  /* pop bx */
            ii(0x9696, 1);    pop(bx);                                  /* pop bx */
            ii(0x9697, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x969a, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x969d, 3);    call(0x6f71, -0x272f);                    /* call 0x6f71 */
            ii(0x96a0, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x96a3, 3);    or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x96a6, 2);    if(jnz(0x967b, -0x2d)) goto l_0x967b;     /* jnz 0x967b */
        l_0x96a8:
            ii(0x96a8, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x96ab, 3);    call(0x970c, 0x5e);                       /* call 0x970c */
            ii(0x96ae, 1);    pop(bx);                                  /* pop bx */
            ii(0x96af, 1);    leave();                                  /* leave */
            ii(0x96b0, 1);    ret();                                    /* ret */
        }
    }
}
