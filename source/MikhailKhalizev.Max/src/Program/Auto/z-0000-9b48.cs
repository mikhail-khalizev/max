using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9b48-1ac17a32")]
        public void Method_0000_9b48()
        {
            ii(0x9b48, 2);    mov(ah, 0x35);                            /* mov ah, 0x35 */
            ii(0x9b4a, 3);    mov(al, memb[ds, 0x34]);                  /* mov al, [0x34] */
            ii(0x9b4d, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x9b4f, 5);    mov(memw[cs, 0x12c4], bx);                /* mov [cs:0x12c4], bx */
            ii(0x9b54, 5);    mov(memw[cs, 0x12c6], es);                /* mov [cs:0x12c6], es */
            ii(0x9b59, 5);    cmp(memw[ds, 0xa2], 0);                   /* cmp word [0xa2], 0x0 */
            ii(0x9b5e, 2);    if(jnz(0x9b95, 0x35)) goto l_0x9b95;      /* jnz 0x9b95 */
            ii(0x9b60, 2);    xor(si, si);                              /* xor si, si */
            ii(0x9b62, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0x9b64, 3);    mov(ax, 0xbf01);                          /* mov ax, 0xbf01 */
            ii(0x9b67, 1);    pushfw();                                 /* pushfw */
            ii(0x9b68, 5);    call_far_ind(cs, 0x12c4);                 /* call far word [cs:0x12c4] */
            ii(0x9b6d, 1);    push(dx);                                 /* push dx */
            ii(0x9b6e, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x9b70, 2);    if(jz(0x9b94, 0x22)) goto l_0x9b94;       /* jz 0x9b94 */
            ii(0x9b72, 5);    mov(memb[ds, 0xa16], 0);                  /* mov byte [0xa16], 0x0 */
            ii(0x9b77, 1);    push(ss);                                 /* push ss */
            ii(0x9b78, 1);    pop(es);                                  /* pop es */
            ii(0x9b79, 3);    mov(di, 0x98);                            /* mov di, 0x98 */
            ii(0x9b7c, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x9b7e, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0x9b81, 2);    rep(() => movsw());                       /* rep movsw */
            ii(0x9b83, 1);    push(ss);                                 /* push ss */
            ii(0x9b84, 1);    pop(ds);                                  /* pop ds */
            ii(0x9b85, 6);    mov(memw[ds, 0xa4], 0);                   /* mov word [0xa4], 0x0 */
            ii(0x9b8b, 6);    mov(memw[ds, 0xa6], 0);                   /* mov word [0xa6], 0x0 */
            ii(0x9b91, 3);    call(0x85e2, -0x15b2);                    /* call 0x85e2 */
        l_0x9b94:
            ii(0x9b94, 1);    pop(ax);                                  /* pop ax */
        l_0x9b95:
            ii(0x9b95, 1);    ret();                                    /* ret */
        }
    }
}
