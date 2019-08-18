using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("37997a20-f437-49f5-90d8-2b7adda314be")]
        public void Method_0000_a2f8()
        {
            ii(0xa2f8, 2);    mov(ah, 0x35);                            /* mov ah, 0x35 */
            ii(0xa2fa, 3);    mov(al, memb_a16[ds, 0x34]);              /* mov al, [0x34] */
            ii(0xa2fd, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xa2ff, 5);    mov(memw_a16[cs, 0x12c4], bx);            /* mov [cs:0x12c4], bx */
            ii(0xa304, 5);    mov(memw_a16[cs, 0x12c6], es);            /* mov [cs:0x12c6], es */
            ii(0xa309, 5);    cmp(memw_a16[ds, 0xa2], 0);               /* cmp word [0xa2], 0x0 */
            ii(0xa30e, 2);    if(jnzw(0xa345, 0x35)) goto l_0xa345;     /* jnz 0xa345 */
            ii(0xa310, 2);    xor(si, si);                              /* xor si, si */
            ii(0xa312, 2);    xor(dx, dx);                              /* xor dx, dx */
            ii(0xa314, 3);    mov(ax, 0xbf01);                          /* mov ax, 0xbf01 */
            ii(0xa317, 1);    pushfw();                                 /* pushfw */
            ii(0xa318, 5);    callw_a16_far_ind(cs, 0x12c4);            /* call far word [cs:0x12c4] */
            ii(0xa31d, 1);    pushw(dx);                                /* push dx */
            ii(0xa31e, 2);    or(dx, dx);                               /* or dx, dx */
            ii(0xa320, 2);    if(jzw(0xa344, 0x22)) goto l_0xa344;      /* jz 0xa344 */
            ii(0xa322, 5);    mov(memb_a16[ds, 0xa16], 0);              /* mov byte [0xa16], 0x0 */
            ii(0xa327, 1);    pushw(ss);                                /* push ss */
            ii(0xa328, 1);    popw(es);                                 /* pop es */
            ii(0xa329, 3);    mov(di, 0x98);                            /* mov di, 0x98 */
            ii(0xa32c, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0xa32e, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xa331, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0xa333, 1);    pushw(ss);                                /* push ss */
            ii(0xa334, 1);    popw(ds);                                 /* pop ds */
            ii(0xa335, 6);    mov(memw_a16[ds, 0xa4], 0);               /* mov word [0xa4], 0x0 */
            ii(0xa33b, 6);    mov(memw_a16[ds, 0xa6], 0);               /* mov word [0xa6], 0x0 */
            ii(0xa341, 3);    callw(0x8d92, -0x15b2);                   /* call 0x8d92 */
        l_0xa344:
            ii(0xa344, 1);    popw(ax);                                 /* pop ax */
        l_0xa345:
            ii(0xa345, 1);    retw(); return;                           /* ret */
        }
    }
}
