using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x540b-4ebffd8")]
        public void Method_0000_540b()
        {
            ii(0x540b, 1);    pusha();                                  /* pusha */
            ii(0x540c, 1);    push(ds);                                 /* push ds */
            ii(0x540d, 1);    push(es);                                 /* push es */
            ii(0x540e, 5);    mov(dx, memw[cs, 0x14d4]);                /* mov dx, [cs:0x14d4] */
            ii(0x5413, 5);    mov(cx, memw[cs, 0x14d6]);                /* mov cx, [cs:0x14d6] */
            ii(0x5418, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x541a, 2);    or(cx, dx);                               /* or cx, dx */
            ii(0x541c, 2);    if(jz(0x5454, 0x36)) goto l_0x5454;       /* jz 0x5454 */
            ii(0x541e, 2);    push(0);                                  /* push 0x0 */
            ii(0x5420, 1);    pop(es);                                  /* pop es */
            ii(0x5421, 5);    mov(bx, memw[es, 0xbe]);                  /* mov bx, [es:0xbe] */
            ii(0x5426, 2);    mov(cx, cs);                              /* mov cx, cs */
            ii(0x5428, 2);    sub(cx, bx);                              /* sub cx, bx */
            ii(0x542a, 2);    if(jb(0x542f, 0x3)) goto l_0x542f;        /* jb 0x542f */
            ii(0x542c, 3);    mov(cx, 0);                               /* mov cx, 0x0 */
        l_0x542f:
            ii(0x542f, 2);    if(jnz(0x543b, 0xa)) goto l_0x543b;       /* jnz 0x543b */
            ii(0x5431, 5);    mov(memw[es, 0xbc], dx);                  /* mov [es:0xbc], dx */
            ii(0x5436, 5);    mov(memw[es, 0xbe], ds);                  /* mov [es:0xbe], ds */
        l_0x543b:
            ii(0x543b, 1);    push(ss);                                 /* push ss */
            ii(0x543c, 1);    pop(ds);                                  /* pop ds */
            ii(0x543d, 6);    test(memw[ds, 0x1582], 0x1);              /* test word [0x1582], 0x1 */
            ii(0x5443, 2);    if(jz(0x5454, 0xf)) goto l_0x5454;        /* jz 0x5454 */
            ii(0x5445, 3);    mov(ax, 0x1706);                          /* mov ax, 0x1706 */
            ii(0x5448, 3);    mov(memw[ds, 0x9c0], ax);                 /* mov [0x9c0], ax */
            ii(0x544b, 3);    mov(ax, 0x2);                             /* mov ax, 0x2 */
            ii(0x544e, 4);    call_far_ind(ds, 0x155c);                 /* call far word [0x155c] */
            ii(0x5452, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
        l_0x5454:
            ii(0x5454, 1);    pop(es);                                  /* pop es */
            ii(0x5455, 1);    pop(ds);                                  /* pop ds */
            ii(0x5456, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x5458, 4);    mov(memw[cs, 0x14d4], ax);                /* mov [cs:0x14d4], ax */
            ii(0x545c, 4);    mov(memw[cs, 0x14d6], ax);                /* mov [cs:0x14d6], ax */
            ii(0x5460, 2);    test(cx, cx);                             /* test cx, cx */
            ii(0x5462, 1);    popa();                                   /* popa */
            ii(0x5463, 1);    ret();                                    /* ret */
        }
    }
}
