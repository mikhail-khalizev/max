using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("11405c4c-4bcb-419b-8c4b-b85956ee12b7")]
        public void Method_0000_4c5b()
        {
            ii(0x4c5b, 1);    pusha();                                  /* pusha */
            ii(0x4c5c, 1);    pushw(ds);                                /* push ds */
            ii(0x4c5d, 1);    pushw(es);                                /* push es */
            ii(0x4c5e, 5);    mov(dx, memw_a16[cs, 0x14d4]);            /* mov dx, [cs:0x14d4] */
            ii(0x4c63, 5);    mov(cx, memw_a16[cs, 0x14d6]);            /* mov cx, [cs:0x14d6] */
            ii(0x4c68, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x4c6a, 2);    or(cx, dx);                               /* or cx, dx */
            ii(0x4c6c, 2);    if(jzw(0x4ca4, 0x36)) goto l_0x4ca4;      /* jz 0x4ca4 */
            ii(0x4c6e, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x4c70, 1);    popw(es);                                 /* pop es */
            ii(0x4c71, 5);    mov(bx, memw_a16[es, 0xbe]);              /* mov bx, [es:0xbe] */
            ii(0x4c76, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0x4c78, 2);    sub(cx, bx);                              /* sub cx, bx */
            ii(0x4c7a, 2);    if(jbw(0x4c7f, 0x3)) goto l_0x4c7f;       /* jb 0x4c7f */
            ii(0x4c7c, 3);    mov(cx, 0);                               /* mov cx, 0x0 */
        l_0x4c7f:
            ii(0x4c7f, 2);    if(jnzw(0x4c8b, 0xa)) goto l_0x4c8b;      /* jnz 0x4c8b */
            ii(0x4c81, 5);    mov(memw_a16[es, 0xbc], dx);              /* mov [es:0xbc], dx */
            ii(0x4c86, 5);    mov(memw_a16[es, 0xbe], ds);              /* mov [es:0xbe], ds */
        l_0x4c8b:
            ii(0x4c8b, 1);    pushw(ss);                                /* push ss */
            ii(0x4c8c, 1);    popw(ds);                                 /* pop ds */
            ii(0x4c8d, 6);    test(memw_a16[ds, 0x1582], 0x1);          /* test word [0x1582], 0x1 */
            ii(0x4c93, 2);    if(jzw(0x4ca4, 0xf)) goto l_0x4ca4;       /* jz 0x4ca4 */
            ii(0x4c95, 3);    mov(ax, 0x1706);                          /* mov ax, 0x1706 */
            ii(0x4c98, 3);    mov(memw_a16[ds, 0x9c0], ax);             /* mov [0x9c0], ax */
            ii(0x4c9b, 3);    mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x4c9e, 4);    callw_a16_far_ind(ds, 0x155c);            /* call far word [0x155c] */
            ii(0x4ca2, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
        l_0x4ca4:
            ii(0x4ca4, 1);    popw(es);                                 /* pop es */
            ii(0x4ca5, 1);    popw(ds);                                 /* pop ds */
            ii(0x4ca6, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x4ca8, 4);    mov(memw_a16[cs, 0x14d4], ax);            /* mov [cs:0x14d4], ax */
            ii(0x4cac, 4);    mov(memw_a16[cs, 0x14d6], ax);            /* mov [cs:0x14d6], ax */
            ii(0x4cb0, 2);    test(cx, cx);                             /* test cx, cx */
            ii(0x4cb2, 1);    popa();                                   /* popa */
            ii(0x4cb3, 1);    retw(); return;                           /* ret */
        }
    }
}
