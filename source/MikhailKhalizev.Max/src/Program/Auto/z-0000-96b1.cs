using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x96b1-3c986451")]
        public void Method_0000_96b1()
        {
            ii(0x96b1, 4);    enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x96b5, 5);    cmp(memb[ds, 0x980], 0x1);                /* cmp byte [0x980], 0x1 */
            ii(0x96ba, 2);    if(jz(0x96df, 0x23)) goto l_0x96df;       /* jz 0x96df */
            ii(0x96bc, 5);    cmp(memb[ds, 0x980], 0x3);                /* cmp byte [0x980], 0x3 */
            ii(0x96c1, 2);    if(jge(0x96df, 0x1c)) goto l_0x96df;      /* jge 0x96df */
            ii(0x96c3, 2);    push(0);                                  /* push 0x0 */
            ii(0x96c5, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x96c8, 3);    call(0x7c18, -0x1ab3);                    /* call 0x7c18 */
            ii(0x96cb, 1);    pop(bx);                                  /* pop bx */
            ii(0x96cc, 1);    pop(bx);                                  /* pop bx */
            ii(0x96cd, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x96d0, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x96d3, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x96d5, 2);    if(jz(0x96df, 0x8)) goto l_0x96df;        /* jz 0x96df */
        l_0x96d7:
            ii(0x96d7, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x96da, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x96dd, 1);    leave();                                  /* leave */
            ii(0x96de, 1);    ret(); return;                            /* ret */
        l_0x96df:
            ii(0x96df, 3);    call(0x6f71, -0x2771);                    /* call 0x6f71 */
            ii(0x96e2, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x96e5, 3);    call(0x970c, 0x24);                       /* call 0x970c */
            ii(0x96e8, 1);    pop(bx);                                  /* pop bx */
            ii(0x96e9, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x96ec, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x96ef, 3);    call(0x773a, -0x1fb8);                    /* call 0x773a */
            ii(0x96f2, 3);    mov(ax, memw[ss, bp - 0x2]);              /* mov ax, [bp-0x2] */
            ii(0x96f5, 3);    or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x96f8, 2);    if(jnz(0x96d7, -0x23)) goto l_0x96d7;     /* jnz 0x96d7 */
            ii(0x96fa, 2);    push(0);                                  /* push 0x0 */
            ii(0x96fc, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x96ff, 3);    call(0x7c18, -0x1aea);                    /* call 0x7c18 */
            ii(0x9702, 1);    pop(bx);                                  /* pop bx */
            ii(0x9703, 1);    pop(bx);                                  /* pop bx */
            ii(0x9704, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x9707, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x970a, 2);    jmp(0x96d7, -0x35); goto l_0x96d7;        /* jmp 0x96d7 */
        }
    }
}
