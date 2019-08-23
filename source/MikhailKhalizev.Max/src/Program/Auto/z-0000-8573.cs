using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8573-60513f5a")]
        public void Method_0000_8573()
        {
            ii(0x8573, 4);    enter(0x1a, 0);                           /* enter 0x1a, 0x0 */
            ii(0x8577, 1);    push(si);                                 /* push si */
            ii(0x8578, 3);    mov(si, 0x22);                            /* mov si, 0x22 */
            ii(0x857b, 5);    cmp(memb[ds, 0xcee], 0x2);                /* cmp byte [0xcee], 0x2 */
            ii(0x8580, 2);    if(jnz(0x8585, 0x3)) goto l_0x8585;       /* jnz 0x8585 */
            ii(0x8582, 3);    mov(si, 0x17);                            /* mov si, 0x17 */
        l_0x8585:
            ii(0x8585, 5);    cmp(memb[ds, 0xcee], 0x3);                /* cmp byte [0xcee], 0x3 */
            ii(0x858a, 2);    if(jnz(0x8596, 0xa)) goto l_0x8596;       /* jnz 0x8596 */
            ii(0x858c, 5);    cmp(memb[ds, 0xcef], 0);                  /* cmp byte [0xcef], 0x0 */
            ii(0x8591, 2);    if(jnz(0x8596, 0x3)) goto l_0x8596;       /* jnz 0x8596 */
            ii(0x8593, 3);    mov(si, 0x28);                            /* mov si, 0x28 */
        l_0x8596:
            ii(0x8596, 4);    mov(memb[ss, bp - 0xd], 0x52);            /* mov byte [bp-0xd], 0x52 */
            ii(0x859a, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x859d, 1);    push(ax);                                 /* push ax */
            ii(0x859e, 3);    lea(cx, bp - 0xe);                        /* lea cx, [bp-0xe] */
            ii(0x85a1, 1);    push(cx);                                 /* push cx */
            ii(0x85a2, 1);    push(cx);                                 /* push cx */
            ii(0x85a3, 3);    call(0x5d08, -0x289e);                    /* call 0x5d08 */
            ii(0x85a6, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x85a9, 3);    mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x85ac, 2);    add(ax, si);                              /* add ax, si */
            ii(0x85ae, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x85b1, 3);    mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x85b4, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x85b7, 3);    mov(si, 0x28);                            /* mov si, 0x28 */
            ii(0x85ba, 2);    jmp(0x85cc, 0x10); goto l_0x85cc;         /* jmp 0x85cc */
        l_0x85bc:
            ii(0x85bc, 1);    dec(si);                                  /* dec si */
            ii(0x85bd, 2);    if(jz(0x85df, 0x20)) goto l_0x85df;       /* jz 0x85df */
            ii(0x85bf, 3);    push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x85c2, 1);    push(dx);                                 /* push dx */
            ii(0x85c3, 3);    call_abs(memw[ss, bp + 0x4]);             /* call word [bp+0x4] */
            ii(0x85c6, 1);    pop(bx);                                  /* pop bx */
            ii(0x85c7, 1);    pop(bx);                                  /* pop bx */
            ii(0x85c8, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x85ca, 2);    if(jnz(0x85df, 0x13)) goto l_0x85df;      /* jnz 0x85df */
        l_0x85cc:
            ii(0x85cc, 3);    les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x85cf, 3);    mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x85d2, 4);    mov(dx, memw[es, bx + 0x2]);              /* mov dx, [es:bx+0x2] */
            ii(0x85d6, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x85d9, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0x85dc, 1);    inc(ax);                                  /* inc ax */
            ii(0x85dd, 2);    if(jnz(0x85bc, -0x23)) goto l_0x85bc;     /* jnz 0x85bc */
        l_0x85df:
            ii(0x85df, 1);    pop(si);                                  /* pop si */
            ii(0x85e0, 1);    leave();                                  /* leave */
            ii(0x85e1, 1);    ret();                                    /* ret */
        }
    }
}
