using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8d23-60513f5a")]
        public void Method_0000_8d23()
        {
            ii(0x8d23, 4);    enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x8d27, 1);    pushw(si);                                /* push si */
            ii(0x8d28, 3);    mov(si, 0x22);                            /* mov si, 0x22 */
            ii(0x8d2b, 5);    cmp(memb_a16[ds, 0xcee], 0x2);            /* cmp byte [0xcee], 0x2 */
            ii(0x8d30, 2);    if(jnzw(0x8d35, 0x3)) goto l_0x8d35;      /* jnz 0x8d35 */
            ii(0x8d32, 3);    mov(si, 0x17);                            /* mov si, 0x17 */
        l_0x8d35:
            ii(0x8d35, 5);    cmp(memb_a16[ds, 0xcee], 0x3);            /* cmp byte [0xcee], 0x3 */
            ii(0x8d3a, 2);    if(jnzw(0x8d46, 0xa)) goto l_0x8d46;      /* jnz 0x8d46 */
            ii(0x8d3c, 5);    cmp(memb_a16[ds, 0xcef], 0);              /* cmp byte [0xcef], 0x0 */
            ii(0x8d41, 2);    if(jnzw(0x8d46, 0x3)) goto l_0x8d46;      /* jnz 0x8d46 */
            ii(0x8d43, 3);    mov(si, 0x28);                            /* mov si, 0x28 */
        l_0x8d46:
            ii(0x8d46, 4);    mov(memb_a16[ss, bp - 0xd], 0x52);        /* mov byte [bp-0xd], 0x52 */
            ii(0x8d4a, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x8d4d, 1);    pushw(ax);                                /* push ax */
            ii(0x8d4e, 3);    lea(cx, bp - 0xe);                        /* lea cx, [bp-0xe] */
            ii(0x8d51, 1);    pushw(cx);                                /* push cx */
            ii(0x8d52, 1);    pushw(cx);                                /* push cx */
            ii(0x8d53, 3);    callw(0x64b8, -0x289e);                   /* call 0x64b8 */
            ii(0x8d56, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x8d59, 3);    mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x8d5c, 2);    add(ax, si);                              /* add ax, si */
            ii(0x8d5e, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x8d61, 3);    mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x8d64, 3);    mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x8d67, 3);    mov(si, 0x28);                            /* mov si, 0x28 */
            ii(0x8d6a, 2);    jmpw(0x8d7c, 0x10); goto l_0x8d7c;        /* jmp 0x8d7c */
        l_0x8d6c:
            ii(0x8d6c, 1);    dec(si);                                  /* dec si */
            ii(0x8d6d, 2);    if(jzw(0x8d8f, 0x20)) goto l_0x8d8f;      /* jz 0x8d8f */
            ii(0x8d6f, 3);    pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x8d72, 1);    pushw(dx);                                /* push dx */
            ii(0x8d73, 3);    callw_abs(memw_a16[ss, bp + 0x4]);        /* call word [bp+0x4] */
            ii(0x8d76, 1);    popw(bx);                                 /* pop bx */
            ii(0x8d77, 1);    popw(bx);                                 /* pop bx */
            ii(0x8d78, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8d7a, 2);    if(jnzw(0x8d8f, 0x13)) goto l_0x8d8f;     /* jnz 0x8d8f */
        l_0x8d7c:
            ii(0x8d7c, 3);    les(bx, ss, bp - 0x1a);                   /* les bx, [bp-0x1a] */
            ii(0x8d7f, 3);    mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x8d82, 4);    mov(dx, memw_a16[es, bx + 0x2]);          /* mov dx, [es:bx+0x2] */
            ii(0x8d86, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x8d89, 3);    mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x8d8c, 1);    inc(ax);                                  /* inc ax */
            ii(0x8d8d, 2);    if(jnzw(0x8d6c, -0x23)) goto l_0x8d6c;    /* jnz 0x8d6c */
        l_0x8d8f:
            ii(0x8d8f, 1);    popw(si);                                 /* pop si */
            ii(0x8d90, 1);    leavew();                                 /* leave */
            ii(0x8d91, 1);    retw(); return;                           /* ret */
        }
    }
}
