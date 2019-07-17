using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("595ba6ec-f8b0-4ad8-9792-c6556d17019c")]
        public void Method_0000_9b48()
        {
            ii(0x9b48, 2);    mov(ah, 0x35);                            /* mov ah, 0x35 */
            ii(0x9b4a, 3);    mov(al, memb_a16[ds, 0x34]);              /* mov al, [0x34] */
            ii(0x9b4d, 2);    @int(0x21);                              /* int 0x21 */
            ii(0x9b4f, 5);    mov(memw_a16[cs, 0x12c4], bx);            /* mov [cs:0x12c4], bx */
            ii(0x9b54, 5);    mov(memw_a16[cs, 0x12c6], es);            /* mov [cs:0x12c6], es */
            ii(0x9b59, 5);    cmp(memw_a16[ds, 0xa2], 0);               /* cmp word [0xa2], 0x0 */
            ii(0x9b5e, 2);    if(jnzw(0x9b95, 0x35)) goto l_0x9b95;     /* jnz 0x9b95 */
            ii(0x9b60, 2);    xor(si, si);                              /* xor si, si */
            ii(0x9b62, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0x9b64, 3);    mov(ax, 0xbf01);                          /* mov ax, 0xbf01 */
            ii(0x9b67, 1);    pushfw();                                 /* pushfw */
            ii(0x9b68, 5);    callw_a16_far_ind(cs, 0x12c4);            /* call far word [cs:0x12c4] */
            ii(0x9b6d, 1);    pushw(dx);                                /* push dx */
            ii(0x9b6e, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0x9b70, 2);    if(jzw(0x9b94, 0x22)) goto l_0x9b94;      /* jz 0x9b94 */
            ii(0x9b72, 5);    mov(memb_a16[ds, 0xa16], 0);              /* mov byte [0xa16], 0x0 */
            ii(0x9b77, 1);    pushw(ss);                                /* push ss */
            ii(0x9b78, 1);    popw(es);                                 /* pop es */
            ii(0x9b79, 3);    mov(di, 0x98);                            /* mov di, 0x98 */
            ii(0x9b7c, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x9b7e, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0x9b81, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x9b83, 1);    pushw(ss);                                /* push ss */
            ii(0x9b84, 1);    popw(ds);                                 /* pop ds */
            ii(0x9b85, 6);    mov(memw_a16[ds, 0xa4], 0);               /* mov word [0xa4], 0x0 */
            ii(0x9b8b, 6);    mov(memw_a16[ds, 0xa6], 0);               /* mov word [0xa6], 0x0 */
            ii(0x9b91, 3);    callw(0x85e2, -0x15b2);                   /* call 0x85e2 */
        l_0x9b94:
            ii(0x9b94, 1);    popw(ax);                                 /* pop ax */
        l_0x9b95:
            ii(0x9b95, 1);    retw();                                   /* ret */
        }
    }
}
